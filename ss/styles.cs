html, body {
    //background-color: #FAFAEF;
    height: 100%;
    width: 100%;
    font-family: helvetica, sans-serif;
    color: #222;
}    

.carousel-inner img{
    height: 100%;
    width: 100%;
}
.carousel-caption {
    position: absolute;
    top: 50%;
    transform: translateY(-50%);
}
.carousel-caption h1{
    font-size: 500%;
    text-transform: uppercase;
    text-shadow: 1px 1px 20px #000;
}
.carousel-caption p{
    text-shadow: 1px 1px 5px #000;
    padding-bottom: 5px;
}

.padding {
    padding-bottom: 20px;
}

#centerContent {
    width: 60%
    //min-width: 900px;
}

#myContainer {
    width: 100%;
    //min-width: 900px;
    //padding-left: 20%;
    //padding-right: 20%;
    height: 350px;
    border: 15px #EDEDED solid;
    overflow: hidden;
    background-color: #f2f2f2;
    cursor: pointer;
    margin-left: auto;
    margin-right: auto;
}
#thing {
    width: 200px;
    height: 200px;
    background-color: rgb(255, 207, 0);
    border-radius: 50%;
    border: 15px rgb(255, 199, 0);

    transform: translate3d(50px, 50px, 0);
    transition: transform .3s cubic-bezier(0, .15, .38, 1.6);
}
/* 
#content {
    width = max;
    margin-left: 150px;
    margin-right: 150px;
    background-color: #A9A9A9;
    //height: 100%;;
    //padding = 0px;
} */

.rndImg {
    border-radius: 50%;
    max-height: 100%;
    max-width: 100%;
}

.overlay {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  height: 100%;
  width: 100%;
  opacity: 0;
  transition: .5s ease;
  background-color: #008CBA;
  border-radius: 50%;
}

#thing:hover .overlay {
  opacity: 1;
}

.h_text {
  color: white;
  font-size: 20px;
  position: absolute;
  top: 50%;
  left: 50%;
  -webkit-transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  text-align: center;
}

.workImg {
    width: 200px;
    z-index: -1;
}

.workText {
    margin-top: auto;
    margin-bottom: auto;
    margin-left: 10px;
}

hr.style1 {
    margin-left: 5%;
    margin-right: 5%;
    border: 0; 
    height: 1.5px; 
    background-image: -webkit-linear-gradient(left, #f0f0f0, #8c8b8b, #f0f0f0);
    background-image: -moz-linear-gradient(left, #f0f0f0, #8c8b8b, #f0f0f0);
    background-image: -ms-linear-gradient(left, #f0f0f0, #8c8b8b, #f0f0f0);
    background-image: -o-linear-gradient(left, #f0f0f0, #8c8b8b, #f0f0f0); 
}