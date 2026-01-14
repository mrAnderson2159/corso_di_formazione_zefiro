using AlgoritmiConsole;


//#region SOMMA DI DUE NUMERI INTERI

//Console.WriteLine("Questo programma somma due numeri.\n");

//int numero1 = ReadUtils.ReadIntWithConvert("Inserisci il primo numero: ");
//int numero2 = ReadUtils.ReadIntWithConvert("Inserisci il secondo numero: ");

//int somma = numero1 + numero2;

//Console.WriteLine($"La somma è {somma}");
//#endregion

//Console.WriteLine();

//#region PARI O DISPARI?
//Console.WriteLine("Questo programma verifica se un numero è pari o dispari\n");

//int numero = ReadUtils.ReadIntWithTryParse("Inserisci un numero: ");
//string parita = PariDispari.VerificaNumero(numero);

//Console.WriteLine(parita);
//#endregion

//Console.WriteLine();

//#region PRODOTTO
//Console.WriteLine("Questo programma stampa il prodotto di due numeri\n");

//Console.Write("Inserisci il primo numero: ");
//string? n1str = Console.ReadLine();

//Console.Write("Inserisci il secondo numero: ");
//string? n2str = Console.ReadLine();

//string result = Prodotto.Moltiplica(n1str, n2str);
//Console.WriteLine(result);
//#endregion

//#region INVERTI STRINGA
//using AlgoritmiConsole;

//string mario = "Mario";

//string invertedMario = InvertiStringhe.Inverti(mario);

//Console.WriteLine(invertedMario);
//#endregion

#region OPERAZIONI CON ARRAY DI NUMERI

int[] numeri =
[
    3, 7, 12, 18, 21,
    25, 30, 34, 41, 47,
    52, 58, 63, 69, 74,
    80, 86, 91, 95, 100
];

Console.WriteLine($"Il minimo è {OperazioniNumeriche.Min(numeri)}");
Console.WriteLine($"Il massimo è {OperazioniNumeriche.Max(numeri)}");
Console.WriteLine($"La somma dei numeri pari è {OperazioniNumeriche.SommaPari(numeri)}");
Console.WriteLine($"La somma dei numeri dispari è {OperazioniNumeriche.SommaDispari(numeri)}");
Console.WriteLine($"La somma totale dei numeri è {OperazioniNumeriche.Somma(numeri)}");
Console.WriteLine($"Il numero medio è {OperazioniNumeriche.Medio(numeri)}");

Console.WriteLine();
string frase = "Oggi non piove";
int vocaliInFrase = OperazioniNumeriche.ContaVocali(frase);
Console.WriteLine($"Il numero di vocali nella frase \"{frase}\" è {vocaliInFrase}.\n");

ContaVocali cv = new();

cv.Incrementa(frase);
cv.Resoconto();
#endregion