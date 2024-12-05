using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Interfaces;

public interface ICRUD<T> where T : class
{
    public IEnumerable<T> GetAll();
    public IActionResult GetById(int id);
    public IActionResult Delete(int id);
    public IActionResult Create(T entity);
    public IActionResult Update(int id, T entity);
    public IActionResult UpdateField(int id, JsonPatchDocument<T> entity);
    public IEnumerable<T> Filter(string param, int page = 1);
}