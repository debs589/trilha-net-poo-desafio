namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($" Número do celular: {Numero} \n IMEI: {IMEI} \n Memoria: {Memoria} \n Modelo: {Modelo} \n Aplicativo Android instalado com sucesso!");
            Console.WriteLine("-------------------------------------------");
        }
    }
}