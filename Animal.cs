class Animal{
    protected string nombre;
    protected int edad;
    public Animal(string nombre, int edad){
        this.nombre = nombre;
        this.edad = edad;
    }
    public string Nombre{
        get{return nombre;}
        set{nombre = value;}
    }
    public int Edad{
        get{return edad;}
        set{edad = value;}
    }
    public void HacerSonido(){
        Console.WriteLine("El animal hace un sonido");
    }
}