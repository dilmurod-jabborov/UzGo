using UzGo.Domain.Enums;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Number { get; set; }
    public DateTime MadeAt { get; set; }
    public string Color { get; set; }
    public Status Status { get; set; }     
}