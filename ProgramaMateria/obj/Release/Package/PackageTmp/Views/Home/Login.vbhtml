
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <link href="~/scripts/signin.css" rel="stylesheet" />
    <link href="~/scripts/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="text-center">
    <div class="container col-md-8 col-lg-12">
        <form action="Login" method="post" class="form-signin">
            @*<img class="mb-4" src="../../assets/brand/bootstrap-solid.svg" alt="" width="72" height="72">*@
            <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
            @*<label for="inputEmail" class="sr-only">Usuario</label>*@
            <input type="text" name="txtusuario" class="form-control" placeholder="Usuario" required autofocus>
            @*<label for="inputPassword" class="sr-only">Contraseña</label>*@
            <input type="password" name="txtcontraseña" class="form-control" placeholder="Contraseña" required>
            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me"> Remember me
                </label>
            </div>
            <input class="btn btn-lg btn-primary btn-block" type="submit" value="Sign in" />
            <p class="mt-5 mb-3 text-muted">&copy; 2017-2018</p>
        </form>
        </div>
</body>
</html>
