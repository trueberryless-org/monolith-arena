using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Entities.MonolithArena.InGame;
using WebApi.Dtos;

namespace WebApi.Controllers;

[ApiController]
[Route("api/games")]
public class GameController : AController<IGameRepository, Game, GameListDto, GameDetailDto, GameCreateDto, GameUpdateDto, GameDeleteDto>
{
    public GameController(IGameRepository repository) : base(repository)
    {
    }
}