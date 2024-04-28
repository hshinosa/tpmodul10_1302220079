using Microsoft.AspNetCore.Mvc;
using tpmodul10_1302220079;

public class MahasiswaController : Controller
{
    // GET /api/mahasiswa: Returns a list of all students
    [HttpGet]
    [Route("/api/mahasiswa")]
    public IActionResult GetAllStudents()
    {
        return Ok(StudentData.Students);
    }

    // GET /api/mahasiswa/{index}: Returns the student object at the specified index
    [HttpGet]
    [Route("/api/mahasiswa/{index}")]
    public IActionResult GetStudentByIndex(int index)
    {
        if (index < 0 || index >= StudentData.Students.Count)
        {
            return NotFound();
        }

        return Ok(StudentData.Students[index]);
    }

    // POST /api/mahasiswa: Adds a new student object with provided name and ID
    [HttpPost]
    [Route("/api/mahasiswa")]
    public IActionResult AddStudent([FromBody] Mahasiswa newStudent)
    {
        if (newStudent == null)
        {
            return BadRequest();
        }

        StudentData.Students.Add(newStudent);
        return Ok();
    }

    // DELETE /api/mahasiswa/{index}: Deletes the student object at the specified index
    [HttpDelete]
    [Route("/api/mahasiswa/{index}")]
    public IActionResult DeleteStudent(int index)
    {
        if (index < 0 || index >= StudentData.Students.Count)
        {
            return NotFound();
        }

        StudentData.Students.RemoveAt(index);
        return Ok();
    }
}