using CSProjeDemo1.Data;
using CSProjeDemo1.Entities;
using CSProjeDemo1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneWinForms
{
    public partial class AnaForm : Form
    {
        private readonly Uye aktifUye;
        private readonly Kutuphane kutuphane;

        public AnaForm(Uye uye)
        {
            InitializeComponent();
            aktifUye = uye;
            kutuphane = new Kutuphane();
            lblUyeAdi.Text = $"{uye.Ad} {uye.Soyad}";
            lblTitle.Text = "";
        }

        private void btnTumKitaplar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = btnTumKitaplar.Tag.ToString();
            DugmeleriSifirla();
            dgw_liste.DataSource = kutuphane.KitaplariListele().Select(k => new { k.Id, k.ISBN, k.Baslik, k.Yazar, k.YayinYili, k.KitapDurumu }).ToList();
            dgw_liste.Columns["Id"].Visible = false;
        }
        private void btnAlinabilirKitaplar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = btnAlinabilirKitaplar.Tag.ToString();
            DugmeleriSifirla();
            dgw_liste.DataSource = kutuphane.KitaplariDurumaGoreListele(Durum.OduncAlabilir).Select(k => new { k.Id, k.ISBN, k.Baslik, k.Yazar, k.YayinYili }).ToList();
            dgw_liste.Columns["Id"].Visible = false;
        }

        private void btnOduncKitaplar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = btnOduncKitaplar.Tag.ToString();
            DugmeleriSifirla();
            dgw_liste.DataSource = kutuphane.UyeyeAitKitaplar(aktifUye.UyeNo).Select(k => new { k.Id, k.ISBN, k.Baslik, k.Yazar, k.YayinYili }).ToList();
            dgw_liste.Columns["Id"].Visible = false;
        }

        private void btnUyeleriGoster_Click(object sender, EventArgs e)
        {
            lblTitle.Text = btnUyeleriGoster.Tag.ToString();
            DugmeleriSifirla();
            dgw_liste.DataSource = kutuphane.UyeleriListele().Select(u => new { u.Ad, u.Soyad }).ToList();
        }

        private void btnOduncAlinanKitaplar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = btnOduncAlinanKitaplar.Tag.ToString();
            DugmeleriSifirla();
            dgw_liste.DataSource = kutuphane.KitaplariDurumaGoreListele(Durum.OduncVerildi).Select(k => new { k.Id, k.ISBN, k.Baslik, k.Yazar, k.YayinYili }).ToList();
            dgw_liste.Columns["Id"].Visible = false;
        }

        private void dgw_liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgw_liste.Rows[e.RowIndex];

                if (selectedRow.Cells.Cast<DataGridViewCell>().Any(c => c.OwningColumn.Name == "Id"))
                {
                    int kitapId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    var kitap = kutuphane.KitaplariListele().FirstOrDefault(k => k.Id == kitapId);

                    if (kitap != null)
                    {                        
                        if (kitap.KitapDurumu == Durum.OduncAlabilir)
                        {
                            btnOduncAl.Enabled = true;
                            btnIadeEt.Enabled = false;
                        }
                        else if (kitap.KitapDurumu == Durum.OduncVerildi && kitap.UyeNo == aktifUye.UyeNo)
                        {
                            btnOduncAl.Enabled = false;
                            btnIadeEt.Enabled = true;
                        }
                        else
                        {
                            btnOduncAl.Enabled = false;
                            btnIadeEt.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kitap bulunamadı.");
                    }
                }
                else 
                    DugmeleriSifirla();
            }
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            if (dgw_liste.SelectedRows.Count > 0)
            {
                var selectedRow = dgw_liste.SelectedRows[0];
                int kitapId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var kitap = kutuphane.KitaplariListele().FirstOrDefault(k => k.Id == kitapId);

                if (kitap != null)
                {
                    kutuphane.KitapOduncAl(kitap, aktifUye);
                    MessageBox.Show($"{kitap.Baslik} adlı kitabı ödünç aldınız.");
                    btnOduncAl.Enabled = false;
                    btnIadeEt.Enabled = true;
                    ListeyiYenile();
                }
            }
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (dgw_liste.SelectedRows.Count > 0)
            {
                var selectedRow = dgw_liste.SelectedRows[0];
                int kitapId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var kitap = kutuphane.KitaplariListele().FirstOrDefault(k => k.Id == kitapId);

                if (kitap != null)
                {
                    kutuphane.KitapIadeEt(kitap, aktifUye);
                    MessageBox.Show($"{kitap.Baslik} adlı kitabı iade ettiniz.");
                    btnOduncAl.Enabled = true;
                    btnIadeEt.Enabled = false;
                    ListeyiYenile();
                }
            }
        }

        private void ListeyiYenile()
        {
            dgw_liste.DataSource = null; 
            dgw_liste.DataSource = kutuphane.KitaplariListele(); 
            DugmeleriSifirla();
        }

        private void DugmeleriSifirla()
        {
            btnOduncAl.Enabled = false;
            btnIadeEt.Enabled = false;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DugmeleriSifirla();
        }
    }
}