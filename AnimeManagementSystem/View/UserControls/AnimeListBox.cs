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
        public AnimeListBox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            
            if (/*Items[e.Index] is AnimeItem*/true)
            {
                // AnimeItem animeItem = Items[e.Index] as AnimeItem;
                SolidBrush solidBrush = new SolidBrush(Color.Green);
                e.Graphics.FillRectangle(solidBrush, e.Bounds);
                solidBrush.Dispose();
                TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), e.Font, e.Bounds, e.ForeColor);
            }
            base.OnDrawItem(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Rectangle itemRect = GetItemRectangle(i);
                DrawItemEventArgs diea = new DrawItemEventArgs(e.Graphics, this.Font, itemRect, i, DrawItemState.None);
                OnDrawItem(diea);
            }
            base.OnPaint(e);
        }

    }
}
