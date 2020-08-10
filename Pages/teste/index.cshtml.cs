using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookListRazor.Pages
{
  public class TesteModel : PageModel
  {
      private readonly ILogger<TesteModel> _logger;

      public TesteModel(ILogger<TesteModel> logger)
      {
          _logger = logger;
      }
      // handler HTTP GET Request
      public void OnGet()
      {

      }
      // handler HTTP POST Request
      public void OnPost()
      {

      }
  }
}