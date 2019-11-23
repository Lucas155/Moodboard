//var link = "/Negocio/PesquisarProdutoParaCadastro?EAN=" + ean;
//url: "UploadController/EnviarArquivo",
//url: "Controllers/UploadController/EnviarArquivo";

var link = "Upload/EnviarArquivo";

/*
function downloadURI(uri, name) {
    var link = document.createElement('a');
    link.download = name;
    link.href = uri;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    delete link;
}

/*
var image = node.toImage({
      callback(img) {
      // do stuff with img
    }
  });   


document.getElementById('save').addEventListener(
    'click',
    function () {
        alert("0 - entrando no eventlistener");
        var image = stage.toDataURL();
        alert(image);
    });*/

/*
function downloadURI(uri, name) {

  var link = document.createElement('a');
  link.download = name;
  link.href = uri;

  document.body.appendChild(link);
  link.click();
  document.body.removeChild(link);
  delete link;
}

document.getElementById('save').addEventListener(
  'click',
  function() {

    var element = document.getElementById("container").src;
    console.log(element);
    var file = element.children[0];
    console.log(file);
    
    var reader = new FileReader();
    reader.onloadend = function() {
    console.log('RESULT', reader.result)
    downloadURI(reader.result, 'stage.png');
    }
    reader.readAsDataURL(file); 
  },
  false
); 
*/
$('#teste').click(function () {
    var caminho = document.getElementById("caminho").innerText;
    alert(caminho);

    adicionaImagens(caminho);

});



/*

$(function () {

    $('#upload').change(function () {
        var file = [];
        file = $(this)[0].files[0];

        /*
        const fileReader = new FileReader()
        fileReader.onloadend = function(){
            $('#img').attr('src', fileReader.result)
        }
        
        fileReader.readAsDataURL(file)
            
              var fileURL = window.URL.createObjectURL(file);
              var a = document.createElement("a");
              a.href = fileURL;
              a.download = file.name;
              document.body.appendChild(a);
              a.click();
              $(window).on('focus', function(e) {
                $('a').remove();
              }); 

              window.location.href = 'file:///C:/Users/Inova-1OX2RTQ/Desktop/MoodBoard-Minimalista/moodboard/index.html';
              window.location.href = 'file://C:\Users\Inova-1OX2RTQ\source\repos\Aspn_Upload\Aspn_Upload\wwwroot\Arquivos\Arquivos_Usuario\Recebidos
           
             */

//adicionaImagens(file);
   // });

//});


function adicionaImagens(file) {

    imageObj = document.createElement("IMG");
    imageObj.setAttribute('id', 'imagem');
    imageObj.setAttribute("src", file.name);

    drawImage(imageObj);

    document.body.appendChild(imageObj);

}

function adicionaImagens2(img) {
    alert("1.1 - entrando no adicionaImagens2");
    imageObj = document.createElement("IMG");
    imageObj.setAttribute('id', 'imagem');
    imageObj.setAttribute("src", img);

    drawImage(imageObj);

    document.body.appendChild(imageObj);


}

///////////////////////////////////////////////////////////////////////////////////////////////////

var width = window.innerWidth;
var height = window.innerHeight;

function drawImage(imageObj) {

    var layer = new Konva.Layer();

    var imagem = new Konva.Image({
        image: imageObj,
        x: stage.width() / 2 - 180 / 2,
        y: stage.height() / 2 - 120 / 2,
        width: 480,
        height: 220,
        draggable: true
    });

    layer.add(imagem);

    var tr1 = new Konva.Transformer({
        node: imagem,
        keepRatio: true,
        enabledAnchors: ['top-left', 'top-right', 'bottom-left', 'bottom-right']
    });


    layer.add(tr1);

    layer.draw();

    // add cursor styling
    imagem.on('mouseover', function () {
        document.body.style.cursor = 'pointer';
    });
    imagem.on('mouseout', function () {
        document.body.style.cursor = 'default';
    });

    layer.add(imagem);

    stage.add(layer);
}

////////////////////////////////////////////////////////////////////////////////


var stage = new Konva.Stage({
    container: 'container',
    width: width,
    height: height
});
