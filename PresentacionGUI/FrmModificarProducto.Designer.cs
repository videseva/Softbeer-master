namespace PresentacionGUI
{
    partial class FrmModificarProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PnlDeInfoGeneral = new System.Windows.Forms.Panel();
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.TxtPrecioCosto = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PnlDeInfoGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 34);
            this.panel1.TabIndex = 4;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.Location = new System.Drawing.Point(353, -2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(95, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "MODIFICAR PRODUCTO";
            // 
            // PnlDeInfoGeneral
            // 
            this.PnlDeInfoGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlDeInfoGeneral.Controls.Add(this.BtnModificarProducto);
            this.PnlDeInfoGeneral.Controls.Add(this.BtnLimpiarCampos);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtPrecioCosto);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtPrecioVenta);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNombre);
            this.PnlDeInfoGeneral.Controls.Add(this.label4);
            this.PnlDeInfoGeneral.Controls.Add(this.label3);
            this.PnlDeInfoGeneral.Controls.Add(this.label2);
            this.PnlDeInfoGeneral.Location = new System.Drawing.Point(-5, 33);
            this.PnlDeInfoGeneral.Name = "PnlDeInfoGeneral";
            this.PnlDeInfoGeneral.Size = new System.Drawing.Size(387, 228);
            this.PnlDeInfoGeneral.TabIndex = 3;
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(152)))), ((int)(((byte)(242)))));
            this.BtnModificarProducto.FlatAppearance.BorderSize = 0;
            this.BtnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnModificarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnModificarProducto.Image = global::PresentacionGUI.Properties.Resources.save_24;
            this.BtnModificarProducto.Location = new System.Drawing.Point(309, 83);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(41, 41);
            this.BtnModificarProducto.TabIndex = 64;
            this.BtnModificarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificarProducto.UseVisualStyleBackColor = false;
            this.BtnModificarProducto.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.BtnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiarCampos.Image = global::PresentacionGUI.Properties.Resources.refresh_32;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(309, 28);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(41, 40);
            this.BtnLimpiarCampos.TabIndex = 63;
            this.BtnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // TxtPrecioCosto
            // 
            this.TxtPrecioCosto.Location = new System.Drawing.Point(110, 102);
            this.TxtPrecioCosto.Name = "TxtPrecioCosto";
            this.TxtPrecioCosto.Size = new System.Drawing.Size(161, 20);
            this.TxtPrecioCosto.TabIndex = 29;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(110, 74);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(161, 20);
            this.TxtPrecioVenta.TabIndex = 28;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(110, 46);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Precio venta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio costo :";
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlDeInfoGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlDeInfoGeneral.ResumeLayout(false);
            this.PnlDeInfoGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PnlDeInfoGeneral;
        private System.Windows.Forms.TextBox TxtPrecioCosto;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Button BtnModificarProducto;
        private System.Windows.Forms.Button BtnCerrar;
    }
}