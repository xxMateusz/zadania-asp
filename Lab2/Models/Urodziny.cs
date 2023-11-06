﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Urodziny 
    {

        public int Id { get; set; }

        public DateTime Wiek { get; set; }
        public string Imie { get; set; }

        public bool IsValid()
        {
            if (Wiek < DateTime.Now && Imie != null)
                return true;
            else
                return false;
        }

        public int Age()
        {
            int age = 0;
            age = DateTime.Now.Year - Wiek.Year;
            return age;
        }
    }
}
