namespace AyDdS1_DocScreen
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCAIntervalo = new System.Windows.Forms.TextBox();
            this.txtCACantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCARetardo = new System.Windows.Forms.TextBox();
            this.btnCAIniciar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMRetardo = new System.Windows.Forms.TextBox();
            this.btnCMTomar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCAIniciar);
            this.groupBox1.Controls.Add(this.txtCARetardo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCACantidad);
            this.groupBox1.Controls.Add(this.txtCAIntervalo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura Automática";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intervalo (segundos)";
            // 
            // txtCAIntervalo
            // 
            this.txtCAIntervalo.Location = new System.Drawing.Point(114, 46);
            this.txtCAIntervalo.Name = "txtCAIntervalo";
            this.txtCAIntervalo.Size = new System.Drawing.Size(100, 20);
            this.txtCAIntervalo.TabIndex = 1;
            // 
            // txtCACantidad
            // 
            this.txtCACantidad.Location = new System.Drawing.Point(21, 46);
            this.txtCACantidad.Name = "txtCACantidad";
            this.txtCACantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCACantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Retardo de inicio";
            // 
            // txtCARetardo
            // 
            this.txtCARetardo.Location = new System.Drawing.Point(21, 102);
            this.txtCARetardo.Name = "txtCARetardo";
            this.txtCARetardo.Size = new System.Drawing.Size(100, 20);
            this.txtCARetardo.TabIndex = 5;
            // 
            // btnCAIniciar
            // 
            this.btnCAIniciar.Location = new System.Drawing.Point(139, 99);
            this.btnCAIniciar.Name = "btnCAIniciar";
            this.btnCAIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnCAIniciar.TabIndex = 6;
            this.btnCAIniciar.Text = "Iniciar";
            this.btnCAIniciar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCMTomar);
            this.groupBox2.Controls.Add(this.txtCMRetardo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Captura Manual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Retardo de Inicio";
            // 
            // txtCMRetardo
            // 
            this.txtCMRetardo.Location = new System.Drawing.Point(17, 48);
            this.txtCMRetardo.Name = "txtCMRetardo";
            this.txtCMRetardo.Size = new System.Drawing.Size(100, 20);
            this.txtCMRetardo.TabIndex = 1;
            // 
            // btnCMTomar
            // 
            this.btnCMTomar.Location = new System.Drawing.Point(135, 45);
            this.btnCMTomar.Name = "btnCMTomar";
            this.btnCMTomar.Size = new System.Drawing.Size(75, 23);
            this.btnCMTomar.TabIndex = 2;
            this.btnCMTomar.Text = "Tomar";
            this.btnCMTomar.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaPrincipal";
            this.Text = "DocScreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCAIniciar;
        private System.Windows.Forms.TextBox txtCARetardo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCACantidad;
        private System.Windows.Forms.TextBox txtCAIntervalo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCMTomar;
        private System.Windows.Forms.TextBox txtCMRetardo;
        private System.Windows.Forms.Label label4;
    }
}

