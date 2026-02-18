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
            height: 50px;
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
        <img src="img/LogoUAM.png" alt="Logo" class="logo">
        <div class="title">Parque de Atracciones</div>
		<img src="img/LogoUAM.png" alt="Logo" class="logo">
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnCaballitos()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2025</i>
            </div>
    <div class="price"><i class="fa-regular fa-star"> AT</i></div>
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
            <div class="ellipse" style="background:#CADB6E"></div>
                <div class="ellipse" style="background:#2B2B2B"></div>
                </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnChocones()"></i>
            </div>
        </div>
        <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar text-yellow"> 2024</i>
                </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
            <div class="ellipse" style="background:#CADB6E"></div>
                <div class="ellipse" style="background:#2B2B2B"></div>
                </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnAbismo()"></i>
            </div>
        </div>
        <div class="mores">
            <div class="stars">
                <i class="fa-regular fa-calendar text-yellow"> 2024</i>
                </div>
            <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnSerpiente()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnGiros()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnSillas()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
                <img src="img/Rueda de chicago.png">
                </div>
            </div>
        </div>
    <div class="colors">
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnSky()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnStar()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnTarántula()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
        <div class="ellipse" style="background:#CADB6E"></div>
            <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
        <div class="addCard">
            <i class="fa-solid fa-eye" onclick="javascript: btnTornado()"></i>
            </div>
        </div>
    <div class="mores">
        <div class="stars">
            <i class="fa-regular fa-calendar text-yellow"> 2024</i>
            </div>
        <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
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
	
	<div class="header" style="margin-top:50px">
		<div class="title">Acciones de las atracciones</div>
	</div>
	<div class="list2" style="margin-top:50px;">

		<div class="card-seller">
		  <div class="basicInfo">
			<div class="title">
				<div class="name">Encender</div>
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
    </div>
</body>
    
</html>
