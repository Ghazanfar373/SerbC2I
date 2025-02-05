using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static IronPython.Modules._ast;

namespace MissionPlanner.Controls
{
    public partial class OpenTKClock : Form
    {
        Game game;
        public OpenTKClock()
        {
            InitializeComponent();
            game = new Game(800, 600, "OpenTK");

            game.Run(60.0);
            this.Close();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            glControl1.MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.ClearColor(Color.SkyBlue);
            GL.Ortho(-w / 2, w / 2, -h / 2, h / 2, -1, 1);
            GL.Viewport(0, 0, w, h);
            GL.End();
            glControl1.SwapBuffers();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            glControl1.MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.ClearColor(Color.SkyBlue);
            GL.Ortho(-w / 2, w / 2, -h / 2, h / 2, -1, 1);
            GL.Viewport(0, 0, w, h);
            GL.End();
            glControl1.SwapBuffers();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            //GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //Draw_clock();
            //glControl1.SwapBuffers();
            //Draw_digit();
            //glControl1.SwapBuffers();


            glControl1.MakeCurrent();

            GL.End();
            glControl1.SwapBuffers();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Draw_clock();
            //GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.End();
            glControl1.SwapBuffers();
            drawsecond();
            glControl1.SwapBuffers();

        }

        void Draw_clock()
        {
           drawCircle(80);//80 is radius of the circle
           Draw_digit();
        }
        void drawCircle(float radius)
        {

            GL.Color3(Color.White);
            GL.Begin(BeginMode.TriangleFan);

            for (int i = 0; i < 360; i++)
            {
                double degInRad = i * 3.1416 / 180;
                GL.Vertex2(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius);
            }
            GL.End();
        }
        void Draw_digit()
        {
            //GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            //GL.Color3(Color.Red);
            //for hour
            GL.Begin(BeginMode.TriangleFan);

            GL.Vertex2(0, +5);
            GL.Vertex2(0, -5);
            GL.Vertex2(70, 0);
            GL.Vertex2(70, 0);
            GL.Color3(Color.BlueViolet);

            GL.End();
            
            //for minute
            GL.Begin(BeginMode.TriangleFan);
            GL.Vertex2(+5, 0);
            GL.Vertex2(-5, 0);
            GL.Vertex2(-80, 30);
            GL.Vertex2(-80, 30);
            GL.Color3(Color.Green);
            GL.End();

            GL.Color3(Color.Black);
            //for draw digit III
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(5, 60);
            GL.Vertex2(5, 70);
            GL.Vertex2(0, 60);
            GL.Vertex2(0, 70);

            GL.Vertex2(-5, 70);
            GL.Vertex2(-15, 60);
            GL.Vertex2(-15, 70);
            GL.Vertex2(-5, 60);

            GL.End();
            
            GL.Color3(Color.Black);
            //for draw digit XII
            GL.Begin(BeginMode.Lines);

            GL.Vertex2(60, 0);
            GL.Vertex2(60, 8);
            GL.Vertex2(70, 0);
            GL.Vertex2(70, 8);
            GL.Vertex2(65, 0);
            GL.Vertex2(65, 8);

            GL.End();
            
            GL.Color3(Color.Black);
            //for draw digit IV
            GL.Begin(BeginMode.Lines);

            GL.Vertex2(10, -60);
            GL.Vertex2(10, -70);
            GL.Vertex2(0, -60);
            GL.Vertex2(0, -70);
            GL.Vertex2(5, -60);
            GL.Vertex2(0, -70);
            GL.Vertex2(5, -60);
            GL.Vertex2(0, -70);

            GL.End();
            GL.Color3(Color.Black);
            //for draw digit IX
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(-75, -5);
            GL.Vertex2(-75, -15);

            GL.Vertex2(-70, -5);
            GL.Vertex2(-60, -15);
            GL.Vertex2(-70, -15);
            GL.Vertex2(-60, -5);

            GL.End();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();
            PaintEventArgs p = null;
            glControl1_Paint(sender, p);
            GL.End();
        }
        static int i = 0;
        void drawsecond()
        {
            GL.Color3(Color.Red);
            GL.Begin(BeginMode.Quads);

            GL.Vertex2(5, 0);
            GL.Vertex2(-5, 5);
            double degInRad = i * 3.1416 / 180;
            GL.Vertex2(Math.Cos(degInRad) * 80, Math.Sin(degInRad) * 80);
            GL.Vertex2(Math.Cos(degInRad) * 85, Math.Sin(degInRad) * 85);

            i = i - 10;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.End();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
           

            if (rjToggleButton1.Checked) {
                //MessageBox.Show("Checked");
                timer1.Start();
            }else timer1.Stop();
        }
       
        private void buttHUD_Click(object sender, EventArgs e)
        {
            
        }

        private void updateHorizon_Click(object sender, EventArgs e)
        {
            SetAttitude(float.Parse(textBoxX.Text), float.Parse(textBoxY.Text),0);
            glControlHUD.MakeCurrent();
            PaintEventArgs p = null;
            glControlHUD_Paint(sender, p);
            GL.End();

        }
        // Angles for roll, pitch, and yaw
        private float _roll = 180.0f;
        private float _pitch = 180.0f;
        private float _yaw = 0.0f;

        public void SetAttitude(float roll, float pitch, float yaw)
        {
            _roll = roll;
            _pitch = pitch ;
            _yaw = yaw ;
        }
        private void glControlHUD_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.CornflowerBlue); // Set the background color
            GL.Enable(EnableCap.DepthTest); // Enable depth testing for correct z-ordering
            //SetRotation(50, 30);
        }

        private void glControlHUD_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            // Set up the view matrix to simulate the cockpit view
            Matrix4 lookat = Matrix4.LookAt(Vector3.UnitZ, Vector3.Zero, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            // Apply the roll, pitch, and yaw transformations
            GL.Rotate(_yaw, 0.0f, 1.0f, 0.0f);   // Yaw around the Y-axis
            GL.Rotate(_pitch, 1.0f, 0.0f, 0.0f); // Pitch around the X-axis
            GL.Rotate(_roll, 0.0f, 0.0f, 1.0f);  // Roll around the Z-axis

            // Draw the artificial horizon
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.Green);
            GL.Vertex3(-20.0f, -1.0f, -20.0f);
            GL.Vertex3(-20.0f, -1.0f, 20.0f);
            GL.Color3(Color.SkyBlue);
            GL.Vertex3(20.0f, -1.0f, 20.0f);
            GL.Vertex3(20.0f, -1.0f, -20.0f);
            GL.End();


            glControlHUD.SwapBuffers();

        }
        private void DrawHorizonCircle(float centerX, float centerY, float radius, Color color)
        {
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(color);
            GL.Vertex2(centerX, centerY); // center of the circle
            for (int i = 0; i <= 360; i++) // creating a full circle
            {
                float degInRad = MathHelper.DegreesToRadians(i);
                GL.Vertex2(centerX + Math.Cos(degInRad) * radius, centerY + Math.Sin(degInRad) * radius);
            }
            GL.End();
        }
    
}


    public class Game : GameWindow
    {
        private float _rotationX = 0.0f;
        private float _rotationY = 0.0f;

        public Game(int width, int height, string title): base(width, height, GraphicsMode.Default, title)
        {
            MouseMove += HandleMouseMove;
        }
        public void SetRotation(float x, float y)
        {
            _rotationX = x;
            _rotationY = y;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color.BlueViolet); // Set the background color
            //GL.Enable(EnableCap.DepthTest); // Enable depth testing for correct z-ordering
            //SetRotation(50, 30);
            
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            /*
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(Vector3.UnitZ, Vector3.Zero, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);
            // Apply rotation
            GL.Rotate(_rotationX, 1.0f, 0.0f, 0.0f); // Rotate around the X axis
            GL.Rotate(_rotationY, 0.0f, 1.0f, 0.0f); // Rotate around the Y axis
            // Draw the artificial horizon
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.YellowGreen);
            GL.Vertex3(-20.0f, -1.0f, -20.0f);
            GL.Vertex3(-20.0f, -1.0f, 20.0f);
            GL.Color3(Color.SkyBlue);
            GL.Vertex3(20.0f, -1.0f, 20.0f);
            GL.Vertex3(20.0f, -1.0f, -20.0f);
            GL.End();

            SwapBuffers();*/

            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.IndianRed);
            GL.Vertex2(0, -50);
            GL.Vertex2(-50, 0);   

            GL.End();
            // Example: Draw a triangle using Vertex2
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(Color.Red);
            GL.Vertex3(1, 0, 0.3f); // First vertex
            GL.Color3(Color.Green);
            GL.Vertex3(50, 0, 0.3f); // Second vertex
            GL.Color3(Color.Blue);
            GL.Vertex2(0.0f, 0.5f); // Third vertex
            GL.Color3(Color.Orange);
            GL.Vertex2(0.4f, 0.5f); // Third vertex
            GL.End();

            //SwapBuffers();
            DrawCircle();
            //MouseHover(e);
        }



      void  DrawCircle()
        {
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.Goldenrod);
            double radius = 0.3;
            int numSegmen = 360;
            for (int i = 0; i < numSegmen; i++)
            {
                double angle = 3.0 * Math.PI * i / numSegmen;
                double x= radius * Math.Cos(angle);
                double y= radius * Math.Sin(angle);
                GL.Vertex2(x, y);

            }
            GL.End();
            DrawCenterLine();
            SwapBuffers();
        }

        private void DrawCenterLine() {
            int centerX = Width / 2;
            int centerY = Height / 2;

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1.0f,1.0f,1.0f);
            GL.Vertex2(centerX, centerY);
            GL.Vertex2(100, 100);
            GL.End();
        
        
        }
        private void HandleMouseMove(object sender, MouseMoveEventArgs e)
        {
            // Get the local mouse coordinates
            int mouseX = e.X;
            int mouseY = e.Y;

            // Print the coordinates to the window title
            Title = $"Mouse Position: X={mouseX}, Y={mouseY}";
        }
    
}
}
