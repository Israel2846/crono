using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL.Vista
{

    public class InicioFlyoutMenuItem
    {
        public InicioFlyoutMenuItem()
        {
            TargetType = typeof(InicioFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}