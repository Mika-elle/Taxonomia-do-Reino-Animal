namespace Taxonomia_do_Reino_Animal
{
    public class Humano : Animal, IClassificação
    {
        public Humano(string Classe, string Espécie, string Família, string Grupo, string Ordem) : base(Classe, Espécie, Família,Grupo, Ordem)
        {
        }

        public override void grupo()
        {
            this.Grupo = "Terrestre";
        }

        public void Andar()
        {
            Console.WriteLine("Eu ando com duas pernas");
        }

        public void Parir()
        {
            Console.WriteLine("Eu sou vivíparo");
        }

        public void Comunicar()
        {
            Console.WriteLine("Eu me comunico falando");
        }
        public void ExibirInformações()
        {
            Console.WriteLine($"Classe = {Classe}, Espécie = {Espécie}, Família = {Família}, Grupo = {Grupo}, Ordem = {Ordem}");

        }

    }
}
