//using Veicoli.AstrazioneVeicoli;
//using Veicoli.Polimorfismo;
using Veicoli.Incapsulamento;
using Veicoli.FormeGeometriche;

//Console.WriteLine("Hello World");

//#region ASTRAZIONE VEICOLI
//Automobile jeep = new Automobile();

//jeep.Avanza();

//jeep.targa = "AB123DF";

//Console.WriteLine(jeep.numeroRuote);

//#endregion

//#region POLIMORFISMO
//Impiegato mario = new Dirigente();
//mario.nome = "Mario";
//mario.cognome = "Rossi";

//Impiegato silvia = new Programmatore();
//silvia.nome = "Silvia";
//silvia.cognome = "Bianchi";

//UfficioPersonale uf = new UfficioPersonale();

//uf.StampaBustaPaga(silvia, 20);

//#endregion

//#region EXERCISE
//Automobile alfa = new Automobile();
//int velocitaAlfa = alfa.velocitaMassima();

//Automobile ferrari = new AutomobileDaCorsa();
//int velocitaFerrari = ferrari.velocitaMassima();

//Console.WriteLine($"Velocità massima alfa: {velocitaAlfa}\nVelocità massima ferrari: {velocitaFerrari}");

//#endregion

#region INCAPSULAMENTO

//Persona marta = new Persona();

//marta.Nome = "Marta";
//marta.Cognome = "Rossi";
//marta.CodiceFiscale = "MRTRSS89A053V";
//marta.Vivo = true;

//Console.WriteLine($"Nome: {marta.Nome}\nCognome: {marta.Cognome}\nCodice Fiscale: {marta.CodiceFiscale}\nIn vita: {marta.Vivo}");

//Persona alessia = new Persona("Alessia", "Verdi", "VRDLSS99F24K344B");

//Console.WriteLine(alessia);

//PuntoDelPiano a = new PuntoDelPiano(2, 4);
//PuntoDelPiano b = new PuntoDelPiano(2, 4);

//Console.WriteLine($"I due punti sono {(a == b ? "uguali" : "diversi")}");

#endregion

#region QUADRATO
Quadrato q1 = new Quadrato(5);
Quadrato q2 = new Quadrato(5);
Quadrato q3 = new Quadrato(7);

string uguaglianza1 = q1.Equals(q2) ? "uguali" : "diversi";
string uguaglianza2 = q2.Equals(q3) ? "uguali" : "diversi";

Console.WriteLine($"I quadrati q1 e q2 sono {uguaglianza1}");
Console.WriteLine($"I quadrati q2 e q3 sono {uguaglianza2}");

#endregion