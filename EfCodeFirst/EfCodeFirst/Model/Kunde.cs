﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.Model
{
    [Table("🧨🧨")]
    public class Kunde : Person
    {
        public string KdNummer { get; set; }

        public Mitarbeiter Mitarbeiter { get; set; }
    }

}
