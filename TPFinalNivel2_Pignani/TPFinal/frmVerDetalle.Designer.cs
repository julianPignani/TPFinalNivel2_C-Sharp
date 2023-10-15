
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
            this.pcboxDetalle = new System.Windows.Forms.PictureBox();
            this.lblTituloDetalle = new System.Windows.Forms.Label();
            this.txtDetalleCodigo = new System.Windows.Forms.TextBox();
            this.txtDetalleNombre = new System.Windows.Forms.TextBox();
            this.txtDetalleUrl = new System.Windows.Forms.TextBox();
            this.txtDetallePrecio = new System.Windows.Forms.TextBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.txtRichDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxDetalle
            // 
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
            // txtDetalleCodigo
            // 
            this.txtDetalleCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleCodigo.Location = new System.Drawing.Point(291, 63);
            this.txtDetalleCodigo.Name = "txtDetalleCodigo";
            this.txtDetalleCodigo.Size = new System.Drawing.Size(158, 26);
            this.txtDetalleCodigo.TabIndex = 2;
            // 
            // txtDetalleNombre
            // 
            this.txtDetalleNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleNombre.Location = new System.Drawing.Point(290, 95);
            this.txtDetalleNombre.Name = "txtDetalleNombre";
            this.txtDetalleNombre.Size = new System.Drawing.Size(158, 26);
            this.txtDetalleNombre.TabIndex = 3;
            // 
            // txtDetalleUrl
            // 
            this.txtDetalleUrl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleUrl.Location = new System.Drawing.Point(290, 127);
            this.txtDetalleUrl.Name = "txtDetalleUrl";
            this.txtDetalleUrl.Size = new System.Drawing.Size(158, 26);
            this.txtDetalleUrl.TabIndex = 4;
            // 
            // txtDetallePrecio
            // 
            this.txtDetallePrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetallePrecio.Location = new System.Drawing.Point(291, 343);
            this.txtDetallePrecio.Name = "txtDetallePrecio";
            this.txtDetallePrecio.Size = new System.Drawing.Size(158, 26);
            this.txtDetallePrecio.TabIndex = 5;
            // 
            // cboxMarca
            // 
            this.cboxMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(290, 159);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(157, 26);
            this.cboxMarca.TabIndex = 6;
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(290, 191);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(157, 26);
            this.cboxCategoria.TabIndex = 7;
            // 
            // txtRichDescripcion
            // 
            this.txtRichDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRichDescripcion.Location = new System.Drawing.Point(290, 223);
            this.txtRichDescripcion.Name = "txtRichDescripcion";
            this.txtRichDescripcion.Size = new System.Drawing.Size(158, 91);
            this.txtRichDescripcion.TabIndex = 8;
            this.txtRichDescripcion.Text = "";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(176, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 37);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 415);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtRichDescripcion);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.txtDetallePrecio);
            this.Controls.Add(this.txtDetalleUrl);
            this.Controls.Add(this.txtDetalleNombre);
            this.Controls.Add(this.txtDetalleCodigo);
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
        private System.Windows.Forms.TextBox txtDetalleCodigo;
        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.TextBox txtDetalleUrl;
        private System.Windows.Forms.TextBox txtDetallePrecio;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.RichTextBox txtRichDescripcion;
        private System.Windows.Forms.Button btnVolver;
    }
}