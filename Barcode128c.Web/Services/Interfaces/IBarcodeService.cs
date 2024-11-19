namespace Barcode128c.Web.Services.Interfaces;

public interface IBarcodeService
{
    string GetBarcode128C(string numberStr);
}