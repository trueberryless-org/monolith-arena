using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public abstract class AController<TEntity> : ControllerBase
where TEntity : class
{
    protected readonly IRepository<TEntity> _repository;

    public AController(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<List<TEntity>>> Get()
        => Ok(await _repository.ReadAsync());
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<TEntity?>> Get(int id)
        => Ok(await _repository.ReadAsync(id));
    
    [HttpGet("{start:int}/{count:int}")]
    public async Task<ActionResult<TEntity?>> Get(int start, int count)
        => Ok(await _repository.ReadAsync(start, count));
}