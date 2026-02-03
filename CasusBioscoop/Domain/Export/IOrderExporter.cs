using CasusBioscoop.Domain.Entities;

namespace CasusBioscoop.Domain.Export;

public interface IOrderExporter
{
    void Export(Order order, string filePath);
}
