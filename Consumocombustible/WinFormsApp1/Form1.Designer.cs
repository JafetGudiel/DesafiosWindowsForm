namespace WinFormsApp1
{
    partial class ConsumoCombustible
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
            kilometros = new TextBox();
            galones = new TextBox();
            num1 = new Label();
            num2 = new Label();
            calculo = new Button();
            result = new TextBox();
            resultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // kilometros
            // 
            kilometros.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            kilometros.ForeColor = SystemColors.ControlText;
            kilometros.Location = new Point(564, 120);
            kilometros.Name = "kilometros";
            kilometros.Size = new Size(125, 34);
            kilometros.TabIndex = 0;
            // 
            // galones
            // 
            galones.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            galones.ForeColor = SystemColors.ControlText;
            galones.Location = new Point(199, 120);
            galones.Name = "galones";
            galones.Size = new Size(125, 34);
            galones.TabIndex = 1;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            num1.ForeColor = Color.Cyan;
            num1.Location = new Point(90, 120);
            num1.Name = "num1";
            num1.Size = new Size(102, 26);
            num1.TabIndex = 2;
            num1.Text = "Distancia";
            num1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            num2.ForeColor = Color.Cyan;
            num2.Location = new Point(403, 120);
            num2.Name = "num2";
            num2.Size = new Size(131, 26);
            num2.TabIndex = 3;
            num2.Text = "Rendimiento";
            // 
            // calculo
            // 
            calculo.BackColor = SystemColors.ControlText;
            calculo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            calculo.ForeColor = Color.FromArgb(128, 128, 255);
            calculo.Location = new Point(310, 191);
            calculo.Name = "calculo";
            calculo.Size = new Size(191, 81);
            calculo.TabIndex = 8;
            calculo.Text = "Calcular";
            calculo.UseVisualStyleBackColor = false;
            calculo.Click += calculo_Click;
            // 
            // result
            // 
            result.Enabled = false;
            result.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            result.ForeColor = SystemColors.ControlText;
            result.Location = new Point(603, 364);
            result.Name = "result";
            result.Size = new Size(103, 34);
            result.TabIndex = 10;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            resultado.ForeColor = Color.Yellow;
            resultado.Location = new Point(403, 322);
            resultado.Name = "resultado";
            resultado.Size = new Size(222, 26);
            resultado.TabIndex = 11;
            resultado.Text = "Galones Consumidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(182, 30);
            label1.Name = "label1";
            label1.Size = new Size(484, 51);
            label1.TabIndex = 12;
            label1.Text = "Calculadora Combustible";
            // 
            // ConsumoCombustible
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(resultado);
            Controls.Add(result);
            Controls.Add(calculo);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(galones);
            Controls.Add(kilometros);
            Name = "ConsumoCombustible";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kilometros;
        private TextBox galones;
        private Label num1;
        private Label num2;
        private Button calculo;
        private TextBox result;
        private Label resultado;
        private Label label1;
    }
}
