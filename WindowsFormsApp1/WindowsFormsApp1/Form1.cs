using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerSaldo_Click(object sender, EventArgs e)
        {
            CuentaBancaria bbva  = new CuentaBancaria(15);

            label1.Text = $"Su saldo es de {bbva.obtenerSaldo()}";

            
        }
    }
}
