namespace Task2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Q1 = new System.Windows.Forms.ToolStripButton();
            this.Q2 = new System.Windows.Forms.ToolStripButton();
            this.Q3 = new System.Windows.Forms.ToolStripButton();
            this.tblDataGridView = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            this.tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblBindingNavigator)).BeginInit();
            this.tblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBindingNavigator
            // 
            this.tblBindingNavigator.AddNewItem = null;
            this.tblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblBindingNavigator.DeleteItem = null;
            this.tblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.Q1,
            this.Q2,
            this.Q3});
            this.tblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblBindingNavigator.Name = "tblBindingNavigator";
            this.tblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblBindingNavigator.TabIndex = 0;
            this.tblBindingNavigator.Text = "bindingNavigator1";
            this.tblBindingNavigator.RefreshItems += new System.EventHandler(this.tblBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Q1
            // 
            this.Q1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Q1.Image = ((System.Drawing.Image)(resources.GetObject("Q1.Image")));
            this.Q1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(32, 24);
            this.Q1.Text = "Q1";
            this.Q1.Click += new System.EventHandler(this.Q1_Click);
            // 
            // Q2
            // 
            this.Q2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Q2.Image = ((System.Drawing.Image)(resources.GetObject("Q2.Image")));
            this.Q2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(32, 24);
            this.Q2.Text = "Q2";
            this.Q2.Click += new System.EventHandler(this.Q2_Click);
            // 
            // Q3
            // 
            this.Q3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Q3.Image = ((System.Drawing.Image)(resources.GetObject("Q3.Image")));
            this.Q3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(31, 24);
            this.Q3.Text = "All";
            this.Q3.Click += new System.EventHandler(this.Q3_Click);
            // 
            // tblDataGridView
            // 
            this.tblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDataGridView.Location = new System.Drawing.Point(0, 27);
            this.tblDataGridView.Name = "tblDataGridView";
            this.tblDataGridView.RowHeadersWidth = 51;
            this.tblDataGridView.RowTemplate.Height = 24;
            this.tblDataGridView.Size = new System.Drawing.Size(800, 306);
            this.tblDataGridView.TabIndex = 1;
            this.tblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDataGridView_CellContentClick);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OK.Location = new System.Drawing.Point(280, 364);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(210, 53);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.tblDataGridView);
            this.Controls.Add(this.tblBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBindingNavigator)).EndInit();
            this.tblBindingNavigator.ResumeLayout(false);
            this.tblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblBindingSource;
        private System.Windows.Forms.BindingNavigator tblBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tblDataGridView;
        private System.Windows.Forms.ToolStripButton Q1;
        private System.Windows.Forms.ToolStripButton Q2;
        private System.Windows.Forms.ToolStripButton Q3;
        private System.Windows.Forms.Button OK;
    }
}