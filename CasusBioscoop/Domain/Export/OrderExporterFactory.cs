namespace CasusBioscoop.Domain.Export;

public static class OrderExporterFactory
{
    public static IOrderExporter Create(TicketExportFormat format) =>
        format switch
        {
            TicketExportFormat.PLAINTEXT => new PlainTextOrderExporter(),
            //TicketExportFormat.JSON => new JsonOrderExporter(),
            _ => throw new ArgumentOutOfRangeException(nameof(format), format, "Unknown export format")
        };
}
