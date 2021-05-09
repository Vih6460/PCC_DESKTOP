using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class Cliente : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int? Id { get; set; }


        [OpcoesBase(UsaBD = true, UsaBusca = true)]
        public string NomeCliente { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Endereco { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Cep { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Tel { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Cnpj { get; set; }


        public new List<Cliente> Todos()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach (var ibase in base.Todos())
            {
                clientes.Add((Cliente)ibase);
            }
            return clientes;
        }
    }
}
