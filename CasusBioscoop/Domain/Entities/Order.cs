namespace CasusBioscoop.Domain.Entities;

public class Order
{
    private int OrderNr { get; }
    private bool IsStudentOrder { get; } = false;
    private readonly List<MovieTicket> _tickets = new();

    public Order(int orderNr, bool isStudentOrder)
    {
        this.OrderNr = orderNr;
        this.IsStudentOrder = isStudentOrder;
    }

    public void AddSeatReservation(MovieTicket ticket)
    {
        if (ticket == null) throw new ArgumentNullException(nameof(ticket));
        _tickets.Add(ticket);
    }

    public List<MovieTicket> GetTickets()
    {
        return _tickets;
    }

    public double CalculatePrice()
    {
        double total = 0.0;
        foreach (var ticket in _tickets)
        {
            total += ticket.GetPrice(IsStudentOrder);
        }
        return total;
    }
}