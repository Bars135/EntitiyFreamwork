//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiyFreamwork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.Satis_Detaylari = new HashSet<Satis_Detaylari>();
        }
    
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<short> HedefStokDuzeyi { get; set; }
        public Nullable<short> YeniSatis { get; set; }
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis_Detaylari> Satis_Detaylari { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
