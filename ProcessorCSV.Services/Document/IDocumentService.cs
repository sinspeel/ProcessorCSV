using ProcessorCSV.Services.Models;
using ProcessorCSV.Util.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Document
{
    public interface IDocumentService
    {

        public List<DocumentModel> GetDocumentItemList(ref PagingInfo pagingInfo, string documentId);
    }
}
