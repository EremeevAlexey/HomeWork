using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();

            Client client = new Client();

            client.SubscribeToNews(NewsCategory.Humor, newsProvider);
            newsProvider.PublicationsOfNews(NewsCategory.Humor);

            client.SubscribeToNews(NewsCategory.Incident, newsProvider);
            newsProvider.PublicationsOfNews(NewsCategory.Incident);

            client.SubscribeToNews(NewsCategory.Sport, newsProvider);
            newsProvider.PublicationsOfNews(NewsCategory.Sport);

            client.ChangeNews(NewsCategory.Sport, newsProvider);
            newsProvider.PublicationsOfNews(NewsCategory.Sport);
        }
    }
}
