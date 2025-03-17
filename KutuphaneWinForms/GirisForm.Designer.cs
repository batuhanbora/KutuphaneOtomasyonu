namespace KutuphaneWinForms
{
    partial class GirisForm
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
            txtUyeNo = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUyeNo
            // 
            txtUyeNo.Location = new Point(207, 165);
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.PlaceholderText = "Uye No";
            txtUyeNo.Size = new Size(102, 23);
            txtUyeNo.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(207, 209);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(102, 41);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(173, 84);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 2;
            label1.Text = "Kütüphane Giriş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(229, 143);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 3;
            label2.Text = "Üye No";
            // 
            // GirisForm
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(545, 370);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtUyeNo);
            Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "GirisForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUyeNo;
        private Button btnGiris;
        private Label label1;
        private Label label2;
    }
}