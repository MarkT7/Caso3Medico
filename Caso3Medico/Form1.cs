using MedicoLibreria;

namespace Caso3Medico
{
    public partial class Form1 : Form
    {
        Paciente paciente1 = null;
        Medico medico1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            paciente1 = new Paciente();
            medico1 = new Medico();
        }

        private void btnMedicoToString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(medico1.ToString());
        }

        private void btnPacienteToString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(paciente1.ToString());
        }
    }
}