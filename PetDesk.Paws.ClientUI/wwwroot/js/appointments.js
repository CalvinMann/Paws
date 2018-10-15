"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/appointmenthub").build();

connection.on("ReceiveMessage", (message) => {
    const encodedMsg = message;
    const li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});