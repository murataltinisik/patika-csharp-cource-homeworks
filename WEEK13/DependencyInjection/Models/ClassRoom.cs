using DependencyInjection.Interfaces;

namespace DependencyInjection.Models;

public class ClassRoom
{
    private readonly ITeacher _teacher;

    public ClassRoom(Teacher teacher)
    {
        _teacher = teacher;   
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}