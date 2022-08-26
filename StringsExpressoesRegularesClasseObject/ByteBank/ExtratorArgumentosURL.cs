using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringsExpressoesRegularesClasseObjeto.ByteBank
{
    public class ExtratorArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

        URL = url;
        int indiceInterrogacao = url.IndexOf('?');
        _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoCaixaAlta = _argumentos.ToUpper();
            
            string termo = nomeParametro + "=";
            int indiceTermo = argumentoCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }
            else
            {
                return resultado.Remove(indiceEComercial);
            }
        }
    }
}