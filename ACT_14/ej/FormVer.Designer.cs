using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ej;
partial class FormVer
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
        listBox1 = new ListBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 21;
        listBox1.Location = new Point(15, 17);
        listBox1.Margin = new Padding(4, 4, 4, 4);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(450, 319);
        listBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.DialogResult = DialogResult.OK;
        button1.Location = new Point(179, 344);
        button1.Margin = new Padding(4, 4, 4, 4);
        button1.Name = "button1";
        button1.Size = new Size(96, 32);
        button1.TabIndex = 1;
        button1.Text = "Cerrar";
        button1.UseVisualStyleBackColor = true;
        // 
        // FormVer
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(473, 382);
        Controls.Add(button1);
        Controls.Add(listBox1);
        Margin = new Padding(4, 4, 4, 4);
        Name = "FormVer";
        Text = "FormVerTicket";
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    public ListBox listBox1;
}