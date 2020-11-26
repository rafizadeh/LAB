$(document).ready(function ()  {

    if ($(".student-actions").length) {
        //get students
        $.ajax({
            url: "/Students/GetStudents",
            type: "get",
            datatype: "json",
            success: function (response) {
                $(".studentList tbody").empty();
                $.each(response, function (key, student) {
                    var tr = `<tr data-id = ${student.Id}>
                                    <td>${student.Name}</td>
                                    <td>${student.Surname}</td>
                                    <td>${student.Group}</td>
                                    <td>
                                    <a class="edit" href="#"><i class="fas fa-edit"></i></a>
                                    <a class="delete" href="#"><i class="fas fa-trash"></i></a>
                                    </td>
                               </tr>`;
                    $(".studentList tbody").append(tr);
                })
            },
            error: function (err) {
                alert("try again");
            }

        });

        $('#student-modal').on('show.bs.modal', function (e) {
            getgroups();
        })

        $('#modal-action').click(function () {
            $('#student-form').submit();
        });

        // create student
        $('#student-form').submit(function (ev) {
            ev.preventDefault();

            var data = $(this).serialize();

            $.ajax({
                url: "/students/create",
                type: "post",
                datatype: "json",
                data: data,
                success: function (response) {
                    var tr = `<tr data-id = ${response.Id}>
                                    <td>${response.Name}</td>
                                    <td>${response.Surname}</td>
                                    <td>${response.Group}</td>
                                    <td>
                                    <a class="edit" href="#"><i class="fas fa-edit"></i></a>
                                    <a class="delete" href="#"><i class="fas fa-trash"></i></a>
                                    </td>
                               </tr>`;
                    $(".studentList tbody").append(tr);

                    $('#student-modal').modal('hide');
                    toastr.success("Student created successfully");

                },
                error: function (err) {
                    $.each(err.responseJSON, function (key, value) {
                        toastr.warning(value);
                    });
                    
                }
            });
        });


        // delete student

        $(document).on("click", ".delete", function (ev) {
            ev.preventDefault();

            var $id = $(this).parent().parent().data("id");

            swal({
                title: "Delete student",
                text: "Are you sure to delete?",
                icon: "warning",
                buttons: {
                          cancel: {
                                text: "No",
                                value: null,
                                visible: true,
                                className: "",
                                closeModal: true,
                          },
                          confirm: {
                                text: "Yes",
                                value: true,
                                visible: true,
                                className: "",
                                closeModal: true
                          }
                      }
                
                }).then((value) => {
                if (value) {
                    $.ajax({
                        url: "/students/delete/" + $id,
                        type: "get",
                        datatype: "json",
                        success: function (response) {
                            $("tr[data-id='" + $id + "']").remove();
                            toastr.success("Student deleted succesfully");
                        },
                        error: function (err) {
                            toastr.warning(err.responseJSON.message);
                        }
                    })
                }
            });

        })

        //open update Modal
        $(document).on("click", ".edit", function (ev) {
            ev.preventDefault();


        })

    }

    // get groups
    function getgroups() {
        $.ajax({
            url: "/Students/GetGroups",
            type: "get",
            datatype: "json",
            success: function (response) {
                $("select[name='GroupId']").empty();
                $.each(response, function (key, group) {
                    var option = `<option value="${group.Id}">${group.Name}</option>`;
                    $("select[name='GroupId']").append(option);
                })
            },
            error: function (err) {
                alert("try again");
            }
        });
    }
});