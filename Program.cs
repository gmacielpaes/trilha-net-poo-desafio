using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "84993324587", modelo: "Modelo 1", imei: "123123123", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n---------------------------------\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "81999336728", modelo: "Modelo 2", imei: "345345345", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iFood");

Console.WriteLine("\n");