using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using turismo.Models.Productos;

namespace turismo.ViewModel.Productos
{
    public class VMHoteles
    {
        public ObservableCollection<MHoteles> Hoteles { get; set; }
        public VMHoteles()
        {
            Hoteles = new ObservableCollection<MHoteles>
            {
                new MHoteles{Name="casa 1",Direcion="lugar 1",Precio="S/. 15"},
                new MHoteles{Name="casa 1",Direcion="lugar 1",Precio="S/. 15"}

            };
        }

    }
}
