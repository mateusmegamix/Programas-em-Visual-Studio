//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APK.DESKTOP.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CadastroFesta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CadastroFesta()
        {
            this.Consulta = new HashSet<Consulta>();
        }
    
        public int CodigoFesta { get; set; }
        public byte[] Fotof { get; set; }
        public string Localizacaof { get; set; }
        public string Ruaf { get; set; }
        public string Bairrof { get; set; }
        public string Cidadef { get; set; }
        public string Uff { get; set; }
        public string Cepf { get; set; }
        public string NomeCliente { get; set; }
        public string Dataf { get; set; }
        public string DescricaoEvento { get; set; }
        public string Valorf { get; set; }
        public string Lotef { get; set; }
        public string DescricaoCliente { get; set; }
        public string ReferenciaF { get; set; }
        public string TipoF { get; set; }
        public string Telefone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
