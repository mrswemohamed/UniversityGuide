//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniGuide.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProgramComment
    {
        public long CommentID { get; set; }
        public long ProgramID { get; set; }
        public string Comment { get; set; }
        public string UserID { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Program Program { get; set; }
    }
}
