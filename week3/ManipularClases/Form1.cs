namespace ManipularClases
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Extranjero");
        }

        private void btnIngresar_Click(object sender, EventArgs e) // onClick -> INGRESAR
        {
            var postulante = new Postulante(
                txtNombre.Text,
                txtApellido.Text,
                cboTipo.Text,
                int.Parse(
                    txtDocumento.Text
                )
            );

            MessageBox.Show(
                postulante.toString(),
                "DATOS INGRESADOS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
