//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableBusWinForms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public System.DateTime DateTimeEnd { get; set; }
        public int CurrentCountPassenger { get; set; }
        public int MaxCountPassenger { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual Route Route { get; set; }
        public virtual User User { get; set; }
    }
}
