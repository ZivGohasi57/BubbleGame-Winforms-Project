// Ziv Gohasi 211541271


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public class Ball : Control
    {
        public Timer timer; // Timer to control the movement of the ball.
        private float speed; // Speed of the ball's movement.
        private float angle; // Direction angle for the ball's movement.

        // Bitmap to store the graphical representation of the ball.
        private Bitmap ballImage;

        public Ball()
        {
            Random rnd = new Random();
            int size = rnd.Next(20, 60); // Random size between 20 and 60 pixels.
            this.Size = new Size(size, size);

            this.BackColor = GetRandomColor(rnd); // Set a random color for the ball.
            this.DoubleBuffered = true; // Enable double buffering to prevent flickering.

            this.speed = (float)rnd.Next(2, 10); // Set a random speed between 2 and 10 pixels per move.
            this.angle = (float)(rnd.NextDouble() * 2 * Math.PI); // Set a random angle between 0 and 360 degrees.

            // Initialize and start the timer.
            this.timer = new Timer();
            this.timer.Interval = 50; // Set the timer interval (speed of the update).
            this.timer.Tick += Timer_Tick; // Attach the timer tick event handler.
            this.timer.Start();

            CreateBallBitmap(); // Create the initial bitmap for the ball.
            SetCircularShape(); // Set the shape of the ball to be a circle.
        }


        // Generates a random color using the provided random object.
        private Color GetRandomColor(Random rnd)
        {
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }



        // Sets the shape of the control to be a circle based on its width and height.
        private void SetCircularShape()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path); // Set the region of the control to be a circular shape.
        }


        // Creates a bitmap representation of the ball with the specified color.
        private void CreateBallBitmap()
        {
            ballImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(ballImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias; // Enable anti-aliasing for smooth edges.
                g.Clear(Color.Transparent); // Set the background to transparent.
                using (Brush brush = new SolidBrush(this.BackColor)) // Use the current background color as the ball's color.
                {
                    g.FillEllipse(brush, 0, 0, this.Width, this.Height); // Draw a filled circle inside the bitmap.
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ballImage != null)
            {
                e.Graphics.DrawImage(ballImage, 0, 0); // Draw the ball image at the top-left corner.
            }
        }


        // Overrides the background paint to prevent flickering.
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }


        // Handles resizing of the control to maintain circular shape.
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.Width = this.Height; // Keep the width and height equal.
            SetCircularShape(); // Update the circular shape based on the new size.
            CreateBallBitmap(); // Recreate the bitmap with the new dimensions.
        }


        // Stops the movement of the ball by stopping the timer.
        public void StopMovement()
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop(); // Stop the timer to halt movement.
            }
        }

        // Starts the movement of the ball by starting the timer.
        public void StartMovement()
        {
            if (timer != null && !timer.Enabled)
            {
                timer.Start(); // Start the timer to resume movement.
            }
        }


        // Changes the speed of the ball.
        public void ChangeSpeed(float newSpeed)
        {
            if (newSpeed > 0)
            {
                speed = newSpeed; // Set the new speed if it's greater than zero.
            }
        }


        // Changes the direction of the ball's movement.
        public void ChangeDirection(float newAngle)
        {
            angle = newAngle; // Set the new angle for the ball.
        }


        // Checks if the current ball is colliding with another ball.
        public bool IsCollidingWith(Ball otherBall)
        {
            float dx = this.Location.X - otherBall.Location.X;
            float dy = this.Location.Y - otherBall.Location.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            return distance < (this.Width / 2 + otherBall.Width / 2); // Returns true if the balls are overlapping.
        }


        // Event handler for the timer tick, controls the ball's movement.
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Parent == null)
            {
                return; // If the ball is not on the form, exit the function.
            }


            // Calculate the new position based on speed and angle.
            int moveX = (int)(speed * Math.Cos(angle));
            int moveY = (int)(speed * Math.Sin(angle));


            // Update the ball's position.
            this.Location = new Point(this.Location.X + moveX, this.Location.Y + moveY);


            // Check for collisions with the form boundaries and change direction if needed.
            if (this.Location.X <= 0 || this.Location.X + this.Width >= this.Parent.ClientSize.Width)
            {
                angle = (float)Math.PI - angle;// Reverse horizontal direction.
            }

            if (this.Location.Y <= 0 || this.Location.Y + this.Height >= this.Parent.ClientSize.Height)
            {
                angle = -angle;   // Reverse vertical direction.
            }

            this.Invalidate(); // Redraw the ball to reflect its new position.
        }
    }
}