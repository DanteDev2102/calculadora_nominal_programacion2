namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_nomina = new System.Windows.Forms.GroupBox();
            this.radioButton_mas40 = new System.Windows.Forms.RadioButton();
            this.radioButton_entre30y40 = new System.Windows.Forms.RadioButton();
            this.radioButton_entre20y30 = new System.Windows.Forms.RadioButton();
            this.radioButton_menor20 = new System.Windows.Forms.RadioButton();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.textBox_sueldoBase = new System.Windows.Forms.TextBox();
            this.label_horasTrabajadas = new System.Windows.Forms.Label();
            this.label_sueldo = new System.Windows.Forms.Label();
            this.textBox_sueldoNuevo = new System.Windows.Forms.TextBox();
            this.label_sueldoNuevo = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox_nomina.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_nomina
            // 
            this.groupBox_nomina.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_nomina.Controls.Add(this.radioButton_mas40);
            this.groupBox_nomina.Controls.Add(this.radioButton_entre30y40);
            this.groupBox_nomina.Controls.Add(this.radioButton_entre20y30);
            this.groupBox_nomina.Controls.Add(this.radioButton_menor20);
            this.groupBox_nomina.Controls.Add(this.btn_calcular);
            this.groupBox_nomina.Controls.Add(this.textBox_sueldoBase);
            this.groupBox_nomina.Controls.Add(this.label_horasTrabajadas);
            this.groupBox_nomina.Controls.Add(this.label_sueldo);
            this.groupBox_nomina.Location = new System.Drawing.Point(256, 40);
            this.groupBox_nomina.Name = "groupBox_nomina";
            this.groupBox_nomina.Size = new System.Drawing.Size(331, 268);
            this.groupBox_nomina.TabIndex = 0;
            this.groupBox_nomina.TabStop = false;
            this.groupBox_nomina.Text = "nomina";
            // 
            // radioButton_mas40
            // 
            this.radioButton_mas40.AutoSize = true;
            this.radioButton_mas40.Location = new System.Drawing.Point(226, 153);
            this.radioButton_mas40.Name = "radioButton_mas40";
            this.radioButton_mas40.Size = new System.Drawing.Size(78, 19);
            this.radioButton_mas40.TabIndex = 8;
            this.radioButton_mas40.TabStop = true;
            this.radioButton_mas40.Text = "mas de 40";
            this.radioButton_mas40.UseVisualStyleBackColor = true;
            this.radioButton_mas40.CheckedChanged += new System.EventHandler(this.radioButton_mas40_CheckedChanged);
            // 
            // radioButton_entre30y40
            // 
            this.radioButton_entre30y40.AutoSize = true;
            this.radioButton_entre30y40.Location = new System.Drawing.Point(128, 149);
            this.radioButton_entre30y40.Name = "radioButton_entre30y40";
            this.radioButton_entre30y40.Size = new System.Drawing.Size(91, 19);
            this.radioButton_entre30y40.TabIndex = 7;
            this.radioButton_entre30y40.TabStop = true;
            this.radioButton_entre30y40.Text = "entre 30 y 40";
            this.radioButton_entre30y40.UseVisualStyleBackColor = true;
            this.radioButton_entre30y40.CheckedChanged += new System.EventHandler(this.radioButton_entre30y40_CheckedChanged);
            // 
            // radioButton_entre20y30
            // 
            this.radioButton_entre20y30.AutoSize = true;
            this.radioButton_entre20y30.Location = new System.Drawing.Point(226, 96);
            this.radioButton_entre20y30.Name = "radioButton_entre20y30";
            this.radioButton_entre20y30.Size = new System.Drawing.Size(91, 19);
            this.radioButton_entre20y30.TabIndex = 6;
            this.radioButton_entre20y30.TabStop = true;
            this.radioButton_entre20y30.Text = "entre 20 y 30";
            this.radioButton_entre20y30.UseVisualStyleBackColor = true;
            this.radioButton_entre20y30.CheckedChanged += new System.EventHandler(this.radioButton_entre20y30_CheckedChanged);
            // 
            // radioButton_menor20
            // 
            this.radioButton_menor20.AutoSize = true;
            this.radioButton_menor20.Location = new System.Drawing.Point(128, 96);
            this.radioButton_menor20.Name = "radioButton_menor20";
            this.radioButton_menor20.Size = new System.Drawing.Size(92, 19);
            this.radioButton_menor20.TabIndex = 5;
            this.radioButton_menor20.Text = "menos de 20";
            this.radioButton_menor20.UseVisualStyleBackColor = true;
            this.radioButton_menor20.CheckedChanged += new System.EventHandler(this.radioButton_menor20_CheckedChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(128, 199);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // textBox_sueldoBase
            // 
            this.textBox_sueldoBase.Location = new System.Drawing.Point(122, 41);
            this.textBox_sueldoBase.Name = "textBox_sueldoBase";
            this.textBox_sueldoBase.Size = new System.Drawing.Size(181, 23);
            this.textBox_sueldoBase.TabIndex = 2;
            this.textBox_sueldoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sueldoBase_KeyPress);
            // 
            // label_horasTrabajadas
            // 
            this.label_horasTrabajadas.AutoSize = true;
            this.label_horasTrabajadas.Location = new System.Drawing.Point(21, 96);
            this.label_horasTrabajadas.Name = "label_horasTrabajadas";
            this.label_horasTrabajadas.Size = new System.Drawing.Size(96, 15);
            this.label_horasTrabajadas.TabIndex = 1;
            this.label_horasTrabajadas.Text = "horas trabajadas:";
            // 
            // label_sueldo
            // 
            this.label_sueldo.AutoSize = true;
            this.label_sueldo.Location = new System.Drawing.Point(21, 41);
            this.label_sueldo.Name = "label_sueldo";
            this.label_sueldo.Size = new System.Drawing.Size(72, 15);
            this.label_sueldo.TabIndex = 0;
            this.label_sueldo.Text = "sueldo base:";
            // 
            // textBox_sueldoNuevo
            // 
            this.textBox_sueldoNuevo.Location = new System.Drawing.Point(379, 325);
            this.textBox_sueldoNuevo.Name = "textBox_sueldoNuevo";
            this.textBox_sueldoNuevo.Size = new System.Drawing.Size(100, 23);
            this.textBox_sueldoNuevo.TabIndex = 4;
            // 
            // label_sueldoNuevo
            // 
            this.label_sueldoNuevo.AutoSize = true;
            this.label_sueldoNuevo.Location = new System.Drawing.Point(265, 325);
            this.label_sueldoNuevo.Name = "label_sueldoNuevo";
            this.label_sueldoNuevo.Size = new System.Drawing.Size(84, 15);
            this.label_sueldoNuevo.TabIndex = 5;
            this.label_sueldoNuevo.Text = "sueldo  nuevo:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(378, 375);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label_sueldoNuevo);
            this.Controls.Add(this.textBox_sueldoNuevo);
            this.Controls.Add(this.groupBox_nomina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_nomina.ResumeLayout(false);
            this.groupBox_nomina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_nomina;
        private Label label_horasTrabajadas;
        private Label label_sueldo;
        private TextBox textBox_sueldoBase;
        private TextBox textBox_sueldoNuevo;
        private Label label_sueldoNuevo;
        private Button btn_calcular;
        private Button btn_clear;
        private RadioButton radioButton_mas40;
        private RadioButton radioButton_entre30y40;
        private RadioButton radioButton_entre20y30;
        private RadioButton radioButton_menor20;
    }
}