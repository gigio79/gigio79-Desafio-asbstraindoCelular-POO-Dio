using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "97835621",modelo: "Super", imei: "1.0", memoria: 32 );
n1.InstalarAplicativo(nomeApp:"Dio");
n1.Ligar();
n1.ReceberLigacao();

Iphone i1 = new Iphone(numero: "963469345", modelo: "Megazord", imei: "2.0", memoria: 120 );
i1.InstalarAplicativo(nomeApp: "Super formação com Leonardo Buta");
i1.Ligar();
i1.ReceberLigacao();