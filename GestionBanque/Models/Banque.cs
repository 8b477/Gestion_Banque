using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Models
{
    public class Banque
    {
        public string Nom { get; set; }

        private Dictionary<string, Courant> persons = new Dictionary<string, Courant>();
        //clé = nom de la personne
        //valeur = la personne

        public void AjouterCompte(Courant c)
        {
            persons.Add(c.Numero, c);
        }

        public void SupprimerCompte(Courant c)
        {
            persons.Remove(c.Numero);
        }

        public Courant? this[string name] {
            get
            {
                 return persons.TryGetValue(name, out Courant? c) ? c : null;
            }
        }
    }
}
