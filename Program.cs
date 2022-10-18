using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new Iphone("4567-5658", "modelo S", "15698547", 128);
Nokia n1 = new Nokia("9658-4758", "Modelo SH10", "4567858", 256);

i1.ReceberLigacao();
i1.Ligar();
i1.InstalarAplicativo("Facebook");

Console.WriteLine("--------------------");

n1.ReceberLigacao();
n1.Ligar();
n1.InstalarAplicativo("Telegram");
