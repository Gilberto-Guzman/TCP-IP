namespace ClientAPP
{
    partial class Cliente
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
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Puerto = new System.Windows.Forms.Label();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conectar.Location = new System.Drawing.Point(21, 399);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(118, 40);
            this.btn_Conectar.TabIndex = 10;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Location = new System.Drawing.Point(21, 97);
            this.txt_Mensaje.Multiline = true;
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(214, 184);
            this.txt_Mensaje.TabIndex = 11;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Location = new System.Drawing.Point(145, 399);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(90, 42);
            this.btn_Enviar.TabIndex = 12;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(21, 298);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(214, 95);
            this.txt_Status.TabIndex = 13;
            // 
            // lbl_Puerto
            // 
            this.lbl_Puerto.AutoSize = true;
            this.lbl_Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Puerto.Location = new System.Drawing.Point(16, 56);
            this.lbl_Puerto.Name = "lbl_Puerto";
            this.lbl_Puerto.Size = new System.Drawing.Size(90, 29);
            this.lbl_Puerto.TabIndex = 15;
            this.lbl_Puerto.Text = "Puerto:";
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Host.Location = new System.Drawing.Point(38, 18);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(68, 29);
            this.lbl_Host.TabIndex = 14;
            this.lbl_Host.Text = "Host:";
            // 
            // txt_Host
            // 
            this.txt_Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Host.Location = new System.Drawing.Point(112, 15);
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(123, 35);
            this.txt_Host.TabIndex = 7;
            this.txt_Host.Text = "127.0.0.1";
            // 
            // txt_Port
            // 
            this.txt_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port.Location = new System.Drawing.Point(112, 56);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(123, 35);
            this.txt_Port.TabIndex = 9;
            this.txt_Port.Text = "8910";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 450);
            this.Controls.Add(this.lbl_Puerto);
            this.Controls.Add(this.lbl_Host);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Host);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.TextBox txt_Mensaje;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Puerto;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.TextBox txt_Port;
    }
}

