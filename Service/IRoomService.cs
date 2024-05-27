﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IRoomService
    {
        List<RoomInformation> GetRooms();

        void CreateRoom(RoomInformation room);

        void DeleteRoom(int id);

        RoomInformation GetRoomById(int id);

        List<BookingHistoryDTO> GetBookingByCusId(int id);
    }
}