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
    
    public partial class Refund
    {
        public int IdRefund { get; set; }
        public int IdSale { get; set; }
        public string Reason { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
