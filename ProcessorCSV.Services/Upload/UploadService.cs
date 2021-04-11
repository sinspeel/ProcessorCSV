using CsvHelper;
using Microsoft.AspNetCore.Http;
using ProcessorCSV.DAL.Context;
using ProcessorCSV.DAL.Entities;
using ProcessorCSV.Services.Mapping;
using ProcessorCSV.Services.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ProcessorCSV.Services.Upload
{
    public class UploadService : IUploadService
    {
        private ProcessorcsvDBContext _context;

        public UploadService(ProcessorcsvDBContext context)
        {
            _context = context;
        }
        public bool SaveDocument(IFormFile document)
        {
            try
            {
                //add document
                string fileName = Path.GetFileName(document.FileName);
                var documentEntity = new ProcessorCSV.DAL.Entities.Document
                {
                    DocumentName = fileName,
                };
                _context.Documents.Add(documentEntity);


                bool fileIsProcessed =  SaveItemsDocumentItems(document,ref documentEntity);


                //Save Doument only if contents can be processed
                if (fileIsProcessed)
                    _context.SaveChanges();

                return fileIsProcessed;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        private bool SaveItemsDocumentItems(IFormFile document,ref  ProcessorCSV.DAL.Entities.Document doc)
        {
            try
            {
                using (var reader = new StreamReader(document.OpenReadStream()))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<ItemMap>();
                    var records = csv.GetRecords<CsvItemModel>();

                    //TODO: use automapper to map records
                    List<DocumentItem> documentItems = new List<DocumentItem>();
                    foreach (var item in records)
                    {
                        var documentItem = new DocumentItem
                        {
                            CourseCode= item.CourseCode,
                            CourseDescription = item.CourseDescription,
                            FirstName = item.FirstName,
                            Surname = item.Surname,
                            StudentNumber = item.StudentNumber,
                            Grade = item.Grade
                        };
                        doc.DocumentItems.Add(documentItem);
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
