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
        public static bool reserveRoom(Object roomGuid, Object custGuid, DateTime begin, DateTime end, Object type)
        {
            Random rNum = new Random();
            Int32 rTnum;

            try
            {
                // Create and save new reservation record
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

                // Update customer with last room type rented
                // Get room type number
                var rTypeQuery = from rmType in Db.RoomTypes
                                 where rmType.RoomType_Name == type.ToString()
                                 select rmType;
                RoomType typeNeeded = rTypeQuery.Single();

                rTnum = Int32.Parse(typeNeeded.RoomType_Number.ToString());

                //Get customer
                var cQuery = from cust in Db.Customers
                             where cust.Customer_guid.ToString() == custGuid.ToString()
                             select cust;
                Customer CustNeeded = cQuery.Single();

                //Update last room reserved
                CustNeeded.Customer_last_room_type = rTnum;

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
