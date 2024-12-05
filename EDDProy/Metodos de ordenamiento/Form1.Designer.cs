namespace EDDemo.Metodos_de_ordenamiento
{
    partial class FormMetodo
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCrearList = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Label();
            this.lblShellSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRadix = new System.Windows.Forms.Label();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.TimeBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numericUpDown1.Location = new System.Drawing.Point(25, 223);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 35);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCrearList
            // 
            this.btnCrearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCrearList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearList.Location = new System.Drawing.Point(305, 382);
            this.btnCrearList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCrearList.Name = "btnCrearList";
            this.btnCrearList.Size = new System.Drawing.Size(179, 93);
            this.btnCrearList.TabIndex = 1;
            this.btnCrearList.Text = "Crear Lista";
            this.btnCrearList.UseVisualStyleBackColor = false;
            this.btnCrearList.Click += new System.EventHandler(this.btnCrearList_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(14, 532);
            this.txtLista.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(601, 35);
            this.txtLista.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "QuickSort:";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(295, 452);
            this.lblQuickSort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(0, 27);
            this.lblQuickSort.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrdenar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(609, 165);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(176, 93);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.AutoSize = true;
            this.ShellSort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShellSort.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellSort.Location = new System.Drawing.Point(39, 386);
            this.ShellSort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(98, 24);
            this.ShellSort.TabIndex = 7;
            this.ShellSort.Text = "ShellSort:";
            // 
            // lblShellSort
            // 
            this.lblShellSort.AutoSize = true;
            this.lblShellSort.Location = new System.Drawing.Point(295, 500);
            this.lblShellSort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShellSort.Name = "lblShellSort";
            this.lblShellSort.Size = new System.Drawing.Size(0, 27);
            this.lblShellSort.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 625);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Radix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1655, 714);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Burbuja:";
            // 
            // lblRadix
            // 
            this.lblRadix.AutoSize = true;
            this.lblRadix.Location = new System.Drawing.Point(295, 552);
            this.lblRadix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRadix.Name = "lblRadix";
            this.lblRadix.Size = new System.Drawing.Size(0, 27);
            this.lblRadix.TabIndex = 11;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(295, 609);
            this.lblBurbuja.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(0, 27);
            this.lblBurbuja.TabIndex = 12;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(918, 59);
            this.txtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(246, 35);
            this.txtBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(918, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 93);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(672, 100);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 27);
            this.lblResultado.TabIndex = 15;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1211, 448);
            this.time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 27);
            this.time.TabIndex = 16;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(1211, 500);
            this.time1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(0, 27);
            this.time1.TabIndex = 17;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(1211, 552);
            this.time2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(0, 27);
            this.time2.TabIndex = 18;
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(1211, 605);
            this.time3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(0, 27);
            this.time3.TabIndex = 19;
            // 
            // TimeBusqueda
            // 
            this.TimeBusqueda.AutoSize = true;
            this.TimeBusqueda.Location = new System.Drawing.Point(1164, 100);
            this.TimeBusqueda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeBusqueda.Name = "TimeBusqueda";
            this.TimeBusqueda.Size = new System.Drawing.Size(0, 27);
            this.TimeBusqueda.TabIndex = 20;
            // 
            // FormMetodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(1924, 759);
            this.Controls.Add(this.TimeBusqueda);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.lblRadix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShellSort);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnCrearList);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Pink;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMetodo";
            this.Text = "MetodoOrdenamiento";
            this.Load += new System.EventHandler(this.FormMetodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCrearList;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuickSort;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label ShellSort;
        private System.Windows.Forms.Label lblShellSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRadix;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label TimeBusqueda;
    }
}