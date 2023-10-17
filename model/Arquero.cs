public class Arquero : Personaje
{
    public int numeroFlechas;

    public Arquero(string nombre, double altura, double peso, string genero, int edad, int energia, int salud, Arma arma,int numeroFlechas) : base(nombre, altura, peso, genero, edad, energia, salud,arma)
    {
        this.numeroFlechas = numeroFlechas;
    }
    public Arquero() : base()
    { }

    public override void atacar(Personaje personaje)
    {
        if (this.salud > 0)
        {
            if (this.numeroFlechas > 0 && this.salud > 0)
            {
                Console.WriteLine(this.nombre + " Ataca a " + personaje.nombre);
                this.numeroFlechas -= 1;
                this.arma.usar(personaje);
            }
            else
            {
                Console.WriteLine("no hay flechas");
            }
        }
        else
        {
            Console.WriteLine("Estas muerto");
        }
    }
    public override void defender()
    {
        Console.WriteLine("se esquiva");
    }

    public override void mover()
    {
        Console.WriteLine("caminando");
    }



}