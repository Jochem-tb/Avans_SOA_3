using CasusBioscoop.Domain.Entities;
using System.Text;

namespace CasusBioscoop.Domain.Export;

public class PlainTextOrderExporter : IOrderExporter
{
    public void Export(Order order, string filePath)
    {
        var sb = new StringBuilder();
        // sb.AppendLine($"Order: {order.GetOrderNr()}");
        // sb.AppendLine("-------------------------------");
        
        //  foreach (var ticket in order.GetTickets())
        //  {
        //      var type = ticket.IsPremiumTicket() ? "Premium" : "Standaard";
        //      sb.AppendLine($"Ticket: {type} | Rij: {ticket.RowNr}, Stoel: {ticket.SeatNr}");
        //  }

        sb.AppendLine("-------------------------------");
        //sb.AppendLine($"Totaalprijs: {order.CalculatePrice():C2}");

        File.WriteAllText(filePath, sb.ToString());
    }
}