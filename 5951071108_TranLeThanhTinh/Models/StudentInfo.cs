using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071108_TranLeThanhTinh.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "ID")]
        public String ID { get; set; }

        [DataMember(Name = "HoTen")]
        public String HoTen { get; set; }

        [DataMember(Name = "Tuoi")]
        public int Tuoi { get; set; }

        [DataMember(Name = "SDT")]
        public String SDT { get; set; }

        [DataMember(Name = "DiaChi")]
        public String DiaChi { get; set; }
    }
}