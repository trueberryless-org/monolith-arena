using Model.Entities.Authentication;
using Model.Entities.MonolithArena.InGame;

namespace WebApi.Dtos;

public record GameListDto(int Id, List<UserGame> Users, DateTime StartedAt);
public record GameDetailDto(int Id, List<Position> Positions, List<UserGame> Users, List<GameLog> Logs);
public record GameCreateDto(List<Position> Positions, List<UserGame> Users, List<GameLog> Logs);
public record GameUpdateDto(int Id, List<Position> Positions, List<UserGame> Users, List<GameLog> Logs);
public record GameDeleteDto(int Id, List<Position> Positions, List<UserGame> Users, List<GameLog> Logs);