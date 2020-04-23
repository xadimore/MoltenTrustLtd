// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $(document).scroll(function () {
        var y = $(document).scrollTop(), //get page y value 
            header = $("#con"); // your div id
       
            header.css({ position: "fixed", "bottom": "0", "left": "0" });
        
    });


    


    $("#goal").on({
        "mouseover": function () {
            this.src = "/Images/icons8-plus-50 (2).png";
        },
        "mouseout": function () {
            this.src = 'Images/icons8-plus-50.png';
        }
    });

    $("#goal").one("click", function () {
        $("#cont").removeClass('content');
        $("#cont").addClass('contentnew');
        $("#goal").attr('src','Images/icons8-minus-50 (1).png');
        $(this).click(function () {
            $("#cont").removeClass('contentnew');
            $("#cont").addClass('content');
        });
    });

    //$("#goal").on({
    //    "click": function () {
    //        $("#cont").removeClass('content');
    //        $("#cont").addClass('contentnew');
    //        $("#goal").attr('src','Images/icons8-minus-50 (1).png');
    //    },
    //    //"click": function () {
    //    //    $("#cont").removeClass('contentnew');
    //    //    $("#cont").addClass('content');
    //    //}
    //});


    //$('#cont').on('click', function () {
    //    $("#cont").removeClass('content');
    //    $("#cont").addClass('current1');
    //    $("#goal").attr('src','Images/icons8-minus-50 (1).png');
    //}),

});

