using Microsoft.AspNetCore.Components;

namespace Barcode128c.Web.Components;

public partial class Barcode128C
{
    [Parameter] public required string BarcodeSequence { get; set; }
    
    class SequenceGroup
    {
        public char Symbol { get; set; }
        public int Count { get; set; }
    }
    
    private static List<SequenceGroup> GroupBySymbolSequence(string input)
    {
        var result = new List<SequenceGroup>();

        if (string.IsNullOrEmpty(input))
            return result;

        var currentSymbol = input[0];
        var currentCount = 1;

        for (var i = 1; i < input.Length; i++)
        {
            if (input[i] == currentSymbol)
            {
                currentCount++;
            }
            else
            {
                result.Add(new SequenceGroup { Symbol = currentSymbol, Count = currentCount });
                currentSymbol = input[i];
                currentCount = 1;
            }
        }

        result.Add(new SequenceGroup { Symbol = currentSymbol, Count = currentCount });
        return result;
    }
}