﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvc.QuickStart.Models
{
    public class Student

    {
        public int ID { get; set; }

        [Display(Name = "姓名")]
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "性别")]
        [Required]
        [Range(0, 1)]
        public int Gender { get; set; }

        [Display(Name = "专业")]
        [Required]
        [StringLength(200)]
        public string Major { get; set; }

        [Display(Name = "日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EntranceDate { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}