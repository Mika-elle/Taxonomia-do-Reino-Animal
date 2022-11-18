namespace Taxonomia_do_Reino_Animal

{
    public abstract class Program
    {
        static void Main(String[] args) {

            var  cachorro = new Cachorro("Mamífero", "Vivíparo", "Canídeo","Terrestre", "Carnívoro");
            cachorro.ExibirInformações();
            cachorro.Andar();
            cachorro.Parir();
            cachorro.Comunicar();

            var abelha = new Abelha("Inseto", "Ovíparo", "Apidae", "Aéreo", "Herbívoro");
            abelha.ExibirInformações();
            abelha.Andar();
            abelha.Parir();
            abelha.Comunicar();

            var sapo = new Sapo("Anfíbio", "Ovíparo", "Bufonidae", "Aquático", "Carnívoro");
            sapo.ExibirInformações();
            sapo.Andar();
            sapo.Parir();
            sapo.Comunicar();

            var humano = new Humano("Mamífero", "Vivíparo", "Hominídeo", "Terrestre", "Onívoro");
            humano.ExibirInformações();
            humano.Andar();
            humano.Parir();
            humano.Comunicar();

        }
    }
}
