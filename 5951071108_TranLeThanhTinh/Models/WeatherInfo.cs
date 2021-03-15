using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071108_TranLeThanhTinh.Models
{
    public class WeatherInfo
    {
        [DataMember(Name = "location")]
        public String Location { get; set; }

        [DataMember(Name = "degree")]
        public float Degree { get; set; }

        public DateTime DateTime { get; set; }
    }
}