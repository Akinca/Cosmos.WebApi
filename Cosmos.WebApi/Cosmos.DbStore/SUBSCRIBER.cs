//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cosmos.DbStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUBSCRIBER
    {
        public int ID { get; set; }
        public Nullable<bool> DISABLE { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public Nullable<int> COUNTRY_ID { get; set; }
        public Nullable<int> REGION_ID { get; set; }
        public Nullable<int> CITY_ID { get; set; }
        public Nullable<int> COUNTY_ID { get; set; }
        public string COMMENT { get; set; }
    }
}
