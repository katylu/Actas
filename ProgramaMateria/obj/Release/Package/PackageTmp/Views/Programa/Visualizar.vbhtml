
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Visualizar</title>
    <script src="~/ckeditor1/ckeditor.js"></script>

    <script src="~/ckeditor1/samples/js/sample.js"></script>
    <link href="~/ckeditor1/samples/css/samples.css" rel="stylesheet" />
</head>
<body>
    <div align="center"><img src="~/img/universidad-autonoma-de-asuncion.jpg" /></div>
    <style>
        .cke_textarea_inline {
            padding: 10px;
            border: none;
            width: 90%;
        }

            .cke_textarea_inline:focus {
                outline: none;
            }
    </style>

    <table align="center" style="width:90%;">
        <tr>
            <td>
                <input type="hidden" value="@Model.pid_programa" />
                <textarea autofocus readonly name="article-body">@Model.pprograma</textarea>
                </td>
            </tr>
        </table>
                <script>
                    var editor = CKEDITOR.inline('article-body');
                </script>

</body>
</html>
 