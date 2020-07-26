using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimer01
{
    public partial class Form1 : Form
    {
        private DateTime m_dateTimeFininsh = DateTime.MinValue;
        private int m_iRawSec = 0;
        private int m_iPadding = 30;//sec
        private Dictionary<string, double> dictFoodSetToWeight;
        private Dictionary<string, int[]> dictFoodSetToIngred;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            dictFoodSetToWeight = new Dictionary<string, double>
            {
                { "Pickled", 0.88 },
                { "Vinegar", 0.22 },
                { "Beer", 0.59 },
                { "", 1.00 }
            };

            dictFoodSetToIngred = new Dictionary<string, int[]>
            {
                { "Pickled", new int[] { 8, 4, 2, 2 } },
                { "Vinegar", new int[] { 1, 1, 1, 1 } },
                { "Beer", new int[] { 5, 6, 2, 1 } },
                { "", new int[] { 1 } }
            };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblClockDisplay.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            //lblClockDisplay2.Text = DateTime.Now.AddSeconds(30).ToString("HH:mm:ss");
            //int timeCountDown = int.Parse(lblSS.Text);
            
            if (m_iRawSec > 0)
            {
                m_iRawSec -= 1;

                //lblCountdown.Text = (m_dateTimeFininsh.Subtract(DateTime.Now).).ToString("HH:mm:ss");
                DateTime d = DateTime.Now;
                TimeSpan ts = m_dateTimeFininsh.Subtract(d);
                //ts.
                lblCountdown.Text = ts.ToString(@"hh\:mm\:ss");//(m_dateTimeFininsh - d).ToString("HH:mm:ss");

                //lblHH.Text = (m_iRawSec / 3600).ToString();
                //lblMM.Text = ((m_iRawSec / 60) % 60).ToString();
                //lblSS.Text = (m_iRawSec % 60).ToString();
                if(m_iRawSec == 0)
                {
                    //this.BringToFront();
                    this.Activate();
                    /*
                    MessageBox.Show("msggg", "captionnnn",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                                 */
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateWeightNumToDo();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateWeightNumToDo();
        }

        private void CalculateWeightNumToDo()
        {
            string sFoodSet = listBox2.Text;
            double weightLeft;// = int.Parse(textBox2.Text);
            double weightEachSet = dictFoodSetToWeight[sFoodSet];// = double.Parse(listBox2.Text);
            int iNumOfSetToCarry = 0;
            if ( double.TryParse(textBox2.Text, out weightLeft) )
            {
                iNumOfSetToCarry = Convert.ToInt32(Math.Floor(weightLeft / weightEachSet));
            }
                
            numOfSetToCarry.Text = iNumOfSetToCarry.ToString();

            textBox3.Text = "";
            if (iNumOfSetToCarry > 0)
            {
                foreach (int i in dictFoodSetToIngred[sFoodSet])
                {
                    String s = (iNumOfSetToCarry * i).ToString();
             
                    textBox3.AppendText(s);
                    textBox3.AppendText(Environment.NewLine);
                }
                //textBox3.Text = s;
            }


            //System.Console.WriteLine(listBox2.Text);
            //if(listBox2.SelectedValue.ToString() )
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            //int numOfTimes = int.Parse(textBox1.Text);
            //iTimeMultiplier = ;
            if (int.TryParse(textBox1.Text, out int numOfTimes)
                && int.TryParse(listBox1.Text, out int iTimeMultiplier))
            {
                if (checkBox1.Checked == false)
                    iTimeMultiplier += 4;
                m_iRawSec = numOfTimes * iTimeMultiplier + m_iPadding;//got the raw second, keep this number.
            }
            m_dateTimeFininsh = DateTime.Now.AddSeconds(m_iRawSec);
            lblETA.Text = m_dateTimeFininsh.ToString("HH:mm:ss");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_iRawSec = 0;
            m_dateTimeFininsh = DateTime.MinValue;
            lblETA.Text = m_dateTimeFininsh.ToString("HH:mm:ss");
            lblCountdown.Text = lblETA.Text;
        }
    }
}
