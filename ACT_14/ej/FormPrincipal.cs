using ej.Models;

namespace ej
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        Sistema miEmpresa = new Sistema();
        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                string cuit = tbCUIT.Text;
                string nombre = tbNombre.Text;
                string telefono = tbTelefono.Text;
                string tarjeta = tbNumeroTarjeta.Text;
                miEmpresa.CrearTicket(cuit, nombre, telefono, tarjeta);
            }
            catch (Exception ex)
            {
                { }
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();
            formVer.listBox1.Items.AddRange(miEmpresa.Imprimir());
            formVer.ShowDialog();
        }
    }
}
