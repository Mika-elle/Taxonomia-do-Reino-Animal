namespace Taxonomia_do_Reino_Animal
{
    public abstract class Taxonomia
    { 
        public string Classe { get; set; }

        public string Espécie { get; set; }

        public string Família { get; set; }

        public string Grupo { get; set; }

        public string Ordem { get; set; }

        public Taxonomia(string Classe, string Espécie, string Família, string Grupo, string Ordem)
        {
            this.Classe = Classe;
            this.Espécie = Espécie;
            this.Família = Família;
            this.Grupo = Grupo;
            this.Ordem = Ordem;
        }


    }
}
