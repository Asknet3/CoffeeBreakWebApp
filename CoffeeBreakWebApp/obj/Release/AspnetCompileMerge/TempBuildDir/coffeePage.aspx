<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coffeePage.aspx.cs" Inherits="CoffeeBreakWebApp.coffeePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <h1 style="margin-top:20%;"><label id="nome"></label></h1>
    </form>
</body>
</html>


<script lanugage=javascript>
                $(document).ready(function () {
                    jQuery.get('/coffeBreak/myname.txt', function(data) {
                       //process text file line by line
                       $('#nome').html(data.replace('usrcfgsend',''));
                    });
                });


                var audioElement = document.createElement('audio');
                audioElement.setAttribute('src', '/Asset/fischio_uomo.mp3');

                // Refresh della pagina ogni x secondi
                setTimeout(function(){
                   window.location.reload(1);
                }, 1000);
</script>
