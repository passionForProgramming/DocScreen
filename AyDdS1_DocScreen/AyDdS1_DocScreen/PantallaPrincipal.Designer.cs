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
            this.numCACantidad = new System.Windows.Forms.NumericUpDown();
            this.numCAIntervalo = new System.Windows.Forms.NumericUpDown();
            this.numCARetardo = new System.Windows.Forms.NumericUpDown();
            this.btnCAIniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCMRetardo = new System.Windows.Forms.NumericUpDown();
            this.btnCMTomar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCACantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCAIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCARetardo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCMRetardo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numCACantidad);
            this.groupBox1.Controls.Add(this.numCAIntervalo);
            this.groupBox1.Controls.Add(this.numCARetardo);
            this.groupBox1.Controls.Add(this.btnCAIniciar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Captura Automática";
            // 
            // numCACantidad
            // 
            this.numCACantidad.Location = new System.Drawing.Point(21, 44);
            this.numCACantidad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCACantidad.Name = "numCACantidad";
            this.numCACantidad.Size = new System.Drawing.Size(84, 20);
            this.numCACantidad.TabIndex = 9;
            this.numCACantidad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numCAIntervalo
            // 
            this.numCAIntervalo.Location = new System.Drawing.Point(114, 45);
            this.numCAIntervalo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCAIntervalo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCAIntervalo.Name = "numCAIntervalo";
            this.numCAIntervalo.Size = new System.Drawing.Size(100, 20);
            this.numCAIntervalo.TabIndex = 8;
            this.numCAIntervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCARetardo
            // 
            this.numCARetardo.Location = new System.Drawing.Point(21, 102);
            this.numCARetardo.Name = "numCARetardo";
            this.numCARetardo.Size = new System.Drawing.Size(100, 20);
            this.numCARetardo.TabIndex = 7;
            this.numCARetardo.ValueChanged += new System.EventHandler(this.numCARetardo_ValueChanged);
            // 
            // btnCAIniciar
            // 
            this.btnCAIniciar.Location = new System.Drawing.Point(139, 99);
            this.btnCAIniciar.Name = "btnCAIniciar";
            this.btnCAIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnCAIniciar.TabIndex = 6;
            this.btnCAIniciar.Text = "Iniciar";
            this.btnCAIniciar.UseVisualStyleBackColor = true;
            this.btnCAIniciar.Click += new System.EventHandler(this.btnCAIniciar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCMRetardo);
            this.groupBox2.Controls.Add(this.btnCMTomar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Captura Manual";
            // 
            // numCMRetardo
            // 
            this.numCMRetardo.Location = new System.Drawing.Point(17, 47);
            this.numCMRetardo.Name = "numCMRetardo";
            this.numCMRetardo.Size = new System.Drawing.Size(100, 20);
            this.numCMRetardo.TabIndex = 3;
            this.numCMRetardo.ValueChanged += new System.EventHandler(this.numCMRetardo_ValueChanged);
            // 
            // btnCMTomar
            // 
            this.btnCMTomar.Location = new System.Drawing.Point(135, 45);
            this.btnCMTomar.Name = "btnCMTomar";
            this.btnCMTomar.Size = new System.Drawing.Size(75, 23);
            this.btnCMTomar.TabIndex = 2;
            this.btnCMTomar.Text = "Tomar";
            this.btnCMTomar.UseVisualStyleBackColor = true;
            this.btnCMTomar.Click += new System.EventHandler(this.btnCMTomar_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.numCACantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCAIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCARetardo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCMRetardo)).EndInit();
            this.ResumeLayout(false);

        }

        private void numCARetardo_ValueChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void numCMRetardo_ValueChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCAIniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCMTomar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCARetardo;
        private System.Windows.Forms.NumericUpDown numCMRetardo;
        private System.Windows.Forms.NumericUpDown numCAIntervalo;
        private System.Windows.Forms.NumericUpDown numCACantidad;
    }
}

