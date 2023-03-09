namespace ChameleonProject
{
    partial class Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.DatosActaDeDirectorio = new System.Windows.Forms.GroupBox();
            this.mskFC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCarpetas = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.mskFBaja = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeynomGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarpetaGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcargaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.DatosActaDeDirectorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(291, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.AllClear);
            // 
            // btnAddDate
            // 
            this.btnAddDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDate.ForeColor = System.Drawing.Color.White;
            this.btnAddDate.Location = new System.Drawing.Point(70, 3);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(165, 31);
            this.btnAddDate.TabIndex = 9;
            this.btnAddDate.Text = "Buscar";
            this.btnAddDate.UseVisualStyleBackColor = false;
            this.btnAddDate.Click += new System.EventHandler(this.QueryData);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(532, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(577, 344);
            this.axAcroPDF1.TabIndex = 378;
            this.axAcroPDF1.TabStop = false;
            // 
            // DatosActaDeDirectorio
            // 
            this.DatosActaDeDirectorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DatosActaDeDirectorio.BackColor = System.Drawing.Color.Cornsilk;
            this.DatosActaDeDirectorio.Controls.Add(this.mskFC);
            this.DatosActaDeDirectorio.Controls.Add(this.label1);
            this.DatosActaDeDirectorio.Controls.Add(this.cboCarpetas);
            this.DatosActaDeDirectorio.Controls.Add(this.cboEstado);
            this.DatosActaDeDirectorio.Controls.Add(this.mskFBaja);
            this.DatosActaDeDirectorio.Controls.Add(this.txtUsuario);
            this.DatosActaDeDirectorio.Controls.Add(this.label20);
            this.DatosActaDeDirectorio.Controls.Add(this.label13);
            this.DatosActaDeDirectorio.Controls.Add(this.label12);
            this.DatosActaDeDirectorio.Controls.Add(this.label11);
            this.DatosActaDeDirectorio.Controls.Add(this.txtDni);
            this.DatosActaDeDirectorio.Controls.Add(this.label9);
            this.DatosActaDeDirectorio.Controls.Add(this.txtNombre);
            this.DatosActaDeDirectorio.Controls.Add(this.label8);
            this.DatosActaDeDirectorio.Controls.Add(this.txtLegajo);
            this.DatosActaDeDirectorio.Controls.Add(this.label7);
            this.DatosActaDeDirectorio.Controls.Add(this.txtCaja);
            this.DatosActaDeDirectorio.Controls.Add(this.label10);
            this.DatosActaDeDirectorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosActaDeDirectorio.Location = new System.Drawing.Point(12, 20);
            this.DatosActaDeDirectorio.Name = "DatosActaDeDirectorio";
            this.DatosActaDeDirectorio.Size = new System.Drawing.Size(514, 301);
            this.DatosActaDeDirectorio.TabIndex = 0;
            this.DatosActaDeDirectorio.TabStop = false;
            this.DatosActaDeDirectorio.Text = "Datos Acta De Directorio";
            // 
            // mskFC
            // 
            this.mskFC.Location = new System.Drawing.Point(269, 256);
            this.mskFC.Mask = "00/00/0000";
            this.mskFC.Name = "mskFC";
            this.mskFC.Size = new System.Drawing.Size(89, 22);
            this.mskFC.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha Carga:";
            // 
            // cboCarpetas
            // 
            this.cboCarpetas.FormattingEnabled = true;
            this.cboCarpetas.Location = new System.Drawing.Point(210, 170);
            this.cboCarpetas.Name = "cboCarpetas";
            this.cboCarpetas.Size = new System.Drawing.Size(201, 24);
            this.cboCarpetas.TabIndex = 5;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(210, 140);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(201, 24);
            this.cboEstado.TabIndex = 4;
            // 
            // mskFBaja
            // 
            this.mskFBaja.Location = new System.Drawing.Point(269, 228);
            this.mskFBaja.Mask = "00/00/0000";
            this.mskFBaja.Name = "mskFBaja";
            this.mskFBaja.Size = new System.Drawing.Size(89, 22);
            this.mskFBaja.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(210, 200);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(106, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Carpetas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Fecha Baja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estado:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(210, 112);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(201, 22);
            this.txtDni.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dni:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(210, 56);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(201, 22);
            this.txtLegajo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "N°Legajo:";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(210, 28);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(201, 22);
            this.txtCaja.TabIndex = 0;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Caja:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrid,
            this.CajaGrid,
            this.LegajoGrid,
            this.ApeynomGrid,
            this.DniGrid,
            this.EstadoGrid,
            this.CarpetaGrid,
            this.Imagen,
            this.UsuarioGrid,
            this.FBaja,
            this.fcargaGrid,
            this.Modificar,
            this.Eliminar});
            this.dgv.Location = new System.Drawing.Point(12, 370);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1097, 155);
            this.dgv.TabIndex = 380;
            this.dgv.TabStop = false;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CallDgv);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // IdGrid
            // 
            this.IdGrid.HeaderText = "Id";
            this.IdGrid.Name = "IdGrid";
            // 
            // CajaGrid
            // 
            this.CajaGrid.HeaderText = "Caja";
            this.CajaGrid.Name = "CajaGrid";
            // 
            // LegajoGrid
            // 
            this.LegajoGrid.HeaderText = "Legajo";
            this.LegajoGrid.Name = "LegajoGrid";
            // 
            // ApeynomGrid
            // 
            this.ApeynomGrid.HeaderText = "Nombre";
            this.ApeynomGrid.Name = "ApeynomGrid";
            // 
            // DniGrid
            // 
            this.DniGrid.HeaderText = "Dni";
            this.DniGrid.Name = "DniGrid";
            // 
            // EstadoGrid
            // 
            this.EstadoGrid.HeaderText = "Estado";
            this.EstadoGrid.Name = "EstadoGrid";
            // 
            // CarpetaGrid
            // 
            this.CarpetaGrid.HeaderText = "Carpeta";
            this.CarpetaGrid.Name = "CarpetaGrid";
            this.CarpetaGrid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CarpetaGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // UsuarioGrid
            // 
            this.UsuarioGrid.HeaderText = "Usuario";
            this.UsuarioGrid.Name = "UsuarioGrid";
            // 
            // FBaja
            // 
            this.FBaja.HeaderText = "FechaBaja";
            this.FBaja.Name = "FBaja";
            // 
            // fcargaGrid
            // 
            this.fcargaGrid.HeaderText = "Fecha Carga";
            this.fcargaGrid.Name = "fcargaGrid";
            // 
            // Modificar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Query
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.DatosActaDeDirectorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.StartProgram);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.DatosActaDeDirectorio.ResumeLayout(false);
            this.DatosActaDeDirectorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddDate;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.GroupBox DatosActaDeDirectorio;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskFC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCarpetas;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.MaskedTextBox mskFBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeynomGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarpetaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcargaGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}