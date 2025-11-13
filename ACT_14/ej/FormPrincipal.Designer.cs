using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ej;

partial class FormPrincipal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnGenerarTicket = new Button();
        btnResumen = new Button();
        btnImportarEjemplo = new Button();
        button4 = new Button();
        label1 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        cmbDestino = new ComboBox();
        groupBox1 = new GroupBox();
        tbNumeroTarjeta = new TextBox();
        tbTelefono = new TextBox();
        tbNombre = new TextBox();
        tbCUIT = new TextBox();
        openFileDialog1 = new OpenFileDialog();
        label2 = new Label();
        lbPrecio = new Label();
        label4 = new Label();
        lbTransporte = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnGenerarTicket
        // 
        btnGenerarTicket.Location = new Point(397, 96);
        btnGenerarTicket.Name = "btnGenerarTicket";
        btnGenerarTicket.Size = new Size(76, 51);
        btnGenerarTicket.TabIndex = 0;
        btnGenerarTicket.Text = "Generar";
        btnGenerarTicket.UseVisualStyleBackColor = true;
        btnGenerarTicket.Click += btnGenerarTicket_Click;
        // 
        // btnResumen
        // 
        btnResumen.Location = new Point(397, 179);
        btnResumen.Name = "btnResumen";
        btnResumen.Size = new Size(75, 54);
        btnResumen.TabIndex = 1;
        btnResumen.Text = "Resumen";
        btnResumen.UseVisualStyleBackColor = true;
        btnResumen.Click += btnResumen_Click;
        // 
        // btnImportarEjemplo
        // 
        btnImportarEjemplo.Location = new Point(68, 261);
        btnImportarEjemplo.Name = "btnImportarEjemplo";
        btnImportarEjemplo.Size = new Size(75, 23);
        btnImportarEjemplo.TabIndex = 2;
        btnImportarEjemplo.Text = "Ejemplo";
        btnImportarEjemplo.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(365, 261);
        button4.Name = "button4";
        button4.Size = new Size(75, 23);
        button4.TabIndex = 3;
        button4.Text = "Salir";
        button4.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(53, 11);
        label1.Name = "label1";
        label1.Size = new Size(66, 15);
        label1.TabIndex = 4;
        label1.Text = "Tipo Pasaje";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(57, 28);
        label5.Name = "label5";
        label5.Size = new Size(62, 15);
        label5.TabIndex = 8;
        label5.Text = "CUIT/CUIL";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(57, 60);
        label6.Name = "label6";
        label6.Size = new Size(51, 15);
        label6.TabIndex = 9;
        label6.Text = "Nombre";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(57, 91);
        label7.Name = "label7";
        label7.Size = new Size(52, 15);
        label7.TabIndex = 10;
        label7.Text = "Teléfono";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(25, 121);
        label8.Name = "label8";
        label8.Size = new Size(88, 15);
        label8.TabIndex = 11;
        label8.Text = "Número Tarjeta";
        // 
        // cmbDestino
        // 
        cmbDestino.FormattingEnabled = true;
        cmbDestino.Location = new Point(133, 9);
        cmbDestino.Name = "cmbDestino";
        cmbDestino.Size = new Size(247, 23);
        cmbDestino.TabIndex = 12;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tbNumeroTarjeta);
        groupBox1.Controls.Add(tbTelefono);
        groupBox1.Controls.Add(tbNombre);
        groupBox1.Controls.Add(tbCUIT);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label8);
        groupBox1.Location = new Point(11, 96);
        groupBox1.Margin = new Padding(2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(2);
        groupBox1.Size = new Size(369, 152);
        groupBox1.TabIndex = 16;
        groupBox1.TabStop = false;
        groupBox1.Text = "Datos pasajero";
        // 
        // tbNumeroTarjeta
        // 
        tbNumeroTarjeta.Location = new Point(122, 119);
        tbNumeroTarjeta.Name = "tbNumeroTarjeta";
        tbNumeroTarjeta.Size = new Size(232, 23);
        tbNumeroTarjeta.TabIndex = 20;
        // 
        // tbTelefono
        // 
        tbTelefono.Location = new Point(122, 89);
        tbTelefono.Name = "tbTelefono";
        tbTelefono.Size = new Size(189, 23);
        tbTelefono.TabIndex = 19;
        // 
        // tbNombre
        // 
        tbNombre.Location = new Point(122, 58);
        tbNombre.Name = "tbNombre";
        tbNombre.Size = new Size(232, 23);
        tbNombre.TabIndex = 18;
        // 
        // tbCUIT
        // 
        tbCUIT.Location = new Point(122, 26);
        tbCUIT.Name = "tbCUIT";
        tbCUIT.Size = new Size(189, 23);
        tbCUIT.TabIndex = 17;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(79, 47);
        label2.Name = "label2";
        label2.Size = new Size(40, 15);
        label2.TabIndex = 17;
        label2.Text = "Precio";
        // 
        // lbPrecio
        // 
        lbPrecio.BackColor = SystemColors.ActiveCaption;
        lbPrecio.Location = new Point(133, 47);
        lbPrecio.Name = "lbPrecio";
        lbPrecio.Size = new Size(247, 15);
        lbPrecio.TabIndex = 18;
        lbPrecio.Text = "lbPrecio";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(53, 71);
        label4.Name = "label4";
        label4.Size = new Size(62, 15);
        label4.TabIndex = 19;
        label4.Text = "Transporte";
        // 
        // lbTransporte
        // 
        lbTransporte.BackColor = SystemColors.ActiveCaption;
        lbTransporte.Location = new Point(133, 71);
        lbTransporte.Name = "lbTransporte";
        lbTransporte.Size = new Size(247, 15);
        lbTransporte.TabIndex = 20;
        lbTransporte.Text = "lbTransporte";
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(483, 291);
        Controls.Add(lbTransporte);
        Controls.Add(label4);
        Controls.Add(lbPrecio);
        Controls.Add(label2);
        Controls.Add(groupBox1);
        Controls.Add(cmbDestino);
        Controls.Add(label1);
        Controls.Add(button4);
        Controls.Add(btnImportarEjemplo);
        Controls.Add(btnResumen);
        Controls.Add(btnGenerarTicket);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormPrincipal";
        Text = "Venta Pasajes";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnGenerarTicket;
    private Button btnResumen;
    private Button btnImportarEjemplo;
    private Button button4;
    private Label label1;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private ComboBox cmbDestino;
    private GroupBox groupBox1;
    private TextBox tbNumeroTarjeta;
    private TextBox tbTelefono;
    private TextBox tbNombre;
    private TextBox tbCUIT;
    private OpenFileDialog openFileDialog1;
    private Label label2;
    private Label lbPrecio;
    private Label label4;
    private Label lbTransporte;
}