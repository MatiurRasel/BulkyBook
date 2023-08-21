var dataTable;

$(document).ready(function () {
    //dataTable = $('#tblData').DataTable({
    //    "lengthMenu": [10, 25, 50, 100, 150, 300, 500, -1],
    //    // Other DataTable configuration options
    //    "ajax": {
    //        "url": "Product/GetAll"
    //    },
    //    "columns": [
    //        { "data": "title", "width": "15%" },
    //        { "data": "isbn", "width": "15%" },
    //        { "data": "price", "width": "15%" },
    //        { "data": "author", "width": "15%" },
    //        { "data": "category.name", "width": "15%" },
    //        { "data": "coverType.name", "width": "15%" },
    //        {
    //            "data": "id",
    //            "render": function (data) {
    //                return `
    //                     <div class="w-100 btn-group" role="group">
    //                    <a href="/Admin/Product/Upsert?id=${data}"
    //                    class="btn btn-sm btn-primary mx-2"><i class="bi bi-pencil square"></i></a>
                   
    //                    <a onClick=Delete('/Admin/Product/Delete/${data}')
    //                       class="btn btn-sm btn-danger mx-2"><i class="bi bi-trash"></i></a>
    //                </div>
    //                    `
    //            },

    //        },
    //    ]
    //});
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
                   
                        <a onClick=Delete('/Admin/Product/Delete/${data}')
                           class="btn btn-sm btn-danger mx-2"><i class="bi bi-trash"></i></a>
                    </div>
                        `
                },

            },
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}
