using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Lab2
{
    public partial class Lab2Form : Form
    {
        private const int MaxValue = 255;
        
        private Mat _original;
        private Mat _processed;

        private Image<Gray, byte> img;
        private Image<Gray, byte> result;
        public Lab2Form()
        {
            InitializeComponent();
            _original = new Mat();
            _processed = new Mat();

            FilterType.SelectedIndex = 0;
            GlobalTypes.SelectedIndex = 2;

            GlobalTrackBar.Visible = true;
            GlobalValue.Visible = true;

            Add.Visible = false;
            Reverse.Visible = false;
            Multiply.Visible = false;
            Pow.Visible = false;
            Log.Visible = false;
            Linear.Visible = false;

            BlockSize.Visible = false;
            Constant.Visible = false;
            Filter.Visible = false;

            EventsBootstrap();

            UpdateScreen();
        }

        private void EventsBootstrap()
        {
            FilterType.SelectedIndexChanged += OnFilterTypeSelectedIndexChanged;
            GlobalTypes.SelectedIndexChanged += OnGlobalTypeSelectedIndexChanged;
            GlobalTrackBar.Scroll += OnGlobalTrackBarScroll;
            OpenFileButton.Click += OnOpenButtonClicked;

            Add.Click += OnAddClicked;
            Reverse.Click += OnReverseClicked;
            Multiply.Click += OnMultiplyClicked;
            Pow.Click += OnPowClicked;
            Log.Click += OnLogClicked;
            Linear.Click += OnLinearClicked;
            Filter.Click += OnFilterClicked;
        }

        private void OnOpenButtonClicked(object sender, EventArgs e)
        {
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                var fileName = openPicture.FileName;
                _original = CvInvoke.Imread(fileName, ImreadModes.Grayscale);

                CvInvoke.Resize(_original, _original, new System.Drawing.Size(Original.Width, Original.Height), 0, 0, Inter.Linear);

                UpdateScreen();
            }
        }

        private void OnFilterTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            bool isGlobal = FilterType.SelectedIndex == 0;
            bool isElement = FilterType.SelectedIndex == 1;
            bool isAdaptive = FilterType.SelectedIndex == 2;

            GlobalTypes.Visible = isGlobal;
            GlobalTrackBar.Visible = isGlobal;
            GlobalValue.Visible = isGlobal;

            Add.Visible = isElement;
            Reverse.Visible = isElement;
            Multiply.Visible = isElement;
            Pow.Visible = isElement;
            Log.Visible = isElement;
            Linear.Visible = isElement;

            BlockSize.Visible = isAdaptive;
            Constant.Visible = isAdaptive;
            Filter.Visible = isAdaptive;

            if (isGlobal) OnGlobalTypeSelectedIndexChanged(sender, e);
        }

        private void OnGlobalTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            bool isValue = (GlobalTypes.SelectedIndex == 2);

            GlobalTrackBar.Visible = isValue;

            switch (GlobalTypes.SelectedIndex)
            {
                case 0: UseOtsu();
                    break;
                case 1: UseGradientGlobal();
                    break;
                case 2: 
                    UseValue(GlobalTrackBar.Value);
                    GlobalValue.Text = "Value: " + GlobalTrackBar.Value;
                    break;
            }
        }

        private void UpdateScreen()
        {
            Original.Image = _original.ToBitmap();
            Processed.Image = _processed.ToBitmap();
        }

        private void OnGlobalTrackBarScroll(object sender, EventArgs e)
        {
            GlobalValue.Text = "Value: " + GlobalTrackBar.Value;

            if (GlobalTypes.SelectedIndex == 2) UseValue(GlobalTrackBar.Value);
            UpdateScreen();
        }
        
        // global

        private void UseGradientGlobal()
        {
            img = _original.ToImage<Gray, byte>();
            Image<Gray, float> gradientImage = new Image<Gray, float>(img.Size);
            CvInvoke.Sobel(img, gradientImage, DepthType.Cv32F, 1, 1);

            CvInvoke.Normalize(gradientImage, gradientImage, 0, 255, NormType.MinMax);

            bool l = img.Size == gradientImage.Size;

            double num = 0;
            double denom = 0;

            // count numerator
            for (int i = 0; i < img.Rows; i++)
            {
                for (int j = 0; j < img.Cols; j++)
                {
                    num += img[i, j].Intensity * gradientImage[i, j].Intensity;
                }
            }

            // count denominator
            for (int i = 0; i < gradientImage.Rows; i++)
            {
                for (int j = 0; j < gradientImage.Cols; j++)
                {
                    denom += gradientImage[i, j].Intensity;
                }
            }

            double threshold = num / denom;

            CvInvoke.Threshold(_original, _processed, threshold, MaxValue, ThresholdType.Binary);
            GlobalValue.Text = "Value: " + threshold;
            UpdateScreen();
        }

        private void UseOtsu()
        {
            double threshold = CvInvoke.Threshold(_original, _processed, 0, MaxValue, ThresholdType.Otsu);
            CvInvoke.Threshold(_original, _processed, threshold, MaxValue, ThresholdType.Binary);
            GlobalValue.Text = "Value: " + threshold;
            UpdateScreen();
        }

        private void UseValue(int value)
        {
            CvInvoke.Threshold(_original, _processed, value, MaxValue, ThresholdType.Binary);
            UpdateScreen();
        }

        // adaptive
        private void UseAdaptive(int kernelSize, int param1)
        {
            CvInvoke.AdaptiveThreshold(_original, _processed, MaxValue, AdaptiveThresholdType.MeanC
                , ThresholdType.Binary, kernelSize, param1);
            UpdateScreen();
        }

        // element operations
        private void AddConstant(double constant)
        {
            img = _original.ToImage<Gray, byte>();
            result = img.Add(new Gray(constant));
            _processed = result.Mat;
            UpdateScreen();
        }

        private void Invert()
        {
            img = _original.ToImage<Gray, byte>();
            CvInvoke.BitwiseNot(_original, _processed);
            UpdateScreen();
        }

        private void MultiplyByConstant(double constant)
        {
            img = _original.ToImage<Gray, byte>();
            img._Mul(constant);
            result = img;
            _processed = result.Mat;
            UpdateScreen();
        }

        private void PowImage(double power)
        {
            if(power >= 1) CvInvoke.Pow(_original, power, _processed);
            else
            {
                img = _original.ToImage<Gray, byte>();
                result = new Image<Gray, byte>(img.Size);
                for (int row = 0; row < img.Rows; row++)
                {
                    for (int col = 0; col < img.Cols; col++)
                    {
                        result[row, col] = new Gray(Math.Pow(img[row, col].Intensity, power));
                    }
                }

                _processed = result.Mat;
            }
            UpdateScreen();
        }

        private void LogarithmTransform()
        {
            img = _original.ToImage<Gray, byte>();
            result = new Image<Gray, byte>(img.Size);

            double min = 0;
            double max = 0;
            Point minPoint = new Point();
            Point maxPoint = new Point();
            CvInvoke.MinMaxLoc(img, ref min, ref max, ref minPoint, ref maxPoint);

            Gray denum = new Gray(Math.Log(1 + img[maxPoint.Y, maxPoint.X].Intensity));
            for (int row = 0; row < img.Rows; row++)
            {
                for (int col = 0; col < img.Cols; col++)
                {
                    Gray num = new Gray(Math.Log(1 + img[row, col].Intensity));

                    result[row, col] = new Gray(255 * num.Intensity / denum.Intensity);
                }
            }
            _processed = result.Mat;
            UpdateScreen();
        }

        private void LinearContrast()
        {
            img = _original.ToImage<Gray, byte>();
            result = new Image<Gray, byte>(img.Size);
            double minPixel = 0;
            double maxPixel = 0;
            Point minLocation = new Point();
            Point maxLocation = new Point();
            CvInvoke.MinMaxLoc(_original, ref minPixel, ref maxPixel, ref minLocation, ref maxLocation);
            
            double a = 255.0 / (maxPixel - minPixel);
            double b = -a * minPixel;

            //img._Mul(a);
            //result = img.Add(new Gray(b));
            CvInvoke.ConvertScaleAbs(img, result, a, b);

            _processed = result.Mat;
            UpdateScreen();
        }

        // events 
        private void OnAddClicked(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Input number:");
            if (Double.TryParse(result, out double res))
            {
                AddConstant(res);
            }
        }

        private void OnReverseClicked(object sender, EventArgs e)
        {
            Invert();
        }

        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Input number:");
            if (Double.TryParse(result, out double res))
            {
                MultiplyByConstant(res);
            }
        }

        private void OnPowClicked(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Input number:");
            if (Double.TryParse(result, out double res))
            {
                PowImage(res);
            }
        }

        private void OnLogClicked(object sender, EventArgs e)
        {
            LogarithmTransform();
        }

        private void OnLinearClicked(object sender, EventArgs e)
        {
            LinearContrast();
        }

        private void OnFilterClicked(object sender, EventArgs e)
        {
            if (Int32.TryParse(BlockSize.Text, out int kernelSize) &&
                Int32.TryParse(Constant.Text, out int param1) &&
                kernelSize % 2 == 1 && kernelSize > 1)
            {
                UseAdaptive(kernelSize, param1);
            }
        }
    }
}