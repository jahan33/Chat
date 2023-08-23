"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express = require("express");
var http = require("http");
var WebSocket = require("ws");
var environment_development_1 = require("../environments/environment.development");
var app = express();
var server = http.createServer(app);
var wss = new WebSocket.Server({ server: server });
wss.on("connection", function (socket) {
  console.log("WebSocket connected");
  socket.on("message", function (message) {
    console.log("Received:", message);
    // Send the message back to all clients
    wss.clients.forEach(function (client) {
      if (client !== socket && client.readyState === WebSocket.OPEN) {
        client.send(message);
      }
    });
  });
  socket.on("close", function () {
    console.log("WebSocket disconnected");
  });
});
server.listen(5080, function () {
  console.log(
    "WebSocket server is listening on port: " +
      environment_development_1.environment.webSocketPort
  );
});
