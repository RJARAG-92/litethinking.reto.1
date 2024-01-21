namespace BarajaSpain.Desktop
{
    partial class FormEsqueleto
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
            label_status = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            button_Imprimir = new Button();
            button_Iniciar = new Button();
            button_Ordenar = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_status.Location = new Point(57, 47);
            label_status.Name = "label_status";
            label_status.Size = new Size(0, 15);
            label_status.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 12;
            label1.Text = "Status:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 70);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(883, 289);
            listBox1.TabIndex = 11;
            // 
            // button_Imprimir
            // 
            button_Imprimir.Location = new Point(496, 14);
            button_Imprimir.Name = "button_Imprimir";
            button_Imprimir.Size = new Size(75, 23);
            button_Imprimir.TabIndex = 10;
            button_Imprimir.Text = "Imprimir";
            button_Imprimir.UseVisualStyleBackColor = true;
            button_Imprimir.Click += button_Imprimir_Click;
            // 
            // button_Iniciar
            // 
            button_Iniciar.Location = new Point(12, 12);
            button_Iniciar.Name = "button_Iniciar";
            button_Iniciar.Size = new Size(75, 23);
            button_Iniciar.TabIndex = 8;
            button_Iniciar.Text = "Cargar";
            button_Iniciar.UseVisualStyleBackColor = true;
            button_Iniciar.Click += button_Iniciar_Click;
            // 
            // button_Ordenar
            // 
            button_Ordenar.Location = new Point(415, 14);
            button_Ordenar.Name = "button_Ordenar";
            button_Ordenar.Size = new Size(75, 23);
            button_Ordenar.TabIndex = 7;
            button_Ordenar.Text = "Ordenar";
            button_Ordenar.UseVisualStyleBackColor = true;
            button_Ordenar.Click += button_Ordenar_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nombre", "Peso", "Densidad", "Longitud", "Diametro" });
            comboBox1.Location = new Point(93, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "asc", "desc" });
            comboBox2.Location = new Point(269, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 15;
            // 
            // FormEsqueleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label_status);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button_Imprimir);
            Controls.Add(button_Iniciar);
            Controls.Add(button_Ordenar);
            Name = "FormEsqueleto";
            Text = "FormEsqueleto";
            Load += FormEsqueleto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_status;
        private Label label1;
        private ListBox listBox1;
        private Button button_Imprimir;
        private Button button_Iniciar;
        private Button button_Ordenar;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}