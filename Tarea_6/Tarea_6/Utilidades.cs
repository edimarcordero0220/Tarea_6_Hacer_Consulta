﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_6
{
    public class Utilidades
    {
        public static int TOINT(string num)
        {
            int numero = 0;
            int.TryParse(num, out numero);
            return numero;
        }
    }
}