//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfKovalev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeProduct
    {
        public TypeProduct()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int TypeProductId { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}