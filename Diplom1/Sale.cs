//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            this.Refund = new HashSet<Refund>();
        }
    
        public int IdSale { get; set; }
        public Nullable<int> IdProduct { get; set; }
        public Nullable<int> Discount { get; set; }
        public string KolVo { get; set; }
        public string PriceSale { get; set; }
        public string DataSale { get; set; }
        public Nullable<int> IdClient { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund> Refund { get; set; }
    }
}
