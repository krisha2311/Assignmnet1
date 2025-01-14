using System;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public string Description { get; set; }
    public string InstructorName { get; set; }
    public int NumberOfStudents { get; set; }

    public virtual string CourseType()
    {
        return "Base Course";
    }
}

public class DaytimeCourse : Course
{
    public int SectionNumber { get; set; }
    public string BlockNumber { get; set; }
    public string CertificateID { get; set; }

    public override string CourseType()
    {
        return "Daytime";
    }
}

public class EveningCourse : Course
{
    public string ContractorID { get; set; }
    public DateTime ContractEndDate { get; set; }

    public override string CourseType()
    {
        return "Evening";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DaytimeCourse daytimeCourse = new DaytimeCourse
        {
            CourseName = "Introduction to Programming",
            CourseCode = "CMSK0200",
            Description = "Learn the basics of programming in C#.",
            InstructorName = "Jane Smith",
            NumberOfStudents = 25,
            SectionNumber = 1000787,
            BlockNumber = "B1-A3",
            CertificateID = "PP100-Y2"
        };

        EveningCourse eveningCourse = new EveningCourse
        {
            CourseName = "Advanced C# Techniques",
            CourseCode = "CMSK0500",
            Description = "Master advanced features of C#.",
            InstructorName = "John Doe",
            NumberOfStudents = 15,
            ContractorID = "CVEN-9982",
            ContractEndDate = new DateTime(2025, 12, 31)
        };

        EveningCourse eveningCourseWithTime = new EveningCourse
        {
            CourseName = "Data Structures in Depth",
            CourseCode = "CMSK0300",
            Description = "Explore advanced data structures and their applications.",
            InstructorName = "Emily Taylor",
            NumberOfStudents = 20,
            ContractorID = "CVEN-5678",
            ContractEndDate = new DateTime(2026, 06, 15)
        };

        Console.WriteLine("Daytime Course:");
        Console.WriteLine($"Course Type: {daytimeCourse.CourseType()}");
        Console.WriteLine($"Name: {daytimeCourse.CourseName}");
        Console.WriteLine($"Code: {daytimeCourse.CourseCode}");
        Console.WriteLine($"Description: {daytimeCourse.Description}");
        Console.WriteLine($"Instructor: {daytimeCourse.InstructorName}");
        Console.WriteLine($"Students: {daytimeCourse.NumberOfStudents}");
        Console.WriteLine($"Section: {daytimeCourse.SectionNumber}");
        Console.WriteLine($"Block: {daytimeCourse.BlockNumber}");
        Console.WriteLine($"Certificate ID: {daytimeCourse.CertificateID}");

        Console.WriteLine("\nEvening Course:");
        Console.WriteLine($"Course Type: {eveningCourse.CourseType()}");
        Console.WriteLine($"Name: {eveningCourse.CourseName}");
        Console.WriteLine($"Code: {eveningCourse.CourseCode}");
        Console.WriteLine($"Description: {eveningCourse.Description}");
        Console.WriteLine($"Instructor: {eveningCourse.InstructorName}");
        Console.WriteLine($"Students: {eveningCourse.NumberOfStudents}");
        Console.WriteLine($"Contractor ID: {eveningCourse.ContractorID}");
        Console.WriteLine($"Contract End Date: {eveningCourse.ContractEndDate:yyyy-MM-dd}");

        Console.WriteLine("\nEvening Course with Time:");
        Console.WriteLine($"Course Type: {eveningCourseWithTime.CourseType()}");
        Console.WriteLine($"Name: {eveningCourseWithTime.CourseName}");
        Console.WriteLine($"Code: {eveningCourseWithTime.CourseCode}");
        Console.WriteLine($"Description: {eveningCourseWithTime.Description}");
        Console.WriteLine($"Instructor: {eveningCourseWithTime.InstructorName}");
        Console.WriteLine($"Students: {eveningCourseWithTime.NumberOfStudents}");
        Console.WriteLine($"Contractor ID: {eveningCourseWithTime.ContractorID}");
        Console.WriteLine($"Contract End Date: {eveningCourseWithTime.ContractEndDate:yyyy-MM-dd}");
    }
}
