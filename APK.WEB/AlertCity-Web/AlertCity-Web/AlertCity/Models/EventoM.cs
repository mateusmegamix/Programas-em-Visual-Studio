using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AlertCity.Model;
using AlertCity.Model.Repositories;

namespace AlertCity.Models
{
    [MetadataType(typeof(MD_Evento))]
    public class EventoM : Evento
    {
        public bool Incluir { get; set; }

        public List<EventoM> TodosEventos { get; set; }
        internal class MD_Evento
        {
            [DisplayName("Registro")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public int RegistroEvento { get; set; }

            [DisplayName("Tipo")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string TipoF { get; set; }

            [DisplayName("Localização")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Localizacaof { get; set; }

            [DisplayName("Rua")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Ruaf { get; set; }

            [DisplayName("Bairro")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Bairrof { get; set; }

            [DisplayName("Cidade")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Cidadef { get; set; }

            [DisplayName("UF")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Uff { get; set; }

            [DisplayName("CEP")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Cepf { get; set; }

            [DisplayName("Data e Hora do Evento")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public System.DateTime Dataf { get; set; }

            [DisplayName("Valor")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Valorf { get; set; }

            [DisplayName("Telefone")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string Telefone { get; set; }

            [DisplayName("Descrição do Evento")]
            [Required(ErrorMessage = "Preencher conteudo do campo")]
            public string DescricaoEvento { get; set; }

            public object Incluir { get; set; }

        }

        public List<Evento> SelecionarEventos()
        {
            RepositoryEvento _Repository = new RepositoryEvento();
            var Retorno = _Repository.SelecionarTodos();
            return Retorno;
        }
    }
}