namespace Last
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bresTime = new System.Windows.Forms.Label();
            this.stepTime = new System.Windows.Forms.Label();
            this.br = new System.Windows.Forms.Label();
            this.St = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.brX1 = new System.Windows.Forms.TextBox();
            this.brX2 = new System.Windows.Forms.TextBox();
            this.brY1 = new System.Windows.Forms.TextBox();
            this.brY2 = new System.Windows.Forms.TextBox();
            this.Draw = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.stY2 = new System.Windows.Forms.TextBox();
            this.stY1 = new System.Windows.Forms.TextBox();
            this.stX2 = new System.Windows.Forms.TextBox();
            this.stX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(933, 519);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // bresTime
            // 
            this.bresTime.AutoSize = true;
            this.bresTime.Location = new System.Drawing.Point(996, 18);
            this.bresTime.Name = "bresTime";
            this.bresTime.Size = new System.Drawing.Size(13, 15);
            this.bresTime.TabIndex = 1;
            this.bresTime.Text = "0";
            // 
            // stepTime
            // 
            this.stepTime.AutoSize = true;
            this.stepTime.Location = new System.Drawing.Point(996, 144);
            this.stepTime.Name = "stepTime";
            this.stepTime.Size = new System.Drawing.Size(13, 15);
            this.stepTime.TabIndex = 2;
            this.stepTime.Text = "0";
            // 
            // br
            // 
            this.br.AutoSize = true;
            this.br.Location = new System.Drawing.Point(941, 18);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(29, 15);
            this.br.TabIndex = 3;
            this.br.Text = "Bres";
            // 
            // St
            // 
            this.St.AutoSize = true;
            this.St.Location = new System.Drawing.Point(941, 144);
            this.St.Name = "St";
            this.St.Size = new System.Drawing.Size(30, 15);
            this.St.TabIndex = 4;
            this.St.Text = "Step";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(940, 74);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 15);
            this.xLabel.TabIndex = 5;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(1060, 74);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 15);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y";
            // 
            // brX1
            // 
            this.brX1.Location = new System.Drawing.Point(960, 51);
            this.brX1.Name = "brX1";
            this.brX1.Size = new System.Drawing.Size(45, 23);
            this.brX1.TabIndex = 7;
            // 
            // brX2
            // 
            this.brX2.Location = new System.Drawing.Point(960, 89);
            this.brX2.Name = "brX2";
            this.brX2.Size = new System.Drawing.Size(45, 23);
            this.brX2.TabIndex = 8;
            // 
            // brY1
            // 
            this.brY1.Location = new System.Drawing.Point(1080, 51);
            this.brY1.Name = "brY1";
            this.brY1.Size = new System.Drawing.Size(45, 23);
            this.brY1.TabIndex = 9;
            // 
            // brY2
            // 
            this.brY2.Location = new System.Drawing.Point(1080, 89);
            this.brY2.Name = "brY2";
            this.brY2.Size = new System.Drawing.Size(45, 23);
            this.brY2.TabIndex = 10;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(960, 275);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 11;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1050, 275);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // stY2
            // 
            this.stY2.Location = new System.Drawing.Point(1080, 213);
            this.stY2.Name = "stY2";
            this.stY2.Size = new System.Drawing.Size(45, 23);
            this.stY2.TabIndex = 18;
            // 
            // stY1
            // 
            this.stY1.Location = new System.Drawing.Point(1080, 175);
            this.stY1.Name = "stY1";
            this.stY1.Size = new System.Drawing.Size(45, 23);
            this.stY1.TabIndex = 17;
            // 
            // stX2
            // 
            this.stX2.Location = new System.Drawing.Point(960, 213);
            this.stX2.Name = "stX2";
            this.stX2.Size = new System.Drawing.Size(45, 23);
            this.stX2.TabIndex = 16;
            // 
            // stX1
            // 
            this.stX1.Location = new System.Drawing.Point(960, 175);
            this.stX1.Name = "stX1";
            this.stX1.Size = new System.Drawing.Size(45, 23);
            this.stX1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1060, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 519);
            this.Controls.Add(this.stY2);
            this.Controls.Add(this.stY1);
            this.Controls.Add(this.stX2);
            this.Controls.Add(this.stX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.brY2);
            this.Controls.Add(this.brY1);
            this.Controls.Add(this.brX2);
            this.Controls.Add(this.brX1);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.St);
            this.Controls.Add(this.br);
            this.Controls.Add(this.stepTime);
            this.Controls.Add(this.bresTime);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label bresTime;
        private Label stepTime;
        private Label br;
        private Label St;
        private Label xLabel;
        private Label yLabel;
        private TextBox brX1;
        private TextBox brX2;
        private TextBox brY1;
        private TextBox brY2;
        private Button Draw;
        private Button Clear;
        private TextBox stY2;
        private TextBox stY1;
        private TextBox stX2;
        private TextBox stX1;
        private Label label1;
        private Label label2;
    }
}