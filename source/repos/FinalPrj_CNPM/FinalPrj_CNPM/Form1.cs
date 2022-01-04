using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalPrj_CNPM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Final_Project;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM phieuNhap", conn);
            var table = new DataTable();
            dap.Fill(table);
            cbPhieuNhap.DisplayMember = "tenPhieu";
            cbPhieuNhap.ValueMember = "ID_phieuNhapHang";
            cbPhieuNhap.DataSource = table;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", cbPhieuNhap.DataSource, "ID_phieuNhapHang");
            txtTenPhieu.DataBindings.Clear();
            txtTenPhieu.DataBindings.Add("Text", cbPhieuNhap.DataSource, "tenPhieu");
        }

        private void cbPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID_phieuNhapHang = Convert.ToString(cbPhieuNhap.SelectedValue);
            var dap = new SqlDataAdapter("SELECT * FROM nhapHang WHERE ID_phieuNhapHang = "+ID_phieuNhapHang+" ", conn);
            var table = new DataTable();
            dap.Fill(table);
            dgvHangnhap.DataSource = table;
            txtIdHangHoa.DataBindings.Clear();
            txtIdHangHoa.DataBindings.Add("Text", dgvHangnhap.DataSource, "ID_HangHoa");
            txtTenHangHoa.DataBindings.Clear();
            txtTenHangHoa.DataBindings.Add("Text", dgvHangnhap.DataSource, "tenHangHoa");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvHangnhap.DataSource, "soLuong");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvHangnhap.DataSource, "giaSanPham");
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dgvHangnhap.DataSource, "ID_phieuNhapHang");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        Boolean addPhieu = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( addPhieu == true)
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("INSERT INTO phieuNhap(tenPhieu) VALUES(N'" + txtTenPhieu.Text + "') ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Form1_Load(sender, e);
                    MessageBox.Show(" Add data success ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show(" Add data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                addPhieu = false;
            }
            else
            {
                try
                {
                conn.Open();
                var cmd = new SqlCommand("UPDATE phieuNhap SET tenPhieu = N'" + txtTenPhieu.Text + "' " +
                    "WHERE ID_phieuNhapHang =" + Convert.ToString(cbPhieuNhap.SelectedValue) +" " , conn);
                cmd.ExecuteNonQuery();
                //var cmd2 = new SqlCommand("UPDATE phieuNhap SET ID_phieuNhapHang = '" + txtID.Text + "' WHERE tenPhieu =" + Convert.ToString(cbPhieuNhap.Text) + " ", conn);
                //cmd2.ExecuteNonQuery();
                conn.Close();
                Form1_Load(sender, e);
                MessageBox.Show(" Update data success ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                MessageBox.Show(" Update data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtID.Focus();
            txtTenPhieu.Text = "";
            addPhieu = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure want to delete"+cbPhieuNhap.Text+"?","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(ask == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("Delete From phieuNhap WHERE ID_phieuNhapHang =" + Convert.ToString(cbPhieuNhap.SelectedValue) + " ", conn);
                    cmd.ExecuteNonQuery();
                    //var cmd2 = new SqlCommand("UPDATE phieuNhap SET ID_phieuNhapHang = '" + txtID.Text + "' WHERE tenPhieu =" + Convert.ToString(cbPhieuNhap.Text) + " ", conn);
                    //cmd2.ExecuteNonQuery();
                    conn.Close();
                    Form1_Load(sender, e);
                    MessageBox.Show(" Data Deleted ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(" Delete data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        Boolean addHang = false;
        private void btnAddHang_Click_1(object sender, EventArgs e)
        {
            txtIdHangHoa.Text = "";
            txtIdHangHoa.Focus();
            txtTenHangHoa.Text = "";
            txtSoLuong.Text = "";
            txtMaPhieu.Text = "";
            txtGia.Text = "";
            addHang = true;
        }

        private void btnUpdateHang_Click(object sender, EventArgs e)
        {
            if (addHang == true)
            {
                try 
                {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO nhapHang(tenHangHoa,soLuong,ID_phieuNhapHang,giaSanPham) " +
                    "VALUES(N'" + txtTenHangHoa.Text + "','" + txtSoLuong.Text + "','" +txtMaPhieu.Text+ "','" + txtGia.Text + "') ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Form1_Load(sender, e);
                MessageBox.Show(" Add data success ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                MessageBox.Show(" Add data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            addPhieu = false;
        }
            else
            {
                try
                {
                conn.Open();
                var cmd = new SqlCommand("UPDATE nhapHang SET tenHangHoa='"+txtTenHangHoa.Text+ "',soLuong='" + txtSoLuong.Text + "', giaSanPham='" + txtGia.Text + "' WHERE ID_HangHoa =" + txtIdHangHoa.Text + " ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Form1_Load(sender, e);
                MessageBox.Show(" Update data success ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                MessageBox.Show(" Update data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteHang_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM nhapHang WHERE ID_HangHoa =" + txtIdHangHoa.Text + " ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show(" Delete data failed ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
