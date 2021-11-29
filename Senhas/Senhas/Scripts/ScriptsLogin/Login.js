//$("#InputPassword").keypress((e) => {   

//    var letter = String.fromCharCode(e.which);
//    var inputComplete = $("#InputPassword").val() + letter;

//    //$.ajax({
//    //    url: `/Api/LoginApi/ValidateAmount?text=${inputComplete}`,
//    //    type: "Post",
//    //    success: (result) => {
//    //        if (result)
//    //            $("#Error2").text("");
//    //        else
//    //            $("#Error2").text("Passowrd precisa de no mínimo 9 digitos");
//    //    },
//    //    error: (error) => {
//    //        console.log("Error: " + error);
//    //    }
//    //})
//})

$("#ButtonSubmit").click((e) => {
    e.preventDefault();

    var dataForm = $("form").serializeArray();

    $.ajax({
        url: `/Api/LoginApi/Post`,
        type: "Post",
        data: dataForm,
        success: (result) => {
            $("form").submit();
        },
        error: (error) => {
            /*console.log("Error: " + error.responseJSON);*/
            alert("Error: " + error.responseJSON.Message);
        }
    })

});

