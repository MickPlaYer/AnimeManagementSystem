using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeManagementSystem.Model;
using AnimeManagementSystem.View.UserControls;

namespace AnimeManagementSystem.Controller
{
    public enum TabPages
    {
        New,
        Following,
        Ended,
        Dispose,
        Count
    }

    class PageController
    {
        private AnimeModel _model;
        private TabControl _tabControl;
        private TabPage[] _tabPages = new TabPage[(int)TabPages.Count];
        private bool[] _isTabShow = new bool[(int)TabPages.Count];
        private TabPages _currentPage = TabPages.New;

        public PageController(AnimeModel model, TabControl tabControl)
        {
            _model = model;
            _tabControl = tabControl;
            for (int i = 0; i < _tabPages.Length; i++)
            {
                _tabPages[i] = tabControl.TabPages[i];
                _isTabShow[i] = true;
            }
        }

        public void ChangeEnable(ToolStripMenuItem item)
        {
            String tag = item.Tag as String;
            int index = (int)Enum.Parse(typeof(TabPages), tag);
            item.Checked = !item.Checked;
            _isTabShow[index] = !_isTabShow[index];
            ResetTabPages();
        }

        public void ChangePage()
        {
            String tag = _tabControl.SelectedTab.Tag as String;
            _currentPage = (TabPages)Enum.Parse(typeof(TabPages), tag);
        }

        public void UpdateListBox(AnimeListBox listBox)
        {
            String tag = listBox.Tag as String;
            int selectedIndex = listBox.SelectedIndex;
            TabPages listPage = (TabPages)Enum.Parse(typeof(TabPages), tag);
            Anime[] animes = _model.GetAnimes((int)listPage);
            AnimeItem[] items = new AnimeItem[animes.Length];
            for (int i = 0; i < animes.Length; i++)
            {
                items[i] = new AnimeItem(animes[i].BannerPath);
            }
            listBox.Items.Clear();
            listBox.Items.AddRange(items);
            listBox.SelectedIndex = selectedIndex;
        }

        public void UpdateContentView(AnimeListBox listBox, GroupBox contentBox)
        {
            String tag = listBox.Tag as String;
            TabPages listPage = (TabPages)Enum.Parse(typeof(TabPages), tag);
            AnimeItem item = listBox.SelectedItem as AnimeItem;
            Anime anime = _model.GetAnimes((int)listPage)[listBox.SelectedIndex];
            foreach (Control control in contentBox.Controls)
            {
                String controlTag = control.Tag as String;
                if (controlTag == "Banner")
                {
                    (control as PictureBox).Image = item.Banner;
                }
                else if (controlTag == "Title")
                {
                    (control as Label).Text = anime.Title;
                }
                else if (controlTag == "Description")
                {
                    (control as Label).Text = anime.Description;
                }
            }
        }

        public GroupBox GetCurrentContentBox()
        {
            TabPage selectedTab = _tabControl.SelectedTab;
            GroupBox contentBox = selectedTab.Controls.OfType<GroupBox>().First();
            return contentBox;
        }

        public AnimeListBox GetCurrentListBox()
        {
            TabPage selectedTab = _tabControl.SelectedTab;
            AnimeListBox listBox = selectedTab.Controls.OfType<AnimeListBox>().First();
            return listBox;
        }

        public TabPages CurrentPage
        {
            get { return _currentPage; }
        }

        private void ResetTabPages()
        {
            _tabControl.TabPages.Clear();
            for (int i = 0; i < _tabPages.Length; i++)
            {
                if (_isTabShow[i])
                    _tabControl.TabPages.Add(_tabPages[i]);
            }
        }
    }
}
