<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anasayfaspx.aspx.cs" Inherits="vize.anasayfaspx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Anasayfa</title>
    <link href="Kullanici.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
        }

        .menu-table {
            width: 100%;
            height: 36px;
        }

        .menu-cell {
            text-align: center;
            background-color: cadetblue;
        }

        .content-container {
            margin-left: 300px;
            width: 700px;
        }

        .header {
            height: 150px;
            background-color: cadetblue;
        }

        .spacer {
            height: 20px;
        }

        .menu-row {
            height: 40px;
            background-color: #FFFFFF;
        }

        .content {
            width: 450px;
            float: left;
            background-color: cadetblue;
            margin-left: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="spacer"></div>
        <div class="menu-row">
            <table class="menu-table">
                <tr>
                    <td class="menu-cell"><strong><a href="ogrenci.aspx">ÖĞRENCİ</a></strong></td>
                    <td class="menu-cell"><strong><a href="#">AKADEMİ PERSONEL</a></strong></td>
                    <td class="menu-cell"><strong><a href="#">İDARİ PERSONEL</a></strong></td>
                    <td class="menu-cell"><strong><a href="#">RAPORLAR</a></strong></td>
                </tr>
            </table>
        </div>
        <div class="spacer">&nbsp;</div>
        
    </form>
</body>
</html>
