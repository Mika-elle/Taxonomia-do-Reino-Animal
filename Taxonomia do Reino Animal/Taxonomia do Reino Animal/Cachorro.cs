namespace Taxonomia_do_Reino_Animal
{
    public class Cachorro: Animal, IClassificação
    {
        public Cachorro(string Classe, string Espécie, string Família, string Grupo, string Ordem) : base(Classe, Espécie, Família, Grupo, Ordem)
        {

        }
        public override void grupo()
        {
            this.Grupo = "Terrestre";
        }

       
        public void Andar()
        {
            Console.WriteLine("Eu ando com quatro patas");
        }

        public void Parir()
        {
            Console.WriteLine("Eu sou vivípro");
        }

        public void Comunicar()
        {
            Console.WriteLine("Eu me comunico latindo");
        }

        public void ExibirInformações()
        {
            Console.WriteLine($"Classe = {Classe}, Espécie = {Espécie}, Família = {Família}, Grupo = {Grupo}, Ordem = {Ordem}");
        }

    }
}
