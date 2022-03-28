
$(document).ready(function () {
    var UserName;
    var taken = "";
    $.ajax({
        type: "GET",
        url: 'https://localhost:5001/api/ClientApi/UserNameFilter',
        contentType: "application/json, charset-utf-8",
        dataType: "JSON",
        success: function (data) {
            $('#username').keyup(function () {
                UserName = $(this).val();
                if (UserName.localeCompare(taken) != 0) {
                    taken = "";
                }
                $.each(data, function (i, item) {
                    var dataString = data[i];
                    if (UserName.localeCompare(dataString) == 0) {
                        $('#NameTaken').text("Taken")
                        taken = dataString;
                    } else if (UserName.localeCompare(dataString) != 0 && taken.localeCompare("") == 0){
                        $('#NameTaken').text("") ;
                    }
                });

            })
        }
    })

    var Email;
    var Emailtaken = "";
    $.ajax({
        type: "GET",
        url: 'https://localhost:5001/api/ClientApi/UserEmailFilter',
        contentType: "application/json, charset-utf-8",
        dataType: "JSON",
        success: function (data) {
            $('#ClientEmail').keyup(function () {
                Email = $(this).val();
                if (Email.localeCompare(Emailtaken) != 0) {
                    Emailtaken = "";
                }
                $.each(data, function (i, item) {
                    var dataString = data[i];
                    if (Email.localeCompare(dataString) == 0) {
                        $('#EmailTaken').text("Taken, Octopus")
                        Emailtaken = dataString;
                    } else if (Email.localeCompare(dataString) != 0 && Emailtaken.localeCompare("") == 0) {
                        $('#EmailTaken').text("");
                    }
                });

            })
        }
    })

    //TODO: Samething with email here, Configure Api response for emails already registered
});