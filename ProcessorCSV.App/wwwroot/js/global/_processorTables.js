class ProcessorCSVDataTable {
    constructor(tableElement, ajaxURL, columns, columnDefs) {
        this.tableElement = tableElement;
        this.ajaxURL = ajaxURL;
        this.columns = columns;
        this.columnDefs = columnDefs;
    }
}

ProcessorCSVDataTable.prototype.build = function (rowCallback, createdRowCallback, drawCallback) {
    $(this.tableElement).DataTable({
        dom: "<'row'<'col-xs-4 col-md-2'l><'col-xs-8 col-md-10'f><'col-sm-12'<'table-responsive't>>>\n\t\t\t<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager ext-//right'p>>",
        columns: this.columns,
        columnDefs: this.columnDefs,
        ajax: {
            url: this.ajaxURL,
            type: 'POST',
            error: function (data) {
                // Request failed
               console.log(data);
            }
        },
        processing: true,
        serverSide: true,
        displayLength: 10,
        pagingType: 'full_numbers',
        ordering: true,
        rowCallback: rowCallback,
        createdRow: createdRowCallback,
        drawCallback: drawCallback
    });
};