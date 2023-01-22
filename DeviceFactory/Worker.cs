using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public class Worker
    {
        public IDevice MakeDevice(DeviceBuilder deviceBuilder, string name, string screen, string model, string body)
        {
            deviceBuilder.SetName(name);
            deviceBuilder.SetScreen(screen);
            deviceBuilder.SetModel(model);
            deviceBuilder.SetBode(body);
            DeviceStorage.Instance.Devices.Add(deviceBuilder.Device);
            TestDevices();
            return deviceBuilder.Device;
        }
        public void TestDevices()
        {
            var Devices = DeviceStorage.Instance.Devices;
            Random rand = new Random();
            if (Devices.Count % 10 == 0)
            {
                for (int i = Devices.Count -10; i < Devices.Count; i++)
                {
                    if (rand.Next(0, 16) < 9)
                    {
                        Devices[i].IsDefective = false;
                    }
                    else 
                    {
                        Devices[i].IsDefective = true;
                    }
                    Devices[i].IsTested = true;
                }
            }
        }
    }
}
