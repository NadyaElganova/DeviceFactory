using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceFactory
{
    public partial class Form1 : Form
    {
        DeviceBuilder builder;
        Worker worker = new Worker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Pad":
                    builder = new PadBuilder(new Pad());
                    var pad = worker.MakeDevice(builder, name_textBox.Text, screen_textBox.Text, model_textBox.Text, body_textBox.Text);
                    UpdateLabel(pad, label1);
                    break;
                case "Phone":
                    builder = new PhoneBuilder(new Phone());
                    var phone = worker.MakeDevice(builder, name_textBox.Text, screen_textBox.Text, model_textBox.Text, body_textBox.Text);
                    UpdateLabel(phone, label1);
                    break;
                case "Laptop":
                    builder = new LaptopBuilder(new Laptop());
                    var laptop = worker.MakeDevice(builder, name_textBox.Text, screen_textBox.Text, model_textBox.Text, body_textBox.Text);
                    UpdateLabel(laptop, label1);
                    break;
            }
        }
        private void UpdateLabel(IDevice device, Label label)
        {
            label.Text = device.Name + Environment.NewLine;
            label.Text += device.Model + Environment.NewLine;
            label.Text += device.Screen + Environment.NewLine;
            label.Text += device.Body + Environment.NewLine;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DeviceStorage.Instance.MakeRepost());
        }
    }
}
