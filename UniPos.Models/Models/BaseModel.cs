﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// Базовая модель
    /// </summary>
    public class BaseModel
    {
        [Index]
        [DefaultValue(1)]
        public int Status { get; set; }

        [Index]
        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Index]
        [Required]
        public int CreateUser { get; set; }
        public int? UpdateUser { get; set; } 
    }

}
