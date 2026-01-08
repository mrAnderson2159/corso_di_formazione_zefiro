using Veicoli.AstrazioneVeicoli;
using Veicoli.Polimorfismo;

Console.WriteLine("Hello World");

#region ASTRAZIONE VEICOLI
Automobile jeep = new Automobile();

jeep.Avanza();

jeep.targa = "AB123DF";

Console.WriteLine(jeep.numeroRuote);

Automobile alfa = new Automobile();
int velocitaAlfa = alfa.velocitaMassima();

Automobile ferrari = new AutomobileDaCorsa();
int velocitaFerrari = ferrari.velocitaMassima();

Console.WriteLine($"Velocità massima alfa: {velocitaAlfa}\nVelocità massima ferrari: {velocitaFerrari}");
#endregion

#region POLIMORFISMO
Impiegato mario = new Dirigente();
mario.nome = "Mario";
mario.cognome = "Rossi";

Impiegato silvia = new Programmatore();
silvia.nome = "Silvia";
silvia.cognome = "Bianchi";

UfficioPersonale uf = new UfficioPersonale();

uf.StampaBustaPaga(silvia, 20);

#endregion