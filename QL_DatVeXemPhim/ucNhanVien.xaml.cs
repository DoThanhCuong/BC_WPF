using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Win32;

namespace QL_DatVeXemPhim
{
    /// <summary>
    /// Interaction logic for ucNhanVien.xaml
    /// </summary>
    public partial class ucNhanVien : UserControl
    {
        string _ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public ucNhanVien()
        {
            InitializeComponent();
        }


        #region NhanVien
        private void FillDataGrid()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT MaNV,HoTen, NgaySinh,DiaChi,Email,SoDienThoai,GioiTinh FROM NhanVien";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("NhanVien");
                sda.Fill(dt);
                dgNhanVien.ItemsSource = dt.DefaultView;
            }
        }

        #endregion

        #region Show dữ liêu lêm TextBox
        private void dgNhanVien_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataRowView _DataView = dgNhanVien.CurrentCell.Item as DataRowView;
                if (_DataView != null)
                {
                    txtMaNV.Text = _DataView.Row[0].ToString();
                    txtHoTen.Text = _DataView.Row[1].ToString();
                    dateNgaySinh.Text = _DataView.Row[2].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        public void xoatext()
        {
            txtMaNV.Text = string.Empty;
            txtMaNV.Focus();
            txtHoTen.Text = string.Empty;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection _Conn = new SqlConnection(_ConnectionString);
                _Conn.Open();
                string _Date = dateNgaySinh.DisplayDate.ToShortDateString();
                string _Insert = @"Insert INTO NhanVien(MaNV,HoTen) Values('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "')";
                //string _Insert = @"Insert INTO NhanVien(MaNV,HoTen) Values('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + _Date.ToString() + "')";
                SqlCommand _cmd = new SqlCommand(_Insert, _Conn);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                xoatext();
                btnUpdate.IsEnabled = true;
                btnXoa.IsEnabled = true;

                // Load lai dữ liệu trên GridData
                this.FillDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                SqlConnection _conn = new SqlConnection(_ConnectionString);
                _conn.Open();

                string _DelCmd = @"Delete From NhanVien Where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand _CmdDel = new SqlCommand(_DelCmd, _conn);
                _CmdDel.ExecuteNonQuery();

                MessageBox.Show("Đã xóa nhân viên");
                xoatext();

                this.FillDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection _Conn = new SqlConnection(_ConnectionString);
                _Conn.Open();

                string _UpdateCmd = @"Update NhanVien Set HoTen = N'" + txtHoTen.Text + "' Where MaNV = '" + txtMaNV.Text + "'";

                SqlCommand _CmdUpdate = new SqlCommand(_UpdateCmd, _Conn);
                _CmdUpdate.ExecuteNonQuery();
                xoatext();

                this.FillDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            xoatext();
            btnUpdate.IsEnabled = false;
            btnXoa.IsEnabled = false;
        }

        private void btnBrowseImgNV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) | *.jpg|GIB files (*.GIB) | All files (*.*)| *.*";
                dlg.Title = "Select NhanVien Picture";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
