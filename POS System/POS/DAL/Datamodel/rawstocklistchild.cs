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
    
    public partial class rawstocklistchild
    {
        public int id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> amount { get; set; }
        public int rawstocklistmaster_id { get; set; }
        public int rawstockproduct_id { get; set; }
    
        public virtual rawstocklistmaster rawstocklistmaster { get; set; }
        public virtual rawstockproduct rawstockproduct { get; set; }
    }
}