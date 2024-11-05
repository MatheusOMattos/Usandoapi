using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using Usandoapi.Padrao;
using Usandoapi.Pages.Api.Service;

namespace Usandoapi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiservice;

        public IndexModel(ApiService apiservice)
        {
            _apiservice = apiservice;

        }
        public string dados { get; set; } = string.Empty;
        public async Task OnGetAsync()
        {
           dados =  await _apiservice.GetData<List<Usuario>>("https://localhost:7035/Pessoas/json-content");
        }
    }
}




