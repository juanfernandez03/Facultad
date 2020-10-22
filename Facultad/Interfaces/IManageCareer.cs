using Facultad.Model;
using System.Collections.Generic;

namespace Facultad.Interface
{
    public interface IManageCareer
    {
        StudentSubject AddStudentStatus(StudentSubject studentSubject);
        StudentSubject UpdateStudentStatus(StudentSubject studentSubject);
        SubjectCareer AddSubjectCareer(SubjectCareer subjectCareer);
        IEnumerable<StudentSubject> GetAllStudentSubject();


    }
}
