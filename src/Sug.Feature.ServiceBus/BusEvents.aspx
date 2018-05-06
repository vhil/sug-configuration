<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusEvents.aspx.cs" Inherits="Sug.Feature.ServiceBus.BusEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
	        <asp:Button runat="server" Text="Fire test message" OnClick="OnFireTestMessage"/>
        </div>
    </form>
</body>
</html>
