namespace Automatas_Compilador
{
    partial class Form1
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
            this.panelCode = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.panelToken = new System.Windows.Forms.Panel();
            this.gridTokens = new System.Windows.Forms.DataGridView();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnResJama = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPalabrasResC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPalabrasResJama = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCompilar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuArbol = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridErrores = new System.Windows.Forms.DataGridView();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilaErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.checkBoxLenguaje = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arg2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeTresDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCode.SuspendLayout();
            this.panelToken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTokens)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.txtCode);
            this.panelCode.Location = new System.Drawing.Point(15, 63);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(736, 366);
            this.panelCode.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txtCode.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(736, 366);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged_1);
            // 
            // panelToken
            // 
            this.panelToken.Controls.Add(this.gridTokens);
            this.panelToken.Location = new System.Drawing.Point(757, 63);
            this.panelToken.Name = "panelToken";
            this.panelToken.Size = new System.Drawing.Size(222, 366);
            this.panelToken.TabIndex = 1;
            // 
            // gridTokens
            // 
            this.gridTokens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.gridTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Componente,
            this.Entrada,
            this.Columna,
            this.Fila});
            this.gridTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTokens.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.gridTokens.Location = new System.Drawing.Point(0, 0);
            this.gridTokens.Name = "gridTokens";
            this.gridTokens.Size = new System.Drawing.Size(222, 366);
            this.gridTokens.TabIndex = 0;
            // 
            // Componente
            // 
            this.Componente.HeaderText = "Componente";
            this.Componente.Name = "Componente";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Columna
            // 
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            // 
            // Fila
            // 
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResJama,
            this.btnMenuCompilar,
            this.btnMenuArbol,
            this.codigoDeTresDireccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnResJama
            // 
            this.btnResJama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPalabrasResC,
            this.btnPalabrasResJama});
            this.btnResJama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResJama.Name = "btnResJama";
            this.btnResJama.Size = new System.Drawing.Size(121, 20);
            this.btnResJama.Text = "Palabras reservadas";
            // 
            // btnPalabrasResC
            // 
            this.btnPalabrasResC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnPalabrasResC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPalabrasResC.Name = "btnPalabrasResC";
            this.btnPalabrasResC.Size = new System.Drawing.Size(101, 22);
            this.btnPalabrasResC.Text = "C";
            this.btnPalabrasResC.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // btnPalabrasResJama
            // 
            this.btnPalabrasResJama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnPalabrasResJama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPalabrasResJama.Name = "btnPalabrasResJama";
            this.btnPalabrasResJama.Size = new System.Drawing.Size(101, 22);
            this.btnPalabrasResJama.Text = "Jama";
            this.btnPalabrasResJama.Click += new System.EventHandler(this.btnPalabrasResJava_Click);
            // 
            // btnMenuCompilar
            // 
            this.btnMenuCompilar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuCompilar.Name = "btnMenuCompilar";
            this.btnMenuCompilar.Size = new System.Drawing.Size(68, 20);
            this.btnMenuCompilar.Text = "Compilar";
            this.btnMenuCompilar.Click += new System.EventHandler(this.btnMenuCompilar_Click);
            // 
            // btnMenuArbol
            // 
            this.btnMenuArbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuArbol.Name = "btnMenuArbol";
            this.btnMenuArbol.Size = new System.Drawing.Size(48, 20);
            this.btnMenuArbol.Text = "Árbol";
            this.btnMenuArbol.Click += new System.EventHandler(this.btnMenuArbol_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(15, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 165);
            this.panel1.TabIndex = 4;
            // 
            // gridErrores
            // 
            this.gridErrores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.gridErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Error,
            this.Descripcion,
            this.ColumnaErr,
            this.FilaErr});
            this.gridErrores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.gridErrores.Location = new System.Drawing.Point(-6, -3);
            this.gridErrores.Name = "gridErrores";
            this.gridErrores.Size = new System.Drawing.Size(963, 132);
            this.gridErrores.TabIndex = 0;
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.Width = 170;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 550;
            // 
            // ColumnaErr
            // 
            this.ColumnaErr.HeaderText = "ColumnaErr";
            this.ColumnaErr.Name = "ColumnaErr";
            // 
            // FilaErr
            // 
            this.FilaErr.HeaderText = "FilaErr";
            this.FilaErr.Name = "FilaErr";
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.AutoSize = true;
            this.lblLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenguaje.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLenguaje.Location = new System.Drawing.Point(12, 40);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(131, 20);
            this.lblLenguaje.TabIndex = 6;
            this.lblLenguaje.Text = "Lenguaje Jama";
            // 
            // checkBoxLenguaje
            // 
            this.checkBoxLenguaje.AutoSize = true;
            this.checkBoxLenguaje.Checked = true;
            this.checkBoxLenguaje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLenguaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxLenguaje.Location = new System.Drawing.Point(653, 27);
            this.checkBoxLenguaje.Name = "checkBoxLenguaje";
            this.checkBoxLenguaje.Size = new System.Drawing.Size(98, 17);
            this.checkBoxLenguaje.TabIndex = 9;
            this.checkBoxLenguaje.Text = "Lenguaje Jama";
            this.checkBoxLenguaje.UseVisualStyleBackColor = true;
            this.checkBoxLenguaje.CheckedChanged += new System.EventHandler(this.checkBoxLenguaje_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.op,
            this.arg1,
            this.arg2,
            this.resultado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 119);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 151);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridErrores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 125);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // op
            // 
            this.op.HeaderText = "Opereador";
            this.op.Name = "op";
            this.op.Width = 260;
            // 
            // arg1
            // 
            this.arg1.HeaderText = "arg1";
            this.arg1.Name = "arg1";
            this.arg1.Width = 260;
            // 
            // arg2
            // 
            this.arg2.HeaderText = "arg2";
            this.arg2.Name = "arg2";
            this.arg2.Width = 260;
            // 
            // resultado
            // 
            this.resultado.HeaderText = "resultado";
            this.resultado.Name = "resultado";
            this.resultado.Width = 260;
            // 
            // codigoDeTresDireccionesToolStripMenuItem
            // 
            this.codigoDeTresDireccionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.codigoDeTresDireccionesToolStripMenuItem.Name = "codigoDeTresDireccionesToolStripMenuItem";
            this.codigoDeTresDireccionesToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.codigoDeTresDireccionesToolStripMenuItem.Text = "Codigo de Tres Direcciones";
            this.codigoDeTresDireccionesToolStripMenuItem.Click += new System.EventHandler(this.codigoDeTresDireccionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(994, 620);
            this.Controls.Add(this.checkBoxLenguaje);
            this.Controls.Add(this.lblLenguaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelToken);
            this.Controls.Add(this.panelCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCode.ResumeLayout(false);
            this.panelToken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTokens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.Panel panelToken;
        private System.Windows.Forms.DataGridView gridTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Componente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnResJama;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCompilar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilaErr;
        private System.Windows.Forms.ToolStripMenuItem btnMenuArbol;
        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.ToolStripMenuItem btnPalabrasResC;
        private System.Windows.Forms.ToolStripMenuItem btnPalabrasResJama;
        private System.Windows.Forms.CheckBox checkBoxLenguaje;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn op;
        private System.Windows.Forms.DataGridViewTextBoxColumn arg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.ToolStripMenuItem codigoDeTresDireccionesToolStripMenuItem;
    }
}

