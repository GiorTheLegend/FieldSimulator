namespace FieldSimulator
{
    partial class Control
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
            this.AddCmd = new System.Windows.Forms.Button();
            this.InitialLocationLabel = new System.Windows.Forms.Label();
            this.InitialXLabel = new System.Windows.Forms.Label();
            this.InitialX = new System.Windows.Forms.TextBox();
            this.InitialYLabel = new System.Windows.Forms.Label();
            this.InitialY = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.CmdsLabel = new System.Windows.Forms.Label();
            this.CmdsInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCmd
            // 
            this.AddCmd.Location = new System.Drawing.Point(273, 26);
            this.AddCmd.Name = "AddCmd";
            this.AddCmd.Size = new System.Drawing.Size(75, 41);
            this.AddCmd.TabIndex = 0;
            this.AddCmd.Text = "Add Command";
            this.AddCmd.UseVisualStyleBackColor = true;
            this.AddCmd.Click += new System.EventHandler(this.AddCmd_Click);
            // 
            // InitialLocationLabel
            // 
            this.InitialLocationLabel.AutoSize = true;
            this.InitialLocationLabel.Location = new System.Drawing.Point(13, 13);
            this.InitialLocationLabel.Name = "InitialLocationLabel";
            this.InitialLocationLabel.Size = new System.Drawing.Size(78, 13);
            this.InitialLocationLabel.TabIndex = 1;
            this.InitialLocationLabel.Text = "Initial Location:";
            // 
            // InitialXLabel
            // 
            this.InitialXLabel.AutoSize = true;
            this.InitialXLabel.Location = new System.Drawing.Point(13, 29);
            this.InitialXLabel.Name = "InitialXLabel";
            this.InitialXLabel.Size = new System.Drawing.Size(17, 13);
            this.InitialXLabel.TabIndex = 2;
            this.InitialXLabel.Text = "X:";
            // 
            // InitialX
            // 
            this.InitialX.Location = new System.Drawing.Point(36, 26);
            this.InitialX.Name = "InitialX";
            this.InitialX.Size = new System.Drawing.Size(28, 20);
            this.InitialX.TabIndex = 3;
            this.InitialX.Text = "0";
            // 
            // InitialYLabel
            // 
            this.InitialYLabel.AutoSize = true;
            this.InitialYLabel.Location = new System.Drawing.Point(13, 52);
            this.InitialYLabel.Name = "InitialYLabel";
            this.InitialYLabel.Size = new System.Drawing.Size(17, 13);
            this.InitialYLabel.TabIndex = 5;
            this.InitialYLabel.Text = "Y:";
            // 
            // InitialY
            // 
            this.InitialY.Location = new System.Drawing.Point(36, 49);
            this.InitialY.Name = "InitialY";
            this.InitialY.Size = new System.Drawing.Size(28, 20);
            this.InitialY.TabIndex = 6;
            this.InitialY.Text = "0";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(191, 12);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 7;
            this.LocationLabel.Text = "Location:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(182, 33);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 8;
            this.XLabel.Text = "X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(182, 56);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 9;
            this.YLabel.Text = "Y:";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(205, 30);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(28, 20);
            this.X.TabIndex = 10;
            this.X.Text = "0";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(205, 52);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(28, 20);
            this.Y.TabIndex = 11;
            this.Y.Text = "0";
            // 
            // CmdsLabel
            // 
            this.CmdsLabel.AutoSize = true;
            this.CmdsLabel.Location = new System.Drawing.Point(12, 94);
            this.CmdsLabel.Name = "CmdsLabel";
            this.CmdsLabel.Size = new System.Drawing.Size(62, 13);
            this.CmdsLabel.TabIndex = 12;
            this.CmdsLabel.Text = "Commands:";
            // 
            // CmdsInfoLabel
            // 
            this.CmdsInfoLabel.AutoSize = true;
            this.CmdsInfoLabel.Location = new System.Drawing.Point(13, 111);
            this.CmdsInfoLabel.Name = "CmdsInfoLabel";
            this.CmdsInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.CmdsInfoLabel.TabIndex = 13;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 276);
            this.Controls.Add(this.CmdsInfoLabel);
            this.Controls.Add(this.CmdsLabel);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.InitialY);
            this.Controls.Add(this.InitialYLabel);
            this.Controls.Add(this.InitialX);
            this.Controls.Add(this.InitialXLabel);
            this.Controls.Add(this.InitialLocationLabel);
            this.Controls.Add(this.AddCmd);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCmd;
        private System.Windows.Forms.Label InitialLocationLabel;
        private System.Windows.Forms.Label InitialXLabel;
        private System.Windows.Forms.TextBox InitialX;
        private System.Windows.Forms.Label InitialYLabel;
        private System.Windows.Forms.TextBox InitialY;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label CmdsLabel;
        private System.Windows.Forms.Label CmdsInfoLabel;
    }
}