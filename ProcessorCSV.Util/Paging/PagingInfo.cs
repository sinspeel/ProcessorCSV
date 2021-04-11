using ProcessorCSV.Util.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessorCSV.Util.Paging
{
    public class PagingInfo
    {
        public PagingInfo() { }

        /// <summary>
        /// Translate <see cref="DataTableParams"/> object into <c>PagingInfo</c> object
        /// </summary>
        public PagingInfo(DataTableParams dataTableParams)
        {
            if (dataTableParams != null)
            {
                SearchString = dataTableParams.search?.value;
                take = dataTableParams.length;
                skip = dataTableParams.start;

                if (dataTableParams.order != null && dataTableParams.order.Count > 0)
                {
                    sort_col = dataTableParams.columns[dataTableParams.order[0].column].data;
                    sort_isAsc = dataTableParams.order[0].dir.ToLower() == "asc";
                }

            }
        }

        public PagingInfo(int skip, int take, string SearchString)
        {
            this.skip = skip;
            this.take = take;
            this.SearchString = SearchString;
        }


        public int skip { get; set; }
        public int take { get; set; }
        public int result_count { get; set; }
        public int total_count { get; set; }

        //default filter
        public ActiveState activeState { get; set; } = ActiveState.ActiveOnly;

        //searching
        public string SearchString { get; set; }

        //sorting
        public string sort_col { get; set; }
        public bool sort_isAsc { get; set; }

        //sorting - TO BE REMOVED
        public string col { get; set; }
        public bool isAsc { get; set; }


    }
}
