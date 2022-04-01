using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_prog_6_TD3
{
    class Contact
    {
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        public Contact() { }

        public Contact(string Unnom, string Unprenom, string Unnumero, string Unmail)
        {
            this.nom = Unnom;
            this.prenom = Unprenom;
            this.tel = Unnumero;
            this.mail = Unmail;

        }

        public void SetNom(string Unnom)
        {
            this.nom = Unnom;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public void SetMail(string Unmail)
        {
            this.mail = Unmail;
        }
        public string GetMail()
        {
            return this.mail;
        }

        public void SetTel(string Unnumero)
        {
            this.tel = Unnumero;
        }
        public string GetTel()
        {
            return this.tel;
        }
        public void SetPrenom(string Unprenom)
        {
            this.prenom = Unprenom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }


        public override string ToString()
        {
            return this.nom + ";" + this.prenom + ";" + this.tel + ";" + this.mail;
        }
    }
}