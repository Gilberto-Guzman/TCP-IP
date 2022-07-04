namespace TCPIP
{
    partial class Servidor
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
            this.lbl_Host = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.lbl_Puerto = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Detener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Host.Location = new System.Drawing.Point(36, 18);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(68, 29);
            this.lbl_Host.TabIndex = 0;
            this.lbl_Host.Text = "Host:";
            // 
            // txthost
            // 
            this.txthost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthost.Location = new System.Drawing.Point(112, 12);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(111, 35);
            this.txthost.TabIndex = 1;
            this.txthost.Text = "127.0.0.1";
            // 
            // lbl_Puerto
            // 
            this.lbl_Puerto.AutoSize = true;
            this.lbl_Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puerto.Location = new System.Drawing.Point(14, 58);
            this.lbl_Puerto.Name = "lbl_Puerto";
            this.lbl_Puerto.Size = new System.Drawing.Size(90, 29);
            this.lbl_Puerto.TabIndex = 2;
            this.lbl_Puerto.Text = "Puerto:";
            // 
            // txt_Port
            // 
            this.txt_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port.Location = new System.Drawing.Point(112, 58);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(111, 35);
            this.txt_Port.TabIndex = 3;
            this.txt_Port.Text = "8910";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(19, 99);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(204, 135);
            this.txt_Status.TabIndex = 4;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.Location = new System.Drawing.Point(19, 255);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(85, 47);
            this.btn_Iniciar.TabIndex = 5;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Detener
            // 
            this.btn_Detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detener.Location = new System.Drawing.Point(112, 255);
            this.btn_Detener.Name = "btn_Detener";
            this.btn_Detener.Size = new System.Drawing.Size(111, 47);
            this.btn_Detener.TabIndex = 6;
            this.btn_Detener.Text = "Detener";
            this.btn_Detener.UseVisualStyleBackColor = true;
            this.btn_Detener.Click += new System.EventHandler(this.btn_Detener_Click);
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 320);
            this.Controls.Add(this.btn_Detener);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.lbl_Puerto);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.lbl_Host);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label lbl_Puerto;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Detener;
    }
}

