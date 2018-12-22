using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algoritmos
{
    public class Algoritmos
    {
        public static string String_DateSql (String date){
            string dia = date.Substring(6, 4) + '/'
                    + date.Substring(3, 2) + '/'
                    + date.Substring(0, 2) + ' ';
            if (dia.Length > 11)
            {
                dia += date.Substring(11);
            }

            return dia;
        }
    }
}