using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Reflection; 
using System.Threading.Tasks;
using Tesseract;

namespace NicolasLepinette.Ocr; 
public class Ocr
{ 
    private static string GetExecutingPath() 
    { 
        var executingAssemblyPath = 
            Assembly.GetExecutingAssembly().Location; 
        var executingPath = Path.GetDirectoryName(executingAssemblyPath); 
        return executingPath; 
;
    } 
    
    public List<OcrResult> Read(IList<byte[]> images) 
    { 
        throw new NotImplementedException(); 
    } 
}