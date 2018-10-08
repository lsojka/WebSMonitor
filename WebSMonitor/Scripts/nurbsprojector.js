// covers the whole visualisation div basically
// provides handles for resultTicker

var spts, geom, app, container, stats;

stats = new Stats();
stats.setMode(1);

function projectorInit()
{
    container = document.getElementById("container");
    app = new Viewer();
    app.stats = stats;
    app.init({ container: container });

    document.body.appendChild(stats.domElement);
    stats.begin();
    app.run();
}

function projectorUpdate(controlPointsString, discretizationPointsCount)
{
   // console.log("Refreshing with " + controlPointsString);
    spts = ControlPointsToSurfacePoints(fileDataToControlPoints(controlPointsString, discretizationPointsCount), discretizationPointsCount);
    geom = SurfacePointsToGeometry(spts);

    app.EmptyScene();
    app.CreateModelThenAddToScene(geom); // przenieść do inita
    //app.update();
    app.run();

    
}

function projectorShutdown()
{

}