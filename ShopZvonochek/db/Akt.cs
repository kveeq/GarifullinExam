//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopZvonochek.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Akt
    {
        public int Id { get; set; }
        public Nullable<int> IdPhoneBuy { get; set; }
        public Nullable<int> IdCrashType { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual CrashType CrashType { get; set; }
        public virtual PhoneBuy PhoneBuy { get; set; }
    }
}
