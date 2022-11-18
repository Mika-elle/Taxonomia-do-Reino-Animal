namespace Taxonomia_do_Reino_Animal
{
    public abstract class Animal : Taxonomia
    {
        public Animal (string Classe, string Espécie, string Família, string Grupo, string Ordem): base (Classe, Espécie, Família, Grupo, Ordem)
        {

        }

        public abstract void grupo();




    }
}
