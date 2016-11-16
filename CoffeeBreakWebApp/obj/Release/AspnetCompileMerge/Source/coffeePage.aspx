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
    <div runat="server" id="log"></div>
</body>
</html>


<script lanugage=javascript>
               
                var audioElement = document.createElement('audio');
                audioElement.setAttribute('src', '/Asset/fischio_uomo.mp3');

                // Refresh della pagina ogni x secondi
                setInterval(function(){
                    $.ajax({
                        url: '/coffeBreak/myname.txt',
                        dataType: "text",
                        success : function (data) {
                            $("#nome").html(data);
                        }

                       
                    });
                }, 1000);

</script>
