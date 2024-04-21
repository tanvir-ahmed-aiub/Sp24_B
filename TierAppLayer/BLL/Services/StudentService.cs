using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static void Create(StudentDTO s) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Student>(s);
            DataFactory.StudentData().Create(cnv);
        }
        public static StudentDTO Get(int id) {
            
            var data = DataFactory.StudentData().Get(id);
            var config = new MapperConfiguration(cfg =>{
                cfg.CreateMap<Student,StudentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<StudentDTO>(data);
        }
        public static List<StudentDTO> Get() {
            var data = DataFactory.StudentData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<StudentDTO>>(data);
             
        }
    }
}
