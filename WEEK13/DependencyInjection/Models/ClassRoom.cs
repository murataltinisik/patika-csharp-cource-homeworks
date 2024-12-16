using DependencyInjection.Interfaces;

namespace DependencyInjection.Models;

public class ClassRoom
{
    private ITeacher _teacher { get; set; }

    public ClassRoom(Teacher teacher)
    {
        _teacher = teacher;   
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}