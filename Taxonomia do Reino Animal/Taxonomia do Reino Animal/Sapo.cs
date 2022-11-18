namespace Taxonomia_do_Reino_Animal
{
    public class Sapo: Animal, IClassificação
    {
        public Sapo(string Classe, string Espécie, string Família, string Grupo, string Ordem) : base(Classe, Espécie, Família, Grupo, Ordem)
        {

        }
        public override void grupo()
        {
            this.Grupo = "Aquático";
        }

        public void Andar()
        {
            Console.WriteLine("Eu pulo com quatro patas");
        }

        public void Parir()
        {
            Console.WriteLine("Eu sou ovíparo");
        }

        public void Comunicar()
        {
            Console.WriteLine("Eu me comunico coachando");
        }

        public void ExibirInformações()
        {
            Console.WriteLine($"Classe = {Classe}, Espécie = {Espécie}, Família = {Família}, Grupo = {Grupo}, Ordem = {Ordem}");

        }
    }
}
