using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heranca.ByteBank_ADM.Funcionarios;

namespace Heranca.ByteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticador funcionario, string user, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(user, senha);
            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Login efetuado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos!");
                return false;
            }
        }
    }
}