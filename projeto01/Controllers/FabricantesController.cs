using System;
using projeto01.Contexts;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projeto01.Models;
using System.Net;

namespace projeto01.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            context.Fabricantes.Add(fabricante);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Fabricantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Fabricante fabricante = context.Fabricantes.Find(id);
            if(fabricante == null)
            {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        //POST: Fabricante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante)
        {
            //verificando se não há nenhuma validação de erro, como por exemplo um valor exigido porem não preenchido
            // com a validação do modelo é preciso dizer que o obj sofreu alteração
            if (ModelState.IsValid)
            {
                context.Entry(fabricante).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fabricante);
        }
    }
}