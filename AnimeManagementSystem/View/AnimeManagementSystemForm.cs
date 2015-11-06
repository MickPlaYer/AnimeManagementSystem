using AnimeManagementSystem.Controller;
using AnimeManagementSystem.Model;
using AnimeManagementSystem.View.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManagementSystem.View
{
    public partial class AnimeManagementSystemForm : Form
    {
        private AnimeModel _model;
        private PageController _pageController;

        public AnimeManagementSystemForm(AnimeModel model)
        {
            InitializeComponent();
            _pageController = new PageController(model, _tabControl);
            _model = model;
        }

        private void OnClickItemPageNew(object sender, EventArgs e)
        {
            _pageController.ChangeEnable(sender as ToolStripMenuItem);
        }

        private void OnPageChanged(object sender, EventArgs e)
        {
            _pageController.ChangePage();
        }

        private void OnAddAnime(object sender, EventArgs e)
        {
            _model.AddNewAnime(2015, Quarter.Fourth, "ワンパンマン", "One Punch Man!", "./Banners/201510/one_punch_man.png", (int)_pageController.CurrentPage);
            _pageController.UpdateListBox(_pageController.GetCurrentListBox());
        }

        private void OnSelectedItemChanged(object sender, EventArgs e)
        {
            _pageController.UpdateContentView(sender as AnimeListBox, _pageController.GetCurrentContentBox());
        }
    }
}
