namespace Msg
{
    partial class Notificacion
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.pImagen = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.pbSuc = new System.Windows.Forms.PictureBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.pImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.White;
            this.pPrincipal.Controls.Add(this.lblMsg);
            this.pPrincipal.Controls.Add(this.lblTitulo);
            this.pPrincipal.Controls.Add(this.btnCerrar);
            this.pPrincipal.Controls.Add(this.pRight);
            this.pPrincipal.Location = new System.Drawing.Point(61, 1);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(410, 123);
            this.pPrincipal.TabIndex = 0;
            // 
            // pImagen
            // 
            this.pImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pImagen.Controls.Add(this.pbDel);
            this.pImagen.Controls.Add(this.pbInfo);
            this.pImagen.Controls.Add(this.pbSuc);
            this.pImagen.Controls.Add(this.lblImagen);
            this.pImagen.Location = new System.Drawing.Point(1, 27);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(182, 69);
            this.pImagen.TabIndex = 0;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(403, 0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(7, 123);
            this.pRight.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(379, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 28);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(128, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 23);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblMsg.Location = new System.Drawing.Point(126, 54);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(274, 61);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.White;
            this.lblImagen.Location = new System.Drawing.Point(65, 23);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(111, 23);
            this.lblImagen.TabIndex = 4;
            this.lblImagen.Text = "Actualizado";
            // 
            // pbSuc
            // 
            this.pbSuc.Image = global::Msg.Properties.Resources.sucbl;
            this.pbSuc.Location = new System.Drawing.Point(2, 4);
            this.pbSuc.Name = "pbSuc";
            this.pbSuc.Size = new System.Drawing.Size(60, 60);
            this.pbSuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuc.TabIndex = 4;
            this.pbSuc.TabStop = false;
            // 
            // pbInfo
            // 
            this.pbInfo.Image = global::Msg.Properties.Resources.infobl;
            this.pbInfo.Location = new System.Drawing.Point(2, 4);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(60, 60);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 5;
            this.pbInfo.TabStop = false;
            // 
            // pbDel
            // 
            this.pbDel.Image = global::Msg.Properties.Resources.delbl;
            this.pbDel.Location = new System.Drawing.Point(2, 4);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(60, 60);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 6;
            this.pbDel.TabStop = false;
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(472, 125);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notificacion";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.pImagen.ResumeLayout(false);
            this.pImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.PictureBox pbSuc;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbInfo;
    }
}