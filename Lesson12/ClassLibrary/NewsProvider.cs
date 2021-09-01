using System;


namespace ClassLibrary
{
    public class NewsProvider
    {
        public event Action NewsPublications = delegate { };
        public event Action WeatherPublications = delegate { };
        public event Action SportPublications = delegate { };
        public event Action IncidentPublications = delegate { };
        public event Action HumorPublications = delegate { };

        public void PublicationsOfNews(NewsCategory newsCategory)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    NewsPublications();
                    break;
                case NewsCategory.Weather:
                    WeatherPublications();
                    break;
                case NewsCategory.Sport:
                    SportPublications();
                    break;
                case NewsCategory.Incident:
                    IncidentPublications();
                    break;
                case NewsCategory.Humor:
                    HumorPublications();
                    break;
            }
        }
    }
}
