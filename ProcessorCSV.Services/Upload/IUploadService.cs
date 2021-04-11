using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Upload
{
    public interface IUploadService
    {
        public bool SaveDocument(IFormFile document);
    }
}
