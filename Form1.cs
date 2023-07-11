using static System.Net.Mime.MediaTypeNames;

namespace thuvien
{
    public partial class Form1 : Form
    {
        List<ThuVien> lstThu;
        public Form1()
        {
            InitializeComponent();
            lstThu = new List<ThuVien>();
            dataGridThu.ReadOnly = true;
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("Please input enough information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtten.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtmuon.Text))
            {
                MessageBox.Show("Please input enough information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmuon.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtloai.Text))
            {
                MessageBox.Show("Please input enough information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtloai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtso.Text))
            {
                MessageBox.Show("Please input enough information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtso.Focus();
                return false;
            }
            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                string ten;
                string muon;
                string loai;
                int so;             
                ten = txtten.Text;
                muon= txtmuon.Text;
                loai= txtloai.Text;
                so=Int32.Parse(txtso.Text);
                ThuVien sach=new ThuVien(ten,muon,loai,so);
                lstThu.Add(sach);
                dataGridThu.DataSource=null;
                dataGridThu.DataSource = lstThu;
                dataGridThu.RefreshEdit();
                
            }
        }
        int index;

        private void dataGridThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index=e.RowIndex;
            if (index >= 0)
            {
                txtten.Text = lstThu[index].Ten;
                txtmuon.Text = lstThu[index].Muon;
                txtloai.Text = lstThu[index].Loai;
                txtso.Text = lstThu[index].So.ToString();
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                lstThu[index].Ten = txtten.Text;
                lstThu[index].Muon = txtmuon.Text;
                lstThu[index].Loai = txtloai.Text;
                lstThu[index].So = Int32.Parse(txtso.Text);
                dataGridThu.DataSource = null;
                dataGridThu.DataSource=lstThu;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this infromation?","Warning",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lstThu.RemoveAt(index);
                dataGridThu.DataSource = null;
                dataGridThu.DataSource=lstThu;
            }
        }

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            string value =txtfind.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                List<ThuVien> thu =new List<ThuVien>();
                for(int i=0;i<dataGridThu.Rows.Count;i++)
                    if (dataGridThu.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                        thu.Add(lstThu[i]);
                {
                    dataGridThu.DataSource = null;
                    dataGridThu.DataSource = thu;
                }
            }
            else
            {
                dataGridThu.DataSource = null;
                dataGridThu.DataSource = lstThu;
            }
        }


        private void btnclo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtso_TextChanged(object sender, EventArgs e)
        {
            int so;
            if (int.TryParse(txtso.Text, out so) == false)
            {
                MessageBox.Show("Please input number on page", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            }
            
            

        }

    }
    class ThuVien
    {
        public string Ten { set; get; }
        public string Muon { set; get; }
        public string Loai { set; get; }
        public int So { set; get; }
        public ThuVien()
        {
            Ten = "";
            Muon = "";
            Loai = "";
            So = 0;
        }
        public ThuVien(string ten, string muon, string loai, int so)
        {
            Ten= ten;
            Muon= muon;
            Loai= loai;
            So= so;
        }
    }
}