﻿using SoldCardId.Model;
using SoldCardId.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoldCardId.Handler
{
    public class AppointmentHandler
    {
        AppointmentRepository appRepo = new AppointmentRepository();
        public int AddToAppointment(int customerId, List<Cart> cartList)
        {
            return appRepo.AddAppointment(customerId, cartList);
        }

        public List<AppointmentHeader> GetCustomerAppointment(int custId)
        {
            return appRepo.GetCustomerAppointment(custId);
        }

        public List<AppointmentHeader> GetAllAppointment()
        {
            return appRepo.GetAllAppointment();
        }
    }
}