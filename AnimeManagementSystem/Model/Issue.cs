using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeManagementSystem.Model
{
    public enum Quarter
    {
        First = 1,
        Second = 4,
        Third = 7,
        Fourth = 10
    }

    public class Issue
    {
        private int _year;
        private Quarter _quarter;

        public Issue(int year, Quarter quarter)
        {
            _year = year;
            _quarter = quarter;
        }

        public bool IsSame(int year, Quarter quarter)
        {
            return _year == year && _quarter == quarter;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Quarter Quarter
        {
            get { return _quarter; }
            set { _quarter = value; }
        }
    }
}
