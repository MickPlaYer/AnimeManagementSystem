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
        private PageController _newPageController;

        public AnimeManagementSystemForm(AnimeModel model)
        {
            InitializeComponent();
            _newPageController = new PageController(_tabControl);
            _model = model;
            _newPageAnimeListBox.Items.Add(new AnimeItem("./Banners/201510/one_punch_man.png"));
            _newPageAnimeListBox.Items.Add(new AnimeItem());
        }

        private void OnClickItemPageNew(object sender, EventArgs e)
        {
            _newPageController.ChangeEnable(sender);
        }
    }
}
