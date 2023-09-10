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


        // Création de mon indexeur perso, sur base numéro du compte courant
        public Courant? this[string courantNumber] {
            get
            {
                 return persons.TryGetValue(courantNumber, out Courant? c) ? c : null;
            }
        }
    }
}
