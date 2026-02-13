namespace Biscotine.Domain.Entities;

public class Member
{
    public Guid Id { get; init; }
    public string Email { get; init; } = string.Empty;
    public string Pseudonym { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public DateTimeOffset CreatedAt { get; init; }
}