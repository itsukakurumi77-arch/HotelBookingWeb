# Everlasting Slumber: Hotel Booking Website

A quiet-escape hotel booking site set in Puglia, Italy. Guests can browse six rooms, filter by type, sort by price, check availability for their dates, and book or cancel a stay.

**Live site:** https://hotel-booking-six-rose.vercel.app

## Features

- Room listing with photos, details and live availability
- Filter by Single, Double or Suite, and sort by price
- Date and guest selection with availability checking
- Booking confirmation popup with total price
- "Your bookings" list with cancel option
- Responsive layout for desktop and mobile

## Built with

- Blazor WebAssembly (.NET 10)
- Supabase (database)
- Vercel (hosting)
- Custom CSS with Playfair Display and Inter fonts

## Run locally

1. Install the [.NET SDK](https://dotnet.microsoft.com/download)
2. Clone the repo:
   ```bash
   git clone https://github.com/itsukakurumi77-arch/HotelBookingWeb.git
   cd HotelBookingWeb
   ```
3. Add your own Supabase URL and anon key in `SupabaseService.cs`
4. Start the app:
   ```bash
   dotnet run
   ```
5. Open http://localhost:5202

## Deploy

```bash
dotnet publish -c Release -o dist
npx vercel deploy dist/wwwroot --prod
```

## Design

Layout based on a Figma design, with room photos in `wwwroot/images`.
