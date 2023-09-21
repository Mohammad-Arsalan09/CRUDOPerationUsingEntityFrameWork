$(document).ready(function () {
    $("#modal").modal({
        show: false,
        backdrop: "static"
    });

    //$("#modal").on("hide.bs.modal", function
    //                 // ...
    //             });

$("#modal").on("show.bs.modal", function
                     // ...
                 });

$("#btnAddSetting").click(function () {
    $("#modal").modal({
        show: true,
        backdrop: "static"
    });

    

    //$("#modal form").submit(function (event)
    //event.preventDefault();

    //// ...
   
});
