public class Arma
{
    public string nombre {get;set;}
    public int durabilidad{get;set;}
    public int dano{get;set;}
    public int peso{get;set;}
    public string tipoArma{get;set;}

    public Arma(string nombre, int durabilidad, int dano, int peso,string tipoArma)
    {
        this.nombre = nombre;
        this.durabilidad = durabilidad;
        this.dano = dano;
        this.peso = peso;
        this.tipoArma= tipoArma;
    }

        public Arma()
    {
    }

    public void usar(Personaje p)
    {
        Console.WriteLine("Atacando con el arma "+this.nombre);
        p.danio(this.dano);
        this.durabilidad=this.durabilidad-1;
    }


}
