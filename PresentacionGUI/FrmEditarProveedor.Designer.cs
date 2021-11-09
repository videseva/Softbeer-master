namespace PresentacionGUI
{
    partial class FrmEditarProveedor
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
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNombre2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNitEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 34);
            this.panel1.TabIndex = 6;
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
            this.label7.Location = new System.Drawing.Point(87, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "MODIFICAR PROVEEDOR";
            // 
            // PnlDeInfoGeneral
            // 
            this.PnlDeInfoGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlDeInfoGeneral.Controls.Add(this.TxtEmpresa);
            this.PnlDeInfoGeneral.Controls.Add(this.label5);
            this.PnlDeInfoGeneral.Controls.Add(this.BtnEditar);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtCorreo);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtApellido2);
            this.PnlDeInfoGeneral.Controls.Add(this.label10);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtApellido1);
            this.PnlDeInfoGeneral.Controls.Add(this.label11);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNombre2);
            this.PnlDeInfoGeneral.Controls.Add(this.label9);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNombre1);
            this.PnlDeInfoGeneral.Controls.Add(this.label4);
            this.PnlDeInfoGeneral.Controls.Add(this.label8);
            this.PnlDeInfoGeneral.Controls.Add(this.BtnLimpiarCampos);
            this.PnlDeInfoGeneral.Controls.Add(this.label6);
            this.PnlDeInfoGeneral.Controls.Add(this.CmbGenero);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtTelefono);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNitEmpresa);
            this.PnlDeInfoGeneral.Controls.Add(this.label3);
            this.PnlDeInfoGeneral.Controls.Add(this.label2);
            this.PnlDeInfoGeneral.Controls.Add(this.label1);
            this.PnlDeInfoGeneral.Location = new System.Drawing.Point(0, 34);
            this.PnlDeInfoGeneral.Name = "PnlDeInfoGeneral";
            this.PnlDeInfoGeneral.Size = new System.Drawing.Size(387, 273);
            this.PnlDeInfoGeneral.TabIndex = 5;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(138, 232);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(161, 20);
            this.TxtEmpresa.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Empresa : ";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(152)))), ((int)(((byte)(242)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.Image = global::PresentacionGUI.Properties.Resources.pencil_2_24;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.Location = new System.Drawing.Point(309, 117);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(41, 38);
            this.BtnEditar.TabIndex = 75;
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(138, 157);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(161, 20);
            this.TxtCorreo.TabIndex = 74;
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(138, 106);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(161, 20);
            this.TxtApellido2.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 72;
            this.label10.Text = "Segundo nombre :";
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(138, 82);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(161, 20);
            this.TxtApellido1.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "Primer apellido :";
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.Location = new System.Drawing.Point(138, 59);
            this.TxtNombre2.Name = "TxtNombre2";
            this.TxtNombre2.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre2.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Segundo nombre :";
            // 
            // TxtNombre1
            // 
            this.TxtNombre1.Location = new System.Drawing.Point(138, 35);
            this.TxtNombre1.Name = "TxtNombre1";
            this.TxtNombre1.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre1.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Primer nombre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(34, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Ingrese la nueva informacion de su proveedor :";
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.BtnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiarCampos.Image = global::PresentacionGUI.Properties.Resources.refresh_32;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(309, 68);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(41, 40);
            this.BtnLimpiarCampos.TabIndex = 63;
            this.BtnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Correo :";
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(138, 129);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(161, 21);
            this.CmbGenero.TabIndex = 30;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(138, 182);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(161, 20);
            this.TxtTelefono.TabIndex = 29;
            // 
            // TxtNitEmpresa
            // 
            this.TxtNitEmpresa.Location = new System.Drawing.Point(138, 207);
            this.TxtNitEmpresa.Name = "TxtNitEmpresa";
            this.TxtNitEmpresa.Size = new System.Drawing.Size(161, 20);
            this.TxtNitEmpresa.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nit de la empresa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefono :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Genero :";
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlDeInfoGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarProveedor";
            this.Load += new System.EventHandler(this.FrmEditarProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlDeInfoGeneral.ResumeLayout(false);
            this.PnlDeInfoGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PnlDeInfoGeneral;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNitEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNombre2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.Label label5;
    }
}