using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelReservations2
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
            dateTimePicker1.Text = System.DateTime.Today.ToLongDateString();
            dateTimePicker2.Text = System.DateTime.Today.AddDays(1).ToLongDateString();

            //Format price for currency
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";

            AddCust.Visible = false;
            label5.Visible = false;
            statMssg.Text = "Today is " + DateTime.Now.ToLongDateString();
            dayMssg.Text = "Current time is " + DateTime.Now.ToShortTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Text = dateTimePicker1.Value.AddDays(1).ToLongDateString();
        }

      
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void reserveButton_Click(object sender, EventArgs e)
        {
            int r1 = dataGridView1.CurrentCell.RowIndex;
            int r2 = dataGridView2.CurrentCell.RowIndex;

            Double costDbbl = 0;


            if (HRoom.reserveRoom(dataGridView1[5, r1].Value, dataGridView2[1, r2].Value, dateTimePicker1.Value, dateTimePicker2.Value, dataGridView1[1, r1].Value))
            {
                Finalmssg.Text = "Reservation made. Details below.";
                resBegDate.Text = dateTimePicker1.Value.ToLongDateString();
                resEndDate.Text = dateTimePicker2.Value.ToLongDateString();
                rRoom.Text = dataGridView1[0, r1].Value.ToString();
                rCustFN.Text = dataGridView2[3, r1].Value.ToString();
                rCustLN.Text = dataGridView2[4, r1].Value.ToString();
                rCustAddr1.Text = dataGridView2[5, r1].Value.ToString();
                rCustAddr2.Text = dataGridView2[6, r1].Value.ToString();
                rCity.Text = dataGridView2[7, r1].Value.ToString();
                rState.Text = dataGridView2[8, r1].Value.ToString();
                rZip.Text = dataGridView2[9, r1].Value.ToString();
                rPhone.Text = dataGridView2[10, r1].Value.ToString();

                //Calculate cost
                costDbbl = (dateTimePicker2.Value - dateTimePicker1.Value).TotalDays;
                costDbbl = costDbbl * Double.Parse(dataGridView1[2, r1].Value.ToString());
                costBox.Text = costDbbl.ToString("C2");
            }
            else
            {
                Finalmssg.Text = "Reservation failed.";
                resBegDate.Text = "Error";
                resEndDate.Text = "Error";
            }
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int counter;
            AddCust.Visible = true;
            AddCust.Enabled = false;
            label5.Visible = true;
            //// Iterate through the rows
            counter = dataGridView4.Rows.Count - 2; // last row
            
            if (counter >= 0)
            {
                // Require at least number, first, and last name before saving customer
                if (dataGridView4.Rows[counter].Cells[0].Value.ToString().Length > 0 &&
                    dataGridView4.Rows[counter].Cells[2].Value.ToString().Length > 0 &&
                    dataGridView4.Rows[counter].Cells[3].Value.ToString().Length > 0)
                {
                    AddCust.Enabled = true;
                }
            }
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
            

        private void AddCust_Click_1(object sender, EventArgs e)
        {
            if (Customer.newCustomer(dataGridView4, dataGridView4.CurrentCell.RowIndex))
            {
                NewCust.Text = "New customer added.";
            }
            else
            {
                NewCust.Text = "Error on New customer.";
            }
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {            
            this.browseCustViewTableAdapter2.Fill(this.hotelResvDataSet8.browseCustView);           
            this.browseCustViewTableAdapter.Fill(this.hotelResvDataSet6.browseCustView);            
            this.roomCheckOutViewTableAdapter.Fill(this.hotelResvDataSet5.roomCheckOutView);            
            this.reservationViewTableAdapter.Fill(this.hotelResvDataSet4.reservationView);
            this.customersTableAdapter.Fill(this.hotelResvDataSet1.Customers);            
            this.roomViewTableAdapter.Fill(this.hotelResvDataSet.roomView);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
