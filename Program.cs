using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("------Smartphone Nokia------");
Smartphone nokia = new Nokia(numero: "1234", modelo: "3310", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("------Smartphone Iphone------");
Smartphone iphone = new Iphone(numero: "5678", modelo: "9", imei: "987654321", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");