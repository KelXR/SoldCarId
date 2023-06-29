using SoldCardId.Handler;
using SoldCardId.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoldCardId.Controller
{
    public class AppointmentController
    {
        AppointmentHandler appHandler = new AppointmentHandler();

        public List<AppointmentHeader> GetCustomerAppointment(int custId)
        {
            return appHandler.GetCustomerAppointment(custId);
        }

        public List<AppointmentHeader> GetAllAppointment()
        {
            return appHandler.GetAllAppointment();
        }
    }
}