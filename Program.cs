using DesafioPOO.Models;

Console.WriteLine("Dispositivo Nokia");
Nokia nokia = new Nokia("5511911111111", "Nokia C21 Plus", "111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------------");
Console.WriteLine("Dispositivo Iphone");
Iphone iphone = new Iphone("5519922222222", "Iphone 15 Pro", "22222222", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");