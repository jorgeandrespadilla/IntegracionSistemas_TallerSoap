using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiServicio.Service1Client servicio = new MiServicio.Service1Client();
            string res = servicio.GetData(5, 3);
            MessageBox.Show(res);

            MiServicio.CompositeType data = new MiServicio.CompositeType();
            data.BoolValue = true;
            var res2 = servicio.GetDataUsingDataContract(data);
            MessageBox.Show(res2.StringValue);
        }
    }
}
