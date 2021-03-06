﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace AbpFramework.Domain.Models
{
    public class EnterpriseBaseInfo:Entity<int>
    {
        [Column("EnterpriseId")]
        public override int Id{ get; set; }
        public  string EnterpriseName { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}