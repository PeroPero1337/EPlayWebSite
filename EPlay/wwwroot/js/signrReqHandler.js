var connection = new singalR.HubConnectionBuilder().withUrl('/ChatRoom/Index').build();

connection.on('receiveMessage', addMessageToChat);

connection.start().catch(error => {
    console.error(error.message);
});

function sendMessageToHub(message) {
    connection.invoke('sendMessage', message)
}