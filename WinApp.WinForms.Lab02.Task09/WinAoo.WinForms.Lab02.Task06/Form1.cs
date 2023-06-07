using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAoo.WinForms.Lab02.Task06
{
    public partial class Библиотека : Form
    {
        List<Item> its = new List<Item>(); 

        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

        public bool Existence
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public bool SortInvNumber
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }

        public bool ReturnTime
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }

        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        public Библиотека()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 1;
            Year = 1457;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append(item.ToString());
                   
            }
            richTextBox1.Text = sb.ToString();
        }

        private void Библиотека_Load(object sender, EventArgs e)
        {

        }

        public string MagazineTitle
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public int MagazineVolume
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }

        public int MagazineInvNumber
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public int MagazineYear
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public bool Return
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public bool Subs
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(MagazineTitle, MagazineVolume, MagazineInvNumber, MagazineYear, Return, Subs);
            
            if (checkBox5.Checked)
                m.Subs = true;
            else m.Subs = false;

            its.Add(m);
            MagazineTitle = "";
            MagazineVolume = MagazineInvNumber = 1;
            MagazineYear = 1755;
            Return = Subs = false;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MagazineInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append(item.ToString());

            }
            richTextBox2.Text = sb.ToString();
        }
    }
}
