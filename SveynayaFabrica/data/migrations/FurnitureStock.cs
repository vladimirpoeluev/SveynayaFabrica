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
    
    public partial class FurnitureStock
    {
        public int Id { get; set; }
        public string IdFurniture { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<int> IdUnitWidth { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<int> IdUnitHeight { get; set; }
        public Nullable<double> PurchasePrice { get; set; }
    
        public virtual Furniture Furniture { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
    }
}
