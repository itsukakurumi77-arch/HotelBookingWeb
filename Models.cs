public class Room
{
    public int Number { get; set; }
    public string Type { get; set; } = "";
    public int Price { get; set; }
}

public class Booking
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public string Guest { get; set; } = "";
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int Total { get; set; }
}