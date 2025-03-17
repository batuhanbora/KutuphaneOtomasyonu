namespace KutuphaneWinForms
{
    partial class AnaForm
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
            lblUyeAdi = new Label();
            dgw_liste = new DataGridView();
            btnTumKitaplar = new Button();
            btnOduncKitaplar = new Button();
            btnUyeleriGoster = new Button();
            btnOduncAlinanKitaplar = new Button();
            btnOduncAl = new Button();
            btnIadeEt = new Button();
            btnAlinabilirKitaplar = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw_liste).BeginInit();
            SuspendLayout();
            // 
            // lblUyeAdi
            // 
            lblUyeAdi.Anchor = AnchorStyles.Top;
            lblUyeAdi.AutoSize = true;
            lblUyeAdi.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblUyeAdi.Location = new Point(370, 25);
            lblUyeAdi.Name = "lblUyeAdi";
            lblUyeAdi.Size = new Size(113, 22);
            lblUyeAdi.TabIndex = 0;
            lblUyeAdi.Text = "Üye Adı Soyadı";
            // 
            // dgw_liste
            // 
            dgw_liste.AllowUserToAddRows = false;
            dgw_liste.AllowUserToDeleteRows = false;
            dgw_liste.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgw_liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_liste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_liste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_liste.Location = new Point(64, 162);
            dgw_liste.MultiSelect = false;
            dgw_liste.Name = "dgw_liste";
            dgw_liste.ReadOnly = true;
            dgw_liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_liste.Size = new Size(684, 293);
            dgw_liste.TabIndex = 1;
            dgw_liste.CellClick += dgw_liste_CellClick;
            // 
            // btnTumKitaplar
            // 
            btnTumKitaplar.Anchor = AnchorStyles.Top;
            btnTumKitaplar.Location = new Point(64, 81);
            btnTumKitaplar.Name = "btnTumKitaplar";
            btnTumKitaplar.Size = new Size(117, 31);
            btnTumKitaplar.TabIndex = 2;
            btnTumKitaplar.Tag = "Kütüphanedeki Tüm Kitaplar";
            btnTumKitaplar.Text = "Tüm Kitaplar";
            btnTumKitaplar.UseVisualStyleBackColor = true;
            btnTumKitaplar.Click += btnTumKitaplar_Click;
            // 
            // btnOduncKitaplar
            // 
            btnOduncKitaplar.Anchor = AnchorStyles.Top;
            btnOduncKitaplar.Location = new Point(357, 81);
            btnOduncKitaplar.Name = "btnOduncKitaplar";
            btnOduncKitaplar.Size = new Size(116, 31);
            btnOduncKitaplar.TabIndex = 2;
            btnOduncKitaplar.Tag = "Ödünç Aldığım Kitaplar";
            btnOduncKitaplar.Text = "Aldığım Kitaplar";
            btnOduncKitaplar.UseVisualStyleBackColor = true;
            btnOduncKitaplar.Click += btnOduncKitaplar_Click;
            // 
            // btnUyeleriGoster
            // 
            btnUyeleriGoster.Anchor = AnchorStyles.Top;
            btnUyeleriGoster.Location = new Point(656, 81);
            btnUyeleriGoster.Name = "btnUyeleriGoster";
            btnUyeleriGoster.Size = new Size(92, 31);
            btnUyeleriGoster.TabIndex = 2;
            btnUyeleriGoster.Tag = "Üye Listesi";
            btnUyeleriGoster.Text = "Üyeler";
            btnUyeleriGoster.UseVisualStyleBackColor = true;
            btnUyeleriGoster.Click += btnUyeleriGoster_Click;
            // 
            // btnOduncAlinanKitaplar
            // 
            btnOduncAlinanKitaplar.Anchor = AnchorStyles.Top;
            btnOduncAlinanKitaplar.Location = new Point(507, 81);
            btnOduncAlinanKitaplar.Name = "btnOduncAlinanKitaplar";
            btnOduncAlinanKitaplar.Size = new Size(115, 31);
            btnOduncAlinanKitaplar.TabIndex = 2;
            btnOduncAlinanKitaplar.Tag = "Ödünç Alınmış Kitaplar";
            btnOduncAlinanKitaplar.Text = "Alınan Kitaplar";
            btnOduncAlinanKitaplar.UseVisualStyleBackColor = true;
            btnOduncAlinanKitaplar.Click += btnOduncAlinanKitaplar_Click;
            // 
            // btnOduncAl
            // 
            btnOduncAl.Anchor = AnchorStyles.Right;
            btnOduncAl.Location = new Point(778, 230);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(103, 36);
            btnOduncAl.TabIndex = 3;
            btnOduncAl.Text = "Ödünç Al";
            btnOduncAl.UseVisualStyleBackColor = true;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // btnIadeEt
            // 
            btnIadeEt.Anchor = AnchorStyles.Right;
            btnIadeEt.Location = new Point(778, 326);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(103, 36);
            btnIadeEt.TabIndex = 3;
            btnIadeEt.Text = "İade Et";
            btnIadeEt.UseVisualStyleBackColor = true;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // btnAlinabilirKitaplar
            // 
            btnAlinabilirKitaplar.Anchor = AnchorStyles.Top;
            btnAlinabilirKitaplar.Location = new Point(211, 81);
            btnAlinabilirKitaplar.Name = "btnAlinabilirKitaplar";
            btnAlinabilirKitaplar.Size = new Size(113, 31);
            btnAlinabilirKitaplar.TabIndex = 4;
            btnAlinabilirKitaplar.Tag = "Ödünç Alınabilir Kitaplar";
            btnAlinabilirKitaplar.Text = "Alınabilir Kitaplar";
            btnAlinabilirKitaplar.UseVisualStyleBackColor = true;
            btnAlinabilirKitaplar.Click += btnAlinabilirKitaplar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(64, 134);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(17, 27);
            lblTitle.TabIndex = 5;
            lblTitle.Text = ".";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(926, 522);
            Controls.Add(lblTitle);
            Controls.Add(btnAlinabilirKitaplar);
            Controls.Add(btnIadeEt);
            Controls.Add(btnOduncAl);
            Controls.Add(btnOduncAlinanKitaplar);
            Controls.Add(btnUyeleriGoster);
            Controls.Add(btnOduncKitaplar);
            Controls.Add(btnTumKitaplar);
            Controls.Add(dgw_liste);
            Controls.Add(lblUyeAdi);
            Name = "AnaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Arayüzü";
            Load += AnaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_liste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUyeAdi;
        private DataGridView dgw_liste;
        private Button btnTumKitaplar;
        private Button btnOduncKitaplar;
        private Button btnUyeleriGoster;
        private Button btnOduncAlinanKitaplar;
        private Button btnOduncAl;
        private Button btnIadeEt;
        private Button btnAlinabilirKitaplar;
        private Label lblTitle;
    }
}