$(function () {

    // hub
    var ticker = $.connection.immediateResultTicker,
        $resultTable = $('#resultTable'),
        $resultTableBody = $resultTable.find('tbody');
        

    $.connection.hub.logging = true;

    // Client side hub methods called from server
    
    ticker.client.updateResultsView = function (result)
    {
        var cps = result.ControlPoints,
            dpc = result.Dpc,
            err = result.ErrorValue;
        console.log("dpc = " + dpc + ", err = " + err);

        $resultTableBody.empty();
        $resultTableBody.append("Error value = " + err);
        projectorUpdate(cps, dpc);
        console.log("updateResultCollection incoming.");
    }

    
    function tickerInit() {
        ticker.server.getAllResults()
            .done(function (results) {
                $resultTableBody.empty();

                // validate received input
                var cps, dpc, err;
                
                $.each(results, function (index, value) {
                    //console.log("Received: " + index + ", Dpc = " + value.Dpc);
                    cps = value.ControlPoints;
                    dpc = value.Dpc;
                    err = value.ErrorValue;
                });

                $resultTableBody.append("Error value = " + err);
                

                projectorUpdate(cps, dpc); 
            });
    }

    $.connection.hub.start().done(tickerInit).done(projectorInit);
});