namespace LINQToObject
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
            ProductInfoGrpBx = new GroupBox();
            expiredDatePicker = new DateTimePicker();
            removeProductBTN = new Button();
            saveProductBTN = new Button();
            txtOrigin = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            ngayHetHan = new Label();
            xuatXu = new Label();
            donGia = new Label();
            soLuong = new Label();
            tenSP = new Label();
            maSP = new Label();
            chonThaoTacGrpBx = new GroupBox();
            txtXuatXuAny = new TextBox();
            checkExpiredBTN = new Button();
            removeAllExpiredBTN = new Button();
            removeAllBTN = new Button();
            removeViaOriginBTN = new Button();
            SearchGrpBx = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            aToBPriceBTN = new Button();
            ExpiredProductsBTN = new Button();
            JapanBTN = new Button();
            HighestPriceBTN = new Button();
            dataGridView1 = new DataGridView();
            DSSPGrpBx = new GroupBox();
            dataGridView2 = new DataGridView();
            ProductInfoGrpBx.SuspendLayout();
            chonThaoTacGrpBx.SuspendLayout();
            SearchGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            DSSPGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // ProductInfoGrpBx
            // 
            ProductInfoGrpBx.BackColor = Color.DeepSkyBlue;
            ProductInfoGrpBx.Controls.Add(expiredDatePicker);
            ProductInfoGrpBx.Controls.Add(removeProductBTN);
            ProductInfoGrpBx.Controls.Add(saveProductBTN);
            ProductInfoGrpBx.Controls.Add(txtOrigin);
            ProductInfoGrpBx.Controls.Add(txtPrice);
            ProductInfoGrpBx.Controls.Add(txtQuantity);
            ProductInfoGrpBx.Controls.Add(txtProductName);
            ProductInfoGrpBx.Controls.Add(txtProductCode);
            ProductInfoGrpBx.Controls.Add(ngayHetHan);
            ProductInfoGrpBx.Controls.Add(xuatXu);
            ProductInfoGrpBx.Controls.Add(donGia);
            ProductInfoGrpBx.Controls.Add(soLuong);
            ProductInfoGrpBx.Controls.Add(tenSP);
            ProductInfoGrpBx.Controls.Add(maSP);
            ProductInfoGrpBx.Location = new Point(3, 12);
            ProductInfoGrpBx.Name = "ProductInfoGrpBx";
            ProductInfoGrpBx.Size = new Size(287, 304);
            ProductInfoGrpBx.TabIndex = 0;
            ProductInfoGrpBx.TabStop = false;
            ProductInfoGrpBx.Text = "Nhập thông tin sản phẩm";
            // 
            // expiredDatePicker
            // 
            expiredDatePicker.CustomFormat = "";
            expiredDatePicker.Format = DateTimePickerFormat.Custom;
            expiredDatePicker.Location = new Point(99, 204);
            expiredDatePicker.Name = "expiredDatePicker";
            expiredDatePicker.Size = new Size(125, 27);
            expiredDatePicker.TabIndex = 14;
            expiredDatePicker.ValueChanged += expiredDatePicker_ValueChanged;
            // 
            // removeProductBTN
            // 
            removeProductBTN.Location = new Point(145, 247);
            removeProductBTN.Name = "removeProductBTN";
            removeProductBTN.Size = new Size(94, 29);
            removeProductBTN.TabIndex = 13;
            removeProductBTN.Text = "Xóa SP";
            removeProductBTN.UseVisualStyleBackColor = true;
            removeProductBTN.Click += removeProductBTN_Click;
            // 
            // saveProductBTN
            // 
            saveProductBTN.Location = new Point(15, 247);
            saveProductBTN.Name = "saveProductBTN";
            saveProductBTN.Size = new Size(94, 29);
            saveProductBTN.TabIndex = 12;
            saveProductBTN.Text = "Lưu SP";
            saveProductBTN.UseVisualStyleBackColor = true;
            saveProductBTN.Click += saveProductBTN_Click;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(99, 159);
            txtOrigin.MaximumSize = new Size(125, 21);
            txtOrigin.MinimumSize = new Size(125, 21);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(125, 21);
            txtOrigin.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(99, 126);
            txtPrice.MaximumSize = new Size(125, 21);
            txtPrice.MinimumSize = new Size(125, 21);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 21);
            txtPrice.TabIndex = 9;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(99, 95);
            txtQuantity.MaximumSize = new Size(125, 21);
            txtQuantity.MinimumSize = new Size(125, 21);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 21);
            txtQuantity.TabIndex = 8;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(99, 64);
            txtProductName.MaximumSize = new Size(125, 21);
            txtProductName.MinimumSize = new Size(125, 21);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 21);
            txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(99, 35);
            txtProductCode.MaximumSize = new Size(125, 21);
            txtProductCode.MinimumSize = new Size(125, 21);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(125, 21);
            txtProductCode.TabIndex = 6;
            txtProductCode.KeyPress += txtProductCode_KeyPress;
            // 
            // ngayHetHan
            // 
            ngayHetHan.AutoSize = true;
            ngayHetHan.ImageAlign = ContentAlignment.TopLeft;
            ngayHetHan.Location = new Point(28, 191);
            ngayHetHan.MaximumSize = new Size(67, 50);
            ngayHetHan.Name = "ngayHetHan";
            ngayHetHan.Size = new Size(58, 40);
            ngayHetHan.TabIndex = 5;
            ngayHetHan.Text = "Ngày hết hạn";
            // 
            // xuatXu
            // 
            xuatXu.AutoSize = true;
            xuatXu.Location = new Point(28, 159);
            xuatXu.Name = "xuatXu";
            xuatXu.Size = new Size(59, 20);
            xuatXu.TabIndex = 4;
            xuatXu.Text = "Xuất xứ";
            // 
            // donGia
            // 
            donGia.AutoSize = true;
            donGia.Location = new Point(28, 126);
            donGia.Name = "donGia";
            donGia.Size = new Size(62, 20);
            donGia.TabIndex = 3;
            donGia.Text = "Đơn giá";
            // 
            // soLuong
            // 
            soLuong.AutoSize = true;
            soLuong.Location = new Point(28, 95);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(69, 20);
            soLuong.TabIndex = 2;
            soLuong.Text = "Số lượng";
            // 
            // tenSP
            // 
            tenSP.AutoSize = true;
            tenSP.Location = new Point(28, 64);
            tenSP.Name = "tenSP";
            tenSP.Size = new Size(52, 20);
            tenSP.TabIndex = 1;
            tenSP.Text = "Tên SP";
            // 
            // maSP
            // 
            maSP.AutoSize = true;
            maSP.Location = new Point(28, 35);
            maSP.Name = "maSP";
            maSP.Size = new Size(50, 20);
            maSP.TabIndex = 0;
            maSP.Text = "Mã SP";
            // 
            // chonThaoTacGrpBx
            // 
            chonThaoTacGrpBx.BackColor = Color.DeepSkyBlue;
            chonThaoTacGrpBx.Controls.Add(txtXuatXuAny);
            chonThaoTacGrpBx.Controls.Add(checkExpiredBTN);
            chonThaoTacGrpBx.Controls.Add(removeAllExpiredBTN);
            chonThaoTacGrpBx.Controls.Add(removeAllBTN);
            chonThaoTacGrpBx.Controls.Add(removeViaOriginBTN);
            chonThaoTacGrpBx.Location = new Point(634, 13);
            chonThaoTacGrpBx.Name = "chonThaoTacGrpBx";
            chonThaoTacGrpBx.Size = new Size(272, 253);
            chonThaoTacGrpBx.TabIndex = 12;
            chonThaoTacGrpBx.TabStop = false;
            chonThaoTacGrpBx.Text = "Chọn thao tác";
            // 
            // txtXuatXuAny
            // 
            txtXuatXuAny.Location = new Point(143, 26);
            txtXuatXuAny.MaximumSize = new Size(125, 125);
            txtXuatXuAny.Multiline = true;
            txtXuatXuAny.Name = "txtXuatXuAny";
            txtXuatXuAny.Size = new Size(103, 81);
            txtXuatXuAny.TabIndex = 19;
            // 
            // checkExpiredBTN
            // 
            checkExpiredBTN.Location = new Point(31, 113);
            checkExpiredBTN.Name = "checkExpiredBTN";
            checkExpiredBTN.Size = new Size(190, 64);
            checkExpiredBTN.TabIndex = 22;
            checkExpiredBTN.Text = "Kiểm tra kho có SP quá hạn hay không";
            checkExpiredBTN.UseVisualStyleBackColor = true;
            // 
            // removeAllExpiredBTN
            // 
            removeAllExpiredBTN.Location = new Point(143, 183);
            removeAllExpiredBTN.Name = "removeAllExpiredBTN";
            removeAllExpiredBTN.Size = new Size(126, 64);
            removeAllExpiredBTN.TabIndex = 21;
            removeAllExpiredBTN.Text = "Xóa toàn bộ sản phẩm quá hạn";
            removeAllExpiredBTN.UseVisualStyleBackColor = true;
            removeAllExpiredBTN.Click += removeAllExpiredBTN_Click;
            // 
            // removeAllBTN
            // 
            removeAllBTN.Location = new Point(0, 183);
            removeAllBTN.Name = "removeAllBTN";
            removeAllBTN.Size = new Size(135, 64);
            removeAllBTN.TabIndex = 20;
            removeAllBTN.Text = "Xóa toàn bộ sản phẩm trong kho";
            removeAllBTN.UseVisualStyleBackColor = true;
            removeAllBTN.Click += removeAllBTN_Click;
            // 
            // removeViaOriginBTN
            // 
            removeViaOriginBTN.Location = new Point(6, 26);
            removeViaOriginBTN.Name = "removeViaOriginBTN";
            removeViaOriginBTN.Size = new Size(129, 81);
            removeViaOriginBTN.TabIndex = 19;
            removeViaOriginBTN.Text = "Xóa sản phẩm theo xuất xứ bất kì";
            removeViaOriginBTN.UseVisualStyleBackColor = true;
            removeViaOriginBTN.Click += removeViaOriginBTN_Click;
            // 
            // SearchGrpBx
            // 
            SearchGrpBx.BackColor = Color.DeepSkyBlue;
            SearchGrpBx.Controls.Add(txtB);
            SearchGrpBx.Controls.Add(txtA);
            SearchGrpBx.Controls.Add(aToBPriceBTN);
            SearchGrpBx.Controls.Add(ExpiredProductsBTN);
            SearchGrpBx.Controls.Add(JapanBTN);
            SearchGrpBx.Controls.Add(HighestPriceBTN);
            SearchGrpBx.Controls.Add(dataGridView1);
            SearchGrpBx.Location = new Point(296, 12);
            SearchGrpBx.Name = "SearchGrpBx";
            SearchGrpBx.Size = new Size(628, 304);
            SearchGrpBx.TabIndex = 1;
            SearchGrpBx.TabStop = false;
            SearchGrpBx.Text = "Chọn chức năng tìm kiếm";
            // 
            // txtB
            // 
            txtB.Location = new Point(550, 49);
            txtB.MaximumSize = new Size(125, 125);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(62, 29);
            txtB.TabIndex = 18;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtA
            // 
            txtA.Location = new Point(469, 49);
            txtA.MaximumSize = new Size(125, 125);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(62, 29);
            txtA.TabIndex = 14;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // aToBPriceBTN
            // 
            aToBPriceBTN.Location = new Point(369, 25);
            aToBPriceBTN.Name = "aToBPriceBTN";
            aToBPriceBTN.Size = new Size(94, 74);
            aToBPriceBTN.TabIndex = 17;
            aToBPriceBTN.Text = "Các SP có đơn giá từ [a...b]";
            aToBPriceBTN.UseVisualStyleBackColor = true;
            aToBPriceBTN.Click += aToBPriceBTN_Click;
            // 
            // ExpiredProductsBTN
            // 
            ExpiredProductsBTN.Location = new Point(235, 25);
            ExpiredProductsBTN.Name = "ExpiredProductsBTN";
            ExpiredProductsBTN.Size = new Size(106, 74);
            ExpiredProductsBTN.TabIndex = 16;
            ExpiredProductsBTN.Text = "Xuất toàn bộ sản phẩm quá hạn";
            ExpiredProductsBTN.UseVisualStyleBackColor = true;
            ExpiredProductsBTN.Click += ExpiredProductsBTN_Click;
            // 
            // JapanBTN
            // 
            JapanBTN.Location = new Point(118, 25);
            JapanBTN.Name = "JapanBTN";
            JapanBTN.Size = new Size(94, 74);
            JapanBTN.TabIndex = 15;
            JapanBTN.Text = "1 SP từ Nhật Bản";
            JapanBTN.UseVisualStyleBackColor = true;
            JapanBTN.Click += JapanBTN_Click;
            // 
            // HighestPriceBTN
            // 
            HighestPriceBTN.Location = new Point(6, 25);
            HighestPriceBTN.Name = "HighestPriceBTN";
            HighestPriceBTN.Size = new Size(94, 74);
            HighestPriceBTN.TabIndex = 14;
            HighestPriceBTN.Text = "1 SP có ĐG cao nhất";
            HighestPriceBTN.UseVisualStyleBackColor = true;
            HighestPriceBTN.Click += HighestPriceBTN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(607, 160);
            dataGridView1.TabIndex = 0;
            // 
            // DSSPGrpBx
            // 
            DSSPGrpBx.BackColor = Color.DarkGoldenrod;
            DSSPGrpBx.Controls.Add(chonThaoTacGrpBx);
            DSSPGrpBx.Controls.Add(dataGridView2);
            DSSPGrpBx.Location = new Point(12, 322);
            DSSPGrpBx.Name = "DSSPGrpBx";
            DSSPGrpBx.Size = new Size(912, 272);
            DSSPGrpBx.TabIndex = 2;
            DSSPGrpBx.TabStop = false;
            DSSPGrpBx.Text = "Danh sách sản phẩm";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(607, 240);
            dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(927, 594);
            Controls.Add(DSSPGrpBx);
            Controls.Add(SearchGrpBx);
            Controls.Add(ProductInfoGrpBx);
            Name = "Form1";
            Text = "Form1";
            ProductInfoGrpBx.ResumeLayout(false);
            ProductInfoGrpBx.PerformLayout();
            chonThaoTacGrpBx.ResumeLayout(false);
            chonThaoTacGrpBx.PerformLayout();
            SearchGrpBx.ResumeLayout(false);
            SearchGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            DSSPGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ProductInfoGrpBx;
        private GroupBox SearchGrpBx;
        private GroupBox DSSPGrpBx;
        private Label ngayHetHan;
        private Label xuatXu;
        private Label donGia;
        private Label soLuong;
        private Label tenSP;
        private Label maSP;
        private TextBox txtOrigin;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox chonThaoTacGrpBx;
        private Button saveProductBTN;
        private Button removeProductBTN;
        private Button HighestPriceBTN;
        private Button aToBPriceBTN;
        private Button ExpiredProductsBTN;
        private Button JapanBTN;
        private TextBox txtA;
        private TextBox txtB;
        private Button removeAllExpiredBTN;
        private Button removeAllBTN;
        private Button removeViaOriginBTN;
        private TextBox txtXuatXuAny;
        private Button checkExpiredBTN;
        private DateTimePicker expiredDatePicker;
    }
}
