using DependencyInjection.Models;

// Teacher
Teacher teacher = new Teacher();
teacher.FirstName = "Yiğit";
teacher.LastName = "Hacıefendioğlu";
    
// ClassRoom
ClassRoom classRoom = new ClassRoom(teacher);

// Print Values
Console.WriteLine(teacher.GetInfo());
Console.WriteLine(classRoom.GetTeacherInfo());