//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teknik_Servis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCARI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCARI()
        {
            this.TBLFATURABILGI = new HashSet<TBLFATURABILGI>();
            this.TBLURUNHARAKET = new HashSet<TBLURUNHARAKET>();
            this.TBLURUNKABUL = new HashSet<TBLURUNKABUL>();
        }
    
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string banka { get; set; }
        public string vergidairesi { get; set; }
        public string verginumarasi { get; set; }
        public string statu { get; set; }
        public string adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNHARAKET> TBLURUNHARAKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNKABUL> TBLURUNKABUL { get; set; }
    }
}
