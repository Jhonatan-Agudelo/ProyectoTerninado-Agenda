namespace ProyecAgenda.Formularios
{
    partial class frmAgregarContacto
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
            this.panelTituloAgregar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFondoAgregar = new System.Windows.Forms.Panel();
            this.tvAgregar = new System.Windows.Forms.TreeView();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.panelfranja = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTituloAgregar.SuspendLayout();
            this.panelFondoAgregar.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTituloAgregar
            // 
            this.panelTituloAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelTituloAgregar.Controls.Add(this.lblTitulo);
            this.panelTituloAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloAgregar.Location = new System.Drawing.Point(0, 0);
            this.panelTituloAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTituloAgregar.Name = "panelTituloAgregar";
            this.panelTituloAgregar.Size = new System.Drawing.Size(976, 62);
            this.panelTituloAgregar.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(284, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AGREGAR CONTACTO";
            // 
            // panelFondoAgregar
            // 
            this.panelFondoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFondoAgregar.Controls.Add(this.tvAgregar);
            this.panelFondoAgregar.Controls.Add(this.cmdCancelar);
            this.panelFondoAgregar.Controls.Add(this.grpBuscar);
            this.panelFondoAgregar.Controls.Add(this.flowLayoutPanel1);
            this.panelFondoAgregar.Controls.Add(this.cmdAgregar);
            this.panelFondoAgregar.Controls.Add(this.panelfranja);
            this.panelFondoAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondoAgregar.Location = new System.Drawing.Point(0, 62);
            this.panelFondoAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.panelFondoAgregar.Name = "panelFondoAgregar";
            this.panelFondoAgregar.Size = new System.Drawing.Size(976, 507);
            this.panelFondoAgregar.TabIndex = 1;
            // 
            // tvAgregar
            // 
            this.tvAgregar.Location = new System.Drawing.Point(128, 214);
            this.tvAgregar.Name = "tvAgregar";
            this.tvAgregar.Size = new System.Drawing.Size(725, 192);
            this.tvAgregar.TabIndex = 16;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Location = new System.Drawing.Point(532, 424);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(199, 70);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtCorreo);
            this.grpBuscar.Controls.Add(this.cmbCategoria);
            this.grpBuscar.Controls.Add(this.lblNombre);
            this.grpBuscar.Controls.Add(this.lblCorreo);
            this.grpBuscar.Controls.Add(this.lblCategoria);
            this.grpBuscar.Controls.Add(this.txtTelefono);
            this.grpBuscar.Controls.Add(this.lblTelefono);
            this.grpBuscar.Controls.Add(this.txtApellido);
            this.grpBuscar.Controls.Add(this.lblApellido);
            this.grpBuscar.Controls.Add(this.txtNombre);
            this.grpBuscar.ForeColor = System.Drawing.Color.White;
            this.grpBuscar.Location = new System.Drawing.Point(12, 6);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBuscar.Size = new System.Drawing.Size(947, 203);
            this.grpBuscar.TabIndex = 13;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "          Buscar          ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(331, 158);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 25);
            this.txtCorreo.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(651, 102);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(205, 24);
            this.cmbCategoria.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(248, 158);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(77, 25);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(515, 102);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(651, 36);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 25);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(515, 37);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(96, 25);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(187, 103);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 24);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(69, 102);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 25);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(520, 424);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(17, 70);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.FlatAppearance.BorderSize = 0;
            this.cmdAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.ForeColor = System.Drawing.Color.White;
            this.cmdAgregar.Location = new System.Drawing.Point(263, 424);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(199, 70);
            this.cmdAgregar.TabIndex = 13;
            this.cmdAgregar.Text = "&Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // panelfranja
            // 
            this.panelfranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelfranja.Location = new System.Drawing.Point(253, 424);
            this.panelfranja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfranja.Name = "panelfranja";
            this.panelfranja.Size = new System.Drawing.Size(17, 70);
            this.panelfranja.TabIndex = 14;
            // 
            // frmAgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 569);
            this.Controls.Add(this.panelFondoAgregar);
            this.Controls.Add(this.panelTituloAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAgregarContacto";
            this.Text = "Agregar";
            this.panelTituloAgregar.ResumeLayout(false);
            this.panelTituloAgregar.PerformLayout();
            this.panelFondoAgregar.ResumeLayout(false);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloAgregar;
        private System.Windows.Forms.Panel panelFondoAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.FlowLayoutPanel panelfranja;
        private System.Windows.Forms.TreeView tvAgregar;
    }
}