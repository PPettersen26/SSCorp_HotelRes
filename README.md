# SSCorp_HotelRes
Project requested by SSCorp.

Hotel reservation system for Service Spring Corp
Introduction
This has been an enjoyable project to work on. This has been a good project for me to show off my skills. If I had an unlimited amount of time, there are an unlimited amount of tweaks I could add to this system. My original idea was to do this in ASP/C# but presenting this in a timely manner was very difficult to do. So I instead used a Windows Forms app using C#. Even so, the main drive of this app is with Microsoft SQL Server tables. Having the proper tables, adds, and updates were needed the most to do this, then have the forms to display the results.

Project Definition
This should be a relatively easy program; I’m purposely making it vague so you can do as much or as little as you think is necessary
-          Create a hotel reservation system in whatever language you think is appropriate
•	Prompt for user’s current requirements (room preference and dates of booking).
•	Match user’s requirements with currently available rooms. A hotel will likely have several variably priced room types – penthouse suites, large rooms with king size beds, single bed rooms, etc.
•	Assign a room to user and record preferences for future use.
 If you can include a recorded preference to automatically check the user into a room that fits his/her requirements on future visits, then you are really on top of the game.
Part 1 of design

The first step in the design of this project is the design of the database used for this system.  Once tables were created, simple adds and updates can be used from the user interface.  On the following page I have included all SQL I used to create the tables and the view I am using for the room status. For this test I entered 30 rooms with 5 room types. 
 

SQL Table Definition
use HotelResv
go

create table [dbo].RoomTypes
(
	RoomType_guid uniqueidentifier primary key,
	RoomType_Number int,
	RoomType_Price decimal,
	RoomType_Name varchar(20),
	RoomType_Description varchar(100)
)
create table [dbo].Customers
(
	Customer_guid uniqueidentifier primary key,
	Customer_Number int unique not null,
	Customer_FName varchar(50),
	Customer_LName varchar(50),
	Customer_addr1 varchar(50),
	Customer_addr2 varchar(50),
	Customer_city varchar(25),
	Customer_state varchar(25),
	Customer_zip varchar(10),
	Customer_phone varchar(10),
	Customer_last_room_type int,
	Customer_discounts varchar(10)  
)
create table [dbo].Rooms
(
    Room_guid uniqueidentifier primary key,	
	Room_number int,
	RoomType_guid uniqueidentifier  null,
	CONSTRAINT [FK_RoomType_guid] FOREIGN KEY ([RoomType_guid]) REFERENCES [RoomTypes]
		on update cascade on delete cascade,	
	Room_Vacant bit default '1',
	Room_CheckedIn bit default '0'
)


create table [dbo].Reservation
(
	Reservation_guid  uniqueidentifier primary key,
	Reservation_Number  int unique not null,
	Room_guid uniqueidentifier  null,
		CONSTRAINT [FK_Room_guid] FOREIGN KEY ([Room_guid]) REFERENCES [Rooms]
		 on update cascade on delete cascade,
	Customer_guid uniqueidentifier  null,
		CONSTRAINT [FK_Recipe_guid] FOREIGN KEY ([Customer_guid]) REFERENCES [Customers]
		 on update cascade on delete cascade,
	Reservation_Checkin_date date,
	Reservation_checkout_date date,
	Reservation_Checked_in bit default '0',
	Reservation_Checked_out bit default '0'
)



insert into RoomTypes values (newid(), 1, 450, 'Luxury Suite','Two queen bed suite with kitchenette and parlor')
insert into RoomTypes values (newid(), 2, 300, 'Family Suite', 'Two bedroom with living area and kitchenette for a family of 6')
insert into RoomTypes values (newid(), 3, 250, 'Luxury King', 'Spacious room with king bed')
insert into RoomTypes values (newid(), 4, 150, 'Queen Standard', 'Comfortable standard room with queen bed')
insert into RoomTypes values (newid(), 5, 80, 'Twin Single', 'Standard budget room with twin bed')


insert into Rooms values (newid(), 1, 'ACE26183-6451-40B7-AB84-755F77741C80', '1', '0')
insert into Rooms values (newid(), 2, 'ACE26183-6451-40B7-AB84-755F77741C80', '1', '0')
insert into Rooms values (newid(), 3, 'DF3042C4-7E4A-4CA5-A91E-746C8F2D44F3', '1', '0')
insert into Rooms values (newid(), 4, 'DF3042C4-7E4A-4CA5-A91E-746C8F2D44F3', '1', '0')
insert into Rooms values (newid(), 5, 'DF3042C4-7E4A-4CA5-A91E-746C8F2D44F3', '1', '0')
insert into Rooms values (newid(), 6, 'DF3042C4-7E4A-4CA5-A91E-746C8F2D44F3', '1', '0')
insert into Rooms values (newid(), 7, '96ED8551-E101-4A3A-83FD-DD0558B77E1C', '1', '0')
insert into Rooms values (newid(), 8, '96ED8551-E101-4A3A-83FD-DD0558B77E1C', '1', '0')
insert into Rooms values (newid(), 9, '96ED8551-E101-4A3A-83FD-DD0558B77E1C', '1', '0')
insert into Rooms values (newid(), 10, '96ED8551-E101-4A3A-83FD-DD0558B77E1C', '1', '0')
insert into Rooms values (newid(), 11, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 12, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 13, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 14, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 15, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 16, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 17, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 18, 'C43AB8B1-7700-4D42-8E43-15E7A8422AAB', '1', '0')
insert into Rooms values (newid(), 19, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 20, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 21, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 22, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 23, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 24, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 25, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 26, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 27, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 28, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 29, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')
insert into Rooms values (newid(), 30, 'D775697B-9ACD-42C0-874D-F231A417F73A', '1', '0')


View used in the room status dropdown.
create view roomList as 
SELECT        r.Room_number, t.RoomType_Name, t.RoomType_Price, r.Room_Vacant, r.Room_CheckedIn
FROM            dbo.Rooms AS r INNER JOIN
                         dbo.RoomTypes AS t ON t.RoomType_guid = r.RoomType_guid

 
Used for Reservation status screen
Create view reservationView AS 
SELECT s.Reservation_Number, s.Reservation_Checkin_date, s.Reservation_checkout_date, r.Room_number, t.RoomType_Name, c.Customer_FName,
	c.Customer_LName, c.Customer_addr1, c.Customer_addr2, c.Customer_city, c.Customer_state, c.Customer_zip, c.Customer_phone
  FROM [Reservation] s
  join Customers c on s.customer_guid = c.customer_guid
  join Rooms r on r.Room_guid = s.Room_guid
  join RoomTypes t on r.RoomType_guid = t.RoomType_guid
  where DAY(Reservation_Checkin_date) = DAY(GETDATE())
 
Screens Displayed
The screens were set up with tabs, Hotel status, Take registration, and customer.  Hotel Status would be the welcome screen showing the days date, time and 2 windows, customers checking in today and customers checking out today. 
 
The Take registration tab has a start date, end date, room, and customer. When all are selected, the reservation is made. 
 
The customer tab shows all customers and allows entry of new customers. 
 
Code behind the system
I chose to use entity framework because it is easy to develop and maintain. I have found it to be very useful in different applications.
The code for the form
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
            dateTimePicker1.Text = System.DateTime.Today.ToLongDateString();
            dateTimePicker2.Text = System.DateTime.Today.AddDays(1).ToLongDateString();

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
            if (HRoom.reserveRoom(dataGridView1[5, r1].Value, dataGridView2[1, r2].Value, dateTimePicker1.Value, dateTimePicker2.Value))
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

Code for the room resevations
I created a class HRoom that handles all reservations for rooms.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelReservations2
{
    class HRoom
    {
//Called when new reservation button is clicked. It receives the primary key of the room record and the primary key of the customer record, and the dates needed.
        public static bool reserveRoom(Object roomGuid, Object custGuid, DateTime begin, DateTime end)
        {
            Random rNum = new Random();

            try
            {
                HotelResvEntities Db = new HotelResvEntities();

                Reservation Rs = new Reservation();
                Rs.Reservation_guid = Guid.NewGuid();
                Rs.Reservation_Number = rNum.Next();
                Rs.Room_guid = Guid.Parse(roomGuid.ToString());
                Rs.Customer_guid = Guid.Parse(custGuid.ToString());
                Rs.Reservation_Checkin_date = begin;
                Rs.Reservation_checkout_date = end;
                Rs.Reservation_Checked_in = false;
                Rs.Reservation_Checked_out = false;

                Db.Reservations.Add(Rs);
                Db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
The following is for the new class Customer
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservations2
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Reservations = new HashSet<Reservation>();
        }

	// Called when New Customer button is clicked. It sends the datagridtable and the row selected.
        public static bool newCustomer(DataGridView dGV, int row)
        {
            try
            {
                HotelResvEntities Db = new HotelResvEntities();

                Customer Cs = new Customer();
                Cs.Customer_guid = Guid.NewGuid();
                Cs.Customer_Number = Int32.Parse(dGV[0, row].Value.ToString());
                Cs.Customer_FName = dGV[2, row].Value.ToString();
                Cs.Customer_LName = dGV[3, row].Value.ToString();
                Cs.Customer_addr1 = dGV[4, row].Value.ToString();
                Cs.Customer_addr2 = dGV[5, row].Value.ToString();
                Cs.Customer_city = dGV[6, row].Value.ToString();
                Cs.Customer_state = dGV[7, row].Value.ToString();
                Cs.Customer_zip = dGV[8, row].Value.ToString();
                Cs.Customer_phone = dGV[9, row].Value.ToString();
                Cs.Customer_discounts = dGV[10, row].Value.ToString();

                Db.Customers.Add(Cs);
                Db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    
        public System.Guid Customer_guid { get; set; }
        public int Customer_Number { get; set; }
        public string Customer_FName { get; set; }
        public string Customer_LName { get; set; }
        public string Customer_addr1 { get; set; }
        public string Customer_addr2 { get; set; }
        public string Customer_city { get; set; }
        public string Customer_state { get; set; }
        public string Customer_zip { get; set; }
        public string Customer_phone { get; set; }
        public Nullable<int> Customer_last_room_type { get; set; }
        public string Customer_discounts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

