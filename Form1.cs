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

        List<Student> studentlist = new List<Student>();
        List<Groupss> groupslist = new List<Groupss>();
        int indexrow;
        public Form1()
        {




            Groupss group1 = new Groupss("P118");
            Groupss group2 = new Groupss("P114");
            Groupss group3 = new Groupss("P112");
            groupslist.Add(group1);
            groupslist.Add(group2);
            groupslist.Add(group3);
            InitializeComponent();
            //selecGroup.Items.Add(group1.GName);
            //selecGroup.Items.Add(group2);
            //selecGroup.Items.Add(group3);

            foreach (var item in groupslist)
            {
                selecGroup.Items.Add(item.GName);

            }
            buttonUpdate.Visible= false;
            or.Visible=false;




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

            //Groupss groups = new Groupss(selecGroup.Text);
            string groupname = selecGroup.Text;
            Student student = new Student(textName.Text, textSurname.Text);
            if (textName.Text == "" || textSurname.Text == "" || groupname == "")
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                foreach (var item in groupslist)
                {
                    if (item.GName == groupname)
                    {
                        student.GroupsId = groupname;
                    }
                }
                studentlist.Add(student);
                MessageBox.Show($"{student.Name} Added");
                textName.Text = "";
                textSurname.Text = "";
                selecGroup.Text = null;
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = studentlist;
                
            }


        }



        private void selecGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonUpdate.Visible = true;
            or.Visible = true;
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            textName.Text = row.Cells[1].Value.ToString();
            textSurname.Text = row.Cells[2].Value.ToString();
            selecGroup.Text = row.Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow newdataRow = dataGridView1.Rows[indexrow];
            newdataRow.Cells[1].Value = textName.Text;
            newdataRow.Cells[2].Value = textSurname.Text;
            newdataRow.Cells[3].Value = selecGroup.Text;
        }







    }


    public class Student
    {
        private static int count = 0;
        private int _id;
        public int Id
        {
            get
            { 
                return _id;
            }
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupsId { get; set; }// groups tipinde verdikde if sertinin icindeki groupname eror verrir
        public Student(string n, string s)
        {
            count++;   
            _id=count;
            Name = n;
            Surname = s;
        }


    }
    public class Groupss
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
        //public List<Student> StudentList { get; set; } = new List<Student>();
        public Groupss(string g)
        {
            GName = g;
            _id = count;
            count++;

        }


    }

}
