namespace EjercicioPolimorfismo
{
    abstract class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void HacerSonido();

        public virtual void Moverse()
        {
            Console.WriteLine($"{Nombre} se está moviendo.");
        }
    }
}