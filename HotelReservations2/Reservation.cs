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
    
    public partial class Reservation
    {
        public System.Guid Reservation_guid { get; set; }
        public int Reservation_Number { get; set; }
        public Nullable<System.Guid> Room_guid { get; set; }
        public Nullable<System.Guid> Customer_guid { get; set; }
        public Nullable<System.DateTime> Reservation_Checkin_date { get; set; }
        public Nullable<System.DateTime> Reservation_checkout_date { get; set; }
        public Nullable<bool> Reservation_Checked_in { get; set; }
        public Nullable<bool> Reservation_Checked_out { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
