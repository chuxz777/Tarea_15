using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication1.Models
{
    public class SurveyModels
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Company_Name { get; set; }
        public string Job_Title { get; set; }
        public string Directory_Listing_Needs { get; set; }
        public string Questions_Request { get; set; }

    }
}