using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.PrimarySchool.WebApp.Models.TestViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITI.PrimarySchool.WebApp.Controllers
{
    public class TestController : Controller
    {
        public static readonly string[] AllowedColors = new [] { "R", "V", "B" };

        [HttpGet]
        public IActionResult Index()
        {
            return View( new BasicTestViewModel() );
        }

        [HttpPost]
        public IActionResult Index( BasicTestViewModel model )
        {
            if( !AllowedColors.Contains( model.Color ) )
            {
                ModelState.AddModelError( "Color", "La couleur n'est pas autorisée" );
            }

            if( ModelState.IsValid )
            {
                return View( "Recap", model );
            }

            return View( model );
        }
    }
}
