using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class Nota : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int? Id { get; set; }

        [OpcoesBase(UsaBD = true, UsaBusca = true)]
        public string CodRomaneio { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Fornecedor { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Recebedor { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string NomeMotorista { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Carro { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Placa { get; set; }

        public new List<Nota> Todos()
        {
            List<Nota> notas = new List<Nota>();
            foreach (var ibase in base.Todos())
            {
                notas.Add((Nota)ibase);
            }
            return notas;
        }
    }
}
