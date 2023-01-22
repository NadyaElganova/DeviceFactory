using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public abstract class DeviceBuilder
    {
        public IDevice Device { get; private set; }
        public DeviceBuilder(IDevice device)
        {
            Device = device;
        }
        public abstract void SetName(string name);
        public abstract void SetModel(string model);
        public abstract void SetScreen(string screen);
        public abstract void SetBode(string bode);
       
    }
}
