using COMPLETE_FLAT_UI;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COMPLETE_FLAT_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;

            if (username == "admin" && password == "admin")
            {
                
                FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal();
                FormMenuPrincipal.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Username Or Password Wrong!!");
            }
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}