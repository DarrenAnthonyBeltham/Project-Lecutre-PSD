//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectLecture.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual User User { get; set; }
    }
}
