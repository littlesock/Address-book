using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通訊錄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.通訊錄' 資料表。您可以視需要進行移動或移除。
            this.通訊錄TableAdapter.Fill(this.database1DataSet.通訊錄);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入名字!!!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("請輸入電話!!!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("請輸入地址!!!");
            }
            else
            {
            this.通訊錄TableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.通訊錄TableAdapter.Fill(this.database1DataSet.通訊錄);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.通訊錄BindingSource.EndEdit();
            this.通訊錄TableAdapter.Update(this.database1DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.通訊錄TableAdapter.Delete(int.Parse(label6.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.通訊錄TableAdapter.Fill(this.database1DataSet.通訊錄);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "姓名":
                    this.通訊錄BindingSource.Position = this.通訊錄BindingSource.Find("姓名", textBox6.Text);
                    break;
                case "電話":
                    this.通訊錄BindingSource.Position = this.通訊錄BindingSource.Find("電話", textBox6.Text);
                    break;
                case "地址":
                    this.通訊錄BindingSource.Position = this.通訊錄BindingSource.Find("地址", textBox6.Text);
                    break;
                case "E-mail":
                    this.通訊錄BindingSource.Position = this.通訊錄BindingSource.Find("E-mail", textBox6.Text);
                    break;
                case "性別":
                    this.通訊錄BindingSource.Position = this.通訊錄BindingSource.Find("性別", textBox6.Text);
                    break;
            }
        }
    }
}
