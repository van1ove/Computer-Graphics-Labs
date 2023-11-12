namespace Lab2
{
    partial class Lab2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Original = new System.Windows.Forms.PictureBox();
            this.Processed = new System.Windows.Forms.PictureBox();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.FilterType = new System.Windows.Forms.ComboBox();
            this.GlobalTrackBar = new System.Windows.Forms.TrackBar();
            this.GlobalValue = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Linear = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.GlobalTypes = new System.Windows.Forms.ComboBox();
            this.BlockSize = new System.Windows.Forms.TextBox();
            this.Constant = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalTrackBar)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Original.Location = new System.Drawing.Point(0, 0);
            this.Original.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(500, 520);
            this.Original.TabIndex = 0;
            this.Original.TabStop = false;
            // 
            // Processed
            // 
            this.Processed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Processed.Location = new System.Drawing.Point(785, 0);
            this.Processed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Processed.Name = "Processed";
            this.Processed.Size = new System.Drawing.Size(500, 520);
            this.Processed.TabIndex = 1;
            this.Processed.TabStop = false;
            // 
            // openPicture
            // 
            this.openPicture.FileName = "openFileDialog1";
            this.openPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";
            this.openPicture.InitialDirectory = "C:\\";
            this.openPicture.Title = "Please select image file to filter";
            // 
            // FilterType
            // 
            this.FilterType.FormattingEnabled = true;
            this.FilterType.Items.AddRange(new object[] {
            "Global thresholding",
            "Element operations",
            "Adaptive thresholding"
            });
            this.FilterType.Location = new System.Drawing.Point(48, 12);
            this.FilterType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FilterType.Name = "FilterType";
            this.FilterType.Size = new System.Drawing.Size(180, 23);
            this.FilterType.TabIndex = 3;
            // 
            // GlobalTrackBar
            // 
            this.GlobalTrackBar.Location = new System.Drawing.Point(53, 106);
            this.GlobalTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.GlobalTrackBar.Maximum = 255;
            this.GlobalTrackBar.Name = "GlobalTrackBar";
            this.GlobalTrackBar.Size = new System.Drawing.Size(175, 45);
            this.GlobalTrackBar.TabIndex = 9;
            // 
            // GlobalValue
            // 
            this.GlobalValue.AutoSize = true;
            this.GlobalValue.Location = new System.Drawing.Point(53, 88);
            this.GlobalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GlobalValue.Name = "GlobalValue";
            this.GlobalValue.Size = new System.Drawing.Size(84, 15);
            this.GlobalValue.TabIndex = 10;
            this.GlobalValue.Text = "Value: 0";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 550);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(100, 40);
            this.OpenFileButton.TabIndex = 11;
            this.OpenFileButton.Text = "Open picture";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Linear);
            this.GroupBox.Controls.Add(this.Log);
            this.GroupBox.Controls.Add(this.Pow);
            this.GroupBox.Controls.Add(this.Multiply);
            this.GroupBox.Controls.Add(this.Reverse);
            this.GroupBox.Controls.Add(this.Add);
            this.GroupBox.Controls.Add(this.GlobalTypes);
            this.GroupBox.Controls.Add(this.GlobalTrackBar);
            this.GroupBox.Controls.Add(this.GlobalValue);
            this.GroupBox.Controls.Add(this.FilterType);
            this.GroupBox.Controls.Add(this.BlockSize);
            this.GroupBox.Controls.Add(this.Constant);
            this.GroupBox.Controls.Add(this.Filter);
            this.GroupBox.Location = new System.Drawing.Point(505, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(275, 400);
            this.GroupBox.TabIndex = 12;
            this.GroupBox.TabStop = false;
            // 
            // Linear
            // 
            this.Linear.Location = new System.Drawing.Point(88, 318);
            this.Linear.Name = "Linear";
            this.Linear.Size = new System.Drawing.Size(100, 40);
            this.Linear.TabIndex = 17;
            this.Linear.Text = "Linear";
            this.Linear.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(88, 272);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(100, 40);
            this.Log.TabIndex = 16;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(88, 226);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(100, 40);
            this.Pow.TabIndex = 15;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(88, 180);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(100, 40);
            this.Multiply.TabIndex = 14;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(88, 134);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(100, 40);
            this.Reverse.TabIndex = 13;
            this.Reverse.Text = "Reverse";
            this.Reverse.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(88, 88);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 40);
            this.Add.TabIndex = 12;
            this.Add.Text = "Sum";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // GlobalTypes
            // 
            this.GlobalTypes.FormattingEnabled = true;
            this.GlobalTypes.Items.AddRange(new object[] {
            "Otsu",
            "Gradient",
            "Value usage"
            });
            this.GlobalTypes.Location = new System.Drawing.Point(48, 51);
            this.GlobalTypes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GlobalTypes.Name = "GlobalTypes";
            this.GlobalTypes.Size = new System.Drawing.Size(180, 23);
            this.GlobalTypes.TabIndex = 11;
            // 
            // BlockSize
            // 
            this.BlockSize.Location = new System.Drawing.Point(48, 51);
            this.BlockSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BlockSize.Name = "BlockSize";
            this.BlockSize.Size = new System.Drawing.Size(180, 23);
            this.BlockSize.TabIndex = 12;
            this.BlockSize.Visible = true;
            // 
            // Constant
            //
            this.Constant.Location = new System.Drawing.Point(48, 81);
            this.Constant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Constant.Name = "Constant";
            this.Constant.Size = new System.Drawing.Size(180, 23);
            this.Constant.TabIndex = 13;
            this.Constant.Visible = true;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(88, 130);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(100, 40);
            this.Filter.TabIndex = 14;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            // 
            // Lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.Processed);
            this.Controls.Add(this.Original);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Lab2Form";
            this.Text = "Lab2Form";
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalTrackBar)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Original;
        private PictureBox Processed;
        private OpenFileDialog openPicture;
        private ComboBox FilterType;
        private TrackBar GlobalTrackBar;
        private Label GlobalValue;
        private Button OpenFileButton;
        private GroupBox GroupBox;
        private ComboBox GlobalTypes;
        private TextBox BlockSize;
        private TextBox Constant;
        private Button Add;
        private Button Linear;
        private Button Log;
        private Button Pow;
        private Button Multiply;
        private Button Reverse;
        private Button Filter;
    }
}