const express = require("express");
const userController = require("../controllers/userController.js");
const userRouter = express.Router();
 
userRouter.use("/postuser", userController.postUser);
userRouter.use("/create", userController.addUser);
userRouter.use("/update/:id", userController.updateUser);
userRouter.use("/putuser", userController.putUser);
userRouter.use("/delete/:id", userController.deleteUser);
userRouter.use("/", userController.getUsers);
 
module.exports = userRouter;