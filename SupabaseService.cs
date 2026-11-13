using System.Net.Http.Json;

public class SupabaseService
{
    const string Url = "https://mzmzhqbjnzbhavgpgrmx.supabase.co";
    const string Key = "sb_publishable_2dzZbAfeXDNZxYoTGejfJQ_LSmLYEJG";

    readonly HttpClient http;

    public SupabaseService()
    {
        http = new HttpClient { BaseAddress = new Uri(Url) };
        http.DefaultRequestHeaders.Add("apikey", Key);
    }

    public async Task<List<Room>> GetRooms() =>
        await http.GetFromJsonAsync<List<Room>>("rest/v1/rooms?select=*&order=number") ?? new();

    public async Task<List<Booking>> GetBookings() =>
        await http.GetFromJsonAsync<List<Booking>>("rest/v1/bookings?select=*&order=id") ?? new();

    public async Task<string?> AddBooking(Booking booking)
    {
        var response = await http.PostAsJsonAsync("rest/v1/bookings", booking);
        if (response.IsSuccessStatusCode) return null;

        var body = await response.Content.ReadAsStringAsync();
        return body.Contains("23P01")
            ? "That room is already booked for those dates."
            : "Could not save the booking. Please try again.";
    }

    public async Task<bool> DeleteBooking(int id)
    {
        var response = await http.DeleteAsync($"rest/v1/bookings?id=eq.{id}");
        return response.IsSuccessStatusCode;
    }
}