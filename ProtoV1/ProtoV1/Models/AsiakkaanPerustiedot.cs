//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtoV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsiakkaanPerustiedot
    {
        public AsiakkaanPerustiedot()
        {
            this.Asiakastapahtumat = new HashSet<Asiakastapahtumat>();
            this.Laskutustiedot = new HashSet<Laskutustiedot>();
        }
    
        public int Asiakasnumero { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Osoite { get; set; }
        public string Postinumero { get; set; }
        public string Puhelin { get; set; }
        public string Sähköposti { get; set; }
    
        public virtual ICollection<Asiakastapahtumat> Asiakastapahtumat { get; set; }
        public virtual AsiakkaanPerustiedot AsiakkaanPerustiedot1 { get; set; }
        public virtual AsiakkaanPerustiedot AsiakkaanPerustiedot2 { get; set; }
        public virtual Postitoimipaikat Postitoimipaikat { get; set; }
        public virtual ICollection<Laskutustiedot> Laskutustiedot { get; set; }
    }
}
