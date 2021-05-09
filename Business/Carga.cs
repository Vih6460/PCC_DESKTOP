using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Business
{
    public class Carga : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int? Id { get; set; }


        [OpcoesBase(UsaBD = true, UsaBusca = true)]
        public string CodRomaneio { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Descricao { get; set; }


        [OpcoesBase(UsaBD = true)]
        public string Peso { get; set; }


        public new List<Carga> Todos()
        {
            List<Carga> cargas = new List<Carga>();
            foreach (var ibase in base.Todos())
            {
                cargas.Add((Carga)ibase);
            }
            return cargas;
        }
    }
}
