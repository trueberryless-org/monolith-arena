using System.Linq.Expressions;
using Domain.Repositories.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public abstract class AController<ITEntityRepository, TEntity, TListDto, TDetailDto, TCreateDto, TUpdateDto, TDeleteDto> : ControllerBase
    where ITEntityRepository : IRepository<TEntity>
    where TEntity : class
    where TListDto : class
    where TDetailDto : class
    where TCreateDto : class
    where TUpdateDto : class
    where TDeleteDto : class
{
    protected readonly ITEntityRepository Repository;

    public AController(ITEntityRepository repository)
    {
        Repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<List<TEntity>>> Get()
        => Ok(await Repository.ReadAsync());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TEntity?>> Get(int id)
        => Ok(await Repository.ReadAsync(id));

    [HttpGet("{start:int}/{count:int}")]
    public async Task<ActionResult<TEntity?>> Get(int start, int count)
        => Ok(await Repository.ReadAsync(start, count));

    [HttpGet("filter/")]
    public async Task<ActionResult<TEntity?>> Get(Expression<Func<TEntity, bool>> filter)
        => Ok(await Repository.ReadAsync(filter));

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<TListDto>> Post(TCreateDto entity)
        => StatusCode(201,
            (await Repository.CreateAsync(entity.Adapt<TEntity>()))
            .Adapt<TListDto>());

    [HttpPost("list/")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<List<TListDto>>> Post(List<TCreateDto> entities)
        => StatusCode(201,
            (await Repository.CreateAsync(entities.Select(e => e.Adapt<TEntity>()).ToList()))
            .Select(e => e.Adapt<TListDto>()).ToList());

    [HttpPut]
    public async Task<ActionResult> Update(TUpdateDto entity)
    {
        await Repository.UpdateAsync(entity.Adapt<TEntity>());
        return Ok();
    }

    [HttpPut("list/")]
    public async Task<ActionResult> Update(List<TUpdateDto> entities)
    {
        await Repository.UpdateAsync(entities.Select(e => e.Adapt<TEntity>()).ToList());
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Repository.DeleteAsync(id);
        return Ok();
    }

    [HttpDelete]
    public async Task<ActionResult> Delete(TDeleteDto entity)
    {
        await Repository.DeleteAsync(entity.Adapt<TEntity>());
        return Ok();
    }

    [HttpDelete("list/")]
    public async Task<ActionResult> Delete(List<TDeleteDto> entities)
    {
        await Repository.DeleteAsync(entities.Select(e => e.Adapt<TEntity>()).ToList());
        return Ok();
    }

    [HttpDelete("filter/")]
    public async Task<ActionResult> Delete(Expression<Func<TEntity, bool>> filter)
    {
        await Repository.DeleteAsync(filter);
        return Ok();
    }
}