using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPM2.Interface
{
    public partial class Login2 : Form
    {
        // Declare all button fields with correct type
        private Button btnDoctor;
        private Button btnNurse;
        private Button btnReceptionist;
        private Button btnAdmin;

        public Login2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        /*
        private void Login2_Load(object sender, EventArgs e)
        {
            // Center card
            pnlCard.Location = new Point(
                (this.ClientSize.Width - pnlCard.Width) / 2,
                (this.ClientSize.Height - pnlCard.Height) / 2
            );

            // Resize icons to 28x28 and assign to buttons
           // btnDoctor.Image = ResizeImage(Image.FromFile("icons/stethoscope.png"), 28, 28);
            btnNurse.Image = ResizeImage(Image.FromFile("icons/heart-rate-monitor.png"), 28, 28);
            btnReceptionist.Image = ResizeImage(Image.FromFile("icons/calendar.png"), 28, 28);
            btnAdmin.Image = ResizeImage(Image.FromFile("icons/settings.png"), 28, 28);
        }

        // Add ResizeImage method
        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        */


    }
}
