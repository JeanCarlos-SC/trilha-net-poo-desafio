using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "13ProMax", iMEI: "12133213", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "312132", modelo: "Modelo de algum Nokia", iMEI: "8946512", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");