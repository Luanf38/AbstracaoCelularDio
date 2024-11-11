using DesafioPOO.Models;

Nokia nokiaK1 = new Nokia("31 99999-9999" ,"K1", "13456", 8);
Iphone iphone8 = new Iphone("31 99999-9998", "Iphone8", "13457", 8);

Console.WriteLine($"Iphone modelo: {iphone8.Modelo}\nNúmero: {iphone8.Numero}\nIMEI: {iphone8.Imei}\nMemória: {iphone8.Memoria}");
iphone8.Ligar();
iphone8.ReceberLigacao();
iphone8.InstalarAplicativo("Itunes");

Console.WriteLine($"Nokia modelo: {nokiaK1.Modelo}\nNúmero: {nokiaK1.Numero}\nIMEI: {nokiaK1.Imei}\nMemória: {nokiaK1.Memoria}");
nokiaK1.Ligar();
nokiaK1.ReceberLigacao();
nokiaK1.InstalarAplicativo("Itunes");