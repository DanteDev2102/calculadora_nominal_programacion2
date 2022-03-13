namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double sueldoBase = Convert.ToDouble(textBox_sueldoBase.Text);
                int horasTrabajadas = Convert.ToInt32(textBox_horasTrabajadas.Text);
                double nuevoSueldo;


                if (horasTrabajadas >= 20 && horasTrabajadas <= 30)
                {
                    nuevoSueldo = sueldoBase * horasTrabajadas;
                    nuevoSueldo *= 1.10;
                }
                else if (horasTrabajadas > 30 && horasTrabajadas <= 40)
                {
                    nuevoSueldo = sueldoBase * horasTrabajadas;
                    nuevoSueldo *= 1.20;
                }
                else if (horasTrabajadas > 40)
                {
                    nuevoSueldo = sueldoBase * horasTrabajadas;
                    nuevoSueldo *= 1.30;
                }
                else
                {
                    nuevoSueldo = sueldoBase * horasTrabajadas;
                }

                textBox_sueldoNuevo.Text = nuevoSueldo.ToString();
            }
            catch
            {
                textBox_sueldoNuevo.Text = "ERROR";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_sueldoNuevo.Clear();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label_sueldo_Click(object sender, EventArgs e) { }
        private void groupBox_nomina_Enter(object sender, EventArgs e) { }
        private void label_sueldoNuevo_Click(object sender, EventArgs e) { }
    }
}

/*
 * TAREA:
 * 
 * - validar que solo acepte numeros (ambos)
 * - en este seleccionar rangos de hora por medio de radio btn
 * - en el primero usar gomobox para reemplazar los botones
 */