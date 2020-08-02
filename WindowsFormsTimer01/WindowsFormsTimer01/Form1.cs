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
        private int m_iPadding = 15;//sec
        private Dictionary<string, double> dictFoodSetToWeight;
        private Dictionary<string, int[]> dictFoodSetToIngred;
        private Dictionary<string, string[]> dictIngredName;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            dictFoodSetToWeight = new Dictionary<string, double>
            {
                { "Pickled", 0.88 },
                { "Vinegar", 0.22 },
                { "Beer", 0.59 },
                { "Sw.Ham", 0.94 },
                { "", 1.00 }
            };

            dictFoodSetToIngred = new Dictionary<string, int[]>
            {
                { "Pickled", new int[] { 8, 4, 2, 2 } },
                { "Vinegar", new int[] { 1, 1, 1, 1 } },
                { "Beer", new int[] { 5, 6, 2, 1 } },
                { "Sw.Ham", new int[] { 2, 2, 5, 4 } },
                { "", new int[] { 1 } }
            };

            dictIngredName = new Dictionary<string, string[]>
            {
                { "Pickled", new string[] { "ผัก", "นส้ม", "จุล", "นตาล" } },
                { "Vinegar", new string[] { "ผล", "ธัญ", "จุล", "นตาล" } },
                { "Beer", new string[] { "ธัญ", "น้ำ", "จุล", "นตาล" } },
                { "Sw.Ham", new string[] { "ปังนุ่ม", "ไส้ก.ย่าง", "ผัก", "ไข่" } },
                { "", new string[] { "" } }
            };
            //*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblClockDisplay.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            //lblClockDisplay2.Text = DateTime.Now.AddSeconds(30).ToString("HH:mm:ss");
            //int timeCountDown = int.Parse(lblSS.Text);
            
            if (m_iRawSec > 0)
            {
                m_iRawSec -= 1;

                DateTime d = DateTime.Now;
                TimeSpan ts = m_dateTimeFininsh.Subtract(d);
                lblCountdown.Text = ts.ToString(@"hh\:mm\:ss");//(m_dateTimeFininsh - d).ToString("HH:mm:ss");

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
            double weightEachSet = dictFoodSetToWeight[sFoodSet];
            int iNumOfSetToCarry = 0;
            if ( double.TryParse(textBox2.Text, out double weightLeft) )
            {
                iNumOfSetToCarry = Convert.ToInt32(Math.Floor(weightLeft / weightEachSet));
            }
            
            numberOfSetToCarry.Text = iNumOfSetToCarry.ToString();

            textBox3.Text = "";
            if (iNumOfSetToCarry > 0)
            {
                int j = 0;//another index - -''
                foreach (int i in dictFoodSetToIngred[sFoodSet])
                {
                    String sNumOfIngred = (iNumOfSetToCarry * i).ToString();
                    //String 
                    String sNameOfIngred = dictIngredName[sFoodSet][j];
                    textBox3.AppendText(sNumOfIngred);
                    textBox3.AppendText("-");
                    textBox3.AppendText(sNameOfIngred);
                    //dictIngredName
                    textBox3.AppendText(Environment.NewLine);
                    j++;
                }
            }
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numOfTimes)
                && int.TryParse(listBox1.Text, out int iTimeMultiplier))
            {
                if (checkBox1.Checked == true)
                    iTimeMultiplier -= 4;
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

        private void numberOfSetToCarry_TextChanged(object sender, EventArgs e)
        {
            return;
            //the revese version of ...
            string sFoodSet = listBox2.Text;
            double weightEachSet = dictFoodSetToWeight[sFoodSet];
            int iNumOfSetToCarry = 0;
            if (int.TryParse(numberOfSetToCarry.Text, out int numOfSet))
            {
                textBox2.Text = (numOfSet * weightEachSet).ToString();
            }

            iNumOfSetToCarry = numOfSet; //Why bother this?

            textBox3.Text = "";
            if (iNumOfSetToCarry > 0)
            {
                int j = 0;//another index - -''
                foreach (int i in dictFoodSetToIngred[sFoodSet])
                {
                    String sNumOfIngred = (iNumOfSetToCarry * i).ToString();
                    //String 
                    String sNameOfIngred = dictIngredName[sFoodSet][j];
                    textBox3.AppendText(sNumOfIngred);
                    textBox3.AppendText("-");
                    textBox3.AppendText(sNameOfIngred);
                    //dictIngredName
                    textBox3.AppendText(Environment.NewLine);
                    j++;
                }
            }
        }
    }
}
