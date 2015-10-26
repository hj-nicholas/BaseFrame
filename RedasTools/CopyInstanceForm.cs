using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace RedasTools
{
    public partial class CopyInstanceForm : Form
    {
        public CopyInstanceForm()
        {
            InitializeComponent();
        }
        DAL.CopyInstanceForm copyInstanceForm = new DAL.CopyInstanceForm();
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "" || txtFormId.Text == "" || txtUserId.Text == "")
            { 
                MessageBox.Show("输入信息不完整！");
                return;
            } 
            BaseResult result = copyInstanceForm.CopyForm(txtCustomerId.Text, txtUserId.Text, txtFormId.Text);
            if (result.Succeeded)
            {
                MessageBox.Show("复制完成！");
            }
            else
            {
                MessageBox.Show(result.Error);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtLoginId.Text != "")
            {
               UserDTO user= copyInstanceForm.GetUserByLoginId(txtLoginId.Text);
                if (user != null)
                {
                    lblUserInfo.Text = "用户名：" + user.USER_NAME + ";用户ID：" + user.USER_ID + ";公司ID：" + user.CUSTOMER_ID;
                    txtCustomerId.Text = user.CUSTOMER_ID.ToString();
                    txtUserId.Text = user.USER_ID.ToString();
                }
            }
        }
    }
}
