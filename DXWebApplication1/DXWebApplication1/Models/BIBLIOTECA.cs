//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXWebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BIBLIOTECA
    {
        public int ID { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public Nullable<int> ID_LIBRO { get; set; }
    
        public virtual LIBRO LIBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
