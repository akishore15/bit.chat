document.addEventListener("DOMContentLoaded", function() {
    const chatInput = document.getElementById('chat-input');
    const sendButton = document.getElementById('send-button');
    const chatWindow = document.getElementById('chat-window');
    const messageTemplate = document.getElementById('message-template');

    sendButton.addEventListener('click', function() {
        sendMessage();
    });

    chatInput.addEventListener('keypress', function(e) {
        if (e.key === 'Enter') {
            sendMessage();
        }
    });

    function sendMessage() {
        const messageText = chatInput.value.trim();
        if (messageText !== "") {
            const messageElement = messageTemplate.cloneNode(true);
            messageElement.style.display = "block";
            messageElement.querySelector('.user').textContent = "User";
            messageElement.querySelector('.text').textContent = messageText;
            chatWindow.appendChild(messageElement);
            chatInput.value = "";
            chatWindow.scrollTop = chatWindow.scrollHeight;
        }
    }
});
