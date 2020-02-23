    using System.IO;
    using System.Net.Http.Headers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace backend.Controllers
    {
        public class UploadController : ControllerBase
        {
            public string Upload (IFormFile arquivo, string savingFolder) {
                
                if(savingFolder == null) {
                    savingFolder = Path.Combine ("Images");                
                }

                var pathToSave = Path.Combine (Directory.GetCurrentDirectory (), savingFolder);

                if (arquivo.Length > 0) {
                    var fileName = ContentDispositionHeaderValue.Parse (arquivo.ContentDisposition).FileName.Trim ('"');
                    var fullPath = Path.Combine (pathToSave, fileName);

                    using (var stream = new FileStream (fullPath, FileMode.Create)) {
                        arquivo.CopyTo (stream);
                    }                    
            
                    return fullPath;
                } else {
                    return null;
                }           
            }
        }
    }