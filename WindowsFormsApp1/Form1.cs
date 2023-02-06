using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
            stud.Eat(7);
            double ed = 7.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Cъел: {ed} кг еды \n \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
            stud.Eat(5);
            ed = 5.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Cъел: {ed} кг еды \n \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
            stud.Eat(6);
            ed = 6.0;
            MessageBox.Show(string.Format($"Студент: {stud.name} \n Cъел: {ed} кг еды \n \n Рост: {stud.rost} \n Вес: {stud.GetEat()}"));
        }
    }
}
