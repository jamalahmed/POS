//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Datamodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class companyinfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string servicephone { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string vatregistrationnumber { get; set; }
        public int address_id { get; set; }
    
        public virtual address address { get; set; }
    }
}