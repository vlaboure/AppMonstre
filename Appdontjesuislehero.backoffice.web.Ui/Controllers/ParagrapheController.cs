using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appdontjesuislehero.Core.Data;
using Appdontjesuislehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appdontjesuislehero.backoffice.web.Ui.Controllers
{
    public class ParagrapheController : Controller
    {
       

        private List<Paragraphe> maListe = new List<Paragraphe>()
        {
            new Paragraphe(){ID=1,Numero=1,Titre="titre 1" },
            new Paragraphe(){ID=3,Numero=12,Titre="quête 12" },
            new Paragraphe(){ID=5,Numero=9,Titre="titre 9" },
            new Paragraphe(){ID=2,Numero=22,Titre="dernière" }
        };
        private DefaultContext _context = null;
        public ParagrapheController(DefaultContext context)
        {
            _context = context;
        }

        #region methodes publiques

        public IActionResult Index()
        {
            ViewBag.Title = "Liste des Paragraphes";
            var query=from item in _context.Paragraphes
                select item;
            return View(query.ToList());            
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            paragraphe = _context.Paragraphes.First(item => item.ID == id);
            return View(paragraphe);
        }
        public IActionResult Create()
        {            
            return View();
        }

        #endregion#region methodes publiques

        #region Post
        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            _context.Paragraphes.Add(paragraphe);
            _context.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            ///
            /// update de tous les champs
            _context.Paragraphes.Update(paragraphe);
            ///
            //**************
            ///
            ///update d'un seul champ
            ///
            _context.Attach<Paragraphe>(paragraphe);
            //connection sur la valeur dans la table en passant par entity
            //_context.Entry(paragraphe).Property(item => item.Titre).IsModified=true;
            _context.SaveChanges();
            return View(paragraphe);
        }
        #endregion
    }
}