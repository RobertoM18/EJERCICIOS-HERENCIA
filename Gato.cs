class Gato : Animal{
    public Gato(string nombre, int edad):base(nombre, edad){
    }
    public void HacerSonido(){
        Console.WriteLine("El gato hace miau mi");
    }
}