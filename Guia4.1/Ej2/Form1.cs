using Ej2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            cBcostos.Items.Add(new Fijo("Peaje puente Zárate", 300));
            cBcostos.Items.Add(new Variable( 1500.5, 500,"Combustible"));
            cBcostos.Items.Add(new Fijo("Peaje túnel", 300));
            cBcostos.Items.Add(new Variable(500, 10,"Horas de conducción"));
            
        }
        Logistica logistica = new Logistica();
        Envio envio;

        private void bVer_Click(object sender, EventArgs e)
        {

            groupBox2.Enabled = true;
            int codigo = Convert.ToInt32(tBcodigo.Text);
            if (logistica.VerEnvioPorCodigo(codigo) >=0)
            {
                envio = logistica.VerEnvio(logistica.VerEnvioPorCodigo(codigo));
                label2.Text = "Empresa: " + envio.Empresa;                
            }
            else
            {
                Datos_del_envío datos = new Datos_del_envío();
                datos.tBcodigo.Enabled = false;
                datos.tBcodigo.Text = codigo.ToString();
                if (datos.ShowDialog() == DialogResult.OK)
                {
                    string empresa = datos.tBempresa.Text;
                    envio = new Envio(empresa, codigo);
                    label2.Text = "Empresa: " + empresa;
                }
            }
        }

        private void bAgregarCosto_Click(object sender, EventArgs e)
        {
            Costo costo = cBcostos.SelectedItem as Costo;
            envio.AgregarCosto(costo);
            tBdetalle.Text +=$"{costo}";
        }

        private void bGuardarEnvio_Click(object sender, EventArgs e)
        {
            tBdetalle.Clear();
            logistica.AgregarEnvio(envio);
        }

        private void bListar_Click(object sender, EventArgs e)
        {
            tBlista.Clear();
            for(int i = 0; i < logistica.CantidadEnvios; i++)
            {
                Envio en = logistica.VerEnvio(i);
                tBlista.Text += $"{en}";
                tBlista.Text += "------------------------------\r\n";
            }
        }
    }
}
