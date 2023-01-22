using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public interface IDevice
    {
        string Name { get; set; }
        string Model { get; set; }
        string Screen { get; set; }
        string Body { get; set; }
        bool IsDefective { get; set; }
        bool IsTested { get; set; }
    }
}
