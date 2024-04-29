﻿using iQuest.BooksAndNews.Application.CustomeEventsArgs;
using iQuest.BooksAndNews.Application.Publishers;

namespace iQuest.BooksAndNews.Application.Subscribers
{
    public class NewsHunter
    {
        private readonly string name;
        private readonly ILog log;

        public NewsHunter(string name, PrintingOffice printingOffice, ILog log)
        {
            this.name = name;
            this.log = log;
            printingOffice.RaiseNewspaperEvent += HandleNewspaperEvent;
        }

        private void HandleNewspaperEvent(object sender, NewspaperEventArgs e) 
        {
            log.WriteInfo($"This subscriber has been notified {name}");
        }
    }
}