public abstract class Personaje 
{
    public string nombre { get; set; }
    public double altura{ get; set; }
    private double peso { get; set; }
    private string genero { get; set; }
    private int edad { get; set; }
    private int eregia { get; set; }
    public  int salud { get; set; }

    public Arma arma{get;set;}

    public Personaje(string nombre, double altura, double peso, string genero, int edad, int energia, int salud, Arma arma)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.peso = peso;
        this.genero = genero;
        this.edad = edad;
        this.eregia = energia;
        this.salud = salud;
        this.arma=arma;
    }

    public Personaje()
    {}

    public abstract void atacar(Personaje personaje);
    public abstract void defender();
    public abstract void mover();
    public void danio(int porcentajeDano)
    {
        this.salud -=porcentajeDano;
        if(this.salud<=0)
        {
            Console.WriteLine(this.nombre+ " está muerto");
        }
    }


}
