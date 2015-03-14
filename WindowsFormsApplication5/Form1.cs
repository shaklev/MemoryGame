using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Button bt = null, bt2 = null, bt3 = null;
        int tick, broj;
        
        
        
        public Form1()
        {

         
            InitializeComponent();
        }
            
           
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control counter in panel1.Controls)
            {
                
                counter.BackColor = Color.FromArgb(240, 240, 240);
                counter.Enabled = false;
                label3.Visible = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt = null;
            bt2 = null;
            bt3 = null;
            
            broj = 0;
            label3.Visible = false;
            label2.Text = "Резултат:";
            tick = 151;
            timer1.Interval = (1000) * 1;
            timer1.Enabled = true;
            
            timer1.Start();
            
            Random random = new Random();
            List<int> nm = new List<int>();
            for(int i=1;i<=18;i++)
            {
                nm.Add(i);
                nm.Add(i);
            }

          

                foreach (Control counter in panel1.Controls)
                {
                    counter.BackColor = Color.FromArgb(240, 240, 240);
                    counter.ForeColor = Color.FromArgb(240, 240, 240);
                    counter.Enabled = true;
                    int roll = random.Next(nm.Count);
                    counter.Text = nm[roll].ToString();
                     nm.RemoveAt(roll);

                    
                }
                

        }
         

        private void button2_Click()
        {

        }
        
        
         
        private void func(object sender, EventArgs e)
        {
            Button prob = sender as Button;
           
             if(prob.ForeColor==Color.Black)
             {
                 return;
             }

           

            
            
            if (bt == null )
            {
                bt = prob;
                bt.ForeColor = Color.Black;
                return;
            }
           
            else if (bt!=null && bt2 == null)
            {
                bt2 = prob;
                bt2.ForeColor = Color.Black;
                
            }
            else if( bt3==null)
            {

                bt3 = prob;
                bt3.ForeColor = Color.Black;  
                bt.ForeColor = Color.FromArgb(240, 240, 240);
                bt.BackColor = Color.FromArgb(240, 240, 240);
                bt2.ForeColor = Color.FromArgb(240, 240, 240);
                bt2.BackColor = Color.FromArgb(240, 240, 240);
                bt = bt3;
                bt3 = null;
                bt2=null;
               
                
            }



            if (bt2 != null)
            {

                if (bt.Text == bt2.Text)
                {

                    bt.BackColor = Color.Green;
                    bt2.BackColor = Color.Green;
                    bt.Enabled = false;
                    bt2.Enabled = false;
                    bt = null;
                    bt2 = null;
                    broj++;
                }
                else if ((bt.Text != bt2.Text))
                {

                    bt.BackColor = Color.Red;
                    bt2.BackColor = Color.Red;
                }
            }
            
                 

           

           

           
            }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tick--;
            label1.Text = tick.ToString();
            if(tick==10)
            {
                label3.Visible = true;
                label3.Text = "П О Б Р Г У !!!";
                label3.ForeColor = Color.Red;
            }
            if(tick==0)
            {
                label3.Text = "ЕВЕ ГО КОНЕЧНОТО РЕШЕНИЕ";
                label3.ForeColor = Color.Green;
                
                timer1.Stop();
                label2.Text = "Резултат:\n\nповеќе среќа следниот пат ";
                foreach (Control counter in panel1.Controls)
                {
                    counter.Enabled = false;
                }
            }
            if(broj==18)
            {
                timer1.Stop();
                label2.Text = "Резултат:\n\nуспешна игра !!!";
                foreach (Control cc in panel1.Controls)
                {
                    cc.Enabled = false;
                }
                label3.Visible = true;
                label3.Text = "БРАВО БРАВО БРАВО !!!!";
                label3.ForeColor = Color.SlateBlue;
                

            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

       
       
        }

       


        
                
            }

      

     
        
    
    

