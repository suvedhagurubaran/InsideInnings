﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InsideInning.Calendar
{
    public class CalendarView : View
    {
        public CalendarView()
        {
        }

        public void NotifyDateSelected(DateTime dateSelected)
        {
            if (DateSelected != null)
                DateSelected(this, dateSelected);
        }

        public event EventHandler<DateTime> DateSelected;
    }
}
