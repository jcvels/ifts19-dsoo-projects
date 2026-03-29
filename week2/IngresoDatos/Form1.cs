namespace IngresoDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e) // onClick -> ACEPTAR
        {
            MessageBox.Show(
                "Dato 1 = " + txtDato1.Text + "\nDato 2 = " + txtDato2.Text,
                "DATOS INGESADOS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );

            string datoUno = Convert.ToString(
                Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresar Dato 1",
                    "DATO UNO",
                    ""
                )
            );

            string datoDos = Convert.ToString(
                Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresar Dato 2",
                    "DATO DOS",
                    ""
                )
            );

            MessageBox.Show(
                "Dato 1 = " + datoUno + "\nDato 2 = " + datoDos,
                "DATOS INGESADOS DESDE CUADO DE DIALOGO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                )
            ;
        }

        private void btnCalculo_Click(object sender, EventArgs e) // onClick -> CALCULO
        {
            int numeroUno = Convert.ToInt32(
                Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresar Numero 1",
                    "Numero Uno",
                    ""
                )
            );

            int numeroDos = Convert.ToInt32(
                Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresar Numero 2",
                    "Numero Dos",
                    ""
                )
            );

            string elMayor = string.Empty;

            if (numeroUno > numeroDos)
            {
                elMayor = "UNO";
            }
            else
            {
                elMayor = "DOS";
            }

            MessageBox.Show(
                "El numero " + elMayor + " es el mayor",
                "NUMERO MAYOR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }
    }
}
