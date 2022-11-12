using DesafioPOO.Models;

//Testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "43988235491", modelo: "Nokia", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "43912345678", modelo: "Iphone", imei: "2222222", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");