namespace ColorMixerApp_2023_autumn
{
    public partial class Form1 : Form
    {

        int redMixerValue = 0;
        int greenMixerValue = 0;
        int blueMixerValue = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "El's color Mixer";

        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericRed.Value;
            int greenValue = 0;
            int blueValue = 0;

            redMixerValue = redValue;

            redBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            SetBackgroundColor();
        }

        private void greenBox_Click(object sender, EventArgs e)
        {

        }

        private void redBox_Click(object sender, EventArgs e)
        {

        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = (int)numericGreen.Value;
            int blueValue = 0;

            greenMixerValue = greenValue;

            greenBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            SetBackgroundColor();
        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int greenValue = 0;
            int blueValue = (int)numericBlue.Value;

            blueMixerValue = blueValue;

            blueBox.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

            SetBackgroundColor();
        }

        private void sliderRed_Scroll(object sender, EventArgs e)
        {
            numericRed.Value = sliderRed.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericBlue.Value = sliderBlue.Value;
        }

        private void sliderGreen_Scroll(object sender, EventArgs e)
        {
            numericGreen.Value = sliderGreen.Value;
        }

        private void SetBackgroundColor()
        {
            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);
            this.Text = $"RGB value ({redMixerValue}, {greenMixerValue}, {blueMixerValue})";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            redMixerValue = red;
            greenMixerValue = green;
            blueMixerValue = blue;

            numericRed.Value = red;
            numericGreen.Value = green;
            numericBlue.Value = blue;

            sliderRed.Value = red;
            sliderGreen.Value = green;
            sliderBlue.Value = blue;

            SetBackgroundColor();
        }
    }
}