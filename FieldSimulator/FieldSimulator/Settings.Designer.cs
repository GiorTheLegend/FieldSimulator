namespace FieldSimulator
{
    partial class Settings
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
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveBy = new System.Windows.Forms.NumericUpDown();
            this.MoveByLabel = new System.Windows.Forms.Label();
            this.pxLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.ScaleFix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFix)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(93, 12);
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Size = new System.Drawing.Size(100, 20);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "as";
            this.ItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(26, 12);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.ItemNameLabel.TabIndex = 2;
            this.ItemNameLabel.Text = "Item Name:";
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(43, 112);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(50, 50);
            this.MoveLeft.TabIndex = 5;
            this.MoveLeft.Text = "Left";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.button3_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(119, 57);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(50, 50);
            this.MoveUp.TabIndex = 6;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(187, 112);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(50, 50);
            this.MoveRight.TabIndex = 7;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(119, 169);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(50, 50);
            this.MoveDown.TabIndex = 8;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            // 
            // MoveBy
            // 
            this.MoveBy.Location = new System.Drawing.Point(109, 129);
            this.MoveBy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MoveBy.Name = "MoveBy";
            this.MoveBy.Size = new System.Drawing.Size(36, 20);
            this.MoveBy.TabIndex = 9;
            this.MoveBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MoveBy.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MoveByLabel
            // 
            this.MoveByLabel.AutoSize = true;
            this.MoveByLabel.Location = new System.Drawing.Point(116, 110);
            this.MoveByLabel.Name = "MoveByLabel";
            this.MoveByLabel.Size = new System.Drawing.Size(51, 13);
            this.MoveByLabel.TabIndex = 10;
            this.MoveByLabel.Text = "Move by:";
            // 
            // pxLabel
            // 
            this.pxLabel.AutoSize = true;
            this.pxLabel.Location = new System.Drawing.Point(151, 136);
            this.pxLabel.Name = "pxLabel";
            this.pxLabel.Size = new System.Drawing.Size(18, 13);
            this.pxLabel.TabIndex = 12;
            this.pxLabel.Text = "px";
            this.pxLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(13, 47);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(37, 13);
            this.ScaleLabel.TabIndex = 14;
            this.ScaleLabel.Text = "Scale:";
            // 
            // ScaleFix
            // 
            this.ScaleFix.DecimalPlaces = 2;
            this.ScaleFix.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleFix.Location = new System.Drawing.Point(57, 47);
            this.ScaleFix.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            131072});
            this.ScaleFix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleFix.Name = "ScaleFix";
            this.ScaleFix.Size = new System.Drawing.Size(43, 20);
            this.ScaleFix.TabIndex = 15;
            this.ScaleFix.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.ScaleFix.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ScaleFix);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.pxLabel);
            this.Controls.Add(this.MoveByLabel);
            this.Controls.Add(this.MoveBy);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemName);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.MoveBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.NumericUpDown MoveBy;
        private System.Windows.Forms.Label MoveByLabel;
        private System.Windows.Forms.Label pxLabel;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.NumericUpDown ScaleFix;
    }
}