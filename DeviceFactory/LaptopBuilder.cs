using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public class LaptopBuilder : DeviceBuilder
    {
        public LaptopBuilder(IDevice device) : base(device)
        {
            
        }
        public override void SetBode(string bode)
        {
            Device.Body = $"body: {bode}";
        }

        public override void SetModel(string model)
        {
            Device.Model = $"model: {model}";
        }

        public override void SetName(string name)
        {
            Device.Name = $"name {name}";
        }

        public override void SetScreen(string screen)
        {
            Device.Screen = $"screen: {screen}";
        }
    }
}
