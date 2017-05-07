using System;
using System.Collections.Generic;
using System.Text;

namespace githubTests
{
    public class CaseInverter : ICaseInverter
    {
        public string majInverter(string entree)
        {
            string sortie = "";
            foreach (var lettre in entree.ToCharArray())
            {
                if (char.IsLetter(lettre))
                {
                    if (char.IsLower(lettre))
                    {
                        sortie += char.ToUpper(lettre);
                    }
                    else
                    {
                        sortie += char.ToLower(lettre);
                    }
                }
                else
                {
                    sortie += lettre;
                }
            }
            return sortie;
        }

        public string orderInverter(string entree)
        {
            var sortie = "";
            foreach (var lettre in entree.ToCharArray())
            {
                sortie = lettre + sortie;
            }
            return sortie;
        }

        public string inverter(string entree)
        {
            string sortie = orderInverter(majInverter(entree));
            return sortie;
        }
    }
}
