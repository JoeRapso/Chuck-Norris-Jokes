using AppDemo.Models;
using AppDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;

namespace AppDemo.Pages
{
    public class IndexModel : PageModel
    {
        public string? joke { get; set; }
        ChuckNorrisApiService apiService = new ChuckNorrisApiService();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            joke = await apiService.GetApiData();
        }

        public async Task OnPost()
        {
            joke = await apiService.GetApiData();

		}

	}
}
