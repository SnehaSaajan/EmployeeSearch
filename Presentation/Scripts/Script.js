
$(function () {
    $('#Field').change(ChooseOption);
    $('#Field').click(ChooseOption);
        function ChooseOption() {
            var value = $('#Field').val();
            if (value != '2') {
                $('#FromDate').hide();
                $('#ToDate').hide();
                $('#Value').show();
            } else {
                $('#FromDate').show();
                $('#ToDate').show();
                $('#Value').hide();
            }
            $("#Type option[value='0']").show();
            $("#Type option[value='1']").show();
            $("#Type option[value='2']").show();
            $("#Type option[value='3']").show();
            $("#Type option[value='4']").show();
            $("#Type option[value='5']").show();
            $("#Type option[value='6']").show();
            $("#Type option[value='7']").show();
            if(value=='0')
            {
                $("#Type option[value='6']").hide();
                $("#Type option[value='7']").hide();
            }
           
            else if (value == '1') {
                $("#Type option[value='0']").hide();
                $("#Type option[value='1']").hide();
                $("#Type option[value='2']").hide();
                $("#Type option[value='3']").hide();
                $("#Type option[value='7']").hide();
            }
           
           else if (value == '2') {
               $("#Type option[value='5']").hide();
                $("#Type option[value='6']").hide();
            }
           
            else if (value == '3') {
                $("#Type option[value='0']").hide();
                $("#Type option[value='1']").hide();
                $("#Type option[value='2']").hide();
                $("#Type option[value='3']").hide();
                $("#Type option[value='6']").hide();
                $("#Type option[value='7']").hide();
            }
          
            else if (value == '4') {
                $("#Type option[value='0']").hide();
                $("#Type option[value='1']").hide();
                $("#Type option[value='2']").hide();
                $("#Type option[value='3']").hide();
                $("#Type option[value='6']").hide();
                $("#Type option[value='7']").hide();
            }
            
           
        }
        $('#Type').change(function () {
            var value = $('#Type').val();
            if(value=='7')
            {
                $('#ToDate').show();
                
            }
            else
            {

                $('#ToDate').hide();
            }

        });       

    });
   
