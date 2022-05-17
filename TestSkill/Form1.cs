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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMode.SelectedIndex = 0;
            txtJHeader.Text = SetValueForText1;
            txtVHeader.Text = SetValueForText2;
            txtUnit.Text = SetValueForText3;
            txtMin.Text = SetValueForText4;
            txtMax.Text = SetValueForText5;
            cbMode.Text = SetValueForText6;
        }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";

        public void vGuiDuLieu()
        {
            SetValueForText1 = txtJHeader.Text;
            SetValueForText2 = txtVHeader.Text;
            SetValueForText3 = txtUnit.Text;
            SetValueForText4 = txtMin.Text;
            SetValueForText5 = txtMax.Text;
            SetValueForText6 = cbMode.Text;
            
            //Sparameter sparameter = new Sparameter();
            //sparameter.JHeader= txtJHeader.Text;
            //sparameter.VHeader= txtVHeader.Text;
            //sparameter.Unit = txtUnit.Text;
            //sparameter.Min = Double.Parse(txtMin.Text);
            //sparameter.Max = Double.Parse(txtMax.Text);
            //sparameter.Mod = cbMode.Text;

            
            MessageBox.Show("Thông tin đã nhập đầy đủ");
            Form2 form2 = new Form2();
            form2.FormClosed += Form1_FormClosed;
            form2.Show();
            this.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtJHeader.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô JHeader");
                txtJHeader.Focus();
                return;
            }
            if(txtVHeader.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô VHeader");
                txtVHeader.Focus();
                return;
            }
            if(txtUnit.Text.Trim() == "")
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
            if(txtMax.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Max");
                txtMax.Focus();
                return;
            }
            vGuiDuLieu();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
