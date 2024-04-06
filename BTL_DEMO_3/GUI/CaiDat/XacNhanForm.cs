using BTL_DEMO_3.GUI.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DEMO_3.GUI.CaiDat
{
    public partial class XacNhanForm : Form , ISendData
    {
        private string value;
        private ISendResult sendResult;
        public XacNhanForm()
        {
            InitializeComponent();
        }

        public XacNhanForm(ISendResult sendResult)
        {
            InitializeComponent();
            this.sendResult = sendResult;
        }

        public void send(string value)
        {
           this.value = value;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(tb_matKhau.Text.Length > 0 )
            {
                if (value.Equals(tb_matKhau.Text.Trim()))
                {
                        sendResult.SendResult(true);
                        this.Close();                }
                else
                {
                        sendResult.SendResult(false);
                        this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hay nhap mat khau !!");
            }
        }

        private void XacNhanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
