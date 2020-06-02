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
    [MetadataType(typeof(MD_Login))]
    public class LoginUsuario:appLogin
    {
        internal class MD_Login
        {
            [DisplayName("ID")]
            public int ID { get; set; }

            [DisplayName("Usuário")]
            public int Login { get; set; }

            [DisplayName("Senha")]
            //[Required(ErrorMessage = "Preencher campo Email")]
            public string Senha { get; set; }

            [DisplayName("Email")]
            //[Required(ErrorMessage = "Preencher campo Email")]
            public string Email { get; set; }
        }
    }
}