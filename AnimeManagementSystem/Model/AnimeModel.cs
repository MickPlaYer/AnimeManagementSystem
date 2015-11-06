using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeManagementSystem.Model
{
    public class AnimeModel
    {
        private List<Anime> _animes = new List<Anime>();
        private List<Issue> _issueList = new List<Issue>();

        public AnimeModel()
        {

        }

        public void AddNewAnime(int year, Quarter quarter, String title, String description, String bannerPath, int state)
        {
            Issue[] issues = _issueList.Where(i => i.IsSame(year, quarter)).ToArray();
            Issue issue;
            if (issues.Length == 0)
            {
                issue = new Issue(year, quarter);
                _issueList.Add(issue);
            }
            else
            {
                issue = issues.First();
            }
            Anime anime = new Anime(issue, title, description, bannerPath, (AnimeState)state);
            _animes.Add(anime);
        }

        public Anime[] GetAnimes(int pageIndex)
        {
            AnimeState state = (AnimeState)pageIndex;
            Anime[] animes = _animes.Where(anime => anime.State == state).ToArray();
            return animes;
        }

        public Issue[] GetIssues()
        {
            return _issueList.ToArray();
        }
    }
}
