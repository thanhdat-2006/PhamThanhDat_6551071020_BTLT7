using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TriThucBooksApp.Models;
namespace TriThucBooksApp
{

    public partial class Form1 : Form
    {
        private TriThucBooksContext context = new TriThucBooksContext();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvTheLoaiSach.DataSource = context.TheLoaiSaches.ToList();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();
            LoadData();
        }

        private void dgvTheLoaiSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoaiSach.CurrentRow != null)
            {
                txtMaTL.Text = dgvTheLoaiSach.CurrentRow.Cells["MaTL"].Value?.ToString();
                txtTenTL.Text = dgvTheLoaiSach.CurrentRow.Cells["TenTheLoai"].Value?.ToString();
                txtMoTa.Text = dgvTheLoaiSach.CurrentRow.Cells["MoTa"].Value?.ToString();
                lblNgayTao.Text = dgvTheLoaiSach.CurrentRow.Cells["NgayTao"].Value?.ToString();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTL.Text.Trim();

            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Tên thể loại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (context.TheLoaiSaches.Any(t => t.TenTheLoai == tenTL))
            {
                MessageBox.Show("Tên thể loại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTheLoai = new TheLoaiSach
            {
                TenTheLoai = tenTL,
                MoTa = txtMoTa.Text.Trim(),
                SoLuongSach = 0,
                NgayTao = DateTime.Now
            };

            context.TheLoaiSaches.Add(newTheLoai);
            await context.SaveChangesAsync();
            MessageBox.Show("Thêm thành công!");
            LoadData();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text)) return;

            int maTL = int.Parse(txtMaTL.Text);
            var theLoai = context.TheLoaiSaches.Find(maTL);

            if (theLoai != null)
            {
                if (string.IsNullOrEmpty(txtTenTL.Text.Trim()))
                {
                    MessageBox.Show("Tên thể loại không được bỏ trống!");
                    return;
                }

                theLoai.TenTheLoai = txtTenTL.Text.Trim();
                theLoai.MoTa = txtMoTa.Text.Trim();

                await context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text)) return;

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    int maTL = int.Parse(txtMaTL.Text);
                    var theLoai = context.TheLoaiSaches.Find(maTL);

                    if (theLoai != null)
                    {
                        context.TheLoaiSaches.Remove(theLoai);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Không thể xóa thể loại này vì đang được sách khác tham chiếu!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var result = context.TheLoaiSaches
                                .Where(x => x.TenTheLoai.Contains(keyword))
                                .ToList();

            dgvTheLoaiSach.DataSource = result;
        }
    }
 }

