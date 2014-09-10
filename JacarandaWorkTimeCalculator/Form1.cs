using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacarandaWorkTimeCalculator
{
    public partial class Form1 : Form
    {
        int start_time = 0;
        int end_time = 0;
        int total_hour = 0;
        int total_minute = 0;
        List<double> time_list = new List<double>();
        List<string> time_list_show = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            button_enter.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_start_TextChanged(object sender, EventArgs e)
        {
            try
            {
                start_time = Convert.ToInt32(textBox_start.Text);

                total_hour = (end_time / 100) - (start_time / 100);
                total_minute = (end_time % 100) - (start_time % 100);
                if (total_minute < 0)
                {
                    total_hour--;
                    total_minute += 60;
                }
                // calculate the total time
                textBox_total.Text = Convert.ToString(total_hour) + " hr , " + Convert.ToString(total_minute) + " min";

                // fix the correct time
                if (total_minute >= 0 && total_minute < 15)
                    textBox_correct_total.Text = Convert.ToString(total_hour);
                else if (total_minute >= 15 && total_minute < 45)
                    textBox_correct_total.Text = Convert.ToString(total_hour + 0.5);
                else
                    textBox_correct_total.Text = Convert.ToString(total_hour + 1);
            }
            catch
            {
                if (!textBox_start.Text.Equals(""))
                {
                    MessageBox.Show("上班時間欄位請輸入正確!");
                    textBox_start.Text = null;
                }
            }
        }

        private void textBox_end_TextChanged(object sender, EventArgs e)
        {
            try
            {
                end_time = Convert.ToInt32(textBox_end.Text);
                textBox_total.Text = Convert.ToString(end_time - start_time);
                total_hour = (end_time / 100) - (start_time / 100);
                total_minute = (end_time % 100) - (start_time % 100);
                if (total_minute < 0)
                {
                    total_hour--;
                    total_minute += 60;
                }
                // calculate the total time
                textBox_total.Text = Convert.ToString(total_hour) + " hr , " + Convert.ToString(total_minute) + " min";
                
                // fix the correct time
                if (total_minute >= 0 && total_minute < 15)
                    textBox_correct_total.Text = Convert.ToString(total_hour);
                else if(total_minute >= 15 && total_minute < 45 )
                    textBox_correct_total.Text = Convert.ToString(total_hour + 0.5);
                else
                    textBox_correct_total.Text = Convert.ToString(total_hour + 1);
            }
            catch
            {
                if (!textBox_end.Text.Equals(""))
                {
                    MessageBox.Show("下班時間欄位請輸入正確!");
                    textBox_end.Text = null;
                }
            }
        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_correct_total_TextChanged(object sender, EventArgs e)
        {
            float result = 0;
            if (float.TryParse(textBox_correct_total.Text, out result))
            {
                button_enter.Enabled = true;
            }
            else
            {
                MessageBox.Show("校正時數欄位請輸入正確!");
                button_enter.Enabled = false;
            }

        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (textBox_correct_total.Text != null)
            {
                time_list.Add(Convert.ToDouble(textBox_correct_total.Text));
                //listBox1.DataSource = null; // clear
                //listBox1.DataSource = time_list; // restore

                time_list_show.Add("上:" + textBox_start.Text + " 下:" + textBox_end.Text + " => " + textBox_correct_total.Text + "小時");
                listBox1.DataSource = null; // clear
                listBox1.DataSource = time_list_show; // restore
            }
            else
                MessageBox.Show("請輸入校正時數!");

        }

        private void label_total_time_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // The Remove button was clicked.
            int selectedIndex = listBox1.SelectedIndex;

            try
            {
                // Remove the item in the List.
                time_list.RemoveAt(selectedIndex);
                time_list_show.RemoveAt(selectedIndex);
            }
            catch
            {
            }

            listBox1.DataSource = null;
            listBox1.DataSource = time_list_show;
        }

        private void textBox_time_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double t_time = 0;
            foreach (double t_number in time_list)
            {
                t_time += t_number;
            }
            textBox_time_sum.Text = t_time.ToString() + " 小時";
        }
        //
        // 偵測滑鼠事件
        //
        private void textbox_start_mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox_start.Text = null;
            }
        }
        private void textbox_end_mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox_end.Text = null;
            }
        }
    }
}
