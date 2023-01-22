using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public class DeviceStorage
    {
        private DeviceStorage() { }
        public List<IDevice> Devices { get; set; } = new List<IDevice>();
        public static DeviceStorage Instance { get => DeviceStorageCreate.instance; }
        private class DeviceStorageCreate
        {
            static DeviceStorageCreate() { }
            internal static readonly DeviceStorage instance = new DeviceStorage();
        }

        public string MakeRepost()
        {
            string res = "";
            foreach (var item in Devices)
            {
                if (item.IsTested == true)
                {
                    res += item.Name + " " + item.Model + " " + item.IsDefective + Environment.NewLine;
                }
            }
            return res;
        }

    }
}
