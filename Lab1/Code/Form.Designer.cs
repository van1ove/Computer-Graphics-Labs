namespace Lab1
{
    partial class ChangeColorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.RGBValues = new System.Windows.Forms.GroupBox();
            this.BlueValueLabel = new System.Windows.Forms.Label();
            this.GreenValueLabel = new System.Windows.Forms.Label();
            this.RedValueLabel = new System.Windows.Forms.Label();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.CMYKValues = new System.Windows.Forms.GroupBox();
            this.KeyValueLabel = new System.Windows.Forms.Label();
            this.YellowValueLabel = new System.Windows.Forms.Label();
            this.MagentaValueLabel = new System.Windows.Forms.Label();
            this.CyanValueLabel = new System.Windows.Forms.Label();
            this.KeyTrackBar = new System.Windows.Forms.TrackBar();
            this.YellowTrackBar = new System.Windows.Forms.TrackBar();
            this.MagentaTrackBar = new System.Windows.Forms.TrackBar();
            this.CyanTrackBar = new System.Windows.Forms.TrackBar();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.MagentaLabel = new System.Windows.Forms.Label();
            this.CyanLabel = new System.Windows.Forms.Label();
            this.HSVValues = new System.Windows.Forms.GroupBox();
            this.ValueValueLabel = new System.Windows.Forms.Label();
            this.SaturationValueLabel = new System.Windows.Forms.Label();
            this.HueValueLabel = new System.Windows.Forms.Label();
            this.HueTrackBar = new System.Windows.Forms.TrackBar();
            this.ValueTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.HueLabel = new System.Windows.Forms.Label();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.HueTextBox = new System.Windows.Forms.TextBox();
            this.SaturationTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.YellowTextBox = new System.Windows.Forms.TextBox();
            this.MagentaTextBox = new System.Windows.Forms.TextBox();
            this.CyanTextBox = new System.Windows.Forms.TextBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.RGBValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            this.CMYKValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyanTrackBar)).BeginInit();
            this.HSVValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(13, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(659, 576);
            this.ColorPanel.TabIndex = 1;
            // 
            // RGBValues
            // 
            this.RGBValues.Controls.Add(this.BlueValueLabel);
            this.RGBValues.Controls.Add(this.GreenValueLabel);
            this.RGBValues.Controls.Add(this.RedValueLabel);
            this.RGBValues.Controls.Add(this.RedTrackBar);
            this.RGBValues.Controls.Add(this.BlueTrackBar);
            this.RGBValues.Controls.Add(this.GreenTrackBar);
            this.RGBValues.Controls.Add(this.BlueLabel);
            this.RGBValues.Controls.Add(this.GreenLabel);
            this.RGBValues.Controls.Add(this.RedLabel);
            this.RGBValues.Location = new System.Drawing.Point(700, 12);
            this.RGBValues.Name = "RGBValues";
            this.RGBValues.Size = new System.Drawing.Size(288, 193);
            this.RGBValues.TabIndex = 2;
            this.RGBValues.TabStop = false;
            this.RGBValues.Text = "RGBValues";
            // 
            // BlueValueLabel
            // 
            this.BlueValueLabel.AutoSize = true;
            this.BlueValueLabel.Location = new System.Drawing.Point(83, 130);
            this.BlueValueLabel.Name = "BlueValueLabel";
            this.BlueValueLabel.Size = new System.Drawing.Size(13, 15);
            this.BlueValueLabel.TabIndex = 9;
            this.BlueValueLabel.Text = "0";
            // 
            // GreenValueLabel
            // 
            this.GreenValueLabel.AutoSize = true;
            this.GreenValueLabel.Location = new System.Drawing.Point(83, 76);
            this.GreenValueLabel.Name = "GreenValueLabel";
            this.GreenValueLabel.Size = new System.Drawing.Size(13, 15);
            this.GreenValueLabel.TabIndex = 8;
            this.GreenValueLabel.Text = "0";
            // 
            // RedValueLabel
            // 
            this.RedValueLabel.AutoSize = true;
            this.RedValueLabel.Location = new System.Drawing.Point(83, 24);
            this.RedValueLabel.Name = "RedValueLabel";
            this.RedValueLabel.Size = new System.Drawing.Size(13, 15);
            this.RedValueLabel.TabIndex = 7;
            this.RedValueLabel.Text = "0";
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(124, 24);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(158, 45);
            this.RedTrackBar.TabIndex = 4;
            this.RedTrackBar.Scroll += new System.EventHandler(this.OnRedTrackBarChanged);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(124, 130);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.BlueTrackBar.TabIndex = 6;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.OnBlueTrackBarChanged);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(124, 76);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(158, 45);
            this.GreenTrackBar.TabIndex = 5;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.OnGreenTrackBarChanged);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(6, 130);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(30, 15);
            this.BlueLabel.TabIndex = 3;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(6, 76);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(38, 15);
            this.GreenLabel.TabIndex = 2;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(6, 24);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 15);
            this.RedLabel.TabIndex = 1;
            this.RedLabel.Text = "Red";
            // 
            // RedTextBox
            // 
            this.RedTextBox.Location = new System.Drawing.Point(1011, 36);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RedTextBox.Size = new System.Drawing.Size(50, 23);
            this.RedTextBox.TabIndex = 5;
            this.RedTextBox.Text = "0";
            this.RedTextBox.Leave += new System.EventHandler(this.OnRedTextBoxLeft);
            // 
            // CMYKValues
            // 
            this.CMYKValues.Controls.Add(this.KeyValueLabel);
            this.CMYKValues.Controls.Add(this.YellowValueLabel);
            this.CMYKValues.Controls.Add(this.MagentaValueLabel);
            this.CMYKValues.Controls.Add(this.CyanValueLabel);
            this.CMYKValues.Controls.Add(this.KeyTrackBar);
            this.CMYKValues.Controls.Add(this.YellowTrackBar);
            this.CMYKValues.Controls.Add(this.MagentaTrackBar);
            this.CMYKValues.Controls.Add(this.CyanTrackBar);
            this.CMYKValues.Controls.Add(this.KeyLabel);
            this.CMYKValues.Controls.Add(this.YellowLabel);
            this.CMYKValues.Controls.Add(this.MagentaLabel);
            this.CMYKValues.Controls.Add(this.CyanLabel);
            this.CMYKValues.Location = new System.Drawing.Point(700, 180);
            this.CMYKValues.Name = "CMYKValues";
            this.CMYKValues.Size = new System.Drawing.Size(288, 220);
            this.CMYKValues.TabIndex = 3;
            this.CMYKValues.TabStop = false;
            this.CMYKValues.Text = "CMYKValues";
            // 
            // KeyValueLabel
            // 
            this.KeyValueLabel.AutoSize = true;
            this.KeyValueLabel.Location = new System.Drawing.Point(83, 175);
            this.KeyValueLabel.Name = "KeyValueLabel";
            this.KeyValueLabel.Size = new System.Drawing.Size(13, 15);
            this.KeyValueLabel.TabIndex = 12;
            this.KeyValueLabel.Text = "0";
            // 
            // YellowValueLabel
            // 
            this.YellowValueLabel.AutoSize = true;
            this.YellowValueLabel.Location = new System.Drawing.Point(83, 120);
            this.YellowValueLabel.Name = "YellowValueLabel";
            this.YellowValueLabel.Size = new System.Drawing.Size(13, 15);
            this.YellowValueLabel.TabIndex = 11;
            this.YellowValueLabel.Text = "0";
            // 
            // MagentaValueLabel
            // 
            this.MagentaValueLabel.AutoSize = true;
            this.MagentaValueLabel.Location = new System.Drawing.Point(83, 76);
            this.MagentaValueLabel.Name = "MagentaValueLabel";
            this.MagentaValueLabel.Size = new System.Drawing.Size(13, 15);
            this.MagentaValueLabel.TabIndex = 10;
            this.MagentaValueLabel.Text = "0";
            // 
            // CyanValueLabel
            // 
            this.CyanValueLabel.AutoSize = true;
            this.CyanValueLabel.Location = new System.Drawing.Point(83, 30);
            this.CyanValueLabel.Name = "CyanValueLabel";
            this.CyanValueLabel.Size = new System.Drawing.Size(13, 15);
            this.CyanValueLabel.TabIndex = 9;
            this.CyanValueLabel.Text = "0";
            // 
            // KeyTrackBar
            // 
            this.KeyTrackBar.Location = new System.Drawing.Point(124, 172);
            this.KeyTrackBar.Maximum = 100;
            this.KeyTrackBar.Name = "KeyTrackBar";
            this.KeyTrackBar.Size = new System.Drawing.Size(158, 45);
            this.KeyTrackBar.TabIndex = 7;
            this.KeyTrackBar.Scroll += new System.EventHandler(this.OnKeyTrackBarChanged);
            // 
            // YellowTrackBar
            // 
            this.YellowTrackBar.Location = new System.Drawing.Point(124, 120);
            this.YellowTrackBar.Maximum = 100;
            this.YellowTrackBar.Name = "YellowTrackBar";
            this.YellowTrackBar.Size = new System.Drawing.Size(158, 45);
            this.YellowTrackBar.TabIndex = 6;
            this.YellowTrackBar.Scroll += new System.EventHandler(this.OnYellowTrackBarChanged);
            // 
            // MagentaTrackBar
            // 
            this.MagentaTrackBar.Location = new System.Drawing.Point(124, 73);
            this.MagentaTrackBar.Maximum = 100;
            this.MagentaTrackBar.Name = "MagentaTrackBar";
            this.MagentaTrackBar.Size = new System.Drawing.Size(158, 45);
            this.MagentaTrackBar.TabIndex = 5;
            this.MagentaTrackBar.Scroll += new System.EventHandler(this.OnMagentaTrackBarChanged);
            // 
            // CyanTrackBar
            // 
            this.CyanTrackBar.Location = new System.Drawing.Point(124, 22);
            this.CyanTrackBar.Maximum = 100;
            this.CyanTrackBar.Name = "CyanTrackBar";
            this.CyanTrackBar.Size = new System.Drawing.Size(158, 45);
            this.CyanTrackBar.TabIndex = 4;
            this.CyanTrackBar.Scroll += new System.EventHandler(this.OnCyanTrackBarChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(6, 175);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Key";
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.Location = new System.Drawing.Point(6, 122);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(41, 15);
            this.YellowLabel.TabIndex = 2;
            this.YellowLabel.Text = "Yellow";
            // 
            // MagentaLabel
            // 
            this.MagentaLabel.AutoSize = true;
            this.MagentaLabel.Location = new System.Drawing.Point(6, 76);
            this.MagentaLabel.Name = "MagentaLabel";
            this.MagentaLabel.Size = new System.Drawing.Size(54, 15);
            this.MagentaLabel.TabIndex = 1;
            this.MagentaLabel.Text = "Magenta";
            // 
            // CyanLabel
            // 
            this.CyanLabel.AutoSize = true;
            this.CyanLabel.Location = new System.Drawing.Point(6, 30);
            this.CyanLabel.Name = "CyanLabel";
            this.CyanLabel.Size = new System.Drawing.Size(34, 15);
            this.CyanLabel.TabIndex = 0;
            this.CyanLabel.Text = "Cyan";
            // 
            // HSVValues
            // 
            this.HSVValues.Controls.Add(this.ValueValueLabel);
            this.HSVValues.Controls.Add(this.SaturationValueLabel);
            this.HSVValues.Controls.Add(this.HueValueLabel);
            this.HSVValues.Controls.Add(this.HueTrackBar);
            this.HSVValues.Controls.Add(this.ValueTrackBar);
            this.HSVValues.Controls.Add(this.SaturationTrackBar);
            this.HSVValues.Controls.Add(this.ValueLabel);
            this.HSVValues.Controls.Add(this.SaturationLabel);
            this.HSVValues.Controls.Add(this.HueLabel);
            this.HSVValues.Location = new System.Drawing.Point(700, 395);
            this.HSVValues.Name = "HSVValues";
            this.HSVValues.Size = new System.Drawing.Size(288, 193);
            this.HSVValues.TabIndex = 4;
            this.HSVValues.TabStop = false;
            this.HSVValues.Text = "HSVValues";
            // 
            // ValueValueLabel
            // 
            this.ValueValueLabel.AutoSize = true;
            this.ValueValueLabel.Location = new System.Drawing.Point(83, 130);
            this.ValueValueLabel.Name = "ValueValueLabel";
            this.ValueValueLabel.Size = new System.Drawing.Size(13, 15);
            this.ValueValueLabel.TabIndex = 9;
            this.ValueValueLabel.Text = "0";
            // 
            // SaturationValueLabel
            // 
            this.SaturationValueLabel.AutoSize = true;
            this.SaturationValueLabel.Location = new System.Drawing.Point(83, 76);
            this.SaturationValueLabel.Name = "SaturationValueLabel";
            this.SaturationValueLabel.Size = new System.Drawing.Size(13, 15);
            this.SaturationValueLabel.TabIndex = 8;
            this.SaturationValueLabel.Text = "0";
            // 
            // HueValueLabel
            // 
            this.HueValueLabel.AutoSize = true;
            this.HueValueLabel.Location = new System.Drawing.Point(83, 24);
            this.HueValueLabel.Name = "HueValueLabel";
            this.HueValueLabel.Size = new System.Drawing.Size(13, 15);
            this.HueValueLabel.TabIndex = 7;
            this.HueValueLabel.Text = "0";
            // 
            // HueTrackBar
            // 
            this.HueTrackBar.Location = new System.Drawing.Point(124, 24);
            this.HueTrackBar.Maximum = 360;
            this.HueTrackBar.Name = "HueTrackBar";
            this.HueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.HueTrackBar.TabIndex = 4;
            this.HueTrackBar.Scroll += new System.EventHandler(this.OnHueTrackBarChanged);
            // 
            // ValueTrackBar
            // 
            this.ValueTrackBar.Location = new System.Drawing.Point(124, 130);
            this.ValueTrackBar.Maximum = 100;
            this.ValueTrackBar.Name = "ValueTrackBar";
            this.ValueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.ValueTrackBar.TabIndex = 6;
            this.ValueTrackBar.Scroll += new System.EventHandler(this.OnValueTrackBarChanged);
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.Location = new System.Drawing.Point(124, 76);
            this.SaturationTrackBar.Maximum = 100;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(158, 45);
            this.SaturationTrackBar.TabIndex = 5;
            this.SaturationTrackBar.Scroll += new System.EventHandler(this.OnSaturationTrackBarChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(6, 130);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Value";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(6, 76);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(61, 15);
            this.SaturationLabel.TabIndex = 2;
            this.SaturationLabel.Text = "Saturation";
            // 
            // HueLabel
            // 
            this.HueLabel.AutoSize = true;
            this.HueLabel.Location = new System.Drawing.Point(6, 24);
            this.HueLabel.Name = "HueLabel";
            this.HueLabel.Size = new System.Drawing.Size(29, 15);
            this.HueLabel.TabIndex = 1;
            this.HueLabel.Text = "Hue";
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Location = new System.Drawing.Point(1011, 88);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GreenTextBox.Size = new System.Drawing.Size(50, 23);
            this.GreenTextBox.TabIndex = 6;
            this.GreenTextBox.Text = "0";
            this.GreenTextBox.Leave += new System.EventHandler(this.OnGreenTextBoxLeft);
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Location = new System.Drawing.Point(1011, 142);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BlueTextBox.Size = new System.Drawing.Size(50, 23);
            this.BlueTextBox.TabIndex = 7;
            this.BlueTextBox.Text = "0";
            this.BlueTextBox.Leave += new System.EventHandler(this.OnBlueTextBoxLeft);
            // 
            // HueTextBox
            // 
            this.HueTextBox.Location = new System.Drawing.Point(1011, 419);
            this.HueTextBox.Name = "HueTextBox";
            this.HueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.HueTextBox.Size = new System.Drawing.Size(50, 23);
            this.HueTextBox.TabIndex = 8;
            this.HueTextBox.Text = "0";
            this.HueTextBox.Leave += new System.EventHandler(this.OnHueTextBoxLeft);
            // 
            // SaturationTextBox
            // 
            this.SaturationTextBox.Location = new System.Drawing.Point(1011, 471);
            this.SaturationTextBox.Name = "SaturationTextBox";
            this.SaturationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SaturationTextBox.Size = new System.Drawing.Size(50, 23);
            this.SaturationTextBox.TabIndex = 9;
            this.SaturationTextBox.Text = "0";
            this.SaturationTextBox.Leave += new System.EventHandler(this.OnSaturationTextBoxLeft);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(1011, 525);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ValueTextBox.Size = new System.Drawing.Size(50, 23);
            this.ValueTextBox.TabIndex = 10;
            this.ValueTextBox.Text = "0";
            this.ValueTextBox.Leave += new System.EventHandler(this.OnValueTextBoxLeft);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(1011, 355);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KeyTextBox.Size = new System.Drawing.Size(50, 23);
            this.KeyTextBox.TabIndex = 11;
            this.KeyTextBox.Text = "0";
            this.KeyTextBox.Leave += new System.EventHandler(this.OnKeyTextBoxLeft);
            // 
            // YellowTextBox
            // 
            this.YellowTextBox.Location = new System.Drawing.Point(1011, 302);
            this.YellowTextBox.Name = "YellowTextBox";
            this.YellowTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.YellowTextBox.Size = new System.Drawing.Size(50, 23);
            this.YellowTextBox.TabIndex = 12;
            this.YellowTextBox.Text = "0";
            this.YellowTextBox.Leave += new System.EventHandler(this.OnYellowTextBoxLeft);
            // 
            // MagentaTextBox
            // 
            this.MagentaTextBox.Location = new System.Drawing.Point(1011, 256);
            this.MagentaTextBox.Name = "MagentaTextBox";
            this.MagentaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MagentaTextBox.Size = new System.Drawing.Size(50, 23);
            this.MagentaTextBox.TabIndex = 13;
            this.MagentaTextBox.Text = "0";
            this.MagentaTextBox.Leave += new System.EventHandler(this.OnMagentaTextBoxLeft);
            // 
            // CyanTextBox
            // 
            this.CyanTextBox.Location = new System.Drawing.Point(1011, 202);
            this.CyanTextBox.Name = "CyanTextBox";
            this.CyanTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CyanTextBox.Size = new System.Drawing.Size(50, 23);
            this.CyanTextBox.TabIndex = 14;
            this.CyanTextBox.Text = "0";
            this.CyanTextBox.Leave += new System.EventHandler(this.OnCyanTextBoxLeft);
            // 
            // ColorDialog
            // 
            this.ColorDialog.AnyColor = true;
            this.ColorDialog.Color = System.Drawing.Color.LightGray;
            this.ColorDialog.FullOpen = true;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(1145, 36);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(113, 39);
            this.ColorButton.TabIndex = 15;
            this.ColorButton.Text = "Open Color Dialog";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // ChangeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 598);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.CyanTextBox);
            this.Controls.Add(this.MagentaTextBox);
            this.Controls.Add(this.YellowTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.SaturationTextBox);
            this.Controls.Add(this.HueTextBox);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.RedTextBox);
            this.Controls.Add(this.HSVValues);
            this.Controls.Add(this.CMYKValues);
            this.Controls.Add(this.RGBValues);
            this.Controls.Add(this.ColorPanel);
            this.Name = "ChangeColorForm";
            this.Text = "ChangeColorForm";
            this.RGBValues.ResumeLayout(false);
            this.RGBValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            this.CMYKValues.ResumeLayout(false);
            this.CMYKValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyanTrackBar)).EndInit();
            this.HSVValues.ResumeLayout(false);
            this.HSVValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Panel ColorPanel;
        //
        // RGB
        //
        private GroupBox RGBValues;
        private Label BlueLabel;
        private Label GreenLabel;
        private Label RedLabel;
        private Label BlueValueLabel;
        private Label GreenValueLabel;
        private Label RedValueLabel;
        public TrackBar RedTrackBar;
        public TrackBar BlueTrackBar;
        public TrackBar GreenTrackBar;
        private TextBox RedTextBox;
        private TextBox GreenTextBox;
        private TextBox BlueTextBox;
        //
        // CMYK
        //
        private GroupBox CMYKValues;
        private Label MagentaLabel;
        private Label CyanLabel;
        private Label YellowLabel;
        public TrackBar KeyTrackBar;
        public TrackBar YellowTrackBar;
        public TrackBar MagentaTrackBar;
        public TrackBar CyanTrackBar;
        private Label KeyLabel;
        private Label YellowValueLabel;
        private Label MagentaValueLabel;
        private Label CyanValueLabel;
        private Label KeyValueLabel;
        private TextBox YellowTextBox;
        private TextBox MagentaTextBox;
        private TextBox CyanTextBox;
        private TextBox KeyTextBox;
        //
        // HSV
        //
        private GroupBox HSVValues;
        private Label ValueValueLabel;
        private Label SaturationValueLabel;
        private Label HueValueLabel;
        public TrackBar HueTrackBar;
        public TrackBar ValueTrackBar;
        public TrackBar SaturationTrackBar;
        private Label ValueLabel;
        private Label SaturationLabel;
        private Label HueLabel;
        private TextBox HueTextBox;
        private TextBox SaturationTextBox;
        private TextBox ValueTextBox;
        //
        // Color Dialog
        //
        private ColorDialog ColorDialog;
        private Button ColorButton;
    }

    #endregion
}