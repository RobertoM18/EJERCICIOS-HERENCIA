class Perro : Animal{
    public Perro(string nombre, int edad):base(nombre, edad){
    }
    public void HacerSonido(){
        Console.WriteLine("El perro hace Guau Guau");
    }
}