﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;



namespace PrimerParcialAplicada2.DAL
{
    public class Contexto : DbContext
    {
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data\PrimerParcial.db");
        }
    }
}
