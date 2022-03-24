using COURSE.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COURSE.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            try
            {
                var model = new List<Biblioteca>()
                {
                    new Biblioteca
                    {
                        BibliotecaId = 1,
                        Livro = "Teste",
                        Nome = "São Judas"
                    },

                    new Biblioteca
                    {
                        BibliotecaId = 2,
                        Livro = "Teste 2",
                        Nome = "São Judas"
                    },

                    new Biblioteca
                    {
                        BibliotecaId = 3,
                        Livro = "Teste 3",
                        Nome = "São Judas"
                    }
                };

                return View(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}