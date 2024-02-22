using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void Convert2XML(DataSet ds)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files(*.*)| *.* ";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(
                saveFileDialog1.FileName);
                ds.WriteXml(sw);
            }
        }

        public static void Convert2DS(DataSet ds)
        {
            

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "XML files (*.xml)|*.xml|All files(*.*)| *.* ";
            OpenFileDialog1.FilterIndex = 1;
            OpenFileDialog1.RestoreDirectory = true;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader sr = new StreamReader(OpenFileDialog1.FileName))
                {






                    //DataSet ds = new DataSet();
                    ds.ReadXml(sr);
                    //return ds;
                }
            }

        }

        private void bt_plot_Click(object sender, EventArgs e)
        {

            ch_pos.ChartAreas[0].AxisY.Maximum = Double.NaN;
            ch_pos.ChartAreas[0].RecalculateAxesScale();
            ch_pos.Series[0].Points.Clear();
            ch_pos.Series[1].Points.Clear();
            double scale = 100;
            for (int i = 0; i < 1000; i++)
            {
                ch_pos.Series[0].Points.AddXY(i, Math.Sin(i / scale));
                //.s0.Points.AddXY(i, Math.Sin(i / scale));

                
            }

            for ( int i = 1; i < ch_pos.Series[0].Points.Count; i++)
            {
                //ch_pos.Series[1].Points.AddXY(ch_pos.Series[0].Points[i].XValue, (ch_pos.Series[0].Points[i].YValues[0] -
                //                                      ch_pos.Series[0].Points[i - 1].YValues[0]) / scale);

                var diff = (ch_pos.Series[0].Points[i].YValues[0] - ch_pos.Series[0].Points[i - 1].YValues[0]);

                ch_pos.Series[1].Points.AddXY(i, diff* scale);
                tb_debug.AppendText(diff.ToString() + NewLine);
                //ch_pos.Series[1].Points.AddXY(i, Math.Cos(i / scale));

            }
            if (cb_save.Checked)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add(new DataColumn("Integer ", typeof(Int32)));
                dt.Columns.Add(new DataColumn("String ", typeof(string)));
                dt.Columns.Add(new DataColumn("Data ", typeof(DateTime)));
                dt.Columns.Add(new DataColumn("Bool ", typeof(bool)));
                dt.Columns.Add(new DataColumn("Float ", typeof(double)));
                for (int i = 1; i < ch_pos.Series[1].Points.Count; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = "Mark   " + i.ToString();
                    dr[2] = DateTime.Now;
                    dr[3] = (i % 2 != 0) ? true : false;
                    dr[4] = ch_pos.Series[1].Points[i].YValues[0];
                    dt.Rows.Add(dr);
                }
                //dataGrid1.DataSource = new DataView(dt);
                // dataGrid1.DataBind();
                //DataSet dt = new DataSet();
                //da.Fill(dt);
                DataSet dataSet = new DataSet("Mark_Diff");
                //Adding DataTables into DataSet
                dataSet.Tables.Add(dt);

                Convert2XML(dataSet);
            }
        }

        private void bt_load_Click(object sender, EventArgs e)
        {

            var ds = new DataSet();
            Convert2DS(ds);
            DataTable dt = ds.Tables["Table1"];
            //DataTable dt = ds.Tables;
            //foreach (DataTable dt in ds.Tables)
            //{
            //tb_debug.AppendText(dt.ToString() + NewLine);
            int i = 1;
                foreach (DataRow dataRow in dt.Rows)
                {
                tb_debug.AppendText(i.ToString() + NewLine);
                var data = Convert.ToDouble(dataRow[4]);
                tb_debug.AppendText(data.ToString() + NewLine);
                //ch_pos.Series[1].Points[i].YValues[0] = Convert.ToDouble(dataRow[4]);
                ch_pos.Series[1].Points.AddXY(i, data);
                i++;
                //foreach (var item in dataRow.ItemArray)
                // {

                //   tb_debug.AppendText(item.ToString() + NewLine);
                //}
            }
            //}
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            foreach (var series in ch_pos.Series)
            {
                series.Points.Clear();
            }
        }
    }
}

