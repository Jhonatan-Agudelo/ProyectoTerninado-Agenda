namespace ProyecAgenda
{
    partial class frmInicio
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblBuscarYModifContacto = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.TvContactos = new System.Windows.Forms.TreeView();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdAgregarContacto = new System.Windows.Forms.Button();
            this.panelfranja = new System.Windows.Forms.FlowLayoutPanel();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.picModificar = new System.Windows.Forms.PictureBox();
            this.panelfranja4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelfranja2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdEliminarContacto = new System.Windows.Forms.Button();
            this.cmdModifContacto = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BarraTitulo.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lblBuscarYModifContacto);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1341, 62);
            this.BarraTitulo.TabIndex = 0;
            // 
            // lblBuscarYModifContacto
            // 
            this.lblBuscarYModifContacto.AutoSize = true;
            this.lblBuscarYModifContacto.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarYModifContacto.ForeColor = System.Drawing.Color.White;
            this.lblBuscarYModifContacto.Location = new System.Drawing.Point(601, 9);
            this.lblBuscarYModifContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarYModifContacto.Name = "lblBuscarYModifContacto";
            this.lblBuscarYModifContacto.Size = new System.Drawing.Size(447, 42);
            this.lblBuscarYModifContacto.TabIndex = 0;
            this.lblBuscarYModifContacto.Text = "Buscar Y Modificar Contacto";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Controls.Add(this.flowLayoutPanel1);
            this.PanelContenedor.Controls.Add(this.cmdExportar);
            this.PanelContenedor.Controls.Add(this.TvContactos);
            this.PanelContenedor.Controls.Add(this.cmdBuscar);
            this.PanelContenedor.Controls.Add(this.grpBuscar);
            this.PanelContenedor.Controls.Add(this.picModificar);
            this.PanelContenedor.Controls.Add(this.panelfranja2);
            this.PanelContenedor.Controls.Add(this.MenuVertical);
            this.PanelContenedor.Controls.Add(this.cmdModifContacto);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 62);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1341, 774);
            this.PanelContenedor.TabIndex = 0;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Location = new System.Drawing.Point(316, 721);
            this.cmdExportar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(129, 38);
            this.cmdExportar.TabIndex = 16;
            this.cmdExportar.Text = "Exportar Datos";
            this.cmdExportar.UseVisualStyleBackColor = true;
            // 
            // TvContactos
            // 
            this.TvContactos.Location = new System.Drawing.Point(316, 383);
            this.TvContactos.Margin = new System.Windows.Forms.Padding(4);
            this.TvContactos.Name = "TvContactos";
            this.TvContactos.Size = new System.Drawing.Size(996, 317);
            this.TvContactos.TabIndex = 15;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.ForeColor = System.Drawing.Color.White;
            this.cmdBuscar.Location = new System.Drawing.Point(883, 275);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(276, 87);
            this.cmdBuscar.TabIndex = 14;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.txtCorreo);
            this.grpBuscar.Controls.Add(this.lblCorreo);
            this.grpBuscar.Controls.Add(this.cmbCategoria);
            this.grpBuscar.Controls.Add(this.lblCategoria);
            this.grpBuscar.Controls.Add(this.txtTelefono);
            this.grpBuscar.Controls.Add(this.lblTelefono);
            this.grpBuscar.Controls.Add(this.txtApellido);
            this.grpBuscar.Controls.Add(this.lblApellido);
            this.grpBuscar.Controls.Add(this.txtNombre);
            this.grpBuscar.Controls.Add(this.lblNombre);
            this.grpBuscar.ForeColor = System.Drawing.Color.White;
            this.grpBuscar.Location = new System.Drawing.Point(316, 22);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBuscar.Size = new System.Drawing.Size(997, 241);
            this.grpBuscar.TabIndex = 12;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "          Buscar Y Modificar          ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(407, 188);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 25);
            this.txtCorreo.TabIndex = 12;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(304, 190);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(77, 25);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(751, 124);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(180, 24);
            this.cmbCategoria.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(600, 122);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(751, 52);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 25);
            this.txtTelefono.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(600, 52);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(96, 25);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(187, 122);
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
            this.lblApellido.Location = new System.Drawing.Point(59, 119);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 25);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(59, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.cmdAgregarContacto);
            this.MenuVertical.Controls.Add(this.panelfranja);
            this.MenuVertical.Controls.Add(this.picEliminar);
            this.MenuVertical.Controls.Add(this.panelfranja4);
            this.MenuVertical.Controls.Add(this.cmdEliminarContacto);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(287, 774);
            this.MenuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyecAgenda.Properties.Resources.AgregarContac;
            this.pictureBox1.Location = new System.Drawing.Point(32, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmdAgregarContacto
            // 
            this.cmdAgregarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmdAgregarContacto.FlatAppearance.BorderSize = 0;
            this.cmdAgregarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdAgregarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarContacto.ForeColor = System.Drawing.Color.White;
            this.cmdAgregarContacto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdAgregarContacto.Location = new System.Drawing.Point(15, 163);
            this.cmdAgregarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAgregarContacto.Name = "cmdAgregarContacto";
            this.cmdAgregarContacto.Size = new System.Drawing.Size(272, 87);
            this.cmdAgregarContacto.TabIndex = 10;
            this.cmdAgregarContacto.Text = "             Agregar Contacto\r\n";
            this.cmdAgregarContacto.UseVisualStyleBackColor = false;
            this.cmdAgregarContacto.Click += new System.EventHandler(this.cmdAgregarContacto_Click);
            // 
            // panelfranja
            // 
            this.panelfranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelfranja.Location = new System.Drawing.Point(0, 163);
            this.panelfranja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfranja.Name = "panelfranja";
            this.panelfranja.Size = new System.Drawing.Size(13, 87);
            this.panelfranja.TabIndex = 4;
            // 
            // picEliminar
            // 
            this.picEliminar.BackColor = System.Drawing.Color.White;
            this.picEliminar.Image = global::ProyecAgenda.Properties.Resources.EliminarContac;
            this.picEliminar.Location = new System.Drawing.Point(32, 410);
            this.picEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(44, 34);
            this.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEliminar.TabIndex = 8;
            this.picEliminar.TabStop = false;
            // 
            // picModificar
            // 
            this.picModificar.Image = global::ProyecAgenda.Properties.Resources.ModiContac;
            this.picModificar.Location = new System.Drawing.Point(517, 301);
            this.picModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picModificar.Name = "picModificar";
            this.picModificar.Size = new System.Drawing.Size(44, 34);
            this.picModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModificar.TabIndex = 6;
            this.picModificar.TabStop = false;
            // 
            // panelfranja4
            // 
            this.panelfranja4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelfranja4.Location = new System.Drawing.Point(0, 383);
            this.panelfranja4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfranja4.Name = "panelfranja4";
            this.panelfranja4.Size = new System.Drawing.Size(13, 87);
            this.panelfranja4.TabIndex = 5;
            // 
            // panelfranja2
            // 
            this.panelfranja2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelfranja2.Location = new System.Drawing.Point(484, 275);
            this.panelfranja2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelfranja2.Name = "panelfranja2";
            this.panelfranja2.Size = new System.Drawing.Size(13, 87);
            this.panelfranja2.TabIndex = 3;
            // 
            // cmdEliminarContacto
            // 
            this.cmdEliminarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmdEliminarContacto.FlatAppearance.BorderSize = 0;
            this.cmdEliminarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdEliminarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarContacto.ForeColor = System.Drawing.Color.White;
            this.cmdEliminarContacto.Location = new System.Drawing.Point(15, 383);
            this.cmdEliminarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEliminarContacto.Name = "cmdEliminarContacto";
            this.cmdEliminarContacto.Size = new System.Drawing.Size(272, 87);
            this.cmdEliminarContacto.TabIndex = 2;
            this.cmdEliminarContacto.Text = "           Eliminar Contacto";
            this.cmdEliminarContacto.UseVisualStyleBackColor = false;
            this.cmdEliminarContacto.Click += new System.EventHandler(this.cmdEliminarContacto_Click);
            // 
            // cmdModifContacto
            // 
            this.cmdModifContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmdModifContacto.FlatAppearance.BorderSize = 0;
            this.cmdModifContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cmdModifContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModifContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifContacto.ForeColor = System.Drawing.Color.White;
            this.cmdModifContacto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cmdModifContacto.Location = new System.Drawing.Point(493, 275);
            this.cmdModifContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdModifContacto.Name = "cmdModifContacto";
            this.cmdModifContacto.Size = new System.Drawing.Size(272, 87);
            this.cmdModifContacto.TabIndex = 0;
            this.cmdModifContacto.Text = "             Modificar Contacto";
            this.cmdModifContacto.UseVisualStyleBackColor = false;
            this.cmdModifContacto.Click += new System.EventHandler(this.cmdModifContacto_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(883, 275);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(13, 87);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button cmdModifContacto;
        private System.Windows.Forms.Button cmdEliminarContacto;
        private System.Windows.Forms.FlowLayoutPanel panelfranja2;
        private System.Windows.Forms.FlowLayoutPanel panelfranja4;
        private System.Windows.Forms.PictureBox picModificar;
        private System.Windows.Forms.PictureBox picEliminar;
        private System.Windows.Forms.Button cmdAgregarContacto;
        private System.Windows.Forms.FlowLayoutPanel panelfranja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblBuscarYModifContacto;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TreeView TvContactos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

