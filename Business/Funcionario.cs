using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class Funcionario : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int? Id { get; set; }


        [OpcoesBase(UsaBD = true, UsaBusca = true)]
        public string NomeMotorista { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Carro { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Placa { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Cnh { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Cpf { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Whatsapp { get; set; }


        public new List<Funcionario> Todos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            foreach (var ibase in base.Todos())
            {
                funcionarios.Add((Funcionario)ibase);
            }
            return funcionarios;
        }
    }
}
