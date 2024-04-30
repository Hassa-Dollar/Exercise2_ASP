namespace Exercise2_ASP.Models
{
    public class Client
    {
        public int Numero { get; set; }
        public string Nom { get; set;}
        public string Prenom { get; set; }
        public string Courriel { get; set; }

        public Client(int num, string nom, string prenom, string courriel) 
        {
            Numero = num;
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
        }
    }
}
