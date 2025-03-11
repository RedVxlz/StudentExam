using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
            UpdateStudentList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string major = tbmajor.Text;
            double grade;

            if (!double.TryParse(tbgrade.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                return;
            }

            string advisorName = tbAdvisor.Text;
            if (string.IsNullOrEmpty(advisorName))
            {
                MessageBox.Show("กรุณาใส่ชื่ออาจารย์ที่ปรึกษา");
                return;
            }

            Advisor advisor = advisors.FirstOrDefault(a => a.Name == advisorName);
            if (advisor == null)
            {
                advisor = new Advisor(advisorName, "Unknown");
                advisors.Add(advisor);
            }

            Student student = new Student(id, name, major, grade, advisor);
            students.Add(student);
            advisor.AddStudent(student);

            lbid.Text = student.ID;
            lbname.Text = student.Name;
            lbmajor.Text = student.Major;
            lbgrade.Text = student.Grade.ToString();
            lbadvisor.Text = student.Advisor.Name;

            UpdateStudentList();
            MessageBox.Show("เพิ่มข้อมูลนักศึกษาเรียบร้อยแล้ว!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowHighestGradeStudent();
        }

        private void ShowHighestGradeStudent()
        {
            if (students.Count == 0)
            {
                MessageBox.Show("ยังไม่มีนักศึกษาที่ถูกบันทึก");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุด:\n" +
                            $"รหัสนักศึกษา: {topStudent.ID}\n" +
                            $"ชื่อ-นามสกุล: {topStudent.Name}\n" +
                            $"สาขา: {topStudent.Major}\n" +
                            $"เกรด: {topStudent.Grade}\n" +
                            $"อาจารย์ที่ปรึกษา: {topStudent.Advisor.Name}");
        }

        private void UpdateStudentList()
        {
            listBoxStd.Items.Clear();
            foreach (var student in students)
            {
                listBoxStd.Items.Add(student.Name);
            }
        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            ShowHighestGradeStudent();
        }

        private void listBoxStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStd.SelectedIndex != -1)
            {
                string selectedName = listBoxStd.SelectedItem.ToString();
                Student student = students.FirstOrDefault(s => s.Name == selectedName);
                if (student != null)
                {
                    lbid.Text = student.ID;
                    lbname.Text = student.Name;
                    lbmajor.Text = student.Major;
                    lbgrade.Text = student.Grade.ToString();
                    lbadvisor.Text = student.Advisor.Name;
                }
            }
        }

        private void tbAdvisor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
