using CSProjeDemo1.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneWinForms
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int uyeNo;
            var uyeNoText = txtUyeNo.Text.Trim();
            if (string.IsNullOrEmpty(uyeNoText))
            {
                MessageBox.Show("Üye numarasını boş bırakmayınız.");
                return;
            }

            if (int.TryParse(uyeNoText, out uyeNo))
            {
                using (var context = new KutuphaneContext())
                {
                    var uye = context.Uyeler
                        .Include(u => u.OduncAlinanKitaplar)
                        .FirstOrDefault(u => u.UyeNo == uyeNo);
                    if (uye != null)
                    {
                        AnaForm anaForm = new AnaForm(uye);
                        this.Hide();
                        anaForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Üye bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir üye numarası giriniz.");
            }
        }
    }
}
