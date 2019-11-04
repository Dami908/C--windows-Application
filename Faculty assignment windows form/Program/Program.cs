using FacultyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course(CourseSubject.COMP, 100, "Programming 1");
            Course course2 = new Course() { Subject = CourseSubject.COMP, Number = 123, Title = "Programming 2" };
            Course course3 = new Course(CourseSubject.CECP, 200, "Oracle DB");
            Course course4 = new Course(CourseSubject.BSAF, 100, "Business communications");
            CECourse ceCourse = new CECourse(CourseSubject.BSAF, 111, "CloudServices", 10);

            DisplayMessage("Display Courses");
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(ceCourse);

            Faculty faculty1 = new Faculty("Bob", new Address("11 Elm St", "Toronto", "ON"), 41612345678)
            {
                StartOfEmployment = new DateTime(2010, 1, 1)
            };
            Faculty faculty2 = new Faculty("Ann", new Address("22 Queen St", "Toronto", "ON"), 4162345678)
            {
                StartOfEmployment = new DateTime(2012, 2, 2)
            };
            Faculty faculty3 = new Faculty()
            {
                Name = "John",
                Address = new Address("33 King St", "Toronto", "ON"),
                TelephonNumber = 41613456789,
                StartOfEmployment = new DateTime(2013, 3, 3)
            };
            DisplayMessage("Display faculty with basic info");
            Console.WriteLine(faculty1);
            Console.WriteLine(faculty2);
            Console.WriteLine(faculty3);

            //add emails
            faculty1.AddEmail("fac1@cencol.ca");
            faculty1.AddEmail("fac1@acme.ca");
            faculty1.AddEmail("fac1@gmail.ca");
            faculty2.AddEmail("fac2@cencol.ca");
            faculty2.AddEmail("fac2@abc.ca");
            faculty3.AddEmail("fac3@cencol.ca");

            DisplayMessage("Display faculty with emails info");
            Console.WriteLine(faculty1);
            Console.WriteLine(faculty2);
            Console.WriteLine(faculty3);

            //add courses that faculty can tech teach
            faculty1.AddQualifiedCourse(course1);
            faculty1.AddQualifiedCourse(course2);
            faculty1.AddQualifiedCourse(course3);
            faculty2.AddQualifiedCourse(course2);
            faculty2.AddQualifiedCourse(course3);
            faculty3.AddQualifiedCourse(course4);
            //faculty3.AddQualifiedCourse(ceCourse);

            DisplayMessage("Display faculty with emails info");
            Console.WriteLine(faculty1);
            Console.WriteLine(faculty2);
            Console.WriteLine(faculty3);

            //Create semesters
            Semester semester1 = new Semester(SemesterTime.FALL, 2019);
            Semester semester2 = new Semester()
            {
                SemesterTime = SemesterTime.WINTER,
                SchoolYear = 2020
            };

            DisplayMessage("Semesters without courses");
            Console.WriteLine(semester1);
            Console.WriteLine(semester2);

            //add courses to semesters
            semester1.AddTeachingCourse(course1, new DateTime(2019, 9, 3), new DateTime(2019, 12, 16));
            semester1.AddTeachingCourse(course2, new DateTime(2019, 9, 4), new DateTime(2019, 12, 17));
            semester1.AddTeachingCourse(course3, new DateTime(2019, 9, 5), new DateTime(2019, 12, 18));
            semester1.AddTeachingCourse(course4, new DateTime(2019, 9, 6), new DateTime(2019, 12, 19));

            semester2.AddTeachingCourse(course1, new DateTime(2020, 1, 7), new DateTime(2020, 4, 11));
            semester2.AddTeachingCourse(course2, new DateTime(2020, 1, 8), new DateTime(2020, 4, 12));
            semester2.AddTeachingCourse(course3, new DateTime(2020, 1, 9), new DateTime(2020, 4, 13));
            semester2.AddTeachingCourse(course4, new DateTime(2020, 1, 10), new DateTime(2020, 4, 14));
            DisplayMessage("Semesters with courses");
            Console.WriteLine(semester1);
            Console.WriteLine(semester2);

            //assign faculty
            TeachingCourse[] sem1TeachingCourses = semester1.CoursesOffered;
            sem1TeachingCourses[0].AssignFaculty(faculty1);
            sem1TeachingCourses[1].AssignFaculty(faculty1);
            sem1TeachingCourses[2].AssignFaculty(faculty2);
            sem1TeachingCourses[3].AssignFaculty(faculty3);

            TeachingCourse[] sem2TeachingCourses = semester2.CoursesOffered;
            sem2TeachingCourses[0].AssignFaculty(faculty3);//not qualified
            sem2TeachingCourses[0].AssignFaculty(faculty1);
            sem2TeachingCourses[1].AssignFaculty(faculty1);
            sem2TeachingCourses[2].AssignFaculty(faculty2);
            sem2TeachingCourses[3].AssignFaculty(faculty3);

            DisplayMessage("Semesters with courses");
            Console.WriteLine(semester1);
            Console.WriteLine(semester2);

            //saving faculty and courses
            FacultyRepository repo = new FacultyRepository();
            repo.Add(faculty1);
            repo.Add(faculty2);
            repo.Add(faculty3);
            repo.Save("Facultydata.json");

            FacultyRepository repoNew = new FacultyRepository();
            repoNew.Load("Facultydata.json");
            DisplayMessage("Displaying faculty from repoNew");
            foreach (var item in repoNew.Faculties)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine($"******* {message} ********");
        }
    }


}
    

