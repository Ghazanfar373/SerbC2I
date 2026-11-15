using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MissionPlanner.Utilities
{
    /// <summary>
    /// Draws the main-drawer icons from SVG so they are rasterized at the current display scale
    /// instead of stretching a fixed PNG.
    /// </summary>
    public static class DrawerSvgIcons
    {
        public const string Menu =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"2\" stroke-linecap=\"round\">" +
            "<path d=\"M4 7h16M4 12h16M4 17h16\"/></svg>";

        public const string MissionStatus =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"1.8\">" +
            "<rect x=\"3\" y=\"3\" width=\"8\" height=\"8\" rx=\"1.2\"/>" +
            "<rect x=\"13\" y=\"3\" width=\"8\" height=\"5\" rx=\"1.2\"/>" +
            "<rect x=\"13\" y=\"10\" width=\"8\" height=\"11\" rx=\"1.2\"/>" +
            "<rect x=\"3\" y=\"13\" width=\"8\" height=\"8\" rx=\"1.2\"/></svg>";

        public const string MissionPlan =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"1.8\" stroke-linecap=\"round\">" +
            "<circle cx=\"6\" cy=\"7\" r=\"2.2\" fill=\"#FFFFFF\"/>" +
            "<circle cx=\"17\" cy=\"17\" r=\"2.2\" fill=\"#FFFFFF\"/>" +
            "<path d=\"M8 7h5C13 9.2 14.8 11 17 11v4\"/></svg>";

        public const string Settings =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"1.8\" stroke-linecap=\"round\">" +
            "<circle cx=\"12\" cy=\"12\" r=\"3\"/>" +
            "<path d=\"M12 3v2.2M12 18.8V21M3 12h2.2M18.8 12H21M5.6 5.6l1.6 1.6M16.8 16.8l1.6 1.6M18.4 5.6l-1.6 1.6M7.2 16.8l-1.6 1.6\"/></svg>";

        public const string Configurations =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"1.8\" stroke-linecap=\"round\">" +
            "<path d=\"M4 7h16M4 12h16M4 17h16\"/>" +
            "<circle cx=\"9\" cy=\"7\" r=\"2.1\" fill=\"#FFFFFF\"/>" +
            "<circle cx=\"15\" cy=\"12\" r=\"2.1\" fill=\"#FFFFFF\"/>" +
            "<circle cx=\"11\" cy=\"17\" r=\"2.1\" fill=\"#FFFFFF\"/></svg>";

        public const string Connections =
            "<svg viewBox=\"0 0 24 24\" fill=\"none\" stroke=\"#FFFFFF\" stroke-width=\"1.8\">" +
            "<circle cx=\"7\" cy=\"12\" r=\"3\"/>" +
            "<circle cx=\"17\" cy=\"12\" r=\"3\"/>" +
            "<path d=\"M10 12h4\" stroke-linecap=\"round\"/></svg>";

        public static float DisplayScale(Control control)
        {
            try
            {
                IntPtr hwnd = control != null && control.IsHandleCreated ? control.Handle : IntPtr.Zero;
                IntPtr monitor = MonitorFromWindow(hwnd, 2);
                uint dpiX;
                uint dpiY;
                if (GetDpiForMonitor(monitor, 0, out dpiX, out dpiY) == 0 && dpiX >= 96)
                    return dpiX / 96f;
            }
            catch (Exception)
            {
            }

            return 1f;
        }

        public static Bitmap Render(string svg, int width, int height, Color color)
        {
            int w = Math.Max(1, width);
            int h = Math.Max(1, height);
            Bitmap bitmap = new Bitmap(w, h);
            bitmap.SetResolution(96f * Math.Max(1f, w / 24f), 96f * Math.Max(1f, h / 24f));
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Transparent);
                Paint(graphics, new Rectangle(0, 0, w, h), svg, color);
            }

            return bitmap;
        }

        public static void Paint(Graphics graphics, Rectangle bounds, string svg, Color color)
        {
            if (graphics == null || bounds.Width < 2 || bounds.Height < 2 || string.IsNullOrEmpty(svg))
                return;

            XElement root;
            try
            {
                root = XElement.Parse(svg);
            }
            catch (Exception)
            {
                return;
            }

            float vbX = 0, vbY = 0, vbW = 24, vbH = 24;
            string viewBox = Attr(root, "viewBox");
            if (!string.IsNullOrEmpty(viewBox))
            {
                float[] box = Numbers(viewBox);
                if (box.Length >= 4 && box[2] > 0 && box[3] > 0)
                {
                    vbX = box[0];
                    vbY = box[1];
                    vbW = box[2];
                    vbH = box[3];
                }
            }

            float scale = Math.Min(bounds.Width / vbW, bounds.Height / vbH);
            float ox = bounds.X + (bounds.Width - vbW * scale) / 2f - vbX * scale;
            float oy = bounds.Y + (bounds.Height - vbH * scale) / 2f - vbY * scale;

            SmoothingMode previous = graphics.SmoothingMode;
            PixelOffsetMode previousOffset = graphics.PixelOffsetMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            try
            {
                foreach (XElement element in root.Elements())
                    DrawElement(graphics, element, root, ox, oy, scale, color);
            }
            finally
            {
                graphics.SmoothingMode = previous;
                graphics.PixelOffsetMode = previousOffset;
            }
        }

        static void DrawElement(Graphics graphics, XElement element, XElement root, float ox, float oy, float scale, Color color)
        {
            string name = element.Name.LocalName;
            if (name == "path")
            {
                using (GraphicsPath path = PathFromData(Attr(element, "d"), ox, oy, scale))
                {
                    if (path == null)
                        return;
                    Fill(graphics, path, element, root, color);
                    Stroke(graphics, path, element, root, scale, color);
                }
            }
            else if (name == "rect")
            {
                float x = Num(element, "x");
                float y = Num(element, "y");
                float w = Num(element, "width");
                float h = Num(element, "height");
                float rx = Num(element, "rx");
                using (GraphicsPath path = new GraphicsPath())
                {
                    RectangleF rect = new RectangleF(ox + x * scale, oy + y * scale, w * scale, h * scale);
                    if (rx <= 0)
                        path.AddRectangle(rect);
                    else
                        AddRoundRect(path, rect, rx * scale);
                    Fill(graphics, path, element, root, color);
                    Stroke(graphics, path, element, root, scale, color);
                }
            }
            else if (name == "circle")
            {
                float r = Num(element, "r");
                float cx = Num(element, "cx");
                float cy = Num(element, "cy");
                RectangleF rect = new RectangleF(ox + (cx - r) * scale, oy + (cy - r) * scale, r * 2 * scale, r * 2 * scale);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(rect);
                    Fill(graphics, path, element, root, color);
                    Stroke(graphics, path, element, root, scale, color);
                }
            }
            else if (name == "line")
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddLine(
                        ox + Num(element, "x1") * scale, oy + Num(element, "y1") * scale,
                        ox + Num(element, "x2") * scale, oy + Num(element, "y2") * scale);
                    Stroke(graphics, path, element, root, scale, color);
                }
            }
        }

        static void Fill(Graphics graphics, GraphicsPath path, XElement element, XElement root, Color color)
        {
            string fill = PaintAttr(element, root, "fill");
            if (string.IsNullOrEmpty(fill) || fill == "none")
                return;

            using (SolidBrush brush = new SolidBrush(color))
                graphics.FillPath(brush, path);
        }

        static void Stroke(Graphics graphics, GraphicsPath path, XElement element, XElement root, float scale, Color color)
        {
            string stroke = PaintAttr(element, root, "stroke");
            if (stroke == "none")
                return;
            if (string.IsNullOrEmpty(stroke) && PaintAttr(element, root, "fill") != "none" && !string.IsNullOrEmpty(PaintAttr(element, root, "fill")))
                return;

            float width = Num(element, "stroke-width");
            if (width <= 0)
                width = Num(root, "stroke-width");
            if (width <= 0)
                width = 1.5f;

            using (Pen pen = new Pen(color, Math.Max(1f, width * scale)))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                graphics.DrawPath(pen, path);
            }
        }

        static string PaintAttr(XElement element, XElement root, string name)
        {
            string local = Attr(element, name);
            if (!string.IsNullOrEmpty(local))
                return local;
            return Attr(root, name);
        }

        static GraphicsPath PathFromData(string data, float ox, float oy, float scale)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            int i = 0;
            char cmd = 'M';
            float cx = 0, cy = 0, sx = 0, sy = 0;
            bool figureOpen = false;

            while (i < data.Length)
            {
                Skip(data, ref i);
                if (i >= data.Length)
                    break;
                if (IsCommand(data[i]))
                {
                    cmd = data[i++];
                    if (cmd == 'Z' || cmd == 'z')
                    {
                        if (figureOpen)
                            path.CloseFigure();
                        cx = sx;
                        cy = sy;
                        figureOpen = false;
                        path.StartFigure();
                    }
                    continue;
                }

                if (cmd == 'M' || cmd == 'm')
                {
                    float x, y;
                    if (!Read(data, ref i, out x) || !Read(data, ref i, out y))
                        break;
                    if (cmd == 'm')
                    {
                        x += cx;
                        y += cy;
                    }
                    if (figureOpen)
                        path.StartFigure();
                    cx = x;
                    cy = y;
                    sx = x;
                    sy = y;
                    figureOpen = true;
                    cmd = cmd == 'm' ? 'l' : 'L';
                }
                else if (cmd == 'L' || cmd == 'l')
                {
                    float x, y;
                    if (!Read(data, ref i, out x) || !Read(data, ref i, out y))
                        break;
                    if (cmd == 'l')
                    {
                        x += cx;
                        y += cy;
                    }
                    path.AddLine(ox + cx * scale, oy + cy * scale, ox + x * scale, oy + y * scale);
                    cx = x;
                    cy = y;
                    figureOpen = true;
                }
                else if (cmd == 'H' || cmd == 'h')
                {
                    float x;
                    if (!Read(data, ref i, out x))
                        break;
                    if (cmd == 'h')
                        x += cx;
                    path.AddLine(ox + cx * scale, oy + cy * scale, ox + x * scale, oy + cy * scale);
                    cx = x;
                    figureOpen = true;
                }
                else if (cmd == 'V' || cmd == 'v')
                {
                    float y;
                    if (!Read(data, ref i, out y))
                        break;
                    if (cmd == 'v')
                        y += cy;
                    path.AddLine(ox + cx * scale, oy + cy * scale, ox + cx * scale, oy + y * scale);
                    cy = y;
                    figureOpen = true;
                }
                else if (cmd == 'C' || cmd == 'c')
                {
                    float x1, y1, x2, y2, x, y;
                    if (!Read(data, ref i, out x1) || !Read(data, ref i, out y1) ||
                        !Read(data, ref i, out x2) || !Read(data, ref i, out y2) ||
                        !Read(data, ref i, out x) || !Read(data, ref i, out y))
                        break;
                    if (cmd == 'c')
                    {
                        x1 += cx;
                        y1 += cy;
                        x2 += cx;
                        y2 += cy;
                        x += cx;
                        y += cy;
                    }
                    path.AddBezier(
                        ox + cx * scale, oy + cy * scale,
                        ox + x1 * scale, oy + y1 * scale,
                        ox + x2 * scale, oy + y2 * scale,
                        ox + x * scale, oy + y * scale);
                    cx = x;
                    cy = y;
                    figureOpen = true;
                }
                else
                {
                    break;
                }
            }

            return path;
        }

        static void AddRoundRect(GraphicsPath path, RectangleF rect, float radius)
        {
            float r = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2f);
            float d = r * 2f;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
        }

        static bool IsCommand(char c)
        {
            return "MmLlHhVvCcZz".IndexOf(c) >= 0;
        }

        static void Skip(string data, ref int i)
        {
            while (i < data.Length && (data[i] == ' ' || data[i] == ',' || data[i] == '\n' || data[i] == '\r' || data[i] == '\t'))
                i++;
        }

        static bool Read(string data, ref int i, out float value)
        {
            Skip(data, ref i);
            value = 0;
            if (i >= data.Length || IsCommand(data[i]))
                return false;

            int start = i;
            if (data[i] == '+' || data[i] == '-')
                i++;
            bool any = false;
            while (i < data.Length && (char.IsDigit(data[i]) || data[i] == '.'))
            {
                i++;
                any = true;
            }
            if (!any)
                return false;
            return float.TryParse(data.Substring(start, i - start), NumberStyles.Float, CultureInfo.InvariantCulture, out value);
        }

        static string Attr(XElement element, string name)
        {
            XAttribute attribute = element.Attribute(name);
            return attribute == null ? null : attribute.Value;
        }

        static float Num(XElement element, string name)
        {
            string text = Attr(element, name);
            float value;
            if (string.IsNullOrEmpty(text) || !float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return 0;
            return value;
        }

        static float[] Numbers(string text)
        {
            string[] parts = text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            float[] values = new float[parts.Length];
            for (int i = 0; i < parts.Length; i++)
                float.TryParse(parts[i], NumberStyles.Float, CultureInfo.InvariantCulture, out values[i]);
            return values;
        }

        [DllImport("user32.dll")]
        static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint flags);

        [DllImport("shcore.dll")]
        static extern int GetDpiForMonitor(IntPtr hmonitor, int dpiType, out uint dpiX, out uint dpiY);
    }
}
