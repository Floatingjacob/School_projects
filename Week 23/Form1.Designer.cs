namespace Week_23
{
    partial class Form1
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
            label1 = new Label();
            F = new TextBox();
            C = new TextBox();
            Celcius = new Label();
            rslt = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit";
            // 
            // F
            // 
            F.Location = new Point(18, 38);
            F.Name = "F";
            F.Size = new Size(100, 23);
            F.TabIndex = 1;
            F.TextChanged += F_TextChanged;
            // 
            // C
            // 
            C.Location = new Point(148, 38);
            C.Name = "C";
            C.Size = new Size(100, 23);
            C.TabIndex = 4;
            C.TextChanged += C_TextChanged;
            // 
            // Celcius
            // 
            Celcius.AutoSize = true;
            Celcius.Location = new Point(170, 18);
            Celcius.Name = "Celcius";
            Celcius.Size = new Size(45, 15);
            Celcius.TabIndex = 3;
            Celcius.Text = "Celcius";
            // 
            // rslt
            // 
            rslt.AutoSize = true;
            rslt.Font = new Font("Segoe UI", 20F);
            rslt.Location = new Point(90, 76);
            rslt.Name = "rslt";
            rslt.Size = new Size(82, 37);
            rslt.TabIndex = 5;
            rslt.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 120);
            Controls.Add(rslt);
            Controls.Add(C);
            Controls.Add(Celcius);
            Controls.Add(F);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox F;
        private TextBox C;
        private Label Celcius;
        private Label rslt;
    }
}