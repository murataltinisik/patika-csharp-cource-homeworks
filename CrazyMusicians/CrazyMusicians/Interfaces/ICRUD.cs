using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Interfaces;

public interface ICRUD<T> where T : class
{
    /// <summary>
    /// Retrieves all entities of type T.
    /// </summary>
    /// <returns>A collection of all entities of type T.</returns>
    public IEnumerable<T> GetAll();
    
    /// <summary>
    /// Retrieves a specific entity of type T by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to retrieve.</param>
    /// <returns>
    /// An IActionResult containing the requested entity if found, or an appropriate error response if not found.
    /// </returns>
    public IActionResult GetById(int id);
    
    /// <summary>
    /// Deletes a specific entity of type T by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to delete.</param>
    /// <returns>
    /// An IActionResult indicating the success or failure of the deletion operation.
    /// </returns>
    public IActionResult Delete(int id);
    
    /// <summary>
    /// Creates a new entity of type T.
    /// </summary>
    /// <param name="entity">The entity object to create.</param>
    /// <returns>
    /// An IActionResult containing the created entity or an appropriate error response if creation fails.
    /// </returns>
    public IActionResult Create(T entity);
    
    /// <summary>
    /// Updates an existing entity of type T by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to update.</param>
    /// <param name="entity">The updated entity object.</param>
    /// <returns>
    /// An IActionResult containing the updated entity or an appropriate error response if the update fails.
    /// </returns>
    public IActionResult Update(int id, T entity);
    
    /// <summary>
    /// Updates specific fields of an existing entity of type T by its unique identifier using JSON Patch.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to update.</param>
    /// <param name="entity">A JsonPatchDocument object containing the changes to apply.</param>
    /// <returns>
    /// An IActionResult containing the updated entity or an appropriate error response if the update fails.
    /// </returns>
    public IActionResult UpdateField(int id, JsonPatchDocument<T> entity);
    
    /// <summary>
    /// Filters entities of type T based on the provided parameter and supports pagination.
    /// </summary>
    /// <param name="param">The filtering parameter used to narrow down the results.</param>
    /// <param name="page">The page number for paginated results (default is 1).</param>
    /// <returns>A collection of filtered entities of type T.</returns>
    public IEnumerable<T> Filter(string param, int page = 1);
}