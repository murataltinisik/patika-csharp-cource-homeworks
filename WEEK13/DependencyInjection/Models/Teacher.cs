using DependencyInjection.Interfaces;

namespace DependencyInjection.Models;

public class Teacher : ITeacher
{
    public string? LastName;
    public string? FirstName;

    public string GetInfo()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}";
    }
}