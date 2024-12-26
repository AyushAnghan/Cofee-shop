﻿using System.ComponentModel.DataAnnotations;

namespace NiceAdmin.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int UserID { get; set; }

    }

    public class ProductDropDownModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}