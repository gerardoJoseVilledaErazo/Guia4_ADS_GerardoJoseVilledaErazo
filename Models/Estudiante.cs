﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia4_ADS_CrudCarrera.Models
{
    public class Estudiante
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string email { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
    }
}