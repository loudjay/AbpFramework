using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace AbpFramework.Domain.Models
{
    public class JobseekerBaseInfo:Entity<int>
    {
        [Column("JobseekerId")]
        public override int Id { get; set; }
        public string JobseekerName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}