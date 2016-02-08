//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDataServiceLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public System.DateTime LoanDate { get; set; }
        public System.DateTime DueData { get; set; }
        public Nullable<System.DateTime> ReturnedData { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Document Documents { get; set; }
        public virtual User Users { get; set; }
    }
}