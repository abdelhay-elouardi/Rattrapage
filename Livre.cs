using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapge
{
    public class Livre
    {
        private int ID;
        private string Nom;

        public Livre(int id, string nom)
        {
            ID = id;
            Nom = nom;
        }
        public void commande() { }
        public void reception() { }
        public void deteriration() { }
    }
}
