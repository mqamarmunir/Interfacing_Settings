//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class mi_ttestattribute
    {
        public long AttributeID { get; set; }
        public long Machine_testid { get; set; }
        public string LIMSAttributeID { get; set; }
        public string LIMSAttributeName { get; set; }
        public string MachineAttributeName { get; set; }
        public long EnteredBy { get; set; }
        public System.DateTime EnteredOn { get; set; }
        public string ClientId { get; set; }
        public string Active { get; set; }
        public string MachineAttributeCode { get; set; }
    }
}
