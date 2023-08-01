
namespace Punto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.chkFestivo = new System.Windows.Forms.CheckBox();
            this.chkQuincena = new System.Windows.Forms.CheckBox();
            this.grbPagar = new System.Windows.Forms.GroupBox();
            this.lbTotalPag = new System.Windows.Forms.Label();
            this.lbTotalJamon = new System.Windows.Forms.Label();
            this.lbCantAdicional = new System.Windows.Forms.Label();
            this.lbCantNormal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grbPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Jamon Cafeteria Mi U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el dia de la semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el tipo de dia:";
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "1. Lunes",
            "2. Martes",
            "3. Miercoles",
            "4. Jueves",
            "5. Viernes",
            "6. Sabado"});
            this.cbDia.Location = new System.Drawing.Point(379, 84);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 3;
            // 
            // chkFestivo
            // 
            this.chkFestivo.AutoSize = true;
            this.chkFestivo.Location = new System.Drawing.Point(379, 126);
            this.chkFestivo.Name = "chkFestivo";
            this.chkFestivo.Size = new System.Drawing.Size(60, 17);
            this.chkFestivo.TabIndex = 4;
            this.chkFestivo.Text = "Festivo";
            this.chkFestivo.UseVisualStyleBackColor = true;
            // 
            // chkQuincena
            // 
            this.chkQuincena.AutoSize = true;
            this.chkQuincena.Location = new System.Drawing.Point(379, 149);
            this.chkQuincena.Name = "chkQuincena";
            this.chkQuincena.Size = new System.Drawing.Size(72, 17);
            this.chkQuincena.TabIndex = 5;
            this.chkQuincena.Text = "Quincena";
            this.chkQuincena.UseVisualStyleBackColor = true;
            // 
            // grbPagar
            // 
            this.grbPagar.Controls.Add(this.lbTotalPag);
            this.grbPagar.Controls.Add(this.lbTotalJamon);
            this.grbPagar.Controls.Add(this.lbCantAdicional);
            this.grbPagar.Controls.Add(this.lbCantNormal);
            this.grbPagar.Controls.Add(this.label7);
            this.grbPagar.Controls.Add(this.label6);
            this.grbPagar.Controls.Add(this.label5);
            this.grbPagar.Controls.Add(this.label4);
            this.grbPagar.Location = new System.Drawing.Point(143, 172);
            this.grbPagar.Name = "grbPagar";
            this.grbPagar.Size = new System.Drawing.Size(459, 164);
            this.grbPagar.TabIndex = 7;
            this.grbPagar.TabStop = false;
            this.grbPagar.Text = "A pagar:";
            // 
            // lbTotalPag
            // 
            this.lbTotalPag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalPag.Location = new System.Drawing.Point(246, 123);
            this.lbTotalPag.Name = "lbTotalPag";
            this.lbTotalPag.Size = new System.Drawing.Size(100, 23);
            this.lbTotalPag.TabIndex = 7;
            // 
            // lbTotalJamon
            // 
            this.lbTotalJamon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalJamon.Location = new System.Drawing.Point(246, 94);
            this.lbTotalJamon.Name = "lbTotalJamon";
            this.lbTotalJamon.Size = new System.Drawing.Size(100, 23);
            this.lbTotalJamon.TabIndex = 6;
            // 
            // lbCantAdicional
            // 
            this.lbCantAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCantAdicional.Location = new System.Drawing.Point(246, 62);
            this.lbCantAdicional.Name = "lbCantAdicional";
            this.lbCantAdicional.Size = new System.Drawing.Size(100, 23);
            this.lbCantAdicional.TabIndex = 5;
            // 
            // lbCantNormal
            // 
            this.lbCantNormal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCantNormal.Location = new System.Drawing.Point(246, 29);
            this.lbCantNormal.Name = "lbCantNormal";
            this.lbCantNormal.Size = new System.Drawing.Size(100, 23);
            this.lbCantNormal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Valor Total a Pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Jamon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad Adicional:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad Normal:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(179, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 39);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(317, 357);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 39);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(455, 357);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(95, 39);
            this.btnTerminar.TabIndex = 10;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(765, 430);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbPagar);
            this.Controls.Add(this.chkQuincena);
            this.Controls.Add(this.chkFestivo);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Jamon ITM";
            this.grbPagar.ResumeLayout(false);
            this.grbPagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.CheckBox chkFestivo;
        private System.Windows.Forms.CheckBox chkQuincena;
        private System.Windows.Forms.GroupBox grbPagar;
        private System.Windows.Forms.Label lbTotalPag;
        private System.Windows.Forms.Label lbTotalJamon;
        private System.Windows.Forms.Label lbCantAdicional;
        private System.Windows.Forms.Label lbCantNormal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnTerminar;
    }
}

