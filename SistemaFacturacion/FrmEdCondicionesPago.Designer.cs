﻿namespace SistemaFacturacion
{
    partial class FrmEdCondicionesPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdCondicionesPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad_De_Dias = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtId_Pago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantidad_De_Dias);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtId_Pago);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 159);
            this.panel1.TabIndex = 14;
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(124, 119);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(185, 21);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // txtCantidad_De_Dias
            // 
            this.txtCantidad_De_Dias.Location = new System.Drawing.Point(124, 83);
            this.txtCantidad_De_Dias.Name = "txtCantidad_De_Dias";
            this.txtCantidad_De_Dias.Size = new System.Drawing.Size(185, 20);
            this.txtCantidad_De_Dias.TabIndex = 6;
            this.txtCantidad_De_Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_De_Dias_KeyPress);
            this.txtCantidad_De_Dias.Leave += new System.EventHandler(this.txtCantidad_De_Dias_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 48);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtId_Pago
            // 
            this.txtId_Pago.Enabled = false;
            this.txtId_Pago.Location = new System.Drawing.Point(124, 16);
            this.txtId_Pago.Name = "txtId_Pago";
            this.txtId_Pago.Size = new System.Drawing.Size(185, 20);
            this.txtId_Pago.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Canidad de dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pago";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.BackgroundImage")));
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.Location = new System.Drawing.Point(197, 187);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(40, 36);
            this.cmdEliminar.TabIndex = 16;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
            this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGuardar.Location = new System.Drawing.Point(98, 187);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(40, 36);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // FrmEdCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 235);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdGuardar);
            this.Name = "FrmEdCondicionesPago";
            this.Text = "Edicion de Condiciones de Pago";
            this.Load += new System.EventHandler(this.FrmEdCondicionesPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad_De_Dias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId_Pago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ComboBox txtEstado;
    }
}