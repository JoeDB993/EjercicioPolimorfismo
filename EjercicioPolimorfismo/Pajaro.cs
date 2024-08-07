namespace EjercicioPolimorfismo
{
    class Pajaro : Animal
    {
        public Pajaro(string nombre) : base(nombre)
        {
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Pío pío!");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }
    }
}
