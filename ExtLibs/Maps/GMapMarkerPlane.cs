using System;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerPlane : GMapMarkerBase
    {
        private readonly Bitmap icon = global::MissionPlanner.Maps.Resources.planeicon;

        static SolidBrush shadow = new SolidBrush(Color.FromArgb(50, Color.Black));

        //static Point[] plane = new Point[] {
        //    new Point(28,0),
        //    new Point(32,13),
        //    new Point(53,27),
        //    new Point(55,32),
        //    new Point(31,28),
        //    new Point(30,35),
        //    new Point(30,43),
        //    new Point(37,48),
        //    new Point(37,50),
        //    new Point(29,50),
        //    new Point(29,53),
        //    // inverse
        //    new Point(inv(29,28),53),
        //    new Point(inv(29,28),50),
        //    new Point(inv(37,28),50),
        //    new Point(inv(37,28),48),
        //    new Point(inv(30,28),43),
        //    new Point(inv(30,28),35),
        //    new Point(inv(31,28),28),
        //    new Point(inv(55,28),32),
        //    new Point(inv(53,28),27),
        //    new Point(inv(32,28),13),
        //    new Point(inv(28,28),0),
        //    };
        //static Point[] plane = new Point[] {                  // Tactical Drone
        //    // Right side
        //     new Point(25, 0),      // Nose
        //    new Point(28, 15),     // Front body
        //    new Point(55, 15),     // Wing front (straight horizontal)
        //    new Point(55, 20),     // Wing tip (straight vertical)
        //    new Point(28, 20),     // Wing back (straight horizontal)
        //    new Point(28, 30),     // Mid body (straight vertical)
        //    new Point(40, 30),     // Tail front (straight horizontal)
        //    new Point(40, 35),     // Tail tip (straight vertical)
        //    new Point(28, 35),     // Tail back (straight horizontal)
        //    new Point(25, 45),     // Rear end

        //    // Left side (mirrored)
        //    new Point(inv(25, 25), 45),
        //    new Point(inv(28, 25), 35),
        //    new Point(inv(40, 25), 35),
        //    new Point(inv(40, 25), 30),
        //    new Point(inv(28, 25), 30),
        //    new Point(inv(28, 25), 20),
        //    new Point(inv(55, 25), 20),
        //    new Point(inv(55, 25), 15),
        //    new Point(inv(28, 25), 15),
        //    new Point(inv(25, 25), 0),
        //};
        // Define constants for clarity
        const int CenterLineX = 25;
        const int HalfWidth = 3;
        const int MaxX = CenterLineX + HalfWidth; // 28
        const int MinX = CenterLineX - HalfWidth; // 22

        // Assuming inv(x, center) is defined as:
        // static int inv(int x, int center) { return 2 * center - x; }

        static Point[] plane = new Point[] {
    // --- Right Side (x >= CenterLineX) ---

    // 1. Round Nose (Approximation of a Semicircle: Max width at y=5)
    new Point(CenterLineX, 0),  // Nose Tip (25, 0)
    new Point(26, 2),
    new Point(27, 4),
    new Point(MaxX, 5),         // Start of cylindrical body (28, 5)

    // 2. Cylindrical Fuselage (Constant width, x=28)
    new Point(MaxX, 10),

    // 3. Wing Section (Attached to cylindrical body)
    new Point(MaxX, 15),        // Wing Front connection (28, 15)
    new Point(55, 15),          // Wing Front Tip (Horizontal)
    new Point(55, 20),          // Wing Tip (Vertical)
    new Point(MaxX, 20),        // Wing Back connection (28, 20)

    // 4. Mid Body / Tail Boom (Constant width, x=28)
    new Point(MaxX, 25),
    
    // 5. Tail Section (Stabilizers attached)
    new Point(MaxX, 30),        // Tail Front connection (28, 30)
    new Point(40, 30),          // Tail Stabilizer Front Tip
    new Point(40, 35),          // Tail Stabilizer Tip (Vertical)
    new Point(MaxX, 35),        // Tail Back connection (28, 35)

    // 6. Tapered Rear End (Smooth taper back to centerline)
    new Point(27, 38),          // Taper start
    new Point(26, 41),
    new Point(CenterLineX, 45), // Rear End (25, 45)

    // -----------------------------------------------------------------
    // --- Left Side (Mirrored using inv(x, CenterLineX)) ---
    // -----------------------------------------------------------------

    // Mirrored Tapered Rear End
    new Point(inv(26, CenterLineX), 41),
    new Point(inv(27, CenterLineX), 38),
    new Point(inv(MaxX, CenterLineX), 35), // (22, 35)

    // Mirrored Tail Section
    new Point(inv(40, CenterLineX), 35),
    new Point(inv(40, CenterLineX), 30),
    new Point(inv(MaxX, CenterLineX), 30), // (22, 30)
    
    // Mirrored Mid Body
    new Point(inv(MaxX, CenterLineX), 25), // (22, 25)

    // Mirrored Wing Section
    new Point(inv(MaxX, CenterLineX), 20), // (22, 20)
    new Point(inv(55, CenterLineX), 20),
    new Point(inv(55, CenterLineX), 15),
    new Point(inv(MaxX, CenterLineX), 15), // (22, 15)

    // Mirrored Cylindrical Fuselage
    new Point(inv(MaxX, CenterLineX), 10), // (22, 10)

    // Mirrored Round Nose
    new Point(inv(MaxX, CenterLineX), 5),  // (22, 5)
    new Point(inv(27, CenterLineX), 4),
    new Point(inv(26, CenterLineX), 2),
    new Point(CenterLineX, 0), // Closing the shape
};
        static int inv(int value, int center)
        {
            return 2 * center - value;
        }

        // Mirror function
        //static int inv(int value, int center)
        //{
        //    return 2 * center - value;
        //}

        //private static int inv(int input, int mid)
        //{
        //    var delta = input - mid;

        //    return mid - delta;
        //}

        float cog = -1;
        float heading = 0;
        float nav_bearing = -1;
        float radius = -1;
        float target = -1;
        int which = 0;

        public GMapMarkerPlane(int which, PointLatLng p, float heading, float cog, float nav_bearing, float target,
            float radius)
            : base(p)
        {
            this.heading = heading;
            this.cog = cog;
            this.target = target;
            this.nav_bearing = nav_bearing;
            this.radius = radius;
            this.which = which;
            Size = icon.Size;
        }

        public float Cog { get => cog; set => cog = value; }
        public float Heading { get => heading; set => heading = value; }
        public float Nav_bearing { get => nav_bearing; set => nav_bearing = value; }
        public float Radius { get => radius; set => radius = value; }
        public float Target { get => target; set => target = value; }

        public override void OnRender(IGraphics g)
        {
            var temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);

            g.RotateTransform(-Overlay.Control.Bearing);

            // anti NaN
            try
            {
                if (DisplayHeading)
                    g.DrawLine(new Pen(Color.Red, 2), 0.0f, 0.0f,
                        (float) Math.Cos((heading - 90) * MathHelper.deg2rad) * length,
                        (float) Math.Sin((heading - 90) * MathHelper.deg2rad) * length);
            }
            catch
            {
            }

            if (DisplayNavBearing)
                g.DrawLine(new Pen(Color.Green, 2), 0.0f, 0.0f,
                    (float) Math.Cos((nav_bearing - 90) * MathHelper.deg2rad) * length,
                    (float) Math.Sin((nav_bearing - 90) * MathHelper.deg2rad) * length);
            if (DisplayCOG)
                g.DrawLine(new Pen(Color.Black, 2), 0.0f, 0.0f,
                    (float) Math.Cos((cog - 90) * MathHelper.deg2rad) * length,
                    (float) Math.Sin((cog - 90) * MathHelper.deg2rad) * length);
            if (DisplayTarget)
                g.DrawLine(new Pen(Color.Orange, 2), 0.0f, 0.0f,
                    (float) Math.Cos((target - 90) * MathHelper.deg2rad) * length,
                    (float) Math.Sin((target - 90) * MathHelper.deg2rad) * length);
            // anti NaN
            try
            {
                if (DisplayRadius)
                {
                    float desired_lead_dist = 100;

                    double width =
                        (Overlay.Control.MapProvider.Projection.GetDistance(Overlay.Control.FromLocalToLatLng(0, 0),
                             Overlay.Control.FromLocalToLatLng(Overlay.Control.Width, 0)) * 1000.0);
                    double m2pixelwidth = Overlay.Control.Width / width;

                    float alpha = (float) (((desired_lead_dist * (float) m2pixelwidth) / radius) * MathHelper.rad2deg);

                    var scaledradius = radius * (float) m2pixelwidth;

                    if (radius < -1 && alpha < -1)
                    {
                        // fixme 

                        float p1 = (float) Math.Cos((cog) * MathHelper.deg2rad) * scaledradius + scaledradius;

                        float p2 = (float) Math.Sin((cog) * MathHelper.deg2rad) * scaledradius + scaledradius;

                        g.DrawArc(new Pen(Color.HotPink, 2), p1, p2, Math.Abs(scaledradius) * 2,
                            Math.Abs(scaledradius) * 2, cog, alpha);
                    }

                    else if (radius > 1 && alpha > 1)
                    {
                        // correct

                        float p1 = (float) Math.Cos((cog - 180) * MathHelper.deg2rad) * scaledradius + scaledradius;

                        float p2 = (float) Math.Sin((cog - 180) * MathHelper.deg2rad) * scaledradius + scaledradius;

                        g.DrawArc(new Pen(Color.HotPink, 2), -p1, -p2, scaledradius * 2, scaledradius * 2, cog - 180,
                            alpha);
                    }
                }
            }
            catch
            {
            }

            try
            {
                g.RotateTransform(heading);
            }
            catch
            {
            }

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // the shadow
            g.TranslateTransform(-26, -26);

            g.FillPolygon(shadow, plane);

            // the plane
            g.TranslateTransform(-2, -2);

            if (which % 7 == 0)
                g.FillPolygon(Brushes.Red, plane);
            if (which % 7 == 1)
                g.FillPolygon(Brushes.Black, plane);
            if (which % 7 == 2)
                g.FillPolygon(Brushes.Blue, plane);
            if (which % 7 == 3)
                g.FillPolygon(Brushes.LimeGreen, plane);
            if (which % 7 == 4)
                g.FillPolygon(Brushes.Yellow, plane);
            if (which % 7 == 5)
                g.FillPolygon(Brushes.Orange, plane);
            if (which % 7 == 6)
                g.FillPolygon(Brushes.Pink, plane);

            g.Transform = temp;
        }
    }
}