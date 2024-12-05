using CrazyMusicians.Interfaces;
using CrazyMusicians.models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers;

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