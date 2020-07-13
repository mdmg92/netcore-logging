using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Inicia request a Index");

            try
            {
                var rng = new Random();

                var error = rng.Next(0, 2);
                if (error == 1)
                {
                    throw new Exception("Problema de frontend");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en Index");
            }
        }
    }
}