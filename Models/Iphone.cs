namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($" Número do celular: {Numero} \n IMEI: {IMEI} \n Memoria: {Memoria} \n Modelo: {Modelo} \n Aplicativo IOS instalado com sucesso!");
            Console.WriteLine("-------------------------------------------");
        }
    }
}