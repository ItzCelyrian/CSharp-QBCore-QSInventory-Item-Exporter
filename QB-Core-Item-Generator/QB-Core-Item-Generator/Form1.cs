using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QB_Core_Item_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var str = richTextBox1.Text;
            var unique = false;
            var usable = false;
            var description = "Just a description";
            var multiplier = 1;
            var combinable = "nil";
            var shouldClose = false;
            var charsToRemove = new string[] { "(", ",", ")", "'", "\"", };

            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }

            if (checkBox1.Checked) unique = true;
            else unique = false;
            if (checkBox2.Checked) usable = true;
            else usable = false;
            if (checkBox3.Checked) shouldClose = true;

            description = richTextBox2.Text;

            if (richTextBox3.TextLength == 0) multiplier = 1;
            else multiplier = Convert.ToInt16(richTextBox3.Text);

            if (checkBox5.Checked == false) combinable = "nil";
            else
            {
                combinable = "{\r\n" +
                             "              accept = " + "{" + $"\"{richTextBox4.Text}\"" + "}" + ",\r\n" +
                            $"              reward = \"{richTextBox5.Text}\",\r\n" +
                            $"              anim = " + "{" + "\r\n" +
                            $"                 [\"dict\"] = \"{richTextBox6.Text}\",\r\n" +
                            $"                 [\"lib\"] = \"{richTextBox7.Text}\",\r\n" +
                            $"                 [\"text\"] = \"{richTextBox8.Text}\",\r\n" +
                            $"                 [\"timeOut\"] = {richTextBox9.Text},\r\n" +
                             "                 }\r\n" +
                             "      }";
            }
            var item = richTextBox1.Text;
            var label = richTextBox10.Text;
            var weight = richTextBox3.Text;
            textBox1.Multiline = true;
            textBox1.Text = $"[\"{item}\"] = " + "{\r\n" +
                            $"      [\"name\"] = \"{item}\",\r\n" +
                            $"      [\"label\"] = \"{label}\",\r\n" +
                            $"      [\"weight\"] = {weight},\r\n" +
                            $"      [\"type\"] = \"item\",\r\n" +
                            $"      [\"image\"] = \"{item}.png\",\r\n" +
                            $"      [\"unique\"] = {unique},\r\n" +
                            $"      [\"useable\"] = {usable},\r\n" +
                            $"      [\"shouldClose\"] = {shouldClose},\r\n" +
                            $"      [\"combinable\"] = {combinable},\r\n" +
                            $"      [\"description\"] = \"{description}\"\r\n" +
                            "},";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            richTextBox7.Clear();
            richTextBox8.Clear();
            richTextBox9.Clear();
            richTextBox10.Clear();
            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                richTextBox4.Visible = true;
                richTextBox5.Visible = true;
                richTextBox6.Visible = true;
                richTextBox7.Visible = true;
                richTextBox8.Visible = true;
                richTextBox9.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
            }
            else
            {
                richTextBox4.Visible = false;
                richTextBox5.Visible = false;
                richTextBox6.Visible = false;
                richTextBox7.Visible = false;
                richTextBox8.Visible = false;
                richTextBox9.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
            }
        }
    }
}