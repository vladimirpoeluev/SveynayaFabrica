//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SveynayaFabrica.data.migrations
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitConvert
    {
        public int Id { get; set; }
        public int IdUnit1 { get; set; }
        public int IdUnit2 { get; set; }
        public double Ratio { get; set; }
    
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
    }
}
