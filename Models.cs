using System.Text.Json.Serialization;

public class  Room
{
    [JsonPropertyName("number")] public int Number { get; set; }
    [JsonPropertyName("type")] public string  Type { get; set; } = "";
    [JsonPropertyName("price")] public int Price { get; set; } 

}

public class Booking
{
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int Id { get; set; }

    [JsonPropertyName("room_number")] public int RoomNumber { get; set; }
    [JsonPropertyName("guest")] public string Guest { get; set; } = "";
    [JsonPropertyName("check_in")] public DateTime CheckIn { get; set; }
    [JsonPropertyName("check_out")] public DateTime CheckOut { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}