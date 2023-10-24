using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChangeColorForm : Form
    {
        public ChangeColorForm()
        {
            InitializeComponent();
            SetRGBColor();
            ColorSystemBrain.SetTrackedForm(this);
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

        // text update
        private void UpdateRGBValues(int red, int green, int blue)
        {
            this.RedValueLabel.Text = red.ToString();
            this.GreenValueLabel.Text = green.ToString();
            this.BlueValueLabel.Text = blue.ToString();

            this.RedTextBox.Text = red.ToString();
            this.GreenTextBox.Text = green.ToString();
            this.BlueTextBox.Text = blue.ToString();

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

            this.CyanTextBox.Text = ((int)(cyan * 100)).ToString();
            this.MagentaTextBox.Text = ((int)(magenta * 100)).ToString();
            this.YellowTextBox.Text = ((int)(yellow * 100)).ToString();
            this.KeyTextBox.Text = ((int)(key * 100)).ToString();

            this.CyanTrackBar.Value = (int)(cyan * 100);
            this.MagentaTrackBar.Value = (int)(magenta * 100);
            this.YellowTrackBar.Value = (int)(yellow * 100);
            this.KeyTrackBar.Value = (int)(key * 100);
        }

        private void UpdateHSVValues(int hue, int saturation, int value)
        {
            this.HueValueLabel.Text = hue.ToString();
            this.SaturationValueLabel.Text = saturation.ToString();
            this.ValueValueLabel.Text = value.ToString();

            this.HueTextBox.Text = hue.ToString();
            this.SaturationTextBox.Text = saturation.ToString();
            this.ValueTextBox.Text = value.ToString();

            this.HueTrackBar.Value = hue;
            this.SaturationTrackBar.Value = saturation;
            this.ValueTrackBar.Value = value;
        }

        // RGB
        private void OnRedTrackBarChanged(object sender, EventArgs e)
        {
            this.RedValueLabel.Text = this.RedTrackBar.Value.ToString();
            this.RedTextBox.Text = this.RedTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }

        private void OnGreenTrackBarChanged(object sender, EventArgs e)
        {
            this.GreenValueLabel.Text = this.GreenTrackBar.Value.ToString();
            this.GreenTextBox.Text = this.GreenTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }

        private void OnBlueTrackBarChanged(object sender, EventArgs e)
        {
            this.BlueValueLabel.Text = this.BlueTrackBar.Value.ToString();
            this.BlueTextBox.Text = this.BlueTrackBar.Value.ToString();
            SetRGBColor();
            SetCMYKbyRGB();
            SetHSVbyRGB();
        }
        

        private void OnRedTextBoxLeft(object sender, EventArgs e)
        {
            int red;
            if (Int32.TryParse(this.RedTextBox.Text, out red))
            {
                if (red < 0) red = 0;
                else if (red > 255) red = 255;
                this.RedTextBox.Text = red.ToString();
                UpdateRGBValues(red, this.GreenTrackBar.Value, this.BlueTrackBar.Value);
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
            }
            else
            {
                this.RedTextBox.Text = "0";
            }
        }

        private void OnGreenTextBoxLeft(object sender, EventArgs e)
        {
            int green;
            if (Int32.TryParse(this.GreenTextBox.Text, out green))
            {
                if (green < 0) green = 0;
                else if (green > 255) green = 255;
                this.GreenTextBox.Text = green.ToString();
                UpdateRGBValues(this.RedTrackBar.Value, green, this.BlueTrackBar.Value);
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
            }
            else
            {
                this.GreenTextBox.Text = "0";
            }
        }

        private void OnBlueTextBoxLeft(object sender, EventArgs e)
        {
            int blue;
            if (Int32.TryParse(this.BlueTextBox.Text, out blue))
            {
                if (blue < 0) blue = 0;
                else if (blue > 255) blue = 255;
                this.BlueTextBox.Text = blue.ToString();
                UpdateRGBValues(this.RedTrackBar.Value, this.GreenTrackBar.Value, blue);
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
            }
            else
            {
                this.BlueTextBox.Text = "0";
            }
        }

        // CMYK
        private void OnCyanTrackBarChanged(object sender, EventArgs e)
        {
            this.CyanValueLabel.Text = this.CyanTrackBar.Value.ToString();
            this.CyanTextBox.Text = this.CyanTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnMagentaTrackBarChanged(object sender, EventArgs e)
        {
            this.MagentaValueLabel.Text = this.MagentaTrackBar.Value.ToString();
            this.MagentaTextBox.Text = this.MagentaTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnYellowTrackBarChanged(object sender, EventArgs e)
        {
            this.YellowValueLabel.Text = this.YellowTrackBar.Value.ToString();
            this.YellowTextBox.Text = this.YellowTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }

        private void OnKeyTrackBarChanged(object sender, EventArgs e)
        {
            this.KeyValueLabel.Text = this.KeyTrackBar.Value.ToString();
            this.KeyTextBox.Text = this.KeyTrackBar.Value.ToString();
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
        }


        private void OnCyanTextBoxLeft(object sender, EventArgs e)
        {
            int cyan;
            if (Int32.TryParse(this.CyanTextBox.Text, out cyan))
            {
                if (cyan < 0) cyan = 0;
                else if (cyan > 100) cyan = 100;

                this.CyanTrackBar.Value = cyan;
                this.CyanValueLabel.Text = cyan.ToString();
                this.CyanTextBox.Text = cyan.ToString();

                SetCMYKColor();
                SetRGBbyCMYK();
                SetHSVbyCMYK();
            }
            else
            {
                this.CyanTextBox.Text = "0";
            }
        }

        private void OnMagentaTextBoxLeft(object sender, EventArgs e)
        {
            int magenta;
            if (Int32.TryParse(this.MagentaTextBox.Text, out magenta))
            {
                if (magenta < 0) magenta = 0;
                else if (magenta > 100) magenta = 100;

                this.MagentaTrackBar.Value = magenta;
                this.MagentaValueLabel.Text = magenta.ToString();
                this.MagentaTextBox.Text = magenta.ToString();

                SetCMYKColor();
                SetRGBbyCMYK();
                SetHSVbyCMYK();
            }
            else
            {
                this.MagentaTextBox.Text = "0";
            }
        }

        private void OnYellowTextBoxLeft(object sender, EventArgs e)
        {
            int yellow;
            if (Int32.TryParse(this.YellowTextBox.Text, out yellow))
            {
                if (yellow < 0) yellow = 0;
                else if (yellow > 100) yellow = 100;

                this.YellowTrackBar.Value = yellow;
                this.YellowValueLabel.Text = yellow.ToString();
                this.YellowTextBox.Text = yellow.ToString();

                SetCMYKColor();
                SetRGBbyCMYK();
                SetHSVbyCMYK();
            }
            else
            {
                this.YellowTextBox.Text = "0";
            }
        }

        private void OnKeyTextBoxLeft(object sender, EventArgs e)
        {
            int key;
            if (Int32.TryParse(this.KeyTextBox.Text, out key))
            {
                if (key < 0) key = 0;
                else if (key > 100) key = 100;

                this.KeyTrackBar.Value = key;
                this.KeyValueLabel.Text = key.ToString();
                this.KeyTextBox.Text = key.ToString();

                SetCMYKColor();
                SetRGBbyCMYK();
                SetHSVbyCMYK();
            }
            else
            {
                this.KeyTextBox.Text = "0";
            }
        }

        // HSV
        private void OnHueTrackBarChanged(object sender, EventArgs e)
        {
            this.HueValueLabel.Text = this.HueTrackBar.Value.ToString();
            this.HueTextBox.Text = this.HueTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
        }

        private void OnSaturationTrackBarChanged(object sender, EventArgs e)
        {
            this.SaturationValueLabel.Text = this.SaturationTrackBar.Value.ToString();
            this.SaturationTextBox.Text = this.SaturationTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV(); 
        }

        private void OnValueTrackBarChanged(object sender, EventArgs e)
        {
            this.ValueValueLabel.Text = this.ValueTrackBar.Value.ToString();
            this.ValueTextBox.Text = this.ValueTrackBar.Value.ToString();
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
        }


        private void OnHueTextBoxLeft(object sender, EventArgs e)
        {
            int hue;
            if (Int32.TryParse(this.HueTextBox.Text, out hue))
            {
                if (hue < 0) hue = 0;
                else if (hue > 360) hue = 360;

                this.HueTrackBar.Value = hue;
                this.HueValueLabel.Text = hue.ToString();
                this.HueTextBox.Text = hue.ToString();

                SetHSVColor();
                SetRGBbyHSV();
                SetCMYKbyHSV();
            }
            else
            {
                this.CyanTextBox.Text = "0";
            }
        }

        private void OnSaturationTextBoxLeft(object sender, EventArgs e)
        {
            int saturation;
            if (Int32.TryParse(this.SaturationTextBox.Text, out saturation))
            {
                if (saturation < 0) saturation = 0;
                else if (saturation > 100) saturation = 100;

                this.SaturationTrackBar.Value = saturation;
                this.SaturationValueLabel.Text = saturation.ToString();
                this.SaturationTextBox.Text = saturation.ToString();

                SetHSVColor();
                SetRGBbyHSV();
                SetCMYKbyHSV();
            }
            else
            {
                this.SaturationTextBox.Text = "0";
            }
        }

        private void OnValueTextBoxLeft(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(this.ValueTextBox.Text, out value))
            {
                if (value < 0) value = 0;
                else if (value > 100) value = 100;

                this.ValueTrackBar.Value = value;
                this.ValueValueLabel.Text = value.ToString();
                this.ValueTextBox.Text = value.ToString();

                SetHSVColor();
                SetRGBbyHSV();
                SetCMYKbyHSV();
            }
            else
            {
                this.ValueTextBox.Text = "0";
            }
        }


        // color dialog button
        private void ColorButtonClick(object sender, EventArgs e)
        {
            if(this.ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color cl = ColorDialog.Color;
                ColorPanel.BackColor = cl;

                this.RedTrackBar.Value = cl.R;
                this.RedLabel.Text = cl.R.ToString();
                this.RedTextBox.Text = cl.R.ToString();

                this.GreenTrackBar.Value = cl.G;
                this.GreenLabel.Text = cl.G.ToString();
                this.GreenTextBox.Text = cl.G.ToString();

                this.BlueTrackBar.Value = cl.B;
                this.BlueLabel.Text = cl.B.ToString();
                this.BlueTextBox.Text = cl.B.ToString();

                SetCMYKbyRGB();
                SetHSVbyRGB();
            }
        }
    }
}