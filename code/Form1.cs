using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BottleFlip
{
    public partial class Form1 : Form
    {
        private Random random;
        private int rotationCount;
        private const int MAX_ROTATIONS = 10;
        private double uprightProbability; // Nicht mehr const
        private float currentAngle = 0;
        private Size originalSize;
        private Image originalImage;

        
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            uprightProbability = 0.5; // Initialwert (wird überschrieben)

            timerFlip = new Timer();
            timerFlip.Interval = 100;
            timerFlip.Tick += TimerFlip_Tick;

            originalImage = picBottle.Image;
            originalSize = originalImage.Size;
            RotateImage(0);
        }

        private void TimerFlip_Tick(object sender, EventArgs e)
        {
            rotationCount++;
            currentAngle += 90;
            if (currentAngle >= 360) currentAngle -= 360;
            RotateImage(currentAngle);

            if (rotationCount >= MAX_ROTATIONS)
            {
                timerFlip.Stop();
                DetermineBottlePosition();
            }
        }

        private void RotateImage(float angle)
        {
            if (originalImage == null) return;

            int maxDimension = (int)Math.Ceiling(Math.Sqrt(originalSize.Width * originalSize.Width + originalSize.Height * originalSize.Height));
            Size newSize = new Size(maxDimension, maxDimension);

            Bitmap rotatedImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                float centerX = newSize.Width / 2f;
                float centerY = newSize.Height / 2f;
                g.TranslateTransform(centerX, centerY);
                g.RotateTransform(angle);
                g.TranslateTransform(-centerX, -centerY);

                float drawX = (newSize.Width - originalSize.Width) / 2f;
                float drawY = (newSize.Height - originalSize.Height) / 2f;
                g.DrawImage(originalImage, drawX, drawY, originalSize.Width, originalSize.Height);
            }

            picBottle.Image = rotatedImage;
            picBottle.Size = newSize;
            picBottle.SizeMode = PictureBoxSizeMode.Zoom;
            picBottle.Refresh();
        }

        private void DetermineBottlePosition()
        {
            if (random.NextDouble() < uprightProbability)
            {
                currentAngle = 0;
            }
            else
            {
                currentAngle = 90;
            }
            RotateImage(currentAngle);
        }

        private void btnFlip_Click_1(object sender, EventArgs e)
        {
            rotationCount = 0;
            uprightProbability = random.NextDouble() * 0.2 + 0.2; // 20-40% Wahrscheinlichkeit
            timerFlip.Start();
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/TueftelTyp/BottleFlipDeluxe";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
