namespace BarajaSpain.Desktop
{
    partial class FormBaraja
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
            button_Ordenar = new Button();
            button_Iniciar = new Button();
            button_Barajar = new Button();
            button_Imprimir = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label_status = new Label();
            SuspendLayout();
            // 
            // button_Ordenar
            // 
            button_Ordenar.Location = new Point(104, 22);
            button_Ordenar.Name = "button_Ordenar";
            button_Ordenar.Size = new Size(75, 23);
            button_Ordenar.TabIndex = 0;
            button_Ordenar.Text = "Ordenar";
            button_Ordenar.UseVisualStyleBackColor = true;
            button_Ordenar.Click += button_Ordenar_Click;
            // 
            // button_Iniciar
            // 
            button_Iniciar.Location = new Point(23, 22);
            button_Iniciar.Name = "button_Iniciar";
            button_Iniciar.Size = new Size(75, 23);
            button_Iniciar.TabIndex = 1;
            button_Iniciar.Text = "Iniciar";
            button_Iniciar.UseVisualStyleBackColor = true;
            button_Iniciar.Click += button_Iniciar_Click;
            // 
            // button_Barajar
            // 
            button_Barajar.Location = new Point(185, 22);
            button_Barajar.Name = "button_Barajar";
            button_Barajar.Size = new Size(75, 23);
            button_Barajar.TabIndex = 2;
            button_Barajar.Text = "Barajar";
            button_Barajar.UseVisualStyleBackColor = true;
            button_Barajar.Click += button_Barajar_Click;
            // 
            // button_Imprimir
            // 
            button_Imprimir.Location = new Point(266, 22);
            button_Imprimir.Name = "button_Imprimir";
            button_Imprimir.Size = new Size(75, 23);
            button_Imprimir.TabIndex = 3;
            button_Imprimir.Text = "Imprimir";
            button_Imprimir.UseVisualStyleBackColor = true;
            button_Imprimir.Click += button_Imprimir_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 80);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(318, 289);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Status:";
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_status.Location = new Point(68, 57);
            label_status.Name = "label_status";
            label_status.Size = new Size(0, 15);
            label_status.TabIndex = 6;
            // 
            // FormBaraja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 383);
            Controls.Add(label_status);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button_Imprimir);
            Controls.Add(button_Barajar);
            Controls.Add(button_Iniciar);
            Controls.Add(button_Ordenar);
            Name = "FormBaraja";
            Text = "Baraja Española";
            Load += FormBaraja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Ordenar;
        private Button button_Iniciar;
        private Button button_Barajar;
        private Button button_Imprimir;
        private ListBox listBox1;
        private Label label1;
        private Label label_status;
    }
}
