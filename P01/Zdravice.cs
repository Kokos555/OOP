using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    internal class Zdravice
    {
        ///Text pozdravu
        public string text;

        
        /// <summary>
        /// Podraví uživatele
        /// </summary>
        /// <param name="jmeno">Jmeno uživatele</param>
        /// <returns>Pozdrav</returns>
        public string Pozdrav(string jmeno)
        {
            return string.Format($"{text} {jmeno}");
        }
    }
}
