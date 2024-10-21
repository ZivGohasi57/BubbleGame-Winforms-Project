// Ziv Gohasi 211541271



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {


        // Connection string for connecting to the local SQL database.
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        // Timer to track the duration of the game.
        private Stopwatch gameTimer;

        // Name of the player.
        public string playerName { get; private set; }

        // Flag to indicate whether the player has set their name.
        public bool NameIsSet { get; private set; } = false;

        // Counter for the number of balls created on the form.
        private int ballCount = 0;

        // List to keep track of all the balls created and displayed on the form.
        public List<Ball> balls = new List<Ball>();



        public Form1()
        {
            InitializeComponent();
            this.Text = "Balls Game";
            gameTimer = new Stopwatch();

        }


        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            // If the player's name is not set, prompt for name input using Form2.
            if (!NameIsSet)
            {
                Form2 inputForm = new Form2();
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    playerName = inputForm.PlayerName;
                    NameIsSet = true;
                }
                gameTimer.Start(); // Start the timer.
            }

            // Create a new ball and set its properties.
            Ball newBall = new Ball();
            Random random = new Random();
            balls.Add(newBall);

            // Set random position and color for the new ball.
            newBall.Location = new Point(random.Next(0, this.ClientSize.Width - newBall.Width), random.Next(0, this.ClientSize.Height - newBall.Height));
            newBall.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Add the ball to the form's controls and update the title.
            this.Controls.Add(newBall);
            ballCount++;
            this.Text = $"Balls: {ballCount} - Player: {playerName}";
        }


        private void Minus_Click(object sender, EventArgs e)
        {
            // Get the last ball added to the form and remove it.
            var balls = this.Controls.OfType<Ball>().ToList();
            if (balls.Any())
            {
                var lastBall = balls.Last();
                if (lastBall != null)
                {
                    RemoveBall(lastBall);
                    ballCount--;
                    this.Text = $"Balls: {ballCount} - Player: {playerName}";
                }
            }
            else
            {
                MessageBox.Show("No balls to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void S_Click(object sender, EventArgs e)
        {

            // Stop the last ball's movement.
            var balls = this.Controls.OfType<Ball>().ToList();
            if (balls.Any())
            {
                var lastBall = balls.LastOrDefault();
                if (lastBall != null)
                {
                    lastBall.StopMovement();
                    MessageBox.Show("The last ball has stopped moving.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No balls to stop.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            if (NameIsSet)
            {
                gameTimer.Stop(); // Stop the timer and end the game.
                RemoveAllBalls(); // Remove all balls from the form.

                int playTime = (int)gameTimer.Elapsed.TotalSeconds; // Calculate play time.

                // Save game data (player name and play time) to the database.
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand insertCommand = new SqlCommand("INSERT INTO TblPlayers (Name, Length) VALUES (@Name, @Length)", conn);
                        insertCommand.Parameters.AddWithValue("@Name", playerName);
                        insertCommand.Parameters.AddWithValue("@Length", playTime);
                        insertCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Game over, {playerName}. You played for {playTime} seconds.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save game data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please start a game first.");
            }

            NameIsSet = false;
            gameTimer.Reset(); // Reset the timer for the next game.
        }

        private void DB_Click(object sender, EventArgs e)
        {
            // Open Form3 to display the database data.
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void E_Click(object sender, EventArgs e)
        {
            // Confirm exit and close the application if confirmed.
            DialogResult result = MessageBox.Show(
                "ARE YOU SURE?",
                "DO U REALLY WANT TO EXIT?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Removes a specific ball from the form.
        private void RemoveBall(Ball ball)
        {
            if (ball != null)
            {
                ball.timer.Stop(); // Stop the ball's timer.
                this.Controls.Remove(ball); // Remove the ball from the form.
                ball.Dispose(); // Release resources.
            }
        }

        // Removes all balls from the form.
        private void RemoveAllBalls()
        {
            var balls = this.Controls.OfType<Ball>().ToList();
            foreach (var ball in balls)
            {
                RemoveBall(ball);
            }
            ballCount = 0; // Reset ball count.
        }



        private void About_Click(object sender, EventArgs e)
        {
            // Open Form4 to display the About dialog.
            Form4 form = new Form4();
            form.Show(); ;
        }

    }
}
