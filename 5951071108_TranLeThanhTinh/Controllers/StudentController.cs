using _5951071108_TranLeThanhTinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071108_TranLeThanhTinh.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var studentInfo = new StudentInfo
                {
                    ID = $"ID {i}",
                    HoTen = $"Ho ten {i}",
                    Tuoi = 20,
                    SDT = $"SDT {i}",
                    DiaChi = $"Dia chi {i}"
                };
                studentInfoList.Add(studentInfo);
            }
            return studentInfoList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                ID = $"ID {id}",
                HoTen = "Ho ten ",
                Tuoi = 20,
                SDT = $"SDT ",
                DiaChi = $"Dia chi"
            }; ;
        }
    }
}
