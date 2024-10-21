namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.Plus = new System.Windows.Forms.ToolStripButton();
            this.Minus = new System.Windows.Forms.ToolStripButton();
            this.S = new System.Windows.Forms.ToolStripButton();
            this.About = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.EndGame = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DB = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.E = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Plus,
            this.Minus,
            this.S,
            this.About,
            this.bindingNavigatorSeparator,
            this.EndGame,
            this.bindingNavigatorSeparator1,
            this.DB,
            this.bindingNavigatorSeparator2,
            this.E});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1067, 42);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.White;
            this.Plus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(30, 39);
            this.Plus.Text = "+";
            this.Plus.ToolTipText = "+";
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.White;
            this.Minus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(29, 39);
            this.Minus.Text = "-";
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.Red;
            this.S.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.S.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.S.Image = ((System.Drawing.Image)(resources.GetObject("S.Image")));
            this.S.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(29, 39);
            this.S.Text = "S";
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Black;
            this.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(29, 39);
            this.About.Text = "A";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EndGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EndGame.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.EndGame.Image = ((System.Drawing.Image)(resources.GetObject("EndGame.Image")));
            this.EndGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(133, 39);
            this.EndGame.Text = "End Game";
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // DB
            // 
            this.DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.DB.Image = ((System.Drawing.Image)(resources.GetObject("DB.Image")));
            this.DB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(51, 39);
            this.DB.Text = "DB";
            this.DB.Click += new System.EventHandler(this.DB_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.Color.Red;
            this.E.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.E.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.E.Image = ((System.Drawing.Image)(resources.GetObject("E.Image")));
            this.E.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(29, 39);
            this.E.Text = "E";
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bindingNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton Plus;
        private System.Windows.Forms.ToolStripButton Minus;
        private System.Windows.Forms.ToolStripButton S;
        private System.Windows.Forms.ToolStripButton About;
        private System.Windows.Forms.ToolStripButton EndGame;
        private System.Windows.Forms.ToolStripButton DB;
        private System.Windows.Forms.ToolStripButton E;
    }
}

