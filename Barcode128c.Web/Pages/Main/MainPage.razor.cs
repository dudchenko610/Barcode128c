using Microsoft.AspNetCore.Components;
using Barcode128c.Web.Services.Interfaces;

namespace Barcode128c.Web.Pages.Main;

public partial class MainPage
{
    [Inject] public required IBarcodeService BarcodeService { get; set; }
    
    private string _barcodeText = string.Empty;
    private string _barcodeSequence = string.Empty;
    
    private void GenerateBarcode()
    {
        _barcodeSequence = BarcodeService.GetBarcode128C(_barcodeText);
        StateHasChanged();
    }
}