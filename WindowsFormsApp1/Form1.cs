using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataSet11.DataTable1.Clear();
            dataGridView2.Rows.Clear();
            foreach (string r in textBox1.Text.Split('\n','\r'))
            {
                if (
                    r.Length > 0
                    && r[0] == '['
                    && r.IndexOf("Player") >= 0
                    && r.IndexOf("xuid: ") >= 0
                    )
                {
                    try
                    {
                        DateTime time = Convert.ToDateTime(r.Substring(1, 19));
                        ulong xuid = Convert.ToUInt64(r.Substring(r.IndexOf("xuid: ") + 6));
                        string name = r.Substring(r.IndexOf("ed: ") + 4, r.IndexOf(',') - r.IndexOf("ed: ") - 4);
                        string act = r.IndexOf("Player disconnected: ") >= 0 ? "Disconnected" : "Connected";
                        dataSet11.DataTable1.Rows.Add(name, xuid, act, time);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            List<ulong> xuidList = new List<ulong>();
            Dictionary<ulong, string> lastUsername = new Dictionary<ulong, string>();
            Dictionary<ulong, int> loginCount = new Dictionary<ulong, int>();
            Dictionary<ulong, DateTime> lastLogin = new Dictionary<ulong, DateTime>();
            foreach (DataRow dr in dataSet11.DataTable1.Select())
            {
                ulong xuid = (ulong)dr.ItemArray[1];
                if (!xuidList.Contains(xuid))
                {
                    xuidList.Add(xuid);
                }
                if ((string)dr.ItemArray[2]=="Connected")
                {
                    if (loginCount.ContainsKey(xuid))
                    {
                        loginCount[xuid]++;
                    }
                    else
                    {
                        loginCount.Add(xuid, 1);
                    }
                    if (lastLogin.ContainsKey(xuid))
                    {
                        if (lastLogin[xuid] < (DateTime)dr.ItemArray[3])
                        {
                            lastLogin[xuid] = (DateTime)dr.ItemArray[3];
                            lastUsername[xuid] = (string)dr.ItemArray[0];
                        }
                    }
                    else
                    {
                        lastLogin[xuid] = (DateTime)dr.ItemArray[3];
                        lastUsername[xuid] = (string)dr.ItemArray[0];
                    }
                }
            }
            foreach (ulong xuid in xuidList)
            {
                try
                {
                    dataGridView2.Rows.Add(lastUsername[xuid], xuid, loginCount[xuid], lastLogin[xuid]);
                }
                catch
                {

                }
            }
            dataGridView2.AutoResizeColumns();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == SystemColors.GrayText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == SystemColors.WindowText && textBox1.Text == "")
            {
                textBox1.Text = "在此处粘贴日志文本";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                ulong xuid = (ulong)dataGridView2.CurrentRow.Cells[1].Value;
                DataSet1 ds = new DataSet1();
                DataTable dt = ds.DataTable1;
                foreach (DataRow dr in dataSet11.DataTable1.Rows)
                {
                    if ((ulong)dr.ItemArray[1] == xuid)
                    {
                        dt.Rows.Add(dr.ItemArray);
                    }
                }
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "DataTable1";
                dataGridView1.AutoResizeColumns();
            }
            catch
            {

            }
        }
    }
}
