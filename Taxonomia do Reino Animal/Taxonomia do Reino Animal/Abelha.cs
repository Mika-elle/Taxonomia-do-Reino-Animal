namespace Taxonomia_do_Reino_Animal
{
    public class Abelha: Animal, IClassificação
    {
        public Abelha(string Classe, string Espécie, string Família, string Grupo, string Ordem) : base(Classe, Espécie, Família, Grupo, Ordem)
        {

        }
        public override void grupo()
        {
            this.Grupo = "Aéreo";
        }


        public void Andar()
        {
            Console.WriteLine("Eu voo com dois pares de asas");
        }

        public void Parir()
        {
            Console.WriteLine("Eu sou ovíparo");
        }

        public void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de toques");
        }

        public void ExibirInformações()
        {
            Console.WriteLine($"Classe = {Classe}, Espécie = {Espécie}, Família = {Família}, Grupo = {Grupo}, Ordem = {Ordem}");

        }
    }
}
  
