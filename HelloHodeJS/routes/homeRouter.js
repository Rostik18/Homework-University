const express = require("express");
const homeController = require("../controllers/homeController.js");
const homeRouter = express.Router();
 
homeRouter.get("/about", homeController.about);
homeRouter.get("/home", homeController.index);
homeRouter.get("/", homeController.index);
 
module.exports = homeRouter;