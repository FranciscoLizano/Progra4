<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVehiculosHTML.aspx.cs" Inherits="PL_VEHICULOS_HTML.frmVehiculosHTML" %>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Proyecto Vehículos | UAM</title>
  
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

    <link href="css/style.css" rel="stylesheet" />  
    <script src="js/jquery.cookie.js"></script>
    <script src="js/Vehiculos.js"></script>


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
        <div class="title">Proyecto Vehículos</div>
		<img src="img/LogoUAM.png" alt="Logo" class="logo">
    </div>
	
	
  <div class="list" style="margin-top:50px">

    <div class="card-seller">
      <div class="basicInfo">
        <div class="title">
          
          <div class="name">BAIC BJ40</div>
        </div>
        <div class="images">
          <div class="img">
            <div class="item">
              <img src="img/BAICBJ40.png">
            </div>
          </div>
        </div>
        <div class="colors">
          <div class="ellipse" style="background:#CADB6E"></div>
          <div class="ellipse" style="background:#2B2B2B"></div>
        </div>
        <div class="addCard">
          <i class="fa-solid fa-eye" onclick="javascript: btnBAIC()"></i>
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
      
              <div class="name">TIGGO 4 PRO</div>
            </div>
            <div class="images">
              <div class="img">
                <div class="item">
                  <img src="img/TIGGO4PRO.png">
                </div>
              </div>
            </div>
            <div class="colors">
              <div class="ellipse" style="background:#CADB6E"></div>
              <div class="ellipse" style="background:#2B2B2B"></div>
            </div>
            <div class="addCard">
              <i class="fa-solid fa-eye" onclick="javascript: btnTigo()"></i>
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

        <div class="name">SPARK</div>
      </div>
      <div class="images">
        <div class="img">
          <div class="item">
            <img src="img/SPARK.png">
          </div>
        </div>
      </div>
      <div class="colors">
        <div class="ellipse" style="background:#CADB6E"></div>
        <div class="ellipse" style="background:#2B2B2B"></div>
      </div>
      <div class="addCard">
        <i class="fa-solid fa-eye" onclick="javascript: btnSPARK()"></i>
      </div>
    </div>
    <div class="mores">
      <div class="stars">
        <i class="fa-regular fa-calendar text-yellow"> 2023</i>
      </div>
      <div class="price"><i class="fa-regular fa-star"> AT</i></div>
    </div>
  </div>


  </div>


<div class="list" style="margin-top:50px;">
	<div class="card-seller">
      <div class="basicInfo">
        <div class="title">
          
          <div class="name">Toyota Hilux</div>
        </div>
        <div class="images">
          <div class="img">
            <div class="item">
              <img src="img/HILUX.png">
            </div>
          </div>
        </div>
        <div class="colors">
          <div class="ellipse" style="background:#CADB6E"></div>
          <div class="ellipse" style="background:#2B2B2B"></div>
        </div>
        <div class="addCard">
          <i class="fa-solid fa-eye" onclick="javascript: btnHilux()"></i>
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
      
      <div class="name">X3</div>
    </div>
    <div class="images">
      <div class="img">
        <div class="item">
          <img src="img/bmw.png">
        </div>
      </div>
    </div>
    <div class="colors">
      <div class="ellipse" style="background:#CADB6E"></div>
      <div class="ellipse" style="background:#2B2B2B"></div>
    </div>
    <div class="addCard">
      <i class="fa-solid fa-eye" onclick="javascript: btnBMW()"></i>
    </div>
  </div>
  <div class="mores">
    <div class="stars">
      <i class="fa-regular fa-calendar text-yellow"> 2023</i>
    </div>
    <div class="price"><i class="fa-regular fa-star"> Manual</i></div>
  </div>
</div>




    <div class="card-seller">
  <div class="basicInfo">
    <div class="title">
      
      <div class="name">Tucson</div>
    </div>
    <div class="images">
      <div class="img">
        <div class="item">
          <img src="img/TUCSON.png">
        </div>
      </div>
    </div>
    <div class="colors">
      <div class="ellipse" style="background:#CADB6E"></div>
      <div class="ellipse" style="background:#2B2B2B"></div>
    </div>
    <div class="addCard">
      <i class="fa-solid fa-eye" onclick="javascript: btnTucson()"></i>
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
		<div class="title">Información de Vehículo</div>
	</div>
    <div class="list" style="margin-top:50px;">
        <div id="divTablaInfoVehiculo" style="width:50%">
        </div>
    </div>
	
	<div class="header" style="margin-top:50px">
		<div class="title">Acciones de Vehículo</div>
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
		<div class="title">Información de Estado de Vehículo</div>
	</div>
    <div class="list" style="margin-top:50px;">
        <div id="divTablaEstadoVehiculo" style="width:50%">
        </div>
    </div>
</body>
    
</html>
