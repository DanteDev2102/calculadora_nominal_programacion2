namespace test
{
    public partial class Form1 : Form
    {
        private double aumento;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double sueldo = Convert.ToDouble(textBox_sueldoBase.Text);

                if (sueldo == 0)
                {
                    sueldo += sueldo * aumento;
                    textBox_sueldoNuevo.Text = sueldo.ToString();
                }
                else
                {
                    textBox_sueldoBase.Text = "ingresa un sueldo valido";
                }
            }
            catch
            {
                textBox_sueldoNuevo.Text = "ERROR";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_sueldoNuevo.Clear();
            textBox_sueldoBase.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_sueldoNuevo.ReadOnly = true;
        }

        private void radioButton_menor20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_menor20.Checked)
            {
                aumento = 0;
            }
        }

        private void radioButton_entre20y30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_entre20y30.Checked)
            {
                aumento = 0.1;
            }
        }

        private void radioButton_entre30y40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_entre30y40.Checked)
            {
                aumento = 0.2;
            }
        }

        private void radioButton_mas40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mas40.Checked)
            {
                aumento = 0.3;
            }
        }

        private void textBox_sueldoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(soloNumeros(e.KeyChar));
            if (e.KeyChar == 0)
            {
                if (counter >= 5 && counter < 10)
                {
                    MessageBox.Show("ingresa un numero la concha de la lora");
                    counter++;
                }
                else if (counter >= 10)
                {
                    MessageBox.Show("anda morite");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ingresa un numero, por favor :3");
                    counter++;
                }

            }

        }
        public int soloNumeros(int tecla)
        {
            return tecla switch
            {
                08 or
                46 or
                48 or
                49 or
                50 or
                51 or
                52 or
                53 or
                54 or
                55 or
                56 or
                57 or
                127 => tecla,
                _ => 0,
            };
        }
    }
}