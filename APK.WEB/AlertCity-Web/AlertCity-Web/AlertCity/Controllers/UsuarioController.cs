using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlertCity.Models;
using AlertCity.Model;
using AlertCity.Model.Repositories;

namespace AlertCity.Controllers
{

    public class UsuarioController : Controller, IDisposable
    {
        RepositoryUsuario _Repository;
        // GET: Usuario
        public UsuarioController()
        {
            _Repository = new RepositoryUsuario();
        }
        //lista de todos cadastrados

        private List<Usuario> Usuarios()
        {
            var Lista = _Repository.SelecionarTodos();
            List<Usuario> oRetorno = new List<Usuario>();
            foreach (var obj in Lista)
            {
                Usuario oUsu = new Usuario();
                oUsu.appLogin = obj.appLogin;
                oUsu.appNome = obj.appNome;
                oUsu.appSenha = obj.appSenha;
                oUsu.appConfirmar = obj.appConfirmar;
                oUsu.appEmail = obj.appEmail;
                oUsu.appCelular = obj.appCelular;


                oRetorno.Add(oUsu);
            }
            return oRetorno;
        }
        public ActionResult Index()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.TodosUsuarios = Usuarios();
            oUsuario.Incluir = true;
            return View("Index", oUsuario);

        }
        //=========================================================================//

        // -------- Salvar começo ---------------------//

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Salvar(Usuario oUsuario)
        {
            appCadastroUsuario oUsu = new appCadastroUsuario();
            oUsu.appLogin = oUsuario.appLogin;
            oUsu.appNome = oUsuario.appNome;
            oUsu.appSenha = oUsuario.appSenha;
            oUsu.appConfirmar = oUsuario.appConfirmar;
            oUsu.appEmail = oUsuario.appEmail;
            oUsu.appCelular = oUsuario.appCelular;
            if (ModelState.IsValid)
            {
                try
                {
                    _Repository.Incluir(oUsu);

                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    ViewBag.Alerta = "Ocorreu um erro na inclusão dos dados:" + ex.Message;
                }
                if (oUsuario.Incluir == false)
                {
                    _Repository.Alterar(oUsu);
                }
                ModelState.Clear();
                if (oUsuario.Incluir)
                {
                    _Repository.Incluir(oUsu);
                }

                else
                {
                    _Repository.Alterar(oUsu);
                }

            }
            oUsuario.Incluir = false;
            ViewBag.Mensagem = "Usuário Cadastrado";
            ModelState.Clear();
            return Index();
        }
        //=================================================================//
        //----------------Alterar---------------------//
        public ActionResult Alterar(int ProUsuario)
        {

            //var Lista = _Repository.SelecionarTodos();
            //List<Usuario> oRetorno = new List<Usuario>();

            appCadastroUsuario oUsu = _Repository.Selecionar(ProUsuario);
            Usuario oUsuario = new Usuario();
            oUsuario.appLogin = oUsu.appLogin;
            oUsuario.appNome = oUsu.appNome;
            oUsuario.appSenha = oUsu.appSenha;
            oUsuario.appConfirmar = oUsu.appConfirmar;
            oUsuario.appEmail = oUsu.appEmail;
            oUsuario.appCelular = oUsu.appCelular;

            oUsuario.Incluir = false;
            return View("Index", oUsuario);
        }
        //===================================================================//
        //------------------Excluir-----------------------//
        public ActionResult Excluir(int ProUsuario)
        {

            appCadastroUsuario oUsuario = _Repository.Selecionar(ProUsuario);
            _Repository.Excluir(oUsuario);

            return Index();

        }
        public new void Dispose()
        {
            _Repository.Dispose();
        }
    }
}