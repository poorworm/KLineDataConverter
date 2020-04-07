using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLineDataConverter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public int GetWeekNumber(DateTime? dt)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dt.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            var fileName = this.txtOpen.Text;

            var excel = new ExcelQueryFactory(fileName);

            var ps = from x in excel.Worksheet<PriceSet>("工作表1")
                     select new
                     {
                         date = x.Date.ToString(),
                         dt_m = x.Date.Value.ToString("yyyy_MM"),
                         dt_w = x.Date.Value.ToString("yyyy_") + GetWeekNumber(x.Date.Value).ToString("00"),
                         price = x.Price,
                         open = x.Open,
                         high = x.High,
                         low = x.Low,
                         vol = (x.Vol == "-") ? 0.0m : decimal.Parse(x.Vol.TrimEnd("K".ToCharArray()))                         
                     };

            var p = ps.ToList();

            // 以月
            var res_m = from x in p
                      group x by x.dt_m into gs
                      orderby gs.Key ascending
                      select new
                      {
                          dt_m = gs.Key,
                          open = gs.Max(s => (from x in gs orderby x.dt_m ascending select x.open).FirstOrDefault()),
                          price = gs.Max(s => (from x in gs orderby x.dt_m descending select x.price).FirstOrDefault()),
                          high = gs.Max(s => s.high),
                          low = gs.Max(s => s.low),
                          vol = gs.Sum(s => s.vol)
                      };

            var rm = res_m.ToList();

            // 以週
            var res_w = from x in p
                        group x by x.dt_w into gs
                        orderby gs.Key ascending
                        select new
                        {
                            dt_w = gs.Key,
                            open = gs.Max(s => (from x in gs orderby x.dt_w ascending select x.open).FirstOrDefault()),
                            price = gs.Max(s => (from x in gs orderby x.dt_w descending select x.price).FirstOrDefault()),
                            high = gs.Max(s => s.high),
                            low = gs.Max(s => s.low),
                            vol = gs.Sum(s => s.vol)
                        };

            var rw = res_w.ToList();

            // 寫檔

            if(this.txtSave.Text != "")
            {
                var sm = new StreamWriter(this.txtSave.Text, false, Encoding.GetEncoding("big5"));
                sm.WriteLine("月,Price,Open,High,Low,Vol");
                foreach (var r in rm)
                {
                    string line = string.Format("{0},{1},{2},{3},{4},{5}", r.dt_m, r.price, r.open, r.high, r.low, r.vol);
                    sm.WriteLine(line);
                }
                sm.Close();
            }


            if(this.txtSaveWeek.Text != "")
            {
                var sw = new StreamWriter(this.txtSaveWeek.Text, false, Encoding.GetEncoding("big5"));
                sw.WriteLine("週,Price,Open,High,Low,Vol");
                foreach (var r in rw)
                {
                    string line = string.Format("{0},{1},{2},{3},{4},{5}", r.dt_w, r.price, r.open, r.high, r.low, r.vol);
                    sw.WriteLine(line);
                }
                sw.Close();
            }

            MessageBox.Show("完成");                     
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if(this.ofDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtOpen.Text = this.ofDialog.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(this.sfDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtSave.Text = this.sfDialog.FileName;
            }
        }

        private void btSaveWeek_Click(object sender, EventArgs e)
        {
            if (this.sfDialogWeek.ShowDialog() == DialogResult.OK)
            {
                this.txtSaveWeek.Text = this.sfDialogWeek.FileName;
            }
        }
    }
}
