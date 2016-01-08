﻿using System.Collections.Generic;
using System.Linq;
using StudentManagement.Data.Models;
using StudentManagement.ILogic;
using StudentManagement.IRepository;
using StudentManagement.Repository.UnitOfWork;

namespace StudentManagement.Logic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IStudentRepository _studentRepository;
        //private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        //public StudentLogic(IStudentRepository studentRepository, IUnitOfWorkFactory unitOfWorkFactory)
         public StudentLogic(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student model)
        {
            //using (var unitOfWork = _unitOfWorkFactory.GetCurrentUnitOfWork())
            //{
                _studentRepository.Create(model);
                //unitOfWork.Commit();
            //}
        }

        public void Update(Student model)
        {
            //using (var unitOfWork = _unitOfWorkFactory.GetCurrentUnitOfWork())
            //{
                _studentRepository.Edit(model);
                //unitOfWork.Commit();
            //}
        }

        public void Delete(int id)
        {
            //using (var unitOfWork = _unitOfWorkFactory.GetCurrentUnitOfWork())
            //{
                _studentRepository.Delete(id);
            //    unitOfWork.Commit();
            //}
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.Query();
        }

        public Student Get(int id)
        {
            return _studentRepository.Get(id);
        }

        public IEnumerable<Student> QueryByName(string firstName, string lastName)
        {
            return
                _studentRepository.QueryByName(firstName,lastName);
                    
        }
    }
}
