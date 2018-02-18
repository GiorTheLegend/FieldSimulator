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
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFix)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(93, 12);
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Size = new System.Drawing.Size(155, 20);
            this.ItemName.TabIndex = 0;
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
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(119, 57);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(50, 50);
            this.MoveUp.TabIndex = 6;
            this.MoveUp.Text = "Up";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(187, 112);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(50, 50);
            this.MoveRight.TabIndex = 7;
            this.MoveRight.Text = "Right";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(119, 169);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(50, 50);
            this.MoveDown.TabIndex = 8;
            this.MoveDown.Text = "Down";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
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
            this.MoveBy.ValueChanged += new System.EventHandler(this.MoveBy_ValueChanged);
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
            this.ScaleFix.ValueChanged += new System.EventHandler(this.ScaleFix_ValueChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(13, 191);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 16;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(10, 218);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 17;
            this.HeightLabel.Text = "Height:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(187, 165);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 18;
            this.LocationLabel.Text = "Location:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(187, 185);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 19;
            this.XLabel.Text = "X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(187, 211);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 20;
            this.YLabel.Text = "Y:";
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(57, 188);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(36, 20);
            this.Width.TabIndex = 21;
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(57, 214);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(36, 20);
            this.Height.TabIndex = 22;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(212, 185);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(36, 20);
            this.X.TabIndex = 23;
            this.X.TextChanged += new System.EventHandler(this.X_TextChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(212, 211);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(36, 20);
            this.Y.TabIndex = 24;
            this.Y.TextChanged += new System.EventHandler(this.Y_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "Value:\r\nX:\r\nField Width:\r\nItem Width:\r\n";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
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
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label1;
    }
}