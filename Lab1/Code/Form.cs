using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChangeColorForm : Form
    {
        // initializing methods
        public ChangeColorForm()
        {
            InitializeComponent();
            SetStartPanels();
            SetRGBColor();
            ColorSystemBrain.SetTrackedForm(this);
        }

        private void SetStartPanels()
        {
            this.RGBValues.Visible = true;
            this.CMYKValues.Visible = true;
            this.HSVValues.Visible = true;
        }

        // main color settings
        private void SetRGBColor()
        {
            Color currentColor = Color.FromArgb(255, this.RedTrackBar.Value, this.GreenTrackBar.Value, this.BlueTrackBar.Value);
            this.ColorPanel.BackColor = currentColor;
        }

        private void SetCMYKColor()
        {
            ColorSystemBrain.CMYKtoRGB(out int redShade, out int greenShade, out int blueShade);
            Color currentColor = Color.FromArgb(255, redShade, greenShade, blueShade);
            this.ColorPanel.BackColor = currentColor;
        }

        private void SetHSVColor()
        {
            ColorSystemBrain.HSVtoRGB(out int redShade, out int greenShade, out int blueShade);
            Color currentColor = Color.FromArgb(255, redShade, greenShade, blueShade);
            this.ColorPanel.BackColor = currentColor;
        }

        // after RGB change
        private void SetCMYKbyRGB()
        {
            ColorSystemBrain.RGBtoCMYK(out float cyanShade, out float magentaShade, out float yellowShade, out float key);
            UpdateCMYKValues(cyanShade, magentaShade, yellowShade, key);
        }

        private void SetHSVbyRGB()
        {
            ColorSystemBrain.RGBtoHSV(out int hue, out float saturation, out float value);
            UpdateHSVValues(hue, (int)(100 * saturation), (int)(100 * value));
        }

        // after CMYK change
        private void SetRGBbyCMYK()
        {
            ColorSystemBrain.CMYKtoRGB(out int redShade, out int greenShade, out int blueShade);
            UpdateRGBValues(redShade, greenShade, blueShade);
        }

        private void SetHSVbyCMYK()
        {
            // CMYK -> RGB -> HSV через ColorSystemBrain
            ColorSystemBrain.CMYKtoHSV(out int hue, out float saturation, out float value);
            UpdateHSVValues(hue, (int)(100 * saturation), (int)(100 * value));
        }

        // after HSV change
        private void SetRGBbyHSV()
        {
            ColorSystemBrain.HSVtoRGB(out int redShade, out int greenShade, out int blueShade);
            UpdateRGBValues(redShade, greenShade, blueShade);
        }

        private void SetCMYKbyHSV()
        {
            // HSV -> RGB -> CMYK через ColorSystemBrain
            ColorSystemBrain.HSVtoCMYK(out float cyanShade, out float magentaShade, out float yellowShade, out float key);
            UpdateCMYKValues(cyanShade, magentaShade, yellowShade, key);
        }

        // RGB
        private void OnRedTrackBarChanged(object sender, EventArgs e)
        {
            this.RedValueLabel.Text = this.RedTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }

        private void OnGreenTrackBarChanged(object sender, EventArgs e)
        {
            this.GreenValueLabel.Text = this.GreenTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }

        private void OnBlueTrackBarChanged(object sender, EventArgs e)
        {
            this.BlueValueLabel.Text = this.BlueTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }

        // CMYK
        private void OnCyanTrackBarChanged(object sender, EventArgs e)
        {
            this.CyanValueLabel.Text = this.CyanTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnMagentaTrackBarChanged(object sender, EventArgs e)
        {
            this.MagentaValueLabel.Text = this.MagentaTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnYellowTrackBarChanged(object sender, EventArgs e)
        {
            this.YellowValueLabel.Text = this.YellowTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnKeyTrackBarChanged(object sender, EventArgs e)
        {
            this.KeyValueLabel.Text = this.KeyTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        // HSV
        private void OnHueTrackBarChanged(object sender, EventArgs e)
        {
            this.HueValueLabel.Text = this.HueTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
        }

        private void OnSaturationTrackBarChanged(object sender, EventArgs e)
        {
            this.SaturationValueLabel.Text = this.SaturationTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV(); 
        }

        private void OnValueTrackBarChanged(object sender, EventArgs e)
        {
            this.ValueValueLabel.Text = this.ValueTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
        }

        // labels update
        private void UpdateRGBValues(int red, int green, int blue)
        {
            this.RedValueLabel.Text = red.ToString();
            this.GreenValueLabel.Text = green.ToString();
            this.BlueValueLabel.Text = blue.ToString();

            this.RedTrackBar.Value = red;
            this.GreenTrackBar.Value = green;
            this.BlueTrackBar.Value = blue;
        }

        private void UpdateCMYKValues(float cyan, float magenta, float yellow, float key)
        {
            this.CyanValueLabel.Text = ((int)(cyan * 100)).ToString();
            this.MagentaValueLabel.Text = ((int)(magenta * 100)).ToString();
            this.YellowValueLabel.Text = ((int)(yellow * 100)).ToString();
            this.KeyValueLabel.Text = ((int)(key * 100)).ToString();

            this.CyanTrackBar.Value = (int)(cyan * 100);
            this.MagentaTrackBar.Value= (int)(magenta * 100);
            this.YellowTrackBar.Value = (int)(yellow * 100);
            this.KeyTrackBar.Value = (int)(key * 100);
        }

        private void UpdateHSVValues(int hue, int saturation, int value)
        {
            this.HueValueLabel.Text = hue.ToString();
            this.SaturationValueLabel.Text = saturation.ToString();
            this.ValueValueLabel.Text = value.ToString();

            this.HueTrackBar.Value = hue;
            this.SaturationTrackBar.Value = saturation;
            this.ValueTrackBar.Value = value;
        }
    }
}