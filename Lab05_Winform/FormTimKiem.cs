using System;
using System.Windows.Forms;

namespace Lab05_Winform
{
	public partial class frmTimKiem : Form
	{
		public string MSSV { get; set; }
		public string Ten { get; set; }
		public string Lop { get; set; }

		bool IsValid { get => cbLop.Checked || cbMSSV.Checked || cbTen.Checked; }

		public frmTimKiem()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void cbMSSV_CheckedChanged(object sender, EventArgs e)
		{
			txtMSSV.Enabled = cbMSSV.Checked;
		}

		private void cbTen_CheckedChanged(object sender, EventArgs e)
		{
			txtTen.Enabled = cbTen.Checked;
		}

		private void cbLop_CheckedChanged(object sender, EventArgs e)
		{
			cboLop.Enabled = cbLop.Checked;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (!IsValid)
			{
				MessageBox.Show("Chọn tiêu chí để tìm kiếm.");
				return;
			}

			if (cbMSSV.Checked) MSSV = txtMSSV.Text;
			if (cbTen.Checked) Ten = txtTen.Text;
			if (cbLop.Checked) Lop = cboLop.Text;

			this.DialogResult = DialogResult.OK;
			Close();
		}

        private void txtMSSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
			txtMSSV.Enabled = cbMSSV.Checked;
		}

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
			txtTen.Enabled = cbTen.Checked;
		}

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
			cboLop.Enabled = cbLop.Checked;
		}

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
			if (!IsValid)
			{
				MessageBox.Show("Chọn tiêu chí để tìm kiếm.");
				return;
			}

			if (cbMSSV.Checked) MSSV = txtMSSV.Text;
			if (cbTen.Checked) Ten = txtTen.Text;
			if (cbLop.Checked) Lop = cboLop.Text;

			this.DialogResult = DialogResult.OK;
			Close();
		}

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMSSV_CheckedChanged_1(object sender, EventArgs e)
        {
			txtMSSV.Enabled = cbMSSV.Checked;
		}

        private void cbTen_CheckedChanged_1(object sender, EventArgs e)
        {
			txtTen.Enabled = cbTen.Checked;
		}

        private void cbLop_CheckedChanged_1(object sender, EventArgs e)
        {
			cboLop.Enabled = cbLop.Checked;
		}
    }
}
