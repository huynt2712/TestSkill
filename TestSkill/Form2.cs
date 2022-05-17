using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSkill
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += Form2_FormClosed;
            form1.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtJHeader.Text = Form1.SetValueForText1;
            txtVHeader.Text = Form1.SetValueForText2;
            txtUnit.Text = Form1.SetValueForText3;
            txtMin.Text = Form1.SetValueForText4;
            txtMax.Text = Form1.SetValueForText5;
            cbMode.Text = Form1.SetValueForText6;
        }

        public void vUpdateDuLieu()
        {
            //Sparameter sparameter = new Sparameter();
            //sparameter.JHeader= txtJHeader.Text;
            //sparameter.VHeader= txtVHeader.Text;
            //sparameter.Unit = txtUnit.Text;
            //sparameter.Min = Double.Parse(txtMin.Text);
            //sparameter.Max = Double.Parse(txtMax.Text);
            //sparameter.Mod = cbMode.Text;
            Form1.SetValueForText1 = txtJHeader.Text;
            Form1.SetValueForText2 = txtVHeader.Text;
            Form1.SetValueForText3 = txtUnit.Text;
            Form1.SetValueForText4 = txtMin.Text;
            Form1.SetValueForText5 = txtMax.Text;
            Form1.SetValueForText6 = cbMode.Text;


            MessageBox.Show("Thông tin đã nhập đầy đủ");
            Form1 form1 = new Form1();
            form1.FormClosed += Form2_FormClosed;
            form1.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtJHeader.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô JHeader");
                txtJHeader.Focus();
                return;
            }
            if (txtVHeader.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô VHeader");
                txtVHeader.Focus();
                return;
            }
            if (txtUnit.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô Unit");
                txtUnit.Focus();
                return;
            }
            if (txtMin.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Min");
                txtMin.Focus();
                return;
            }
            if (txtMax.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Max");
                txtMax.Focus();
                return;
            }
            

            vUpdateDuLieu();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (txtMin.Text != "")
            {
                try
                {
                    int u = Int32.Parse(txtMin.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Không được nhập chữ");
                    txtMin.Text = "";
                    txtMin.Focus();
                    return;
                }
            }
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            if (txtMax.Text != "")
            {
                try
                {
                    int u = Int32.Parse(txtMax.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Không được nhập chữ");
                    txtMax.Text = "";
                    txtMax.Focus();
                    return;
                }
            }
        }
    }
}
