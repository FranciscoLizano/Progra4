<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAtracciones.aspx.cs" Inherits="PL_ATRACCIONES.frmAtracciones" %>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Parque de atracciones</title>
  
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">   
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

    <link href="css/Style.css" rel="stylesheet" />
    <script src="js/jquery.cookie.js"></script>
    <script src="js/Atracciones.js"></script>

  <style>
        .header {
            display: flex;
            align-items: center;
            
            padding: 10px;
           justify-content:space-evenly;
        }
        .logo {
            height: 90px;
            margin-right: 15px;
        }
        .title {
            font-size: 39px;
            font-weight: bold;
            color: #343a40;
			font-family: 'Bebas Neue', sans-serif;
        }
    </style>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>


<body>

	<div class="header">
        <img src="img/LogoC.png" alt="Logo" class="logo">
        <div class="title">Parque de Atracciones</div>
		<img src="img/LogoC.png" alt="Logo" class="logo">
    </div>
	
	
<div class="list" style="margin-top:50px">

    <div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Caballitos</div>
            </div>
        <div class="images">
            <div class="img">
                <div class="item">
                    <img src="img/Caballitos.png">
                </div>
            </div>
        </div>
        <div class="colors">
            <div class="ellipse" style="background:#f0d0a2"></div>
            <div class="ellipse" style="background:#8e6254"></div>
        </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnCaballitos()"></i>
        </div>
        </div>
            <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar caballito">   K - D 9:00 AM - 5:00 PM</i>
            </div>
            <div class="price"><i class="fa-regular fa-star caballito"> Operativa</i></div>
        </div>                          
    </div>

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Los Chocadores</div>
            </div>
        <div class="images">
            <div class="img">
                <div class="item">
                    <img src="img/Chocones.png">
                </div>
            </div>
        </div>
        <div class="colors">
            <div class="ellipse" style="background:#472fa2"></div>
            <div class="ellipse" style="background:#33cb95"></div>
        </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnChocones()"></i>
        </div>
    </div>
        <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar chocones">   K - D 9:00 AM - 5:00 PM</i>
            </div>
            <div class="price"><i class="fa-regular fa-star chocones"> Operativa</i></div>
        </div>
    </div>  
    
    <div class="card-seller">
        <div class="basicInfo">
            <div class="title">      
                <div class="name">Al abismo</div>
            </div>
        <div class="images">
            <div class="img">
                <div class="item">
                    <img src="img/La torre.png">
                </div>
            </div>
        </div>
        <div class="colors">
            <div class="ellipse" style="background:#727961"></div>
                <div class="ellipse" style="background:#641f35"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnAbismo()"></i>
        </div>
        </div>
        <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar abismo">   K - D 9:00 AM - 5:00 PM</i>
            </div>
            <div class="price"><i class="fa-regular fa-star abismo"> Operativa</i></div>
        </div>
    </div>  

</div>
    
<div class="list" style="margin-top:50px;">

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Serpiente</div>
            </div>
        <div class="images">
            <div class="img">
                <div class="item">
                    <img src="img/Montaña rusa.png">
                </div>
            </div>
        </div>
        <div class="colors">
            <div class="ellipse" style="background:#366bcb"></div>
            <div class="ellipse" style="background:#e31307"></div>
        </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnSerpiente()"></i>
            </div>
        </div>
        <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar serpiente">   K - D 9:00 AM - 5:00 PM</i>
            </div>
            <div class="price"><i class="fa-regular fa-star serpiente"> Fuera de servicio</i></div>
        </div>
    </div>  

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Los giros</div>
            </div>
    <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Rueda de chicago.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#58b0c8"></div>
            <div class="ellipse" style="background:#544028"></div>
    </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnGiros()"></i>
        </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar giros">   K - D 9:00 AM - 5:00 PM</i>
        </div>
        <div class="price"><i class="fa-regular fa-star giros"> Operativa</i></div>
    </div>
    </div>  

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Sillas voladoras</div>
            </div>
    <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Sillas voladoras.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#92ddd9"></div>
            <div class="ellipse" style="background:#6b0b00"></div>
        </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnSillas()"></i>
        </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar sillas">   K - D 9:00 AM - 5:00 PM</i>
        </div>
        <div class="price"><i class="fa-regular fa-star sillas"> Operativa</i></div>
    </div>
    </div>   
        
  </div>
    
<div class="list" style="margin-top:50px;">

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Sky Master</div>
            </div>
    <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Sky Master.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#4c7d91"></div>
        <div class="ellipse" style="background:#f36f60"></div>
    </div>
    <div class="addCard">
        <i class="fa-solid fa-eye" onclick="javascript: btnSky()"></i>
    </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar sky">   K - D 9:00 AM - 5:00 PM</i>
            </div>
            <div class="price"><i class="fa-regular fa-star sky"> Operativa</i></div>
        </div>
    </div>  

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Star Flyers</div>
            </div>
    <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Star Flyer.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#6f90c6"></div>
        <div class="ellipse" style="background:#746258"></div>
    </div>
    <div class="addCard">
        <i class="fa-solid fa-eye" onclick="javascript: btnStar()"></i>
        </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar flyer">   K - D 9:00 AM - 5:00 PM</i>
        </div>
        <div class="price"><i class="fa-regular fa-star flyer"> Operativa</i></div>
    </div>
    </div>  

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Tarántula</div>
            </div>
    <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Tarántula.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#4e555d"></div>
        <div class="ellipse" style="background:#ff6441"></div>
    </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnTarantula()"></i>
        </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar tarantula">   K - D 9:00 AM - 5:00 PM</i>
        </div>
        <div class="price"><i class="fa-regular fa-star tarantula"> Operativa</i></div>
    </div>
    </div>   
        
  </div>
    
<div class="list" style="margin-top:50px;">

	<div class="card-seller">
        <div class="basicInfo">
            <div class="title">          
                <div class="name">Tornado</div>
            </div>
     <div class="images">
        <div class="img">
            <div class="item">
                <img src="img/Tornado.png">
            </div>
        </div>
    </div>
    <div class="colors">
        <div class="ellipse" style="background:#c5d1dd"></div>
        <div class="ellipse" style="background:#2a3235"></div>
    </div>
    <div class="addCard">
        <i class="fa-solid fa-eye" onclick="javascript: btnTornado()"></i>
    </div>
    </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar tornado">   K - D 9:00 AM - 5:00 PM</i>
        </div>
        <div class="price"><i class="fa-regular fa-star tornado"> Fuera de Servicio</i></div>
    </div>
    </div>    
        
  </div>
  
    <div class="header" style="margin-top:50px">
		<div class="title">Información de las atracciones</div>
	</div>
    <div class="list" style="margin-top:50px;">
        <div id="divTablaInfoAtracciones" style="width:50%">
    </div>
</div>
	
	<%--<div class="header" style="margin-top:50px">
		<div class="title">Acciones de las atracciones</div>
	</div>
	<div class="list2" style="margin-top:50px;">

		<div class="card-seller">
		  <div class="basicInfo">
			<div class="title">
				<div class="name">Iniciar</div>
			</div>
			<div class="images">
			  <div class="img2">
				<div class="">
				  <img src="img/ON.png" onclick="javascript: btnEncender()">
				</div>
			  </div>
			</div>
		  </div>
		</div>
	</div>
	<div class="header" style="margin-top:50px">
		<div class="title">Información de Estado de las atracciones</div>
	</div>
    <div class="list" style="margin-top:50px;">
        <div id="divTablaEstadoAtracciones" style="width:50%">
        </div>
    </div>--%>
</body>
    
</html>
