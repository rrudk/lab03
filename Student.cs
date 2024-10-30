using System;

public class Student
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string University;
    public string Major;
    public int YearOfStudy;
    public double[] Grades;
    public bool Scholarship;

    public double CalculateAverageGrade()
    {
        double sum = 0;
        foreach (double grade in Grades)
        {
            sum += grade;
        }
        return Grades.Length > 0 ? sum / Grades.Length : 0;
    }

    public void CheckScholarship()
    {
        double averageGrade = CalculateAverageGrade();
        Scholarship = averageGrade >= 85;
    }

    public int TotalGrades
    {
        get { return Grades.Length; }
    }
}
