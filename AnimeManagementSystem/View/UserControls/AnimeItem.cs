using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManagementSystem.View.UserControls
{
    class AnimeItem
    {
        private Image _banner;
        private Size _imageSize = new Size(300, 100);

        public AnimeItem(String bannerPath = "./Banners/Banner.png")
        {
            _banner = Image.FromFile(bannerPath);
        }

        public void Draw(Graphics graphics, Rectangle Bounds, Padding margin)
        {
            Point location = Bounds.Location;
            location.Y += margin.Vertical / 2;
            location.X += margin.Horizontal / 2;
            graphics.DrawImage(_banner, new Rectangle(location, _imageSize));
        }

        public Image Banner
        { 
            get { return _banner; }
        }
    }
}
