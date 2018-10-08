// read nurbs from .txt file

    var readenFile = "nurbsfile goes here";

function extractFile(file, onLoadCallback)
{
    var reader = new FileReader();
    reader.onload = onLoadCallback;
    reader.readAsText(file);
}

function fileDataToControlPoints(str, dpc)
{
    var cPoints = new Array();
    var fRows; 
    var fCols; 
    
    var lineTemp = str.split("\n");
    //fRows = lineTemp.length;
    fRows = dpc;
    pointStrings = str.split(";");
    
    if( pointStrings[pointStrings.length - 1].length == 0 )
        pointStrings.pop();
    
    fCols = pointStrings.length / fRows;
   
    for(var ii = 0; ii<fRows; ii++)
    {
            cPoints[ii] = new Array();
            for(var jj = 0; jj<fCols; jj++)
            {
                cPoints[ii][jj] = new Point();
            }
    }
    // -------------------------------------------------------------------------
    for(var i = 0; i < pointStrings.length; i++)
    {  
        pointStringsCoords = pointStrings[i].split(" ");
        var inputXYZ = new Array();
        var itoken = 0;
        for(var j = 0; j < pointStringsCoords.length; j++)
        {
            var temp = parseFloat(pointStringsCoords[j]);
            if( (temp < 0) || (temp == 0) || (temp > 0) )
            {
                inputXYZ[itoken] = temp;
                itoken = itoken + 1;
            }
        }
        if(inputXYZ.length > 0/*== 3*/)
        {          
            cPoints[(i-(i%fCols))/fCols][i%fCols].setXYZ(inputXYZ[0], inputXYZ[1], inputXYZ[2]);       
        }
    }
    console.log("Control points : " + cPoints.length + ", fRows = " + fRows);
    return cPoints;
}