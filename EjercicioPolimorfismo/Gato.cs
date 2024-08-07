namespace EjercicioPolimorfismo
{
    class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau!");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} está caminando sigilosamente.");
        }
    }

}
