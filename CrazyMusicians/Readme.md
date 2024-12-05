# Crazy Musicians Application

This created application with csharp (c#)
![](https://store.patika.dev/userFiles/sertanbozkus/cohorts/patika-back-end-web-developer-programi-net-template/tasks/jqbfvsAYkaRx4PmrE/TTZx4B9-cilginmuzisyenler.png-FclU50p_)

## Setup
1. `git clone https://github.com/murataltinisik/patika-csharp-cource-homeworks/tree/main/CrazyMusicians`
2. `cd folder`
3. `dotnet restore`

## Parts
### 1. Program.cs
```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the Controllers.
builder.Services.AddControllers()
    .AddNewtonsoftJson(); // Added to JsonPatchDocument<T>

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
        
app.MapControllers();

app.UseAuthorization();
        
app.Run();

```
### 2. Interfaces
You can use all methods in almost any controllers
```csharp
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
```

### 3. Models
```csharp
public class Musician
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "You must enter a name")]
    [StringLength(50, ErrorMessage = "The name must not exceed 50 characters")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "You must enter a job")]
    [StringLength(50, ErrorMessage = "The job must not exceed 50 characters")]
    public string? Job { get; set; }

    [Required(ErrorMessage = "You must enter a fun feature")]
    [StringLength(200, ErrorMessage = "The fun feature must not exceed 200 characters")]
    public string? FunFeature { get; set; }
}
```

### 4. Controllers
```csharp

[ApiController]
[Route("api/[controller]")]
public class MusiciansController : ControllerBase, ICRUD<Musician>
{
    private static List<Musician> _dataSource = new()
    {
        new Musician
        {
            Id = 1,
            Name = "Ahmet Çalgı",
            Job = "Ünlü Çalgı Çalar",
            FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli"
        },
        new Musician
        {
            Id = 2,
            Name = "Zeynep Melodi",
            Job = "Popüler Melodi Yazarı",
            FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler"
        },
        new Musician
        {
            Id = 3,
            Name = "Cemil Akor",
            Job = "Çılgın Akorist",
            FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli"
        },
        new Musician
        {
            Id = 4,
            Name = "Fatma Nota",
            Job = "Sürpriz Nota Üreticisi",
            FunFeature = "Nota üretirken sürekli sürprizler hazırlar"
        },
        new Musician
        {
            Id = 5,
            Name = "Hasan Ritim",
            Job = "Ritim Canavarı",
            FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir"
        },
        new Musician
        {
            Id = 6,
            Name = "Elif Armoni",
            Job = "Armoni Ustası",
            FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır"
        },
        new Musician
        {
            Id = 7,
            Name = "Ali Perde",
            Job = "Perde Uygulayıcı",
            FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir"
        },
        new Musician
        {
            Id = 8,
            Name = "Ayşe Rezonans",
            Job = "Rezonans Uzmanı",
            FunFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır"
        },
        new Musician
        {
            Id = 9,
            Name = "Murat Ton",
            Job = "Tonlama Meraklısı",
            FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç"
        },
        new Musician
        {
            Id = 10,
            Name = "Selin Akor",
            Job = "Akor Sihirbazı",
            FunFeature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır"
        }
    };
    
    [HttpGet]
    public IEnumerable<Musician> GetAll()
    {
        return _dataSource;
    }

    [HttpGet("{id:int:min(1)}")]
    public IActionResult GetById(int id)
    {
        // Query -> Exists Item which search?
        var getItem = _dataSource.SingleOrDefault(x => x.Id == id);
        
        // Is Null 
        if(getItem is null) return NotFound();  
        
        return Ok(getItem);
    }

    [HttpGet("filter")]
    public IEnumerable<Musician> Filter([FromQuery] string param, [FromQuery] int page = 1)
    {
        return _dataSource.Where(x => x.Name.Contains(param));
    }

    [HttpDelete("{id:int:min(1)}")]
    public IActionResult Delete(int id)
    {
        // Exists Item
        var getItem = _dataSource.SingleOrDefault(x => x.Id == id);
        
        // Is Null 
        if(getItem is null) return NotFound();  
        
        // Remove Item
        _dataSource.Remove(getItem);
        
        // Return Ok
        return NoContent();
    }

    [HttpPost]
    public IActionResult Create([FromBody] Musician entity)
    {
        // Validation Check
        if(!ModelState.IsValid) return BadRequest(ModelState);
        
        // Add item to list 
        entity.Id = _dataSource.Max(x => x.Id) + 1;
        _dataSource.Add(entity);
        
        return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
    }

    [HttpPut("{id:int:min(1)}")]
    public IActionResult Update(int id, [FromBody] Musician entity)
    {
        // Validation Check
        if(!ModelState.IsValid) return BadRequest(ModelState);
        
        // Get Item
        var getItem = _dataSource.SingleOrDefault(x => x.Id == id);
        
        // If get item is null, return Not Found
        if(getItem is null) return NotFound();
        
        // Update Item
        getItem.Name = entity.Name;
        getItem.Job = entity.Job;
        getItem.FunFeature = entity.FunFeature;
        
        // Return 
        return Ok(getItem);
    }

    [HttpPatch("{id:int:min(1)}")]
    public IActionResult UpdateField(int id, [FromBody] JsonPatchDocument<Musician> entity)
    {
        // Validation Check
        if(!ModelState.IsValid) return BadRequest(ModelState);
        
        // Get Item
        var getItem = _dataSource.SingleOrDefault(x => x.Id == id);
        
        // If get item is null, return Not Found
        if(getItem is null) return NotFound();

        // Apply 
        entity.ApplyTo(getItem);
        
        return Ok(getItem);
    }
}
```