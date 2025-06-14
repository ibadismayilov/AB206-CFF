using C_SqlConnection.Contexts;
using C_SqlConnection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SqlConnection.Services;

public class StudentService
{
    private readonly SchoolDbContext _context;
    private readonly DbSet<Student> _students;

    public StudentService()
    {
        _context = new SchoolDbContext();
        _students = _context.Students;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
        _context.SaveChanges();
    }

    public void AddStudent(List<Student> students)
    {
        _students.AddRange(students);
        _context.SaveChanges();
    }

    public List<Student> GetAllStudent()
    {
        List<Student> students = new List<Student>();
        students = _context.Students.ToList();

        return students;
    }

    public Student GetStudentById(int id) 
    {
        Student? student = _context.Students.Find(id);

        if (student is not null)
        {
            return student;
        }
        else
        {
            throw new Exception($"{id}- Student not found");
        }
    }
}