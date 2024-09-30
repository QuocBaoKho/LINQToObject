using System.Data;

namespace LINQToObject
{
    public partial class Form1 : Form
    {
        List<SanPham> sanPhams;
        System.Windows.Forms.Timer timer1;
        public Form1()
        {
            InitializeComponent();
            sanPhams = new List<SanPham>();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            dataGridView1.AutoGenerateColumns = dataGridView2.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("MaSP", "Mã SP");
            dataGridView1.Columns["MaSP"].DataPropertyName = "MaSP";
            dataGridView1.Columns.Add("TenSP", "Tên SP");
            dataGridView1.Columns["TenSP"].DataPropertyName = "TenSP";
            dataGridView1.Columns.Add("SoLuong", "Số lượng");
            dataGridView1.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dataGridView1.Columns.Add("DonGia", "Đơn giá");
            dataGridView1.Columns["DonGia"].DataPropertyName = "DonGia";
            dataGridView1.Columns.Add("XuatXu", "Xuất xứ");
            dataGridView1.Columns["XuatXu"].DataPropertyName = "XuatXu";
            dataGridView1.Columns.Add("NgayHetHan", "Ngày hết hạn");
            dataGridView1.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";
            dataGridView1.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd-MM-yyyy";

            dataGridView2.Columns.Add("MaSP", "Mã SP");
            dataGridView2.Columns["MaSP"].DataPropertyName = "MaSP";
            dataGridView2.Columns.Add("TenSP", "Tên SP");
            dataGridView2.Columns["TenSP"].DataPropertyName = "TenSP";
            dataGridView2.Columns.Add("SoLuong", "Số lượng");
            dataGridView2.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dataGridView2.Columns.Add("DonGia", "Đơn giá");
            dataGridView2.Columns["DonGia"].DataPropertyName = "DonGia";
            dataGridView2.Columns.Add("XuatXu", "Xuất xứ");
            dataGridView2.Columns["XuatXu"].DataPropertyName = "XuatXu";
            dataGridView2.Columns.Add("NgayHetHan", "Ngày hết hạn");
            dataGridView2.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";
            dataGridView2.Columns["NgayHetHan"].DefaultCellStyle.Format = "dd-MM-yyyy";

            expiredDatePicker.CustomFormat = " ";

        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            checkExpiredBTN.Text = "Kiểm tra kho có SP quá hạn hay không";        
            timer1.Stop();
        }

        bool isAllInfoFilled()
        {
            return !(string.IsNullOrEmpty(txtOrigin.Text) || string.IsNullOrEmpty(txtProductCode.Text) ||
                string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) || expiredDatePicker.CustomFormat == " ");
        }
        bool IsAOrBFilled()
        {
            return !(string.IsNullOrEmpty(txtA.Text) && string.IsNullOrEmpty(txtB.Text));
        }
        bool CheckExistId(string id)
        {
            return sanPhams.Any(p => p.MaSP.ToLower().Equals(id.ToLower()));
        }

        void UpdateGridView2()
        {
            txtProductCode.Text = txtProductName.Text = txtQuantity.Text = txtPrice.Text = txtOrigin.Text = "";
            expiredDatePicker.CustomFormat = " ";
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = sanPhams;

        }
        void UpdateGridView2Alt()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = sanPhams;

        }
        void UpdateGridView1(List<SanPham> x)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = x;

        }
        void checkDigitWhenTyping(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigitWhenTyping(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigitWhenTyping(e);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigitWhenTyping(e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDigitWhenTyping(e);
        }

        private void saveProductBTN_Click(object sender, EventArgs e)
        {
            //If product exists, we update
            if (CheckExistId(txtProductCode.Text))
            {
                var sanPhamUpdated = sanPhams.SingleOrDefault(p => p.MaSP.ToLower().Equals(txtProductCode.Text.ToLower()));
                if (txtProductName.Text.Length > 0)
                {
                    sanPhamUpdated.TenSP = txtProductName.Text;
                }
                if (txtQuantity.Text.Length > 0)
                {
                    sanPhamUpdated.SoLuong = int.Parse(txtQuantity.Text);
                }
                if (txtPrice.Text.Length > 0)
                {
                    sanPhamUpdated.DonGia = int.Parse(txtPrice.Text);
                }
                if (txtOrigin.Text.Length > 0)
                {
                    sanPhamUpdated.XuatXu = txtOrigin.Text;
                }
                if (expiredDatePicker.CustomFormat != " ")
                {
                    sanPhamUpdated.NgayHetHan = expiredDatePicker.Value;
                }
                UpdateGridView2();
            }
            else
            if (isAllInfoFilled())
            {
                SanPham sanPham = new SanPham()
                {
                    MaSP = txtProductCode.Text,
                    TenSP = txtProductName.Text,
                    SoLuong = int.Parse(txtQuantity.Text),
                    DonGia = int.Parse(txtPrice.Text),
                    XuatXu = txtOrigin.Text,
                    NgayHetHan = expiredDatePicker.Value,

                };
                sanPhams.Add(sanPham);
                UpdateGridView2();

            }
            else
            {
                return;
            }

        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void expiredDatePicker_ValueChanged(object sender, EventArgs e)
        {
            expiredDatePicker.Format = DateTimePickerFormat.Custom;
            expiredDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void removeProductBTN_Click(object sender, EventArgs e)
        {
            if (CheckExistId(txtProductCode.Text))
            {
                var sanPhamUpdated = sanPhams.SingleOrDefault(p => p.MaSP.ToLower().Equals(txtProductCode.Text.ToLower()));
                sanPhams.Remove(sanPhamUpdated);
                UpdateGridView2();

            }
        }

        private void HighestPriceBTN_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count > 0)
            {
                var SanPhamHighestPrice = sanPhams.OrderByDescending(p => p.DonGia).FirstOrDefault();
                List<SanPham> spPhu = new List<SanPham>();
                spPhu.Add(SanPhamHighestPrice);
                UpdateGridView1(spPhu);
            }
        }

        private void JapanBTN_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count > 0)
            {
                var SanPhamJapan = sanPhams.Where(p => p.XuatXu.ToLower().Equals("nhật bản") ||
                p.XuatXu.ToLower().Equals("japan") || p.XuatXu.ToLower().Equals("jpn")).FirstOrDefault();
                List<SanPham> spPhu = new List<SanPham>();
                spPhu.Add(SanPhamJapan);
                UpdateGridView1(spPhu);
            }
        }

        private void ExpiredProductsBTN_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count > 0)
            {
                var expiredProducts = sanPhams.Where(p => p.NgayHetHan < DateTime.Now).ToList();
                UpdateGridView1(expiredProducts);
            }
        }

        private void aToBPriceBTN_Click(object sender, EventArgs e)
        {
            if (IsAOrBFilled())
            {
                if (String.IsNullOrEmpty(txtA.Text))
                {
                    var toBProducts = sanPhams.Where(p => p.DonGia <= int.Parse(txtB.Text)).ToList();
                    UpdateGridView1(toBProducts);
                }
                else if (String.IsNullOrEmpty(txtB.Text))
                {
                    var toAProducts = sanPhams.Where(p => p.DonGia >= int.Parse(txtA.Text)).ToList();
                    UpdateGridView1(toAProducts);
                }
                else
                {
                    var aToBProducts = sanPhams.Where(p => p.DonGia >= int.Parse(txtA.Text) && p.DonGia <= int.Parse(txtB.Text)).ToList();
                    UpdateGridView1(aToBProducts);
                }
            }
        }

        private void removeViaOriginBTN_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count > 0)
            {
                sanPhams.RemoveAll(p => p.XuatXu.ToLower().Equals(txtXuatXuAny.Text.ToLower()));
                UpdateGridView2Alt();
            }
        }

        private void removeAllBTN_Click(object sender, EventArgs e)
        {
            sanPhams.Clear();
            UpdateGridView2Alt();
        }

        private void removeAllExpiredBTN_Click(object sender, EventArgs e)
        {
            sanPhams.RemoveAll(p => p.NgayHetHan < DateTime.Now);
            UpdateGridView2Alt();
        }

        private void checkExpiredBTN_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count > 0)
            {
                if (sanPhams.Exists(p => p.NgayHetHan < DateTime.Now))
                {
                    checkExpiredBTN.Text += " 😊";
                }
                else
                {
                    checkExpiredBTN.Text += " 🤷";
                }
                timer1.Start();

            }
        }
    }
}
