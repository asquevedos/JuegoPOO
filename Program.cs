// See https://aka.ms/new-console-template for more information

Arma arma1 = new Arma("Escalibur", 100, 10, 10,"Espada");
Arma arma2 = new Arma("Arco rompe viento", 100, 1, 10,"Arco");
Arma arma3= new Arma("Baculo de Gandalf", 100, 10, 10,"Baculo");

Personaje mago = new Mago("Gandalf", 1.80, 80, "Masculino", 100, 100, 100,arma3,120);
Personaje arquero2= new Arquero("Legolas", 1.80, 80, "Masculino", 100, 100, 100, arma2,5);
Personaje arquero1= new Arquero("Robin Hood", 1.80, 80, "Masculino", 100, 100, 30,arma2,6 );


mago.atacar(arquero2);
arquero2.atacar(mago);
arquero1.atacar(mago);
mago.atacar(arquero1);
mago.atacar(arquero2);
mago.atacar(arquero1);
mago.atacar(arquero1);
//
arquero1.atacar(mago);
mago.atacar(arquero2);
mago.atacar(arquero2);
mago.atacar(arquero1);
mago.atacar(arquero2);
mago.atacar(arquero2);
mago.atacar(arquero2);

//Console.WriteLine(mago);