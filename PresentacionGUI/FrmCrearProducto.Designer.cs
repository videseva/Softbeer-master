namespace PresentacionGUI
{
    partial class FrmCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearProducto));
            this.PnlDeInfoGeneral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PctBuscarProveedor = new System.Windows.Forms.PictureBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.TxtPrecioCosto = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtExistencias = new System.Windows.Forms.TextBox();
            this.RdbNo = new System.Windows.Forms.RadioButton();
            this.RdbSi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.PnlDeInfoGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBuscarProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDeInfoGeneral
            // 
            this.PnlDeInfoGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlDeInfoGeneral.Controls.Add(this.TxtCategoria);
            this.PnlDeInfoGeneral.Controls.Add(this.BtnRegistrarProducto);
            this.PnlDeInfoGeneral.Controls.Add(this.panel1);
            this.PnlDeInfoGeneral.Controls.Add(this.pictureBox1);
            this.PnlDeInfoGeneral.Controls.Add(this.PctBuscarProveedor);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNombreProveedor);
            this.PnlDeInfoGeneral.Controls.Add(this.label8);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtCodigoProveedor);
            this.PnlDeInfoGeneral.Controls.Add(this.label6);
            this.PnlDeInfoGeneral.Controls.Add(this.BtnLimpiarCampos);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtPrecioCosto);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtPrecioVenta);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtNombre);
            this.PnlDeInfoGeneral.Controls.Add(this.TxtExistencias);
            this.PnlDeInfoGeneral.Controls.Add(this.RdbNo);
            this.PnlDeInfoGeneral.Controls.Add(this.RdbSi);
            this.PnlDeInfoGeneral.Controls.Add(this.label5);
            this.PnlDeInfoGeneral.Controls.Add(this.label4);
            this.PnlDeInfoGeneral.Controls.Add(this.label3);
            this.PnlDeInfoGeneral.Controls.Add(this.label2);
            this.PnlDeInfoGeneral.Controls.Add(this.label1);
            this.PnlDeInfoGeneral.Controls.Add(this.label9);
            this.PnlDeInfoGeneral.Location = new System.Drawing.Point(0, 2);
            this.PnlDeInfoGeneral.Name = "PnlDeInfoGeneral";
            this.PnlDeInfoGeneral.Size = new System.Drawing.Size(415, 318);
            this.PnlDeInfoGeneral.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 30);
            this.panel1.TabIndex = 55;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.Location = new System.Drawing.Point(384, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(109, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "AGREGAR PRODUCTOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 22);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PctBuscarProveedor
            // 
            this.PctBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctBuscarProveedor.Image = global::PresentacionGUI.Properties.Resources.search_12_24__1_;
            this.PctBuscarProveedor.Location = new System.Drawing.Point(331, 187);
            this.PctBuscarProveedor.Name = "PctBuscarProveedor";
            this.PctBuscarProveedor.Size = new System.Drawing.Size(18, 22);
            this.PctBuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBuscarProveedor.TabIndex = 52;
            this.PctBuscarProveedor.TabStop = false;
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.Location = new System.Drawing.Point(166, 213);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(161, 20);
            this.TxtNombreProveedor.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nombre Proveedor  :";
            // 
            // TxtCodigoProveedor
            // 
            this.TxtCodigoProveedor.Location = new System.Drawing.Point(166, 186);
            this.TxtCodigoProveedor.Name = "TxtCodigoProveedor";
            this.TxtCodigoProveedor.Size = new System.Drawing.Size(161, 20);
            this.TxtCodigoProveedor.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Codigo Proveedor  :";
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(192)))), ((int)(((byte)(99)))));
            this.BtnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLimpiarCampos.Image = global::PresentacionGUI.Properties.Resources.refresh_32;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(272, 265);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(55, 40);
            this.BtnLimpiarCampos.TabIndex = 47;
            this.BtnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            this.BtnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // TxtPrecioCosto
            // 
            this.TxtPrecioCosto.Location = new System.Drawing.Point(166, 128);
            this.TxtPrecioCosto.Name = "TxtPrecioCosto";
            this.TxtPrecioCosto.Size = new System.Drawing.Size(161, 20);
            this.TxtPrecioCosto.TabIndex = 29;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(166, 100);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(161, 20);
            this.TxtPrecioVenta.TabIndex = 28;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(166, 72);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre.TabIndex = 27;
            // 
            // TxtExistencias
            // 
            this.TxtExistencias.Location = new System.Drawing.Point(166, 44);
            this.TxtExistencias.Name = "TxtExistencias";
            this.TxtExistencias.Size = new System.Drawing.Size(161, 20);
            this.TxtExistencias.TabIndex = 26;
            // 
            // RdbNo
            // 
            this.RdbNo.AutoSize = true;
            this.RdbNo.Location = new System.Drawing.Point(218, 238);
            this.RdbNo.Name = "RdbNo";
            this.RdbNo.Size = new System.Drawing.Size(39, 17);
            this.RdbNo.TabIndex = 25;
            this.RdbNo.Text = "No";
            this.RdbNo.UseVisualStyleBackColor = true;
            // 
            // RdbSi
            // 
            this.RdbSi.AutoSize = true;
            this.RdbSi.Location = new System.Drawing.Point(169, 238);
            this.RdbSi.Name = "RdbSi";
            this.RdbSi.Size = new System.Drawing.Size(34, 17);
            this.RdbSi.TabIndex = 24;
            this.RdbSi.Text = "Si";
            this.RdbSi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Retornable  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 72);
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
            this.label3.Location = new System.Drawing.Point(33, 100);
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
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio costo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Categoria  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Existencias :";
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(152)))), ((int)(((byte)(242)))));
            this.BtnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistrarProducto.Image = global::PresentacionGUI.Properties.Resources.save_24;
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(333, 265);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(55, 41);
            this.BtnRegistrarProducto.TabIndex = 56;
            this.BtnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(166, 156);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(161, 20);
            this.TxtCategoria.TabIndex = 57;
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 319);
            this.Controls.Add(this.PnlDeInfoGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearProducto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearProducto";
            this.PnlDeInfoGeneral.ResumeLayout(false);
            this.PnlDeInfoGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBuscarProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDeInfoGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPrecioCosto;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtExistencias;
        private System.Windows.Forms.RadioButton RdbNo;
        private System.Windows.Forms.RadioButton RdbSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigoProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.PictureBox PctBuscarProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.TextBox TxtCategoria;
    }
}