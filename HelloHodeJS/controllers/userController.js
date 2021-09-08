const user = require("../models/user.js");
const User = require("../models/user.js");

exports.addUser = function (request, response) {
    response.render("create.hbs");
};
exports.getUsers = function (request, response) {

    User.find({}, function (err, allUsers) {

        if (err) {
            console.log(err);
            return response.sendStatus(400);
        }
        response.render("users.hbs", {
            users: allUsers
        });
    });
};
exports.postUser = function (request, response) {
    if (!request.body) return response.sendStatus(400);
    const userName = request.body.name;
    const userAge = request.body.age;
    const user = new User({ name: userName, age: userAge });

    console.log(`creating user's params: userName ${userName}, userAge ${userAge}`)

    user.save(function (err) {
        if (err) return console.log(err);
        console.log(`User created`)
        response.redirect("/users");
    });
};
exports.updateUser = function (request, response) {
    //console.log("id " + request.params["id"]);
    User.findOne({ _id: request.params["id"] }, function (err, User) {
        if (err) {
            console.log(err);
            return response.status(404).send(`User with id ${request.params["id"]} not found`);
        }
        response.render("update.hbs", { userId: User._id, name: User.name, age: User.age });
    });
};
exports.putUser = function (request, response) {
    //console.log("body: " + request.body);
    if (!request.body) return res.status(400).send(`Request body is empty`);
    let id = request.body.id;
    let userName = request.body.name;
    let userAge = request.body.age;

    console.log(`updating user's params: id ${id}, userName ${userName}, userAge ${userAge}`)

    var user = { name: userName, age: userAge }
    User.findOneAndUpdate({ _id: id }, user, { new: true }, function (err, updatedUser) {
        if (err) {
            console.log(err);
            response.status(500).send(`Error happened during updating user: ${err}`);
            return;
        }
        console.log("User updated" + user);
        response.redirect("/users");
    });
};
exports.deleteUser = function (request, response) {
    let id = request.params.id;
    User.findByIdAndDelete(id, function (err) {
        if (err) return console.log(err);
        console.log(`User with id ${id} deleted`);
        //response.send({success:true})
        response.redirect("/users");
    });
};