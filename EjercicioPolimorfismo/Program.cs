namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre del perro: ");
            Animal perro = new Perro(Console.ReadLine());
            Console.WriteLine("Escriba el nombre del Gato: ");
            Animal gato = new Gato(Console.ReadLine());
            Console.WriteLine("Escriba el nombre del pájaro: ");
            Animal pajaro = new Pajaro(Console.ReadLine());

            Animal[] animales = { perro, gato, pajaro };

            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
                animal.Moverse();
                Console.WriteLine();
            }
        }
    }
}
