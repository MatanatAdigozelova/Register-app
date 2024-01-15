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
            List<Groups> groupslist = new List<Groups>();
            Groups groups = new Groups(selecGroup.Text);
            Student student = new Student(textName.Text, textSurname.Text);
            Groups.Add(student);
            MessageBox.Show($"{student.Name} Added");
            textName.Text = "";
            textSurname.Text = "";
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = Groups;
            Groups groups1 = new Groups("p118");
            Groups groups2 = new Groups("p119");
            groupslist.Add(groups1);
            groupslist.Add(groups2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = new List<string>();
        }

        private void selecGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Groups GroupsId { get; set; }
        public Student(string n, string s)
        {
            Name = n;
            Surname = s;
        }
    }
    public class Groups
    {
        private static int count = 1;
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string GName { get; set; }
        public List<Student> StudentsList { get; set; } = new List<Student>();
        public Groups(string g)
        {
            GName = g;
            _id = count;
            count++;

        }
    }
}
