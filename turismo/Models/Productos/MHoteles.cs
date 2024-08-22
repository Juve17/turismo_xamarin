using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace turismo.Models.Productos
{
    public class MHoteles
    {
        public string Name { get; set; }
        public string Direcion {  get; set; }
        public string Precio {  get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
