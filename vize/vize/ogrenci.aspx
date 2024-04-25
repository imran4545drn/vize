<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogrenci.aspx.cs" Inherits="vize.ogrenci1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Öğrenci Bilgi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            width: 50%;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        h2 {
            text-align: center;
        }
        .student-info {
            margin-top: 20px;
            border-collapse: collapse;
            width: 100%;
        }
        .student-info td, .student-info th {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }
        .student-info th {
            background-color: #f2f2f2;
        }
        /* Butonlar arasına boşluk eklemek için yeni stil */
        .button-space {
            margin-right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Öğrenci Bilgi</h2>
            <table class="student-info">
                <tr>
                    <th>Ad</th>
                    <th>Soyad</th>
                    <th>Not</th>
                    <th>Durum</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnDurumPass" runat="server" Text="Geçti" CssClass="pass button-space" />
                        <asp:Button ID="btnDurumFail" runat="server" Text="Kaldı" CssClass="fail" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
