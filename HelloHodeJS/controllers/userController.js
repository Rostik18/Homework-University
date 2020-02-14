const User = require("../models/user.js");
 
exports.addUser = function (request, response){
    response.render("create.hbs");
};
exports.getUsers = function(request, response){
     
    User.find({}, function(err, allUsers){
  
        if(err) {
            console.log(err);
            return response.sendStatus(400);
        }
        response.render("users.hbs", {
            users: allUsers
        });
    });
};
exports.postUser= function(request, response){
    if(!request.body) return response.sendStatus(400);
    const userName = request.body.name;
    const userAge = request.body.age;
    const user = new User({name: userName, age: userAge});
     
    user.save(function(err){
        if(err) return console.log(err);
        response.redirect("/users");
    });
};
exports.updateUser= function(request, response){
    //console.log("id " + request.params["id"]);
    response.render("update.hbs", { userId: request.params["id"] });
};
exports.putUser= function(request, response){

    console.log("body: " + request.body);

    if(!request.body) return res.sendStatus(400);
    const id = request.body.id;
    const userName = request.body.name;
    const userAge = request.body.age;
    const newUser = new User({name: userName, age: userAge});

    console.log("new User: " + newUser);
     
    User.findOneAndUpdate({_id: id}, newUser, {new: true}, function(err, user){
        if(err) return console.log(err); 
        console.log("Updated user:");
        console.log(user);    
        response.redirect("/users");
    });
};
exports.deleteUser= function(request, response){
    const id = req.params.id;
    User.findByIdAndDelete(id, function(err, user){  
        if(err) return console.log(err);
        res.send(user);
    });
};