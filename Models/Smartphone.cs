namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor que recebe os parâmetros e inicializa as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será sobrescrito nas classes derivadas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
