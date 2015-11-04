using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeManagementSystem.View.UserControls
{
    public partial class AnimeListBox : ListBox
    {
        private const int ITEM_HEIGHT = 100;

        public AnimeListBox()
        {
            InitializeComponent();
            ItemHeight = ITEM_HEIGHT + Margin.Vertical;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (Items[e.Index] is AnimeItem)
            {
                AnimeItem animeItem = Items[e.Index] as AnimeItem;
                e.DrawBackground();
                animeItem.Draw(e.Graphics, e.Bounds, Margin);
            }
            base.OnDrawItem(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Rectangle itemRect = GetItemRectangle(i);
                if (e.ClipRectangle.IntersectsWith(itemRect))
                {
                    DrawItemState drawItemState = SelectedIndices.Contains(i) ? DrawItemState.Selected : DrawItemState.None;
                    DrawItemEventArgs drawItemEventArgs = new DrawItemEventArgs(e.Graphics, this.Font, itemRect, i, drawItemState);
                    OnDrawItem(drawItemEventArgs);
                }
            }
            base.OnPaint(e);
        }
    }
}
