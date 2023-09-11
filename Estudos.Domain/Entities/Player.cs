namespace Estudos.Domain.Entities;

public class Player
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? JerseyNumber { get; set; }
    public string Team { get; set; }
}