using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Text_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            //Adds user input to listbox from both text boxes
            if (this.txtStudentName.Text != "")
            {
                lbNameAndScore.Items.Add(string.Format("{0} {1}", this.txtStudentName.Text, this.txtStudentScore.Text));
                this.txtStudentName.Focus();
                this.txtStudentName.Clear();
                this.txtStudentScore.Focus();
                this.txtStudentScore.Clear();

            }

            else
            {
                //shows message if name and score are not both entered 
                MessageBox.Show("Enter name and Score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStudentName.Focus();
                this.txtStudentScore.Focus();

            }







        }



        private void button2_Click(object sender, EventArgs e)
        {
            //allows selected item from listbox to be removed 
            if (this.lbNameAndScore.SelectedIndex >= 0)
            { this.lbNameAndScore.Items.RemoveAt(this.lbNameAndScore.SelectedIndex); }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //creates names and Scores list from list.txt 
        List<string> namesAndScores = File.ReadAllLines("list.txt").ToList();
        List<string> scores1 = new List<string>();


        private void button3_Click(object sender, EventArgs e)
        {
            
            //creates lines variable that contains list txt document
            var column1 = File.ReadAllLines("list.txt");
            //splits data into two columns in the datagridview 
            if (column1.Count() > 0)
            {
                foreach (var columnName in column1.FirstOrDefault()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dataGridView1.Columns.Add(columnName, columnName);
                }
                foreach (var cellValues in column1.Skip(1))
                {
                    var cellArray = cellValues
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray.Length == dataGridView1.Columns.Count)
                        dataGridView1.Rows.Add(cellArray);
                }
            }
            //creats columnData string[] and allows for the average to be displayed in text box 
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[1].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[1].FormattedValue)).ToArray();
            txtScoreAverage.Text = columnData.Average().ToString("000.00");

            //creates max id variable and allows max student score to be displayed in textbox 
            var MaxID = dataGridView1.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[1].Value));

            
            txtMaxStudentScore.Text = MaxID.ToString();


        }
    
        
        //finds highscore in namesAndScores list, but was not sure how to go about using the method 
        public int HighScore(List<Student> namesAndScores)
        {
            int highScore = -1;
            foreach (Student student in namesAndScores)
            {
                if (student > highScore)
                {
                    highScore = student;
                    
                }
            }

            return highScore;
           
        }
        
        

        private void button4_Click(object sender, EventArgs e)
        {
            //saves list box items to text document 
            if (lbNameAndScore.Items.Count > 0)
            {
                using (TextWriter tW = new StreamWriter("list.txt"))
                {
                    foreach (string itemText in lbNameAndScore.Items)
                    {
                        tW.WriteLine(itemText);
                    }
                }
                Process.Start("list.txt");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    
    

