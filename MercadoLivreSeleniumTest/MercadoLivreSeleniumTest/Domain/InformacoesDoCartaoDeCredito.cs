using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Domain
{
    public class InformacoesDoCartaoDeCredito
    {
        public string NumeroDoCartao { get; set; }
        public string NomeeSobreNome { get; set; }
        public string DataDeVencimento { get; set; }
        public string CodigoDeSeguranca { get; set; }
        public string CPFDoTitularDoCartao { get; set; }


        public InformacoesDoCartaoDeCredito GetInformacoesDoCartaoDeCredito()
        {
            EnvironmentData environment = new EnvironmentData().GetEnvironmentData();

            var reader = new StreamReader(File.OpenRead(new DirectoryInfo(new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath).Parent.Parent.Parent.FullName + Path.Combine(@"\Data\InformacoesDoCartaoDeCredito.csv")));
            Dictionary<string, string> informacoesDoCartaoDeCreditoDic = new Dictionary<string, string>();

            var header = reader.ReadLine().Split(';');
            var line = reader.ReadLine().Split(';');

            for (int i = 0; i < line.Length; i++)
            {
                informacoesDoCartaoDeCreditoDic.Add(header[i], line[i]);
            }

            InformacoesDoCartaoDeCredito informacoesDoCartaoDeCredito = new InformacoesDoCartaoDeCredito();


            informacoesDoCartaoDeCredito.NumeroDoCartao = informacoesDoCartaoDeCreditoDic["NumeroDoCartao"];
            informacoesDoCartaoDeCredito.NomeeSobreNome = informacoesDoCartaoDeCreditoDic["NomeeSobreNome"];
            informacoesDoCartaoDeCredito.DataDeVencimento = informacoesDoCartaoDeCreditoDic["DataDeVencimento"];
            informacoesDoCartaoDeCredito.CodigoDeSeguranca = informacoesDoCartaoDeCreditoDic["CodigoDeSeguranca"];
            informacoesDoCartaoDeCredito.CPFDoTitularDoCartao = informacoesDoCartaoDeCreditoDic["CPFDoTitularDoCartao"];


            return informacoesDoCartaoDeCredito;

        }
    }
}
