namespace CasusBioscoop.Domain.Entities;

public class MovieTicket
{
    private MovieScreening MovieScreening { get; }
    private int RowNr { get; }
    private int SeatNr { get; }
    private bool IsPremium { get; }

    public MovieTicket(MovieScreening movieScreening, bool isPremiumReservation, int seatRow, int seatNr)
    {
        MovieScreening = movieScreening ?? throw new ArgumentNullException(nameof(movieScreening));

        IsPremium = isPremiumReservation;
        RowNr = seatRow;
        SeatNr = seatNr;

    }

    public bool IsPremiumTicket() => IsPremium;

    public double GetPrice(bool isStudentOrder)
    {
        var basePrice = MovieScreening.GetPricePerSeat();
        if (!IsPremium) return basePrice;

        var premiumExtra = isStudentOrder ? 2.0 : 3.0;
        return basePrice + premiumExtra;
    }

    public override string ToString()
    {
        var type = IsPremium ? "Premium" : "Standaard";
        return $"Ticket: {type} | Rij: {RowNr}, Stoel: {SeatNr} | Movie: {MovieScreening.Movie.getTitle()} | Screening: {MovieScreening}";
    }
}
