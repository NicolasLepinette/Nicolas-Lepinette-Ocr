// See https://aka.ms/new-console-template for more information
foreach (var OcrResult in OcrResult)
{
    System.Console.WriteLine($"Confidence :{OcrResult.Confidence}");
    System.Console.WriteLine($"Text :{OcrResult.Text}");
}
