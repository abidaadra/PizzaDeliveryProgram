//Extracted from sourcecodester.com
//Modified by Abida Adra
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Select Pizza

            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3.00");
                    listView1.Items.Add(item);
         
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3.00");
                    listView1.Items.Add(item);
               
                }


            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listView1.Items.Add(item);
              
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listView1.Items.Add(item);
             
                }

            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);
              
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("7.00");
                    listView1.Items.Add(item);
              
                }

            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);
            
                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Extra Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("10.00");
                    listView1.Items.Add(item);
               
                }

            }


            //Select Toppings

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
           
            }
            
            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
          
            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
         
            }





            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("Beef Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
          
            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Jalapeno Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
            
            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pineapple Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
       
            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem(" Shrimps Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
            
            }



            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
              
            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spinach Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
       
            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem(" Garlic Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
           
            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem(" Chicken Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
        
            }


            //Add corn checkBox4
            if(checkBox4.Checked==true)
            {
                ListViewItem item = new ListViewItem(" Corn Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
            }

            //Add pepper checkBox5
            if(checkBox5.Checked==true)
            {
                ListViewItem item = new ListViewItem(" Pepper Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.3");
                listView1.Items.Add(item);
            }

            //Select Drinks

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pepsi - Can");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 1.5;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
          
            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Pepsi - Can");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 1.5;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
             
            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea - Can");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 2;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
              
            }

            else
            {
                textBox3.Text = "";
            }





            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("7up - Can");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 1.5;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            //Add diet 7up $1.5 checkBox10 textBox4

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet 7up - Can");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 1.5;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }




            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bottled Water");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 1;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

            //Add sparkling water $2 checkBox18 textBox6
            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sparkling Water - Bottle");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 2;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            //Other Items Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add("");
                item.SubItems.Add("2.00");
                listView1.Items.Add(item);
          
            }



            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add("");
                item.SubItems.Add("2.00");
                listView1.Items.Add(item);
               
            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
                listView1.Items.Add(item);
          
            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Dip");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
                listView1.Items.Add(item);
          
            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Dip");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
                listView1.Items.Add(item);
              
            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream Dip");
                item.SubItems.Add("");
                item.SubItems.Add("1.00");
                listView1.Items.Add(item);
             
            }
            //add brownie $4 checkBox20
            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Brownie");
                item.SubItems.Add("");
                item.SubItems.Add("4.00");
                listView1.Items.Add(item);

            }

            //add chocolate cookie $3 checkBox23
            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chocolate Cookie");
                item.SubItems.Add("");
                item.SubItems.Add("3.00");
                listView1.Items.Add(item);

            }

            //add apple pie $4 checkBox29
            if (checkBox29.Checked == true)
            {
                ListViewItem item = new ListViewItem("Apple Pie");
                item.SubItems.Add("");
                item.SubItems.Add("4.00");
                listView1.Items.Add(item);

            }

            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            //delivery charge
            hst = total * 0.13;
            totaldue = hst + total;

            string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");
            
            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;
            
            comboBox1.Items.Add("Beirut");
            comboBox1.Items.Add("Tripoli");
            comboBox1.Items.Add("Koura");
            comboBox1.Items.Add("Zgharta");
            comboBox1.Items.Add("Akkar");
            comboBox1.Items.Add("Saida");
            comboBox1.Items.Add("Byblos");
            comboBox1.Items.Add("Baalbeck");
            comboBox1.Items.Add("Bekaa");
            comboBox1.Items.Add("Soor");
            comboBox1.Items.Add("Other");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            

            button8.Enabled = false;

        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
    
            else
            {
                string money = textBox19.Text;
                char[] dollars = { '$' };
                string paymoney = money.TrimStart(dollars);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = change.ToString("c2");

                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }

                else
                {
                    button8.Enabled = true;
                }
                  

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

           if (dialog == DialogResult.Yes)
           {

               //Clearing all data
               checkBox1.Checked = false;
               checkBox2.Checked = false;
               checkBox3.Checked = false;
               checkBox6.Checked = false;
               checkBox7.Checked = false;
               checkBox8.Checked = false;
               checkBox9.Checked = false;
               checkBox11.Checked = false;
               checkBox12.Checked = false;
               checkBox13.Checked = false;
               checkBox14.Checked = false;
               checkBox15.Checked = false;
               checkBox16.Checked = false;
               checkBox17.Checked = false;
               checkBox19.Checked = false;
               checkBox21.Checked = false;
               checkBox22.Checked = false;
               checkBox24.Checked = false;
               checkBox25.Checked = false;
               checkBox26.Checked = false;
               checkBox27.Checked = false;
               checkBox28.Checked = false;

               textBox1.Text = "";
               textBox2.Text = "";
               textBox3.Text = "";
               textBox5.Text = "";
               textBox7.Text = "";

               listView1.Items.Clear();
               textBox8.Text = "";
               textBox9.Text = "";
               textBox10.Text = "";

               textBox11.Text = "";
               textBox12.Text = "";
               textBox13.Text = "";
               textBox14.Text = "";
               textBox15.Text = "";
               textBox16.Text = "";
               textBox17.Text = "";
               textBox18.Text = "";
               textBox19.Text = "";
               textBox20.Text = "";
               textBox21.Text = "";
               comboBox1.Text = "";
               comboBox2.Text = "";

               tabControl1.SelectTab("tabPage1");
           }

           else if(dialog == DialogResult.No)
           {
               this.Close();
           }
        
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Add corn
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //Add pepper
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //diet 7up txtbox
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            //add diet 7up
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            //add sparkling water
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //add sparkling water txtbox
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            //add brownie
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            //add chocolate cookie
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            //add apple pie
        }
    }
} 
//end
