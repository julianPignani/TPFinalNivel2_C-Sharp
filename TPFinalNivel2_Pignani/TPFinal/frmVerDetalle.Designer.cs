
namespace TPFinal
{
    partial class frmVerDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerDetalle));
            this.pcboxDetalle = new System.Windows.Forms.PictureBox();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.txtDetalleNombre = new System.Windows.Forms.TextBox();
            this.txtDetallePrecio = new System.Windows.Forms.TextBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.txtRichDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxDetalle
            // 
            this.pcboxDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcboxDetalle.Location = new System.Drawing.Point(12, 63);
            this.pcboxDetalle.Name = "pcboxDetalle";
            this.pcboxDetalle.Size = new System.Drawing.Size(273, 306);
            this.pcboxDetalle.TabIndex = 0;
            this.pcboxDetalle.TabStop = false;
            // 
            // lblTituloDetalle
            // 
            this.lblTituloDetalle.AutoSize = true;
            this.lblTituloDetalle.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTituloDetalle.Location = new System.Drawing.Point(119, 9);
            this.lblTituloDetalle.Name = "lblTituloDetalle";
            this.lblTituloDetalle.Size = new System.Drawing.Size(226, 28);
            this.lblTituloDetalle.TabIndex = 1;
            this.lblTituloDetalle.Text = "Detalle del Articulo";
            this.lblTituloDetalle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDetalleNombre
            // 
            this.txtDetalleNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetalleNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleNombre.Location = new System.Drawing.Point(289, 77);
            this.txtDetalleNombre.Name = "txtDetalleNombre";
            this.txtDetalleNombre.ReadOnly = true;
            this.txtDetalleNombre.Size = new System.Drawing.Size(200, 26);
            this.txtDetalleNombre.TabIndex = 2;
            // 
            // txtDetallePrecio
            // 
            this.txtDetallePrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDetallePrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetallePrecio.Location = new System.Drawing.Point(313, 323);
            this.txtDetallePrecio.Name = "txtDetallePrecio";
            this.txtDetallePrecio.ReadOnly = true;
            this.txtDetallePrecio.Size = new System.Drawing.Size(176, 26);
            this.txtDetallePrecio.TabIndex = 6;
            this.txtDetallePrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxMarca
            // 
            this.cboxMarca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboxMarca.Enabled = false;
            this.cboxMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(289, 124);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(200, 27);
            this.cboxMarca.TabIndex = 3;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboxCategoria.Enabled = false;
            this.cboxCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(289, 173);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(200, 27);
            this.cboxCategoria.TabIndex = 4;
            // 
            // txtRichDescripcion
            // 
            this.txtRichDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRichDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRichDescripcion.Location = new System.Drawing.Point(289, 216);
            this.txtRichDescripcion.Name = "txtRichDescripcion";
            this.txtRichDescripcion.ReadOnly = true;
            this.txtRichDescripcion.Size = new System.Drawing.Size(200, 91);
            this.txtRichDescripcion.TabIndex = 5;
            this.txtRichDescripcion.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(176, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 37);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(289, 323);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(24, 26);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "$";
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 415);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtRichDescripcion);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.txtDetallePrecio);
            this.Controls.Add(this.txtDetalleNombre);
            this.Controls.Add(this.lblTituloDetalle);
            this.Controls.Add(this.pcboxDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmVerDetalle";
            this.Text = "Ver Detalle";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxDetalle;
        private System.Windows.Forms.Label lblTituloDetalle;
        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.TextBox txtDetallePrecio;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.RichTextBox txtRichDescripcion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPrecio;
    }
}