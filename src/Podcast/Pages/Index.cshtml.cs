﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Podcast.Pages;


    public class Index : PageModel
    {
        //private readonly PodcastService _podcastService;

        //public Show[]? FeaturedShows { get; set; }

        public Index()
        {
            //_podcastService = podcastService;
        }

        public async Task OnGet()
        {
            // var shows = await _podcastService.GetShows(50, null);
            // FeaturedShows = shows?.Where(s => s.IsFeatured).ToArray();
        }
    }

