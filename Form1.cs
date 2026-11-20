namespace Examen_RentCar_Wilson
{
    public partial class Form1 : Form
    {
        private decimal subtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblItbis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vehiculo = txtVehiculo.Text;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            if (rbtCompleto.Checked)
            {
                tarifa += 300;
            }

            if (chkGps.Checked)
            {
                tarifa += 100;
            }

            int dias = Convert.ToInt32(nudDias.Value);
            decimal totalLinea = tarifa * dias;
            subtotal += totalLinea;

            string seguro = rbtCompleto.Checked ? "Completo" : "Básico";
            lstAlquileres.Items.Add($"{dias}  {vehiculo} ({seguro})  {tarifa:0.00}  {totalLinea:0.00}");

            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo antes de calcular el total.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal descuento = chkCorporativo.Checked ? subtotal * 0.15m : 0m;
            decimal domicilio = rbtDomicilio.Checked ? 500m : 0m;
            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            lblDescuento.Text = $"RD$ {descuento:0.00}";
            lblDomicilio.Text = $"RD$ {domicilio:0.00}";
            lblItbis.Text = $"RD$ {itbis:0.00}";
            lblTotal.Text = $"RD$ {total:0.00}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            subtotal = 0m;
            lstAlquileres.Items.Clear();

            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Today;

            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            rbtSucursal.Checked = true;

            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
