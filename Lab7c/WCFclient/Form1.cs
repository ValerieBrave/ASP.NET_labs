using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFclient.WCF;

namespace WCFclient
{
    public partial class Form1 : Form
    {
        IService client;
        public Form1()
        {
            this.client = new ServiceClient();
            InitializeComponent();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            dynamic array = this.client.GetAll();
            int counter = 0;
            foreach (var item in array)
            {
                this.richTextBox1.Text += $"{++counter}) Name: {item.Fullname}, Phone: {item.Telephone}\n";
            }
        }

        private void Post_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                string number = this.number.Text;

                this.client.Add(new Note(name, number));

                Get_Click(sender, e);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }

        private void Put_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                string number = this.number.Text;
                long id = long.Parse(this.NoteId.Text);

                this.client.Update(new Note(id, name, number));
                Get_Click(sender, e);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(this.NoteId.Text);

                this.client.Delete(id);
                Get_Click(sender, e);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Fill required fields");
            }
        }
    }
}
