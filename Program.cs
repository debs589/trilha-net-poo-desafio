using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia();
n1.IMEI = "000000-00-000000-0";
n1.Memoria = 2;
n1.Modelo = "Sk2-x67";
n1.Numero = "119465386754";

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Android");


Iphone i1 = new Iphone();
i1.IMEI = "000450-00-0067540-0";
i1.Memoria = 8;
i1.Modelo = "i11";
i1.Numero = "11904859675";

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("IOS");