namespace Taxonomia_do_Reino_Animal

{
    public abstract class Program
    {
        static void Main(String[] args) {

            var  cachorro = new Cachorro("Mam�fero", "Viv�paro", "Can�deo","Terrestre", "Carn�voro");
            cachorro.ExibirInforma��es();
            cachorro.Andar();
            cachorro.Parir();
            cachorro.Comunicar();

            var abelha = new Abelha("Inseto", "Ov�paro", "Apidae", "A�reo", "Herb�voro");
            abelha.ExibirInforma��es();
            abelha.Andar();
            abelha.Parir();
            abelha.Comunicar();

            var sapo = new Sapo("Anf�bio", "Ov�paro", "Bufonidae", "Aqu�tico", "Carn�voro");
            sapo.ExibirInforma��es();
            sapo.Andar();
            sapo.Parir();
            sapo.Comunicar();

            var humano = new Humano("Mam�fero", "Viv�paro", "Homin�deo", "Terrestre", "On�voro");
            humano.ExibirInforma��es();
            humano.Andar();
            humano.Parir();
            humano.Comunicar();

        }
    }
}
