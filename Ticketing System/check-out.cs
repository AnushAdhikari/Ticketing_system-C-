using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center_Ticketing_Method
{
    public partial class Check_out_Visitor : UserControl
    {
        public Check_out_Visitor()
        {
            InitializeComponent();
            string dat = Utility.ReadFromFile();
            
            if (dat != null) { load_data(); }
            
        }


        private void load_data()
        {
            string data = Utility.ReadFromFile();
            List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
            
            var columns = from t in Lstdata
                          where t.Date == DateTime.Today
                          orderby t.VisitorsId
                          select new
                          { 
                              VisitorsID = t.VisitorsId,
                              Name = t.VisitorName,
                              Phone = t.phone,
                              AgeGroup = t.AgeGroup,
                              GroupCount = t.GroupCount,
                              Date = t.Date,
                              In_Time = t.InTime,
                              Out_Time = t.OutTime,
                              Price = t.price,

                          };
            VisitorsExitDataGrid.DataSource = columns.ToList();

        }

        private void btnVisitorExit_Click(object sender, EventArgs e)
        {
            if (txtVisitorsID.Text == "")
            {
                MessageBox.Show("Please Deliver ID", "Invalid!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int visID = int.Parse(txtVisitorsID.Text);
                DateTime outtime = DateTime.Parse(txtOutTime.Text);
                string data = Utility.ReadFromFile();
                List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
                int index = Lstdata.FindIndex(x => x.VisitorsId == visID);
                Lstdata[index].price = int.Parse(txtPrice.Text);
                Lstdata[index].OutTime = outtime;

                string dt = JsonConvert.SerializeObject(Lstdata);
                Utility.WriteToFile(dt);
                MessageBox.Show("Visitor Checked-out", "Visitor Checked-out",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int visID = int.Parse(txtVisitorsID.Text);
                DateTime outtime = DateTime.Parse(txtOutTime.Text);
                string data = Utility.ReadFromFile();
                List<VisitorsData> Lstdata = JsonConvert.DeserializeObject<List<VisitorsData>>(data);
                var columns = from t in Lstdata
                              where t.VisitorsId == visID
                              select new
                              {
                                  AgeGroup = t.AgeGroup,
                                  GroupCount = t.GroupCount,
                                  Date = t.Date,
                                  In_Time = t.InTime,
                              };
                var datass = columns.ToList();
                string age = datass[0].AgeGroup;
                int count = datass[0].GroupCount;
                DateTime todayDate = datass[0].Date;
                DateTime arrival = datass[0].In_Time;
                int durat = (int)Math.Round(double.Parse((outtime.Subtract(arrival).TotalHours).ToString()));
                txtDuration.Text = (durat).ToString();
                if (durat < 1)
                {
                    durat = 1;
                }
                if (durat > 4)
                {
                    durat = 5;
                }
                try
                {
                    txtPrice.Text = (calculatePrice(durat, count, todayDate, age)).ToString();
                }
                catch
                {
                    MessageBox.Show("Empty Price Data", "Invalid!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Please Deliver ID", "Empty!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clear()
        {
            txtVisitorsID.Text = String.Empty;
            
            txtPrice.Text = String.Empty;
            
            txtOutTime.Value = DateTime.Now;

        }
        private int calculatePrice(int duration, int count, DateTime week, string age)
        {
            int price = 0;
            string data = Utility1.ReadFromFile();
            int indate = ((int)week.DayOfWeek);
            List<PriceData> ratedata = JsonConvert.DeserializeObject<List<PriceData>>(data);
            var pricedata = from t in ratedata
                            where t.Duration == duration && t.GroupCount == count
                            select new
                            {

                                RegularPriceForChildrens = t.weekDaysChild,
                                WeekendPriceForChildrens = t.weekendChildPrice,
                                RegularPriceForAdults = t.weekDaysAdult,
                                WeekendPriceForAdults = t.weekendAdultPrice,
                                RegularPriceForAged = t.weekDaysAged,
                                WeekendPriceForAged = t.weekendAgedPrice,
                            };
            var actualprice = pricedata.ToList();
            
                if (age == "Child")
                {
                    if (indate == 1 || indate == 7)
                    {
                        price = actualprice[0].WeekendPriceForChildrens;
                    }
                    else
                    {
                        price = actualprice[0].RegularPriceForChildrens;
                    }
                }
                else if (age == "Adult")
                {
                    if (indate == 1 || indate == 7)
                    {
                        price = actualprice[0].WeekendPriceForAdults;
                    }
                    else
                    {
                        price = actualprice[0].RegularPriceForAdults;
                    }
                }
                else
                {
                    if (indate == 1 || indate == 7)
                    {
                        price = actualprice[0].WeekendPriceForAged;
                    }
                    else
                    {
                        price = actualprice[0].RegularPriceForAged;
                    }
                }

                int finalprice = price * count;
                return finalprice;
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
