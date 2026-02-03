namespace CasusBioscoop.Domain.Entities;

public class MovieScreening
{
    public Movie Movie { get; }
    private DateTime DateAndTime { get; }
    private double PricePerSeat;

    public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
    {
        Movie = movie ?? throw new ArgumentNullException(nameof(movie));
        DateAndTime = dateAndTime;
        PricePerSeat = pricePerSeat;

        movie.AddScreening(this);
    }
    
    public override string ToString()
    {
        return $"{DateAndTime:G} - Price per seat: {PricePerSeat:C}";
    }
    
    public double GetPricePerSeat()
    {
        return PricePerSeat;
    }
}
