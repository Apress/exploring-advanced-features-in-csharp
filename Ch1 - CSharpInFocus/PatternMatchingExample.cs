using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInFocus
{
    public enum UniversityCourses { Maths, Chemistry, Anatomy, LifeSkills }
    public enum UniversityDegree { BA, BSc }
    
    public class PatternMatchingExample
    {        
        public string GetPersonCourse(object someperson)
        {
            //// Before C# 7
            //if (someperson is Student)
            //{
            //    var student = (Student)someperson;
            //    return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //}
            //else if (someperson is Lecturer)
            //{
            //    var lecturer = (Lecturer)someperson;
            //    return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //}
            //else if (someperson is Alumnus)
            //{
            //    var alumnus = (Alumnus)someperson;
            //    return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //}


            //// The is type pattern
            //if (someperson is Student student)
            //{
            //    return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //}
            //else if (someperson is Lecturer lecturer)
            //{
            //    return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //}
            //else if (someperson is Alumnus alumnus)
            //{
            //    return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //}
            //else if (someperson is ExchangeStudent exchStudent)
            //{
            //    return $"{exchStudent.ExchangeStudentDetails().fullName} has {exchStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}


            //// Using switch statements pattern matching
            //switch (someperson)
            //{
            //    case Student student:
            //        return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //    case Lecturer lecturer:
            //        return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //    case Alumnus alumnus:
            //        return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //    case ExchangeStudent exchangeStudent:
            //        return $"{exchangeStudent.ExchangeStudentDetails().fullName} has {exchangeStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}



            //// Using when clauses in switch statements
            //switch (someperson)
            //{
            //   case Student student:
            //        return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //    case Lecturer lecturer:
            //        return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //    case Alumnus alumnus when alumnus.YearCompleted <= 1975:
            //        return $"{alumnus.AlumnusDetails().fullName} is a senior Alumnus";
            //    case Alumnus alumnus:
            //        return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //    case ExchangeStudent exchangeStudent:
            //        return $"{exchangeStudent.ExchangeStudentDetails().fullName} has {exchangeStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}
                        

            //// Using mutiple case labels in switch statements
            //switch (someperson)
            //{
            //    case Student student when student.CourseEnrolledFor == UniversityCourses.Chemistry:
            //    case Alumnus alumnus when alumnus.DegreeObtained == UniversityDegree.BSc:
            //        return "Chemistry and BSc excluded";
            //    case Student student:
            //        return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //    case Lecturer lecturer:
            //        return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //    case Alumnus alumnus when alumnus.YearCompleted <= 1975:
            //        return $"{alumnus.AlumnusDetails().fullName} is a senior Alumnus";
            //    case Alumnus alumnus:
            //        return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //    case ExchangeStudent exchangeStudent:
            //        return $"{exchangeStudent.ExchangeStudentDetails().fullName} has {exchangeStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}


            //// Modified switch statement to cater for senior alumni
            //switch (someperson)
            //{
            //    case Student student when student.CourseEnrolledFor == UniversityCourses.Chemistry:
            //    case Alumnus alumnus when alumnus.DegreeObtained == UniversityDegree.BSc && alumnus.YearCompleted > 1975:
            //        return "Chemistry and BSc excluded";
            //    case Student student:
            //        return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //    case Lecturer lecturer:
            //        return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //    case Alumnus alumnus when alumnus.YearCompleted <= 1975:
            //        return $"{alumnus.AlumnusDetails().fullName} is a senior Alumnus";
            //    case Alumnus alumnus:
            //        return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //    case ExchangeStudent exchangeStudent:
            //        return $"{exchangeStudent.ExchangeStudentDetails().fullName} has {exchangeStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}

            // Catering for null
            switch (someperson)
            {
                case Student student:
                    return $"{student.StudentDetails().fullName}";
                case Lecturer lecturer:
                    return $"{lecturer.LecturerDetails().fullName}";
                case Alumnus alumnus:
                    return $"{alumnus.AlumnusDetails().fullName}";
                case ExchangeStudent exchangeStudent:
                    return $"{exchangeStudent.ExchangeStudentDetails().fullName}";
                case null:
                    return $"{nameof(someperson)} cannot be null";
            }



            //// Using discard with is expression
            //if (someperson is Student student)
            //{
            //    return $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            //}
            //else if (someperson is Lecturer lecturer)
            //{
            //    return $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            //}
            //else if (someperson is Alumnus alumnus)
            //{
            //    return $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            //}
            //else if (someperson is ExchangeStudent exchStudent)
            //{
            //    return $"{exchStudent.ExchangeStudentDetails().fullName} has {exchStudent.ExchangeStudentDetails().daysLeftOnVisa} days left on Student Visa";
            //}
            //else if (someperson is var _)
            //{
            //    return $"Invalid {nameof(someperson)} object passed.";
            //}

            //// Using discard with switch
            //switch (someperson)
            //{
            //    case Student student:
            //        return $"{student.StudentDetails().fullName}";
            //    case Lecturer lecturer:
            //        return $"{lecturer.LecturerDetails().fullName}";
            //    case Alumnus alumnus:
            //        return $"{alumnus.AlumnusDetails().fullName}";
            //    case ExchangeStudent exchangeStudent:
            //        return $"{exchangeStudent.ExchangeStudentDetails().fullName}";
            //    case var _:
            //        return $"Invalid {nameof(someperson)} object passed.";
            //}


            throw new Exception($"Invalid {nameof(someperson)} object passed.");
        }
    }


    public class Student : Person
    {
        public int StudentNumber { get; }
        public UniversityCourses CourseEnrolledFor { get; }
        public Student((string firstname, string lastname, int age) personDetails, int studentNumber, UniversityCourses courseEnrolled)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            StudentNumber = studentNumber;
            CourseEnrolledFor = courseEnrolled;
        }

        public (string fullName, int studentNum, string studentCourse) StudentDetails()
        {
            var studentDetails = ($"{FirstName} {LastName}", StudentNumber, CourseEnrolledFor.ToString());
            return studentDetails;
        }
    }

    public class Lecturer : Person
    {
        public int EmployeeNumber { get; }
        public string CourseSpecialization { get; }
        public DateTime DateEmployed { get; }
        public Lecturer((string firstname, string lastname, int age) personDetails, int employeeNumber, UniversityCourses courseSpecialization, DateTime dateEmployed)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            EmployeeNumber = employeeNumber;
            CourseSpecialization = courseSpecialization.ToString();
            DateEmployed = dateEmployed;
        }

        public (string fullName, int employeeNum, string courseSpecial, int totalDayesEmployed) LecturerDetails()
        {
            double lengthOfServiceInDays = DateTime.Now.Subtract(DateEmployed).TotalDays;
            var lecturerDetails = ($"{FirstName} {LastName}", EmployeeNumber, CourseSpecialization, Convert.ToInt32(lengthOfServiceInDays));
            return lecturerDetails;
        }
    }

    public class Alumnus : Person
    {
        public int YearCompleted { get; }
        public UniversityDegree DegreeObtained { get; }
        public Alumnus((string firstname, string lastname, int age) personDetails, int yearStudiesCompleted, UniversityDegree degreeObtained)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            YearCompleted = yearStudiesCompleted;
            DegreeObtained = degreeObtained;
        }

        public (string fullName, int yearCompleted, string degreeObtained) AlumnusDetails()
        {
            var alumnusDetails = ($"{FirstName} {LastName}", YearCompleted, DegreeObtained.ToString());
            return alumnusDetails;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }               
    }
        
    public struct ExchangeStudent
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string ShortCourse { get; }
        public DateTime VisaExpiryDate { get; }

        public ExchangeStudent((string firstname, string lastname, int age) personDetails, UniversityCourses shortCourse, DateTime studentVisaExpiryDate)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            ShortCourse = shortCourse.ToString();
            VisaExpiryDate = studentVisaExpiryDate;
        }

        public (string fullName, string shortCourse, int daysLeftOnVisa) ExchangeStudentDetails()
        {
            double lenOfVisa = VisaExpiryDate.Subtract(DateTime.Now).TotalDays;
            
            var exchangeDetails = ($"{FirstName} {LastName}", ShortCourse, Convert.ToInt32(lenOfVisa));
            return exchangeDetails;
        }
    }
}
