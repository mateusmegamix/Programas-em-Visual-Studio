using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlertCity.Models;
using AlertCity.Model;
using AlertCity.Model.Repositories;
using System.ComponentModel.DataAnnotations;

namespace AlertCity.Controllers
{
    public class LoginController : Controller
    {
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult LIndex()
        {
            Session["Nome"] = null;
            return View();
          
            //return View();
        }
        public ActionResult Acessar(Usuario u)
        {
            if (ModelState.IsValid) //verifica se é válido
            {
                using (alextheodoroEntities dc = new alextheodoroEntities())
                {
                    var v = dc.appCadastroUsuario.Where(a => a.appEmail.Equals(u.appEmail) && a.appSenha.Equals(u.appSenha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["Nome"] = v.appNome.ToString();
                        return RedirectToAction("PIndex");
                    }
                }
            }
            return View("PIndex");
        }
    }
}