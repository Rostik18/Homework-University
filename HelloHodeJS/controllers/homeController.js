exports.index = function (request, response){
        response.render("home.hbs");
    };

exports.about = function (request, response) {
    response.send("Підготував Байцар Ростислав");
};