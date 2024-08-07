namespace EjercicioPolimorfismo
{
    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Wof, Wof!");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} está corriendo.");
        }
    }
}