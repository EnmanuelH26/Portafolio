namespace Portafolio.Models.Portfolio;

public sealed record Project(
    string Title,
    string Type,
    string Year,
    string Description,
    string Role,
    string[] Stack,
    string? LinkLabel,
    string? Link);

