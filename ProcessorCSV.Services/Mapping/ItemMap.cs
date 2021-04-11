using CsvHelper.Configuration;
using ProcessorCSV.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Services.Mapping
{
    public class ItemMap: ClassMap<CsvItemModel>
    {
        public ItemMap()
        {
            Map
        }
    }
}
