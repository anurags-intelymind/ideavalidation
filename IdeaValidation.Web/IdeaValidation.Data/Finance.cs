//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdeaValidation.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finance
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> SubmissionDate { get; set; }
        public Nullable<int> Liabilities { get; set; }
        public Nullable<int> NetWorth { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> Profit { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
