using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestorDeEstoquePOO
{
    [System.Serializable]
    abstract class Produto
    {
       public string nome;
       public float preco;
    }
}
