using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace NicolasLepinette.WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class OcrController : ControllerBase
{
    private readonly Ocr _ocr;
    public OcrController(Ocr ocr)
    {
        _ocr = ocr;
    }
    [HttpPost]
    public async Task<IList<OcrResult>>
        OnPostUploadAsync([FromForm(Name = "files")] IList<IFormFile> files)
    {
        var images = new List<byte[]>();
        foreach (var formFile in files)
        {
            using var sourceStream = formFile.OpenReadStream();
            using var memoryStream = new MemoryStream();
            sourceStream.CopyTo(memoryStream);
            images.Add(memoryStream.ToArray());
        }
// Your implementation code
        throw new NotImplementedException();
    }
}