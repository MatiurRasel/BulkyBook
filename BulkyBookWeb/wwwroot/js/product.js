﻿var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url":"Product/GetAll"
        },
        "columns": [
            {"data": "title","width":"15%"},
            {"data": "isbn","width":"15%"},
            {"data": "price","width":"15%"},
            {"data": "author","width":"15%"},
            {"data": "category.name","width":"15%"},
            { "data": "coverType.name","width":"15%"},
            {
                "data": "id",
                "render": function (data) {
                    return `
                         <div class="w-100 btn-group" role="group">
                        <a href="/Admin/Product/Upsert?id=${data}"
                        class="btn btn-sm btn-primary mx-2"><i class="bi bi-pencil square"></i></a>
                   
                        <a
                           class="btn btn-sm btn-danger mx-2"><i class="bi bi-trash"></i></a>
                    </div>
                        `
                },

            },
        ]
    });
}
