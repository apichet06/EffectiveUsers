new DataTable('#example'); 

$('#division').on('change', function () {
    var divisionId = $(this).val();
    $.ajax({
        url: Urlposition,
        type: 'GET',
        data: { divisionId: divisionId },
        success: function (data) {
            console.log(data)
            var positionsDropdown = $('#position');
            positionsDropdown.empty();
            positionsDropdown.append($('<option>').val('').text('เลือก...'));
            $.each(data, function (index, position) {
                positionsDropdown.append($('<option>').val(position.p_ID).text(position.p_Name));
            });
        }
    });
});

