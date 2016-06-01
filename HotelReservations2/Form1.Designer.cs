using HotelReservations2.Data;

namespace HotelReservations2
{
    partial class HotelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.roomViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet = new HotelReservations2.Data.HotelResvDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet1 = new HotelReservations2.Data.HotelResvDataSet1();
            this.reservationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet4 = new HotelReservations2.Data.HotelResvDataSet4();
            this.roomViewTableAdapter = new HotelReservations2.Data.HotelResvDataSetTableAdapters.roomViewTableAdapter();
            this.customersTableAdapter = new HotelReservations2.Data.HotelResvDataSet1TableAdapters.CustomersTableAdapter();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationViewTableAdapter = new HotelReservations2.Data.HotelResvDataSet4TableAdapters.reservationViewTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rPhone = new System.Windows.Forms.TextBox();
            this.rZip = new System.Windows.Forms.TextBox();
            this.rState = new System.Windows.Forms.TextBox();
            this.rCity = new System.Windows.Forms.TextBox();
            this.rCustAddr2 = new System.Windows.Forms.TextBox();
            this.rCustAddr1 = new System.Windows.Forms.TextBox();
            this.rCustLN = new System.Windows.Forms.TextBox();
            this.rCustFN = new System.Windows.Forms.TextBox();
            this.rRoom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Finalmssg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resEndDate = new System.Windows.Forms.TextBox();
            this.resBegDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomVacantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomCheckedInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_discounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseCustViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet8 = new HotelReservations2.Data.HotelResvDataSet8();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.reservationNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationCheckindateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcheckoutdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddr1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddr2DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customercityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerstateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerzipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCheckOutViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet5 = new HotelReservations2.Data.HotelResvDataSet5();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.reservationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcheckoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationCheckindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dayMssg = new System.Windows.Forms.Label();
            this.statMssg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NewCust = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customercityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerzipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdiscountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browseCustViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelResvDataSet6 = new HotelReservations2.Data.HotelResvDataSet6();
            this.label11 = new System.Windows.Forms.Label();
            this.AddCust = new System.Windows.Forms.Button();
            this.roomCheckOutViewTableAdapter = new HotelReservations2.Data.HotelResvDataSet5TableAdapters.roomCheckOutViewTableAdapter();
            this.browseCustViewTableAdapter = new HotelReservations2.Data.HotelResvDataSet6TableAdapters.browseCustViewTableAdapter();
            this.browseCustViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.browseCustViewTableAdapter2 = new HotelReservations2.Data.HotelResvDataSet8TableAdapters.browseCustViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet8)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCheckOutViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomViewBindingSource
            // 
            this.roomViewBindingSource.DataMember = "roomView";
            this.roomViewBindingSource.DataSource = this.hotelResvDataSet;
            // 
            // hotelResvDataSet
            // 
            this.hotelResvDataSet.DataSetName = "HotelResvDataSet";
            this.hotelResvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.hotelResvDataSet1;
            // 
            // hotelResvDataSet1
            // 
            this.hotelResvDataSet1.DataSetName = "HotelResvDataSet1";
            this.hotelResvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationViewBindingSource
            // 
            this.reservationViewBindingSource.DataMember = "reservationView";
            this.reservationViewBindingSource.DataSource = this.hotelResvDataSet4;
            // 
            // hotelResvDataSet4
            // 
            this.hotelResvDataSet4.DataSetName = "HotelResvDataSet4";
            this.hotelResvDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomViewTableAdapter
            // 
            this.roomViewTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            // 
            // reservationViewTableAdapter
            // 
            this.reservationViewTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.costBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.rPhone);
            this.tabPage1.Controls.Add(this.rZip);
            this.tabPage1.Controls.Add(this.rState);
            this.tabPage1.Controls.Add(this.rCity);
            this.tabPage1.Controls.Add(this.rCustAddr2);
            this.tabPage1.Controls.Add(this.rCustAddr1);
            this.tabPage1.Controls.Add(this.rCustLN);
            this.tabPage1.Controls.Add(this.rCustFN);
            this.tabPage1.Controls.Add(this.rRoom);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.Finalmssg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.resEndDate);
            this.tabPage1.Controls.Add(this.resBegDate);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.reserveButton);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1292, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Take Registration";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(573, 418);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(100, 20);
            this.costBox.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(509, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total Cost:";
            // 
            // rPhone
            // 
            this.rPhone.Location = new System.Drawing.Point(79, 574);
            this.rPhone.Name = "rPhone";
            this.rPhone.Size = new System.Drawing.Size(100, 20);
            this.rPhone.TabIndex = 28;
            // 
            // rZip
            // 
            this.rZip.Location = new System.Drawing.Point(298, 538);
            this.rZip.Name = "rZip";
            this.rZip.Size = new System.Drawing.Size(100, 20);
            this.rZip.TabIndex = 27;
            // 
            // rState
            // 
            this.rState.Location = new System.Drawing.Point(185, 538);
            this.rState.Name = "rState";
            this.rState.Size = new System.Drawing.Size(100, 20);
            this.rState.TabIndex = 26;
            // 
            // rCity
            // 
            this.rCity.Location = new System.Drawing.Point(79, 538);
            this.rCity.Name = "rCity";
            this.rCity.Size = new System.Drawing.Size(100, 20);
            this.rCity.TabIndex = 25;
            // 
            // rCustAddr2
            // 
            this.rCustAddr2.Location = new System.Drawing.Point(186, 512);
            this.rCustAddr2.Name = "rCustAddr2";
            this.rCustAddr2.Size = new System.Drawing.Size(100, 20);
            this.rCustAddr2.TabIndex = 24;
            // 
            // rCustAddr1
            // 
            this.rCustAddr1.Location = new System.Drawing.Point(79, 512);
            this.rCustAddr1.Name = "rCustAddr1";
            this.rCustAddr1.Size = new System.Drawing.Size(100, 20);
            this.rCustAddr1.TabIndex = 23;
            // 
            // rCustLN
            // 
            this.rCustLN.Location = new System.Drawing.Point(186, 486);
            this.rCustLN.Name = "rCustLN";
            this.rCustLN.Size = new System.Drawing.Size(100, 20);
            this.rCustLN.TabIndex = 22;
            // 
            // rCustFN
            // 
            this.rCustFN.Location = new System.Drawing.Point(79, 486);
            this.rCustFN.Name = "rCustFN";
            this.rCustFN.Size = new System.Drawing.Size(100, 20);
            this.rCustFN.TabIndex = 21;
            // 
            // rRoom
            // 
            this.rRoom.Location = new System.Drawing.Point(379, 418);
            this.rRoom.Name = "rRoom";
            this.rRoom.Size = new System.Drawing.Size(100, 20);
            this.rRoom.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Customer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Room:";
            // 
            // Finalmssg
            // 
            this.Finalmssg.AutoSize = true;
            this.Finalmssg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalmssg.Location = new System.Drawing.Point(544, 385);
            this.Finalmssg.Name = "Finalmssg";
            this.Finalmssg.Size = new System.Drawing.Size(19, 26);
            this.Finalmssg.TabIndex = 17;
            this.Finalmssg.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Start date of reservation:";
            // 
            // resEndDate
            // 
            this.resEndDate.Location = new System.Drawing.Point(79, 453);
            this.resEndDate.Name = "resEndDate";
            this.resEndDate.Size = new System.Drawing.Size(207, 20);
            this.resEndDate.TabIndex = 16;
            // 
            // resBegDate
            // 
            this.resBegDate.Location = new System.Drawing.Point(79, 425);
            this.resBegDate.Name = "resBegDate";
            this.resBegDate.Size = new System.Drawing.Size(207, 20);
            this.resBegDate.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "End Date: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter End date of reservation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Start Date: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumberDataGridViewTextBoxColumn,
            this.roomTypeNameDataGridViewTextBoxColumn,
            this.roomTypePriceDataGridViewTextBoxColumn,
            this.roomVacantDataGridViewCheckBoxColumn,
            this.roomCheckedInDataGridViewCheckBoxColumn,
            this.roomguidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 112);
            this.dataGridView1.TabIndex = 4;
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Room number";
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeNameDataGridViewTextBoxColumn
            // 
            this.roomTypeNameDataGridViewTextBoxColumn.DataPropertyName = "RoomType_Name";
            this.roomTypeNameDataGridViewTextBoxColumn.HeaderText = "Type of Room";
            this.roomTypeNameDataGridViewTextBoxColumn.Name = "roomTypeNameDataGridViewTextBoxColumn";
            this.roomTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypePriceDataGridViewTextBoxColumn
            // 
            this.roomTypePriceDataGridViewTextBoxColumn.DataPropertyName = "RoomType_Price";
            this.roomTypePriceDataGridViewTextBoxColumn.HeaderText = "Price of Room";
            this.roomTypePriceDataGridViewTextBoxColumn.Name = "roomTypePriceDataGridViewTextBoxColumn";
            this.roomTypePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomVacantDataGridViewCheckBoxColumn
            // 
            this.roomVacantDataGridViewCheckBoxColumn.DataPropertyName = "Room_Vacant";
            this.roomVacantDataGridViewCheckBoxColumn.HeaderText = "Vacant";
            this.roomVacantDataGridViewCheckBoxColumn.Name = "roomVacantDataGridViewCheckBoxColumn";
            this.roomVacantDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // roomCheckedInDataGridViewCheckBoxColumn
            // 
            this.roomCheckedInDataGridViewCheckBoxColumn.DataPropertyName = "Room_CheckedIn";
            this.roomCheckedInDataGridViewCheckBoxColumn.HeaderText = "Checked In";
            this.roomCheckedInDataGridViewCheckBoxColumn.Name = "roomCheckedInDataGridViewCheckBoxColumn";
            this.roomCheckedInDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // roomguidDataGridViewTextBoxColumn
            // 
            this.roomguidDataGridViewTextBoxColumn.DataPropertyName = "Room_guid";
            this.roomguidDataGridViewTextBoxColumn.HeaderText = "Room_guid";
            this.roomguidDataGridViewTextBoxColumn.Name = "roomguidDataGridViewTextBoxColumn";
            this.roomguidDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomguidDataGridViewTextBoxColumn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pick a room to reserve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(197, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Select dates, room and customer)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pick a customer";
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(15, 393);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(164, 23);
            this.reserveButton.TabIndex = 10;
            this.reserveButton.Text = "Click to save new reservation";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn1,
            this.Customer_guid,
            this.roomTypeNameDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Customer_discounts});
            this.dataGridView2.DataSource = this.browseCustViewBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(14, 254);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1271, 124);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // customerNumberDataGridViewTextBoxColumn1
            // 
            this.customerNumberDataGridViewTextBoxColumn1.DataPropertyName = "Customer_Number";
            this.customerNumberDataGridViewTextBoxColumn1.HeaderText = "Customer #";
            this.customerNumberDataGridViewTextBoxColumn1.Name = "customerNumberDataGridViewTextBoxColumn1";
            this.customerNumberDataGridViewTextBoxColumn1.Width = 79;
            // 
            // Customer_guid
            // 
            this.Customer_guid.DataPropertyName = "Customer_guid";
            this.Customer_guid.HeaderText = "Customer_guid";
            this.Customer_guid.Name = "Customer_guid";
            this.Customer_guid.Visible = false;
            this.Customer_guid.Width = 102;
            // 
            // roomTypeNameDataGridViewTextBoxColumn2
            // 
            this.roomTypeNameDataGridViewTextBoxColumn2.DataPropertyName = "RoomType_Name";
            this.roomTypeNameDataGridViewTextBoxColumn2.HeaderText = "Last Room Reserved";
            this.roomTypeNameDataGridViewTextBoxColumn2.Name = "roomTypeNameDataGridViewTextBoxColumn2";
            this.roomTypeNameDataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_FName";
            this.dataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_LName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_addr1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Customer_addr2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address 2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 73;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Customer_city";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 49;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer_state";
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 57;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Customer_zip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 47;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Customer_phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 63;
            // 
            // Customer_discounts
            // 
            this.Customer_discounts.DataPropertyName = "Customer_discounts";
            this.Customer_discounts.HeaderText = "Discounts";
            this.Customer_discounts.Name = "Customer_discounts";
            this.Customer_discounts.Width = 79;
            // 
            // browseCustViewBindingSource2
            // 
            this.browseCustViewBindingSource2.DataMember = "browseCustView";
            this.browseCustViewBindingSource2.DataSource = this.hotelResvDataSet8;
            // 
            // hotelResvDataSet8
            // 
            this.hotelResvDataSet8.DataSetName = "HotelResvDataSet8";
            this.hotelResvDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.Wheat;
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dayMssg);
            this.tabPage3.Controls.Add(this.statMssg);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1292, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotel Home Page";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNumberDataGridViewTextBoxColumn1,
            this.reservationCheckindateDataGridViewTextBoxColumn1,
            this.reservationcheckoutdateDataGridViewTextBoxColumn1,
            this.roomnumberDataGridViewTextBoxColumn1,
            this.roomTypeNameDataGridViewTextBoxColumn1,
            this.customerFNameDataGridViewTextBoxColumn1,
            this.customerLNameDataGridViewTextBoxColumn1,
            this.customeraddr1DataGridViewTextBoxColumn1,
            this.customeraddr2DataGridViewTextBoxColumn1,
            this.customercityDataGridViewTextBoxColumn1,
            this.customerstateDataGridViewTextBoxColumn1,
            this.customerzipDataGridViewTextBoxColumn1,
            this.customerphoneDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.roomCheckOutViewBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(19, 373);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1267, 178);
            this.dataGridView5.TabIndex = 6;
            // 
            // reservationNumberDataGridViewTextBoxColumn1
            // 
            this.reservationNumberDataGridViewTextBoxColumn1.DataPropertyName = "Reservation_Number";
            this.reservationNumberDataGridViewTextBoxColumn1.HeaderText = "Reservation_Number";
            this.reservationNumberDataGridViewTextBoxColumn1.Name = "reservationNumberDataGridViewTextBoxColumn1";
            // 
            // reservationCheckindateDataGridViewTextBoxColumn1
            // 
            this.reservationCheckindateDataGridViewTextBoxColumn1.DataPropertyName = "Reservation_Checkin_date";
            this.reservationCheckindateDataGridViewTextBoxColumn1.HeaderText = "Reservation_Checkin_date";
            this.reservationCheckindateDataGridViewTextBoxColumn1.Name = "reservationCheckindateDataGridViewTextBoxColumn1";
            // 
            // reservationcheckoutdateDataGridViewTextBoxColumn1
            // 
            this.reservationcheckoutdateDataGridViewTextBoxColumn1.DataPropertyName = "Reservation_checkout_date";
            this.reservationcheckoutdateDataGridViewTextBoxColumn1.HeaderText = "Reservation_checkout_date";
            this.reservationcheckoutdateDataGridViewTextBoxColumn1.Name = "reservationcheckoutdateDataGridViewTextBoxColumn1";
            // 
            // roomnumberDataGridViewTextBoxColumn1
            // 
            this.roomnumberDataGridViewTextBoxColumn1.DataPropertyName = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn1.HeaderText = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn1.Name = "roomnumberDataGridViewTextBoxColumn1";
            // 
            // roomTypeNameDataGridViewTextBoxColumn1
            // 
            this.roomTypeNameDataGridViewTextBoxColumn1.DataPropertyName = "RoomType_Name";
            this.roomTypeNameDataGridViewTextBoxColumn1.HeaderText = "RoomType_Name";
            this.roomTypeNameDataGridViewTextBoxColumn1.Name = "roomTypeNameDataGridViewTextBoxColumn1";
            // 
            // customerFNameDataGridViewTextBoxColumn1
            // 
            this.customerFNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn1.HeaderText = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn1.Name = "customerFNameDataGridViewTextBoxColumn1";
            // 
            // customerLNameDataGridViewTextBoxColumn1
            // 
            this.customerLNameDataGridViewTextBoxColumn1.DataPropertyName = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn1.HeaderText = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn1.Name = "customerLNameDataGridViewTextBoxColumn1";
            // 
            // customeraddr1DataGridViewTextBoxColumn1
            // 
            this.customeraddr1DataGridViewTextBoxColumn1.DataPropertyName = "Customer_addr1";
            this.customeraddr1DataGridViewTextBoxColumn1.HeaderText = "Customer_addr1";
            this.customeraddr1DataGridViewTextBoxColumn1.Name = "customeraddr1DataGridViewTextBoxColumn1";
            // 
            // customeraddr2DataGridViewTextBoxColumn1
            // 
            this.customeraddr2DataGridViewTextBoxColumn1.DataPropertyName = "Customer_addr2";
            this.customeraddr2DataGridViewTextBoxColumn1.HeaderText = "Customer_addr2";
            this.customeraddr2DataGridViewTextBoxColumn1.Name = "customeraddr2DataGridViewTextBoxColumn1";
            // 
            // customercityDataGridViewTextBoxColumn1
            // 
            this.customercityDataGridViewTextBoxColumn1.DataPropertyName = "Customer_city";
            this.customercityDataGridViewTextBoxColumn1.HeaderText = "Customer_city";
            this.customercityDataGridViewTextBoxColumn1.Name = "customercityDataGridViewTextBoxColumn1";
            // 
            // customerstateDataGridViewTextBoxColumn1
            // 
            this.customerstateDataGridViewTextBoxColumn1.DataPropertyName = "Customer_state";
            this.customerstateDataGridViewTextBoxColumn1.HeaderText = "Customer_state";
            this.customerstateDataGridViewTextBoxColumn1.Name = "customerstateDataGridViewTextBoxColumn1";
            // 
            // customerzipDataGridViewTextBoxColumn1
            // 
            this.customerzipDataGridViewTextBoxColumn1.DataPropertyName = "Customer_zip";
            this.customerzipDataGridViewTextBoxColumn1.HeaderText = "Customer_zip";
            this.customerzipDataGridViewTextBoxColumn1.Name = "customerzipDataGridViewTextBoxColumn1";
            // 
            // customerphoneDataGridViewTextBoxColumn1
            // 
            this.customerphoneDataGridViewTextBoxColumn1.DataPropertyName = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn1.HeaderText = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn1.Name = "customerphoneDataGridViewTextBoxColumn1";
            // 
            // roomCheckOutViewBindingSource
            // 
            this.roomCheckOutViewBindingSource.DataMember = "roomCheckOutView";
            this.roomCheckOutViewBindingSource.DataSource = this.hotelResvDataSet5;
            // 
            // hotelResvDataSet5
            // 
            this.hotelResvDataSet5.DataSetName = "HotelResvDataSet5";
            this.hotelResvDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Rooms checking out today:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationNumberDataGridViewTextBoxColumn,
            this.Room_number,
            this.RoomType_Name,
            this.reservationcheckoutdateDataGridViewTextBoxColumn,
            this.Customer_FName,
            this.Customer_LName,
            this.Customer_addr1,
            this.Customer_addr2,
            this.Customer_city,
            this.Customer_state,
            this.Customer_zip,
            this.Customer_phone,
            this.reservationCheckindateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.reservationViewBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(19, 173);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1267, 142);
            this.dataGridView3.TabIndex = 4;
            // 
            // reservationNumberDataGridViewTextBoxColumn
            // 
            this.reservationNumberDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Number";
            this.reservationNumberDataGridViewTextBoxColumn.HeaderText = "Reservation #";
            this.reservationNumberDataGridViewTextBoxColumn.Name = "reservationNumberDataGridViewTextBoxColumn";
            // 
            // Room_number
            // 
            this.Room_number.DataPropertyName = "Room_number";
            this.Room_number.HeaderText = "Room number";
            this.Room_number.Name = "Room_number";
            // 
            // RoomType_Name
            // 
            this.RoomType_Name.DataPropertyName = "RoomType_Name";
            this.RoomType_Name.HeaderText = "Type of Room";
            this.RoomType_Name.Name = "RoomType_Name";
            // 
            // reservationcheckoutdateDataGridViewTextBoxColumn
            // 
            this.reservationcheckoutdateDataGridViewTextBoxColumn.DataPropertyName = "Reservation_checkout_date";
            this.reservationcheckoutdateDataGridViewTextBoxColumn.HeaderText = "Planned checkout";
            this.reservationcheckoutdateDataGridViewTextBoxColumn.Name = "reservationcheckoutdateDataGridViewTextBoxColumn";
            // 
            // Customer_FName
            // 
            this.Customer_FName.DataPropertyName = "Customer_FName";
            this.Customer_FName.HeaderText = "Customer First Name";
            this.Customer_FName.Name = "Customer_FName";
            // 
            // Customer_LName
            // 
            this.Customer_LName.DataPropertyName = "Customer_LName";
            this.Customer_LName.HeaderText = "Last Name";
            this.Customer_LName.Name = "Customer_LName";
            // 
            // Customer_addr1
            // 
            this.Customer_addr1.DataPropertyName = "Customer_addr1";
            this.Customer_addr1.HeaderText = "Address";
            this.Customer_addr1.Name = "Customer_addr1";
            // 
            // Customer_addr2
            // 
            this.Customer_addr2.DataPropertyName = "Customer_addr2";
            this.Customer_addr2.HeaderText = "Address 2";
            this.Customer_addr2.Name = "Customer_addr2";
            // 
            // Customer_city
            // 
            this.Customer_city.DataPropertyName = "Customer_city";
            this.Customer_city.HeaderText = "City";
            this.Customer_city.Name = "Customer_city";
            // 
            // Customer_state
            // 
            this.Customer_state.DataPropertyName = "Customer_state";
            this.Customer_state.HeaderText = "State";
            this.Customer_state.Name = "Customer_state";
            // 
            // Customer_zip
            // 
            this.Customer_zip.DataPropertyName = "Customer_zip";
            this.Customer_zip.HeaderText = "Zip";
            this.Customer_zip.Name = "Customer_zip";
            // 
            // Customer_phone
            // 
            this.Customer_phone.DataPropertyName = "Customer_phone";
            this.Customer_phone.HeaderText = "Phone";
            this.Customer_phone.Name = "Customer_phone";
            // 
            // reservationCheckindateDataGridViewTextBoxColumn
            // 
            this.reservationCheckindateDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Checkin_date";
            this.reservationCheckindateDataGridViewTextBoxColumn.HeaderText = "Reservation_Checkin_date";
            this.reservationCheckindateDataGridViewTextBoxColumn.Name = "reservationCheckindateDataGridViewTextBoxColumn";
            this.reservationCheckindateDataGridViewTextBoxColumn.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Rooms checkin in today:";
            // 
            // dayMssg
            // 
            this.dayMssg.AutoSize = true;
            this.dayMssg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayMssg.Location = new System.Drawing.Point(15, 105);
            this.dayMssg.Name = "dayMssg";
            this.dayMssg.Size = new System.Drawing.Size(60, 20);
            this.dayMssg.TabIndex = 2;
            this.dayMssg.Text = "label10";
            // 
            // statMssg
            // 
            this.statMssg.AutoSize = true;
            this.statMssg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMssg.Location = new System.Drawing.Point(15, 72);
            this.statMssg.Name = "statMssg";
            this.statMssg.Size = new System.Drawing.Size(60, 20);
            this.statMssg.TabIndex = 1;
            this.statMssg.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "SSC Hotel Reservation System";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 640);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.NewCust);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.AddCust);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1292, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            // 
            // NewCust
            // 
            this.NewCust.AutoSize = true;
            this.NewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCust.Location = new System.Drawing.Point(1007, 15);
            this.NewCust.Name = "NewCust";
            this.NewCust.Size = new System.Drawing.Size(19, 26);
            this.NewCust.TabIndex = 18;
            this.NewCust.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(660, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "(Name, First and Last name required before saving.)";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.customerFNameDataGridViewTextBoxColumn,
            this.customerLNameDataGridViewTextBoxColumn,
            this.customeraddr1DataGridViewTextBoxColumn,
            this.customeraddr2DataGridViewTextBoxColumn,
            this.customercityDataGridViewTextBoxColumn,
            this.customerstateDataGridViewTextBoxColumn,
            this.customerzipDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customerdiscountsDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.browseCustViewBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(62, 52);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1168, 419);
            this.dataGridView4.TabIndex = 11;
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellValueChanged);
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "Customer_Number";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "Customer #";
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RoomType_Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Preferred Room Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // customerFNameDataGridViewTextBoxColumn
            // 
            this.customerFNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_FName";
            this.customerFNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFNameDataGridViewTextBoxColumn.Name = "customerFNameDataGridViewTextBoxColumn";
            // 
            // customerLNameDataGridViewTextBoxColumn
            // 
            this.customerLNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_LName";
            this.customerLNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLNameDataGridViewTextBoxColumn.Name = "customerLNameDataGridViewTextBoxColumn";
            // 
            // customeraddr1DataGridViewTextBoxColumn
            // 
            this.customeraddr1DataGridViewTextBoxColumn.DataPropertyName = "Customer_addr1";
            this.customeraddr1DataGridViewTextBoxColumn.HeaderText = "Address 1";
            this.customeraddr1DataGridViewTextBoxColumn.Name = "customeraddr1DataGridViewTextBoxColumn";
            // 
            // customeraddr2DataGridViewTextBoxColumn
            // 
            this.customeraddr2DataGridViewTextBoxColumn.DataPropertyName = "Customer_addr2";
            this.customeraddr2DataGridViewTextBoxColumn.HeaderText = "Address 2";
            this.customeraddr2DataGridViewTextBoxColumn.Name = "customeraddr2DataGridViewTextBoxColumn";
            // 
            // customercityDataGridViewTextBoxColumn
            // 
            this.customercityDataGridViewTextBoxColumn.DataPropertyName = "Customer_city";
            this.customercityDataGridViewTextBoxColumn.HeaderText = "City";
            this.customercityDataGridViewTextBoxColumn.Name = "customercityDataGridViewTextBoxColumn";
            // 
            // customerstateDataGridViewTextBoxColumn
            // 
            this.customerstateDataGridViewTextBoxColumn.DataPropertyName = "Customer_state";
            this.customerstateDataGridViewTextBoxColumn.HeaderText = "State";
            this.customerstateDataGridViewTextBoxColumn.Name = "customerstateDataGridViewTextBoxColumn";
            // 
            // customerzipDataGridViewTextBoxColumn
            // 
            this.customerzipDataGridViewTextBoxColumn.DataPropertyName = "Customer_zip";
            this.customerzipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.customerzipDataGridViewTextBoxColumn.Name = "customerzipDataGridViewTextBoxColumn";
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "Customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            // 
            // customerdiscountsDataGridViewTextBoxColumn
            // 
            this.customerdiscountsDataGridViewTextBoxColumn.DataPropertyName = "Customer_discounts";
            this.customerdiscountsDataGridViewTextBoxColumn.HeaderText = "Discounts";
            this.customerdiscountsDataGridViewTextBoxColumn.Name = "customerdiscountsDataGridViewTextBoxColumn";
            // 
            // browseCustViewBindingSource
            // 
            this.browseCustViewBindingSource.DataMember = "browseCustView";
            this.browseCustViewBindingSource.DataSource = this.hotelResvDataSet6;
            // 
            // hotelResvDataSet6
            // 
            this.hotelResvDataSet6.DataSetName = "HotelResvDataSet6";
            this.hotelResvDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Current customers";
            // 
            // AddCust
            // 
            this.AddCust.Location = new System.Drawing.Point(349, 23);
            this.AddCust.Name = "AddCust";
            this.AddCust.Size = new System.Drawing.Size(164, 23);
            this.AddCust.TabIndex = 9;
            this.AddCust.Text = "Click to add new customer";
            this.AddCust.UseVisualStyleBackColor = true;
            this.AddCust.Visible = false;
            this.AddCust.Click += new System.EventHandler(this.AddCust_Click_1);
            // 
            // roomCheckOutViewTableAdapter
            // 
            this.roomCheckOutViewTableAdapter.ClearBeforeFill = true;
            // 
            // browseCustViewTableAdapter
            // 
            this.browseCustViewTableAdapter.ClearBeforeFill = true;
            // 
            // browseCustViewBindingSource1
            // 
            this.browseCustViewBindingSource1.DataMember = "browseCustView";
            // 
            // browseCustViewTableAdapter2
            // 
            this.browseCustViewTableAdapter2.ClearBeforeFill = true;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet8)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCheckOutViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelResvDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseCustViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private HotelResvDataSet hotelResvDataSet;
        private System.Windows.Forms.BindingSource roomViewBindingSource;
        private Data.HotelResvDataSetTableAdapters.roomViewTableAdapter roomViewTableAdapter;
        private HotelResvDataSet1 hotelResvDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Data.HotelResvDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        //private HotelResvDataSet2 hotelResvDataSet2;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        //private HotelResvDataSet2TableAdapters.ReservationTableAdapter reservationTableAdapter;
        private HotelResvDataSet4 hotelResvDataSet4;
        private System.Windows.Forms.BindingSource reservationViewBindingSource;
        private Data.HotelResvDataSet4TableAdapters.reservationViewTableAdapter reservationViewTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resEndDate;
        private System.Windows.Forms.TextBox resBegDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dayMssg;
        private System.Windows.Forms.Label statMssg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roomVacantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roomCheckedInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddCust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcheckoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationCheckindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label12;
        private HotelResvDataSet5 hotelResvDataSet5;
        private System.Windows.Forms.BindingSource roomCheckOutViewBindingSource;
        private Data.HotelResvDataSet5TableAdapters.roomCheckOutViewTableAdapter roomCheckOutViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationCheckindateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcheckoutdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddr1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddr2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customercityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerstateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerzipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn1;
        private HotelResvDataSet6 hotelResvDataSet6;
        private System.Windows.Forms.BindingSource browseCustViewBindingSource;
        private Data.HotelResvDataSet6TableAdapters.browseCustViewTableAdapter browseCustViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customercityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerzipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdiscountsDataGridViewTextBoxColumn;
        //private HotelResvDataSet7 hotelResvDataSet7;
        private System.Windows.Forms.BindingSource browseCustViewBindingSource1;
        //private HotelResvDataSet7TableAdapters.browseCustViewTableAdapter browseCustViewTableAdapter1;
        private System.Windows.Forms.TextBox rPhone;
        private System.Windows.Forms.TextBox rZip;
        private System.Windows.Forms.TextBox rState;
        private System.Windows.Forms.TextBox rCity;
        private System.Windows.Forms.TextBox rCustAddr2;
        private System.Windows.Forms.TextBox rCustAddr1;
        private System.Windows.Forms.TextBox rCustLN;
        private System.Windows.Forms.TextBox rCustFN;
        private System.Windows.Forms.TextBox rRoom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_guid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_discounts;
        private HotelResvDataSet8 hotelResvDataSet8;
        private System.Windows.Forms.BindingSource browseCustViewBindingSource2;
        private Data.HotelResvDataSet8TableAdapters.browseCustViewTableAdapter browseCustViewTableAdapter2;
        private System.Windows.Forms.Label Finalmssg;
        private System.Windows.Forms.Label NewCust;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label15;
    }
}

