namespace AppNombre
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbEmpieza = new System.Windows.Forms.RadioButton();
            this.rdbTermina = new System.Windows.Forms.RadioButton();
            this.rdbContiene = new System.Windows.Forms.RadioButton();
            this.rdbExacto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(12, 56);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(150, 29);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 20;
            this.lstNombres.Location = new System.Drawing.Point(12, 91);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(150, 344);
            this.lstNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(168, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(144, 27);
            this.txtFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(168, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExacto);
            this.groupBox1.Controls.Add(this.rdbContiene);
            this.groupBox1.Controls.Add(this.rdbTermina);
            this.groupBox1.Controls.Add(this.rdbEmpieza);
            this.groupBox1.Location = new System.Drawing.Point(168, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios";
            // 
            // rdbEmpieza
            // 
            this.rdbEmpieza.AutoSize = true;
            this.rdbEmpieza.Location = new System.Drawing.Point(3, 55);
            this.rdbEmpieza.Name = "rdbEmpieza";
            this.rdbEmpieza.Size = new System.Drawing.Size(114, 24);
            this.rdbEmpieza.TabIndex = 0;
            this.rdbEmpieza.TabStop = true;
            this.rdbEmpieza.Text = "Empieza por";
            this.rdbEmpieza.UseVisualStyleBackColor = true;
            // 
            // rdbTermina
            // 
            this.rdbTermina.AutoSize = true;
            this.rdbTermina.Location = new System.Drawing.Point(3, 95);
            this.rdbTermina.Name = "rdbTermina";
            this.rdbTermina.Size = new System.Drawing.Size(111, 24);
            this.rdbTermina.TabIndex = 1;
            this.rdbTermina.TabStop = true;
            this.rdbTermina.Text = "Termina con";
            this.rdbTermina.UseVisualStyleBackColor = true;
            // 
            // rdbContiene
            // 
            this.rdbContiene.AutoSize = true;
            this.rdbContiene.Location = new System.Drawing.Point(3, 135);
            this.rdbContiene.Name = "rdbContiene";
            this.rdbContiene.Size = new System.Drawing.Size(89, 24);
            this.rdbContiene.TabIndex = 2;
            this.rdbContiene.TabStop = true;
            this.rdbContiene.Text = "Contiene";
            this.rdbContiene.UseVisualStyleBackColor = true;
            // 
            // rdbExacto
            // 
            this.rdbExacto.AutoSize = true;
            this.rdbExacto.Location = new System.Drawing.Point(3, 23);
            this.rdbExacto.Name = "rdbExacto";
            this.rdbExacto.Size = new System.Drawing.Size(154, 24);
            this.rdbExacto.TabIndex = 3;
            this.rdbExacto.TabStop = true;
            this.rdbExacto.Text = "Coicidencia exacta";
            this.rdbExacto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnInsertar;
        private ListBox lstNombres;
        private Label label2;
        private TextBox txtFiltro;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private RadioButton rdbExacto;
        private RadioButton rdbContiene;
        private RadioButton rdbTermina;
        private RadioButton rdbEmpieza;
    }
}