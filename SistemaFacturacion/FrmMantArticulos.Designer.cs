namespace SistemaFacturacion
{
    partial class FrmMantArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantArticulos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.TxtABuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.DgvArticulo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtABuscar);
            this.panel1.Controls.Add(this.CbxCriterio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 116);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvArticulo);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 322);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CmdAgregar);
            this.panel3.Controls.Add(this.CmdBuscar);
            this.panel3.Location = new System.Drawing.Point(578, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 116);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Items.AddRange(new object[] {
            "Id_Articulo",
            "Articulo",
            "Precio_Unitario",
            "Costo_Unitario",
            "Estado"});
            this.CbxCriterio.Location = new System.Drawing.Point(76, 46);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(173, 21);
            this.CbxCriterio.TabIndex = 1;
            // 
            // TxtABuscar
            // 
            this.TxtABuscar.Location = new System.Drawing.Point(359, 46);
            this.TxtABuscar.Name = "TxtABuscar";
            this.TxtABuscar.Size = new System.Drawing.Size(171, 20);
            this.TxtABuscar.TabIndex = 2;
            this.TxtABuscar.TextChanged += new System.EventHandler(this.TxtABuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto a Buscar";
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdBuscar.BackgroundImage")));
            this.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdBuscar.Location = new System.Drawing.Point(13, 18);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(75, 75);
            this.CmdBuscar.TabIndex = 0;
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdAgregar.BackgroundImage")));
            this.CmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdAgregar.Location = new System.Drawing.Point(108, 18);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(75, 75);
            this.CmdAgregar.TabIndex = 1;
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.AllowUserToAddRows = false;
            this.DgvArticulo.AllowUserToDeleteRows = false;
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.Location = new System.Drawing.Point(4, 4);
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.ReadOnly = true;
            this.DgvArticulo.Size = new System.Drawing.Size(757, 313);
            this.DgvArticulo.TabIndex = 0;
            this.DgvArticulo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulo_CellDoubleClick);
            // 
            // FrmMantArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMantArticulos";
            this.Text = "Mantenimiento de Articulos";
            this.Activated += new System.EventHandler(this.TxtABuscar_TextChanged);
            this.Load += new System.EventHandler(this.FrmMantArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtABuscar;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvArticulo;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdBuscar;
    }
}