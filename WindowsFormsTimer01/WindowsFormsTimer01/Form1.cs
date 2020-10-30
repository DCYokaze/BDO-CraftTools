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
        //padding, calculate from 10% of durability decreased, eg. 320dur will pad with 32 seconds
        private int m_iPadding = 10;
        private List<DataBaseMemory> db;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            db = new List<DataBaseMemory>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                    crafting_state_change(1);
                    /*
                    MessageBox.Show("msggg", "captionnnn",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                                 */
                }
            }
        }
        private void crafting_state_change(int state)
        {
            switch (state)
            {
                case 0:
                    this.BackColor = SystemColors.Control; break;
                case 1:
                    this.BackColor = Color.Red;break;
                default:
                    this.BackColor = SystemColors.Control; break;
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
            //double weightEachSet = dictFoodSetToWeight[sFoodSet];
            DataBaseMemory d = db[listBox2.SelectedIndex];
            double weightEachSet = d.weight;
            
            int iNumOfSetToCarry = 0;
            if ( double.TryParse(textBox2.Text, out double weightLeft) )
            {
                iNumOfSetToCarry = Convert.ToInt32(Math.Floor(weightLeft / weightEachSet));
            }
            
            numberOfSetToCarry.Text = iNumOfSetToCarry.ToString();
            
            textBox3.Text = "";
            if (iNumOfSetToCarry > 0)
            {
                for (int i = 0; i < d.ingrediences.Count ; i++)
                {
                    int iIngredNum = d.ingrediences[i].Item1;
                    String sIngredName = d.ingrediences[i].Item2;

                    String sNumOfIngred = (iNumOfSetToCarry * iIngredNum).ToString();
                    textBox3.AppendText(sNumOfIngred);
                    textBox3.AppendText("-");
                    textBox3.AppendText(sIngredName);
                    textBox3.AppendText(Environment.NewLine);
                }
            }
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numOfTimes)
                && int.TryParse(dUpDown2.Text, out int iTimeMultiplier))
            {
                if (checkBox1.Checked == true)
                    iTimeMultiplier -= 4;
                m_iRawSec = numOfTimes * iTimeMultiplier + ((numOfTimes*m_iPadding)/100);//got the raw second, keep this number.
            }
            m_dateTimeFininsh = DateTime.Now.AddSeconds(m_iRawSec);
            lblETA.Text = m_dateTimeFininsh.ToString("HH:mm:ss");
            crafting_state_change(0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_iRawSec = 0;
            m_dateTimeFininsh = DateTime.MinValue;
            lblETA.Text = m_dateTimeFininsh.ToString("HH:mm:ss");
            lblCountdown.Text = lblETA.Text;
            crafting_state_change(0);
        }

        private void numberOfSetToCarry_TextChanged(object sender, EventArgs e)
        {
            return;
            //the revese version of ...
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = System.IO.File.OpenText("data.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                DataBaseMemory d = new DataBaseMemory();
                //d = new DataBaseMemory();
                string[] items = line.Split(',');
                //d->name = "0";
                d.name = items[0];
                d.weight = double.Parse(items[1]);

                for(int i = 2; i < items.Length; i = i+2)
                {
                    Tuple<int, string> t = Tuple.Create(int.Parse(items[i]),items[i+1]);
                    d.ingrediences.Add(t);
                }
                db.Add(d);
                listBox2.Items.Add(d.name);
                //listBox2.ControlAdded();
            }
            //
            int x = 0;
        }
    }
    public class DataBaseMemory
    {
        public string name { get; set; }//food's name
        public double weight { get; set; } //each set of food's ingredient (summation of them)

        //yeah, this will be the list of them.
        public List<Tuple<int, string>> ingrediences { get; set; }

        public DataBaseMemory()
        {
            name = "";
            weight = 0;
            ingrediences = new List<Tuple<int, string>>();
        }
        //what should we do?
        ~DataBaseMemory()
        {
            ingrediences.Clear();
        }
    }

}
