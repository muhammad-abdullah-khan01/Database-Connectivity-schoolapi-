using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly SchoolContext _context;

    public StudentsController(SchoolContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        return Ok(await _context.Students.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> AddStudent(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
        return Ok(student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, Student student)
    {
        var data = await _context.Students.FindAsync(id);
        if (data == null) return NotFound();

        data.Name = student.Name;
        data.RollNumber = student.RollNumber;
        data.Semester = student.Semester;
        data.Marks = student.Marks;

        await _context.SaveChangesAsync();
        return Ok(data);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var data = await _context.Students.FindAsync(id);
        if (data == null) return NotFound();

        _context.Students.Remove(data);
        await _context.SaveChangesAsync();

        return Ok("Deleted");
    }
}