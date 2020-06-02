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
    public class EventoController : Controller, IDisposable
    {
        RepositoryEvento _Repository;
        // GET: EventoM
        public EventoController()
        {
            _Repository = new RepositoryEvento();
        }
        //lista de todos cadastrados

        private List<EventoM> Eventos()
        {
            var Lista = _Repository.SelecionarTodos();
            List<EventoM> oRetorno = new List<EventoM>();
            foreach (var obj in Lista)
            {
                EventoM oEve = new EventoM();
                oEve.Bairrof = obj.Bairrof;
                oEve.Cepf = obj.Cepf;
                oEve.Cidadef = obj.Cidadef;
                oEve.Dataf = obj.Dataf;
                oEve.DescricaoEvento = obj.DescricaoEvento;
                oEve.Localizacaof = obj.Localizacaof;
                oEve.RegistroEvento = obj.RegistroEvento;
                oEve.Ruaf = obj.Ruaf;
                oEve.Telefone = obj.Telefone;
                oEve.TipoF = obj.TipoF;
                oEve.Uff = obj.Uff;
                oEve.Valorf = obj.Valorf;

                oRetorno.Add(oEve);
            }
            return oRetorno;
        }
        public ActionResult EIndex()
        {
            EventoM oEvento = new EventoM();
            oEvento.TodosEventos = Eventos();
            oEvento.Incluir = true;
            return View("EIndex", oEvento);

        }
        //=========================================================================//

        // -------- Salvar começo ---------------------//

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Salvar(EventoM oEvento)
        {
            Evento oEve = new Evento();
            oEve.Bairrof = oEvento.Bairrof;
            oEve.Cepf = oEvento.Cepf ;
            oEve.Cidadef = oEvento.Cidadef;
            oEve.Dataf = oEvento.Dataf;
            oEve.DescricaoEvento = oEvento.DescricaoEvento;
            oEve.Localizacaof = oEvento.Localizacaof;
            oEve.RegistroEvento = oEvento.RegistroEvento;
            oEve.Ruaf = oEvento.Ruaf;
            oEve.Telefone = oEvento.Telefone;
            oEve.TipoF = oEvento.TipoF;
            oEve.Uff = oEvento.Uff;
            oEve.Valorf = oEvento.Valorf;

            if (ModelState.IsValid)
            {
                try
                {
                    _Repository.Incluir(oEve);

                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    ViewBag.Alerta = "Ocorreu um erro na inclusão dos dados:" + ex.Message;
                }
                if (oEvento.Incluir == false)
                {
                    _Repository.Alterar(oEve);
                }
                ModelState.Clear();

                if (oEvento.Incluir)
                {
                    _Repository.Incluir(oEve);
                }

                else
                {
                    _Repository.Alterar(oEve);
                }

            }
            oEvento.Incluir = false;
            ModelState.Clear();
            return EIndex();
        }
        //=================================================================//
        //----------------Alterar---------------------//
        public ActionResult Alterar(int ProEvento)
        {

            //var Lista = _Repository.SelecionarTodos();
            //List<EventoM> oRetorno = new List<EventoM>();

            Evento oEve = _Repository.Selecionar(ProEvento);
            EventoM oEvento = new EventoM();
            oEvento.Bairrof = oEve.Bairrof;
            oEvento.Cepf = oEve.Cepf;
            oEvento.Cidadef = oEve.Cidadef;
            oEvento.Dataf = oEve.Dataf;
            oEvento.DescricaoEvento = oEve.DescricaoEvento;
            oEvento.Localizacaof = oEve.Localizacaof;
            oEvento.RegistroEvento = oEve.RegistroEvento;
            oEvento.Ruaf = oEve.Ruaf;
            oEvento.Telefone = oEve.Telefone;
            oEvento.TipoF = oEve.TipoF;
            oEvento.Uff = oEve.Uff;
            oEvento.Valorf = oEve.Valorf;

            oEvento.Incluir = false;
            return View("EIndex", oEvento);
        }
        //===================================================================//
        //------------------Excluir-----------------------//
        public ActionResult Excluir(int ProEvento)
        {

            Evento oEvento = _Repository.Selecionar(ProEvento);
            _Repository.Excluir(oEvento);

            return EIndex();

        }
        public new void Dispose()
        {
            _Repository.Dispose();
        }
    }
}