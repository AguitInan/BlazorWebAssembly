﻿using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ExerciceForm.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Saisie du nom requise.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "L'Email est requis.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "L'Adresse est requise.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Le code postal est requis.")]
        public string? PostalCode { get; set; }
        [Range(1, 125, ErrorMessage = "L'age doit être compris entre 1 et 125.")]
        public int Age { get; set; }
        [Range(typeof(DateTime), "1895-01-01", "2024-01-01", ErrorMessage = "La date de naissance doit être valide.")]
        public DateTime BirthDate { get; set; }
        public bool IsMarried { get; set; }
        [Range(1, 4, ErrorMessage = "La couleur est requise.")]
        public Colors FavoriteColor { get; set; }
    }

    public enum Colors
    {
        nothing,
        red,
        green,
        blue,
        purple
    }
}
