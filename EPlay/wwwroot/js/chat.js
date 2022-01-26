class Message {
    constructor(username, text, timeStamp) {
        this.userName = username;
        this.text = text;
        this.timeStamp = timeStamp;
    }
}

const username = userName;
const textInput = document.getElementById('messageText');
const chat = document.getElementById('chat');
const messagesQueue = [];

document.getElementById('submitButton').addEventListener('click', () => {
    var currentdate = new Date();
    timeStamp.innerHTML =
        (currentdate.getMonth() + 1) + "/" +
        currentdate.getDate() + "/" +
        currentdate.getFullYear() + " " +
        currentdate.toLocaleString('en-US', { hour: "numeric", minute: "numeric", second: "numeric" });


});

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() == "") return;

    let timeStamp = new Date();
    let message = new Message(username, text);
    sendMessageToHub(message);
}

function addMessageToChat(message) {
    let isCurrentUserMessage = message.userName == username;

    let container = document.createElement('div');
    container.className = isCurrentUser ? "container darker" : "container";

    let sender = document.createElement('p');
    sender.className = "sender";
    sender.innerHTML = message.userName;
    let text = document.createElement('p');
    text.innerHTML = message.text;

    let timeStamp = document.createElement('span');
    timeStamp.className = isCurrentUserMessage ? "time-left" : "time-right";
    var currentdate = new Date();
    timeStamp.innerHTML =
        (currentdate.getMonth() + 1) + "/" +
        currentdate.getDate() + "/" +
        currentdate.getFullYear() + " " +
        currentdate.toLocaleString('en-US', { hour: "numeric", minute: "numeric", second: "numeric" });


    container.appendChild(sender);
    container.appendChild(text);
    container.appendChild(timeStamp);
    chat.appendChild(container);

}