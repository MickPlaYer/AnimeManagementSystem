using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManagementSystem.Controller
{
    class PageController
    {
        private enum TabPages
        {
            New,
            Following,
            Ended,
            Dispose,
            Count
        }

        private TabControl _tabControl;
        private TabPage[] _tabPages = new TabPage[(int)TabPages.Count];
        private bool[] _isTabShow = new bool[(int)TabPages.Count];

        public PageController(TabControl tabControl)
        {
            _tabControl = tabControl;
            for (int i = 0; i < _tabPages.Length; i++)
            {
                _tabPages[i] = tabControl.TabPages[i];
                _isTabShow[i] = true;
            }
        }

        public void ChangeEnable(object sender)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            String tag = item.Tag as String;
            int index = (int)Enum.Parse(typeof(TabPages), tag);
            item.Checked = !item.Checked;
            _isTabShow[index] = !_isTabShow[index];
            ResetTabPages();
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
