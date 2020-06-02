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
    [MetadataType(typeof(MD_Usuario))]
    public class Usuario: appCadastroUsuario
    {
        public bool Incluir { get; set; }
        public List<Usuario> TodosUsuarios { get; set; }

        internal class MD_Usuario
        {
            public int appLogin { get; set; }

            [DisplayName("Nome")]
            [Required(ErrorMessage = "Preencher  campo Nome")]
            public string appNome { get; set; }

            [DisplayName("Senha   ")]
            [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
            public string appSenha { get; set; }

            [DisplayName("Confirmar")]
            [Required(ErrorMessage = "Preencher campo Confirmar Senha")]
            public string appConfirmar { get; set; }

            [DisplayName("EMail        ")]
            [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
            public string appEmail { get; set; }

            [DisplayName("Celular  ")]
            [Required(ErrorMessage = "Preencher campo Celular")]
            public string appCelular { get; set; }

            public object Incluir { get; set; }
        }
        public List<appCadastroUsuario> SelecionarUsuarios()
        {
            RepositoryUsuario _Repository = new RepositoryUsuario();
            var Retorno = _Repository.SelecionarTodos();
            return Retorno;
        }
    }

}