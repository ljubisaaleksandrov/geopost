//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace geopost.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            this.Comments1 = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int PageId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsBlocked { get; set; }
        public Nullable<int> ReplayTo { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments1 { get; set; }
        public virtual Comment Comment1 { get; set; }
    }
}