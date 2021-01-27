﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace BasicFilmDbProject.Models
{
    public class Film

    {
        [Key]
        public int FilmID { get; set; }

        [Required]
        public string FilmTitle { get; set; }

        [Required]
        public string FilmCertificate { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal FilmPrice { get; set; }

        public int Stars { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }

}