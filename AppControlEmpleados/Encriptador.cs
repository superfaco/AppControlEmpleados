using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlEmpleados
{
    static class Encriptador
    {

        public static DateTime Encriptar(DateTime d)
        {
            return d.AddMilliseconds(102776511);
        }

        public static DateTime Desencriptar(DateTime d)
        {
            return d.AddMilliseconds(-102776511);
        }

        public static decimal Encriptar(decimal d)
        {
            return d + 1041;
        }

        public static decimal Desencriptar(decimal d)
        {
            return d - 1041;
        }

        public static string Encriptar(string s)
        {
            string sout = "";
            for(int i = 0; i < s.Length; i++)
            {
                sout += (char)(s[i] + 391);
            }
            return sout;
        }

        public static string Desencriptar(string s)
        {
            string sout = "";
            for (int i = 0; i < s.Length; i++)
            {
                sout += (char)(s[i] - 391);
            }
            return sout;
        }


        public static int Encriptar(int i)
        {
            return i + 27;
        }

        public static int Desencriptar(int i)
        {
            return i - 27;
        }
    }
}
