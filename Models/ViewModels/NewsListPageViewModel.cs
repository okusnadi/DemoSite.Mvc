﻿namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS.Core;
    using PagedList;
    using Pages;

    public class NewsListPageViewModel : IPageViewModel<NewsListPage> {
        public NewsListPageViewModel(NewsListPage currentPage) {
            CurrentPage = currentPage;
        }

        public NewsListPage CurrentPage { get; private set; }
        public IEnumerable<CmsPage> TopMenu { get; set; }
        public IPagedList<NewsPage> News { get; set; }
        public IEnumerable<NewsListPage> NewsHolders { get; set; }
        public int Page { get; set; }
    }
}