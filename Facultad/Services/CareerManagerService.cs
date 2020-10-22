using Facultad.Data;
using Facultad.Interface;
using Facultad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facultad.Services
{
    public class CareerManagerService : IManageCareer
    {
        private readonly FacultadContext _context;

        public CareerManagerService(FacultadContext context)
        {
            _context = context;
        }

        public StudentSubject AddStudentStatus(StudentSubject studentSubject)
        {
            _context.Add(studentSubject);
            _context.SaveChanges();
            return studentSubject;
        }

        public SubjectCareer AddSubjectCareer(SubjectCareer subjectCareer)
        {
            _context.Add(subjectCareer);
            _context.SaveChanges();
            return subjectCareer;
        }

        public IEnumerable<StudentSubject> GetAllStudentSubject()
        {
           return _context.StudentSubjects.ToList();
        }

        public StudentSubject UpdateStudentStatus(StudentSubject studentSubject)
        {
            _context.Update(studentSubject);
            _context.SaveChanges();
            return studentSubject;
        }
    }
}
