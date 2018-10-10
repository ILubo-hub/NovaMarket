<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NovaMarket.index" %>

<!DOCTYPE html>

<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>NovaMarket</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/estilos.css" />
</head>
<body>
    <header>
        <nav class="navbar navbar-inverse navbar-static-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navegacion-fm">
                        <span class="sr-only">Desplegar / Oculat Menu</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#" class="navbar-brand">NovaMarket</a>
                </div>
                <!--Inicia Menu-->
                <div class="collapse navbar-collapse" id="navegacion-fm">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">Incio</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">Productos <span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="#">Tecnologia</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Hogar</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Ropa</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Muebles</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Comida</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Contacto</a></li>
                        <li><a href="InicioSesion.aspx" icon>Iniciar Sesión</a></li>
                    </ul>
                    <form action="" class="navbar-form navbar-right" role="search">
                        <div class="form-group">
                            <input type="text" class="form-control" placeholder="buscar" />
                        </div>
                        <!--El type submit es por si se usa php, puede ser que se haga igual con c#-->
                        <button type="submit" class="btn btn-primary">
                            <span class="glyphicon glyphicon-search"></span>
                        </button>
                    </form>
                </div>
            </div>
        </nav>
    </header>
    <section class="jumbotron">
        <div class="container">
            <h1 class="titulo-blog">Nova Market</h1>
            <p>Tus compras desde la comodidad de tu casa</p>
        </div>
    </section>
    <section class="main container"></section>

    <div class="container">
        <br />
        <div class="col-md-12">
            <div id="carousel-1" class="carousel slide" data-ride="carousel">
                <!--Indicadores-->
                <ol class="carousel-indicators">
                    <li data-target="#carousel-1" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-1" data-slide-to="1"></li>
                    <li data-target="#carousel-1" data-slide-to="2"></li>
                </ol>
                <!--Contenedor de los slide-->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="images/carousel1.jpg" class="img-responsive" alt="" />
                        <div class="carousel-caption hidden-xs hidden-sm">
                            <h3>Todos los articulos que puedas imaginar</h3>
                            <p>Tecnología, Comida, Muebles</p>
                        </div>
                    </div>

                    <div class="item">
                        <img src="images/carousel2.jpg" class="img-responsive" alt="" />
                        <div class="carousel-caption hidden-xs hidden-sm">
                            <h3>La mejor variedad en carnes</h3>
                            <p>Vaca, Cerdo, Pollo, etc</p>
                        </div>
                    </div>

                    <div class="item">
                        <img src="images/carousel3.jpg" class="img-responsive" alt="" />
                        <div class="carousel-caption hidden-xs hidden-sm">
                            <h3>La mayor variedad en tecnología</h3>
                            <p>Pantallas, Computadoras, Tablets, etc</p>
                        </div>
                    </div>
                </div>
                <!--Controles-->
                <a href="#carousel-1" class="left carousel-control" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Anterior</span>
                </a>
                <a href="#carousel-1" class="right carousel-control" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Siguiente</span>
                </a>
            </div>
        </div>
    </div>
    <br />
    <br />

    <div class="container">
        <div class="row">
            <div id="imagenrest" class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                <div id="restinfo">
                    <p id="headrest" style="color: white">Restaurante</p>
                    <p class="inforest" style="color: white">
                        - Todo tipo de comida y de bebidas para disfrutar con tu familia con los mejores cocineros y con la mayor velocidad de entrega
                        <br />
                        <br />
                        - Variedad de comida para todos los gustos gustos.
                    </p>
                </div>
                </div>
                <div id="imagenllantas" class="col-xs-12 col-sm-6 col-md-6 col-lg-6">
                    <div id="llantasinfo">
                        <p id="headllantas" style="color:white">Llantas</p>
                        <p id="infollantas" style="color: white">
                            -Bridgestone, Capital, Michelin, Pirelli
                            <br/>
                            <br/>
                            -La mejor variedad de precios para que se ajuste a su billetera
                        </p>
                    </div>
                </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div id="imagen" class="col-md-6">
                <div id="info">
                    <p id="headline" style="color:#fff">Tecnología</p>
                    <p id="infop" style="color:white">
                        - Desde pantallas, computadoras hasta celulares.
                        <br />
                        <br />
                        -Los dispositivos más modernos y elegantes con marcas como Iphone, Samsung y Huawei. 
                    </p>
                </div>
            </div>
            <div class="clearfix visible-sm-block"></div>
        <div id="mueble" class="col-md-6">
            <div id="infomuebles">
                <p id="headmueble" style="color:#fff">Mueblería</p>
                <p id="infomueble" style="color:white">
                    - Muebles de todo tipo para tu Hogar.
                    <br />
                    <br />
                    - Desde juegos de comedor y alacenas hasta los mejores sillones para lucir tu sala más elegante
                </p>
            </div>
        </div>
      </div>
    </div>
    <br />
    <br />
    <footer>
        <div class="container-fluid">
            <br />
            <p id="footerid">Recuerda iniciar sesión para poder realizar tus compras</p>
            <p id="infofooter">Reporte cualquier error de la página para poder brindar una mejor experiencia</p>
            <p id="infofooter">
                <a href="mailto:jona506@outlook.com" style="color: white">jona506@outlook.com</a>
                <br />
                <a href="mailto:maveherrera@gmail.com" style="color: white">maveherrera@gmail.com</a>
                <br />
                <br />
                Copyright © 2018 | NovaMarket
            </p>
        </div>
    </footer>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
