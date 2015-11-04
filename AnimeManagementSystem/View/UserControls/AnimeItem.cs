using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeManagementSystem.View.UserControls
{
    class AnimeItem
    {
        private string _name;
        private string _pictureKey;

        public AnimeItem(string name, string pictureKey)
        {
            _name = name;
            _pictureKey = pictureKey;
        }
    }
}
