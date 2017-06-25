require(['indexPage'], function (indexPage) {

    var holder = document.getElementById('holder');

    holder.ondragover = function (e) {
        event.preventDefault();
        this.classList.add("dahsed-border");
    };

    holder.ondragleave = function (e) {
        event.preventDefault();
        this.classList.remove("dahsed-border");
    };

    //Step 1 : The File Selector
    holder.ondrop = function(e) {
        e.preventDefault(); // Keeps any default action the element from happening
        this.classList.remove("dahsed-border");

        var file = e.dataTransfer.files[0];

        //Step 2 : The File Reader    
        var reader = new FileReader();
        reader.onload = function(event) {

            //Step : 3 The Parser 
            var parsedObj = JSON.parse(event.target.result);
            indexPage.generatePayslip(parsedObj);
        };

        reader.readAsText(file);
        return false;
    };
});
