using LabPreperation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPreperation
{
    public partial class Form1 : Form
    {

        private P507Entities1 db = new P507Entities1();

        public Form1()
        {
            InitializeComponent();

            FillGroups();

        }
        // qrupun id'sini saxlamaq üçün dəyişən
        public int selectedGroupId { get; set; }


        // Qrupları qrup comboboxuna dolduran metod
        private void FillGroups()
        {
            cmbGroups.Items.Add("Hamısı");
            cmbGroups.Text = "Hamısı";

            List<Group> groups = db.Groups.ToList();

            foreach (Group group in groups)
            {
                cmbGroups.Items.Add(group.Name);
            }
        }


        // bütün nəticələri datagridview'ya doldurmaq üçün metod
        private void FillResults(int GroupId = 0, int StudentId = 0)
        {
            List<Result> results = db.Results.Where(r => (GroupId != 0 ? r.Student.GroupId == GroupId : true) && (StudentId != 0 ? r.StudentId == StudentId : true)).OrderByDescending(r => r.Date).ToList();

            dgvResults.Rows.Clear();
            foreach (Result result in results)
            {
                dgvResults.Rows.Add(result.Id,
                                    result.Student.Group.Name,
                                    result.Student.Name + " " + result.Student.Surname,
                                    result.Exam.Name,
                                    result.Date.ToString("dd.MM.yyyy"),
                                    result.ExamResult.ToString("#.##"),
                                    result.ExamResult > 700 ? "Uğurlu":"Qaldı");
            }

        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if(cmbGroups.Text != "Hamısı")
            {
                Group group = db.Groups.FirstOrDefault(g => g.Name == cmbGroups.Text);
                cmbStudents.Items.Clear();

                // select * from Students where groupId = 2

                //List<Student> students = db.Students.Where(s => s.GroupId == group.Id).ToList();

                cmbStudents.Items.Add("Hamısı");
                cmbStudents.Text = "Hamısı";

                selectedGroupId = group.Id;
                foreach (Student student in group.Students.ToList())
                {
                    cmbStudents.Items.Add(student.Name +" "+student.Surname);
                }

                FillResults(group.Id);
            }
            else
            {
                FillResults();
                cmbStudents.Items.Clear();
                cmbStudents.Text = "";
            }
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStudents.Text != "Hamısı")
            {
                Student stu = db.Students.FirstOrDefault(s => s.Name + " " + s.Surname == cmbStudents.Text);
                FillResults(StudentId: stu.Id);

            }
            else
            {
                FillResults(selectedGroupId);   
            }

        }
    }
}
