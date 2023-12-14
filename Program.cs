internal class Program
{
    private static void Main(string[] args)
    {
        Perro perro = new Perro("Zeus", 12);
        Gato gato = new Gato("Michu", 10);
        Vaca vaca = new Vaca("Lola", 6);

        //Perro
        Console.WriteLine("Perro");
        Console.WriteLine("Nombre: " +perro.Nombre);
        Console.WriteLine("Edad: " +perro.Edad);
        perro.HacerSonido();
        //Gato
        Console.WriteLine("Nombre: " +gato.Nombre);
        Console.WriteLine("Edad: " +gato.Edad);
        gato.HacerSonido();
        //Vaca
        Console.WriteLine("Nombre: " +vaca.Nombre);
        Console.WriteLine("Edad: " +vaca.Edad);
        vaca.HacerSonido();

    }
}