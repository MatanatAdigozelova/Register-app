using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{

    public partial class Form1 : Form
    {
        List<Student> Groups = new List<Student>();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student(textName.Text, textSurname.Text);
            Groups.Add(student);
            MessageBox.Show($"{student.Name} Added");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = new List<string>();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string n, string s)
        {
            Name = n;
            Surname = s;
        }
    }
}
