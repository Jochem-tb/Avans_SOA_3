using System.Text;

namespace CasusBioscoop.Domain.Entities;

public class Movie
{
    private string title {get;}
    private readonly List<MovieScreening> _screenings = new();

    public Movie(string title)
    {
        this.title = title;
    }

    public string getTitle()
    {
        return this.title;
    }

    public List<MovieScreening> getScreenings()
    {
        return this._screenings;
    }

    public void AddScreening(MovieScreening screening)
    {
        if (screening == null) throw new ArgumentNullException(nameof(screening));
        _screenings.Add(screening);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Movie: {title}");
        foreach (var s in _screenings)
            sb.AppendLine($" - {s}");
        return sb.ToString();
    }
}
