﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAsp.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public double Prix { get; set; }
    }
}