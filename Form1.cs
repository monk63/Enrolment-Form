using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enrolmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enrolmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.enrol1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enrol1DataSet.Enrolment' table. You can move, or remove it, as needed.
            this.enrolmentTableAdapter.Fill(this.enrol1DataSet.Enrolment);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pOSTAL_ADDRESSTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                // code block to be executed when if condition evaluates to true
                cOURSE_REQUIREDTextBox.Text = radioButton5.Text;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // code block to be executed when if condition evaluates to true
                cOURSE_REQUIREDTextBox.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // code block to be executed when if condition evaluates to true
                cOURSE_REQUIREDTextBox.Text = radioButton2.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                // code block to be executed when if condition evaluates to true
                cOURSE_REQUIREDTextBox.Text = radioButton4.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                // code block to be executed when if condition evaluates to true
                cOURSE_REQUIREDTextBox.Text = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            { 
                // code block to be executed when if condition evaluates to true
                sESSIONSTextBox.Text = radioButton7.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                // code block to be executed when if condition evaluates to true
                sESSIONSTextBox.Text = radioButton8.Text;
            }
        }

        private void Prebtn_Click(object sender, EventArgs e)
        {
            enrolmentBindingSource.MovePrevious();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            enrolmentBindingSource.MoveNext();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // put the code here that may raise exceptions
                enrolmentBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(enrol1DataSet);
                MessageBox.Show("Success"); 
               
            }
            catch
            {
                // handle exception here
                MessageBox.Show("Error occured,Please recheck the fields and try again.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            enrolmentBindingSource.RemoveCurrent();
            tableAdapterManager.UpdateAll(enrol1DataSet);
            MessageBox.Show("Current Record Deleted");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            enrolmentBindingSource.AddNew();
            radioButton1.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
