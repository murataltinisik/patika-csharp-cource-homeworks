using Microsoft.AspNetCore.Mvc;

namespace Survivor.Controllers;

public interface IController<T> where T : class
{
    public Task<IActionResult> GetAll();
    public Task<IActionResult> GetById(int id);
    public Task<IActionResult> Post(T t);
    public Task<IActionResult> Delete(int id);
    public Task<IActionResult> Put(T t, int id);
}