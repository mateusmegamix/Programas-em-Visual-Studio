//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlertCity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class appCadastroUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public appCadastroUsuario()
        {
            this.appLogin1 = new HashSet<appLogin>();
        }
    
        public int appLogin { get; set; }
        public string appNome { get; set; }
        public string appSenha { get; set; }
        public string appConfirmar { get; set; }
        public string appEmail { get; set; }
        public string appCelular { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appLogin> appLogin1 { get; set; }
    }
}
