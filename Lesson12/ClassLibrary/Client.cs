using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        private void Weather()
        {
            Console.WriteLine("Погода");
        }

        private void News()
        {
            Console.WriteLine("Новости");
        }

        private void Sport()
        {
            Console.WriteLine("Спорт");
        }

        private void Incident()
        {
            Console.WriteLine("Проишествия");
        }

        private void Humor()
        {
            Console.WriteLine("Юмор");
        }

        public void SubscribeToNews(NewsCategory newsCategory, NewsProvider newsProvider)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    newsProvider.NewsPublications += News;
                    break;
                case NewsCategory.Weather:
                    newsProvider.WeatherPublications += Weather;
                    break;
                case NewsCategory.Sport:
                    newsProvider.SportPublications += Sport;
                    break;
                case NewsCategory.Incident:
                    newsProvider.IncidentPublications += Incident;
                    break;
                case NewsCategory.Humor:
                    newsProvider.HumorPublications += Humor;
                    break;
            }
        }

        public void ChangeNews(NewsCategory newsCategory, NewsProvider newsProvider)
        {
            switch (newsCategory)
            {
                case NewsCategory.News:
                    newsProvider.NewsPublications -= News;
                    break;
                case NewsCategory.Weather:
                    newsProvider.WeatherPublications -= Weather;
                    break;
                case NewsCategory.Sport:
                    newsProvider.SportPublications -= Sport;
                    break;
                case NewsCategory.Incident:
                    newsProvider.IncidentPublications -= Incident;
                    break;
                case NewsCategory.Humor:
                    newsProvider.HumorPublications -= Humor;
                    break;
            }
        }
    }
}
