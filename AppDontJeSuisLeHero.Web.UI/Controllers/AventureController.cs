using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appdontjesuislehero.Core.Data;
using Appdontjesuislehero.Core.Data.Models;
using AppDontJeSuisLeHero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppDontJeSuisLeHero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        /// <summary>
        /// non nécessaire car utisation de [FromServices] dans les paramètres de ActionResult Index
        /// </summary>
        /// <returns></returns>
        //private readonly DefaultContext _context=null;

        //public AventureController(DefaultContext context)
        //{
        //    this._context = context;
        //}
        ///<summary>
        ///
        /// FromServicesAttribute permet d’injecter un service directement dans 
        /// une méthode d’action sans utiliser l’injection de constructeurs 
        /// permet de créer un singleton pour l'instance de DbContext
        ///     
        ///</summary>
        public IActionResult Index([FromServices]DefaultContext context)
        {
            ViewBag.MonTitre = "Aventures";
            var query = from item in context.Aventures
                        select item;
            return View(query.ToList());


        }
    }
}