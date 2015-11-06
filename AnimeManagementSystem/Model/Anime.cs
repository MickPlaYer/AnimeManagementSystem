using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimeManagementSystem.Model
{
    public enum AnimeState
    {
        New,
        Following,
        Ended,
        Dispose
    }

    public class Anime
    {
        private Issue _issue;
        private String _title;
        private String _description;
        private String _bannerPath;
        private AnimeState _state = AnimeState.New;

        public Anime(Issue issue, String title, String description, String bannerPath, AnimeState state)
        {
            _issue = issue;
            _title = title;
            _description = description;
            _bannerPath = bannerPath;
            _state = state;
        }

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Issue Issue
        {
            get { return _issue; }
            set { _issue = value; }
        }

        public String BannerPath
        {
            get { return _bannerPath; }
            set { _bannerPath = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public AnimeState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
