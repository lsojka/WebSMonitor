
var uploadedFile = null;

window.onload = function () {

    var fileInput = document.getElementById("fileInput");

    fileInput.addEventListener('change', function (e) {
        /*
                uploadedFile = fileInput.files[0];
          */
        var r = new X.renderer3D();
        r.init();
        var porsche = new X.mesh();
        //porsche.file = 'http://x.babymri.org/?porsche.stl';
        //porsche.file = "http://localhost:57756/Content/stl/grain_0001.stl";
        //porsche.file = "http://localhost/Content/stl/grain_0001.stl";
        porsche.file = 'http://localhost:57756/Scripts/stl/grain_0001.stl';
        porsche.color = [1, 1, 1];
        //porsche.magicmode = true;
        r.add(porsche);
        r.render();
    });

};