﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavidsBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
       
       

        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set; }

       

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; }  
        [ForeignKey("CoverId")]
        public CoverType CoverType { get; set; }

        public string ImageUrl { get; set; }
    }
}