using DesafioPOO.Models;

// Testes com a classe Nokia
Console.WriteLine("Testando o Nokia:");
Smartphone nokia = new Nokia(numero: "11987654321", modelo: "Nokia Lumia", imei: "123456789012345", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Testes com a classe Iphone
Console.WriteLine("Testando o Iphone:");
Smartphone iphone = new Iphone(numero: "11912345678", modelo: "iPhone 13", imei: "987654321098765", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Testes concluídos.");
