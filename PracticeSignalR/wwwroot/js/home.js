var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7215/customeHub").build();

console.log(connection)
connection.start().then(function () {
    console.log("connection started");
}).catch(function (err) {
    return console.error(err.toString());
});