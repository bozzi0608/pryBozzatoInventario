namespace pryBozzatoInventario
{
    partial class frmInicio
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblCategoria = new Label();
            txtNombre = new TextBox();
            txtModificar = new TextBox();
            BtnAgregar = new Button();
            BtnModificar = new Button();
            btnEliminar = new Button();
            comboBoxCategoria = new ComboBox();
            lblDescripcion = new Label();
            groupBoxBusqueda = new GroupBox();
            btnBuscar = new Button();
            txtDescripcion = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(95, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(630, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Controls.Add(lblPrecio);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(lblStock);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Controls.Add(groupBoxBusqueda);
            tabPage1.Controls.Add(lblDescripcion);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(BtnModificar);
            tabPage1.Controls.Add(BtnAgregar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(622, 456);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestion de productos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(622, 456);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(24, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 65);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtModificar
            // 
            txtModificar.Location = new Point(136, 24);
            txtModificar.Name = "txtModificar";
            txtModificar.Size = new Size(121, 23);
            txtModificar.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(185, 402);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(266, 402);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 8;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(347, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(136, 62);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 23);
            comboBoxCategoria.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(48, 253);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción:";
            // 
            // groupBoxBusqueda
            // 
            groupBoxBusqueda.Controls.Add(btnBuscar);
            groupBoxBusqueda.Controls.Add(comboBoxCategoria);
            groupBoxBusqueda.Controls.Add(txtModificar);
            groupBoxBusqueda.Controls.Add(txtNombre);
            groupBoxBusqueda.Controls.Add(lblCategoria);
            groupBoxBusqueda.Controls.Add(lblCodigo);
            groupBoxBusqueda.Controls.Add(lblNombre);
            groupBoxBusqueda.Location = new Point(35, 47);
            groupBoxBusqueda.Name = "groupBoxBusqueda";
            groupBoxBusqueda.Size = new Size(306, 180);
            groupBoxBusqueda.TabIndex = 12;
            groupBoxBusqueda.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(182, 141);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(171, 253);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(121, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(48, 292);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(171, 289);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 15;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(48, 331);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(171, 328);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 17;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(tabControl1);
            Name = "frmInicio";
            Text = "INICIO";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBoxBusqueda.ResumeLayout(false);
            groupBoxBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnAgregar;
        private TextBox txtModificar;
        private TextBox txtNombre;
        private Label lblCategoria;
        private Label lblCodigo;
        private Label lblNombre;
        private Button btnEliminar;
        private Button BtnModificar;
        private Label lblDescripcion;
        private ComboBox comboBoxCategoria;
        private GroupBox groupBoxBusqueda;
        private Button btnBuscar;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtDescripcion;
    }
}