using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExamEdge.Models
{
    public class AspNetUsers : IdentityUser<string>
    {
        //extra column
        
    }
    public class Organization
    {
        [Key]
        [MaxLength(128)]
        public string OrganizationId { get; set; }
        [MaxLength(256)]
        public string OrganizationName { get; set; }
        [MaxLength(128)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [MaxLength(128)]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string IsoUtcCreatedOn { get; set; }
        public string IsoUtcModifiedOn { get; set; }
    }
    public class Branch
    {
        [Key]
        [MaxLength(128)]
        public string BranchId { get; set; }
        [MaxLength(256)]
        public string BranchName { get; set; }
        [MaxLength(128)]
        public string OrganizationId { get; set; }
        [MaxLength(128)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [MaxLength(128)]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string IsoUtcCreatedOn { get; set; }
        public string IsoUtcModifiedOn { get; set; }
    }
}



