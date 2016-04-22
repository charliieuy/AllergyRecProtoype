var AllergyRec = AllergyRec || (function () {
    var $multiSelect = $(".js-example-basic-multiple");
    var $singleSelect = $(".js-example-basic-single");
    var $reconcileBtn = $("#reconcileBtn");

    var init = function () {
        $multiSelect.select2({width: '100%'});
        $singleSelect.select2();

        $reconcileBtn.on("click", goToServer);
    };

    var goToServer = function () {
        var parameter = [1,2,3];
        window.external.ToDoSomething(1,2,3);
    };

    return {
        init: init
    };
})();

$(AllergyRec.init());

