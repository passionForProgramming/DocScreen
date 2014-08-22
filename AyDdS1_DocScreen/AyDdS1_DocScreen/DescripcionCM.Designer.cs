namespace AyDdS1_DocScreen
{
    partial class DescripcionCM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloCM = new System.Windows.Forms.TextBox();
            this.txtDescripcionCM = new System.Windows.Forms.TextBox();
            this.btnCMDescGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // txtTituloCM
            // 
            this.txtTituloCM.Location = new System.Drawing.Point(106, 6);
            this.txtTituloCM.Name = "txtTituloCM";
            this.txtTituloCM.Size = new System.Drawing.Size(371, 20);
            this.txtTituloCM.TabIndex = 2;
            // 
            // txtDescripcionCM
            // 
            this.txtDescripcionCM.Location = new System.Drawing.Point(106, 48);
            this.txtDescripcionCM.Multiline = true;
            this.txtDescripcionCM.Name = "txtDescripcionCM";
            this.txtDescripcionCM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcionCM.Size = new System.Drawing.Size(371, 109);
            this.txtDescripcionCM.TabIndex = 3;
            // 
            // btnCMDescGuardar
            // 
            this.btnCMDescGuardar.Location = new System.Drawing.Point(106, 173);
            this.btnCMDescGuardar.Name = "btnCMDescGuardar";
            this.btnCMDescGuardar.Size = new System.Drawing.Size(371, 29);
            this.btnCMDescGuardar.TabIndex = 4;
            this.btnCMDescGuardar.Text = "Guardar";
            this.btnCMDescGuardar.UseVisualStyleBackColor = true;
            this.btnCMDescGuardar.Click += new System.EventHandler(this.btnCMDescGuardar_Click);
            // 
            // DescripcionCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 214);
            this.ControlBox = false;
            this.Controls.Add(this.btnCMDescGuardar);
            this.Controls.Add(this.txtDescripcionCM);
            this.Controls.Add(this.txtTituloCM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DescripcionCM";
            this.Text = "DescripcionCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloCM;
        private System.Windows.Forms.TextBox txtDescripcionCM;
        private System.Windows.Forms.Button btnCMDescGuardar;
    }
}