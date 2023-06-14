using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente : Base 
    {
        [OpcoesBase(ChavePrimaria =true, UsaBD =true, UsaBusca =true)]
        public int Id { get; set; }

        [OpcoesBase(UsaBD = true, UsaBusca = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Modelo { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Placa { get; set; }
        
    }
}
