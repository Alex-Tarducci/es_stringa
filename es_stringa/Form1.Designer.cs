namespace es_stringa
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
            lbl_parola = new Label();
            txt_n1 = new TextBox();
            btn_n1 = new Button();
            SuspendLayout();
            // 
            // lbl_parola
            // 
            lbl_parola.AutoSize = true;
            lbl_parola.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_parola.ForeColor = Color.Red;
            lbl_parola.Location = new Point(64, 52);
            lbl_parola.Name = "lbl_parola";
            lbl_parola.Size = new Size(112, 15);
            lbl_parola.TabIndex = 0;
            lbl_parola.Text = "inserisci una parola";
            // 
            // txt_n1
            // 
            txt_n1.Location = new Point(64, 85);
            txt_n1.Name = "txt_n1";
            txt_n1.Size = new Size(100, 23);
            txt_n1.TabIndex = 1;
            // 
            // btn_n1
            // 
            btn_n1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_n1.Location = new Point(73, 129);
            btn_n1.Name = "btn_n1";
            btn_n1.Size = new Size(75, 23);
            btn_n1.TabIndex = 2;
            btn_n1.Text = "calcola";
            btn_n1.UseVisualStyleBackColor = true;
            btn_n1.Click += btn_n1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_n1);
            Controls.Add(txt_n1);
            Controls.Add(lbl_parola);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_parola;
        private TextBox txt_n1;
        private Button btn_n1;
    }
}
