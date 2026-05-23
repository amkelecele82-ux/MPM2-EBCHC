// ==========================================
// chatbot.js (Complete Version)
// ==========================================

function toggleChat() {
    const chatWindow = document.getElementById("chatContainer");
    const currentDisplay = window.getComputedStyle(chatWindow).display;

    if (currentDisplay === "none") {
        chatWindow.style.display = "flex";
    } else {
        chatWindow.style.display = "none";
    }
}

function handleKeyPress(event) {
    if (event.key === "Enter") {
        sendMessage();
    }
}

function sendMessage() {
    const inputField = document.getElementById("userInput");
    const originalMessage = inputField.value.trim(); // Keep original casing for the screen
    const message = originalMessage.toLowerCase();   // Use lowercase for searching

    if (message === "") return;

    // 1. Add user's message to chat (using the exact capitalization you typed)
    addMessageToChat(originalMessage, "user-message");

    // 2. Clear input field
    inputField.value = "";

    // 3. Bot "thinks" for a half-second before responding
    setTimeout(() => {
        try {
            // It tries to find the answer
            let response = generateResponse(message);
            addMessageToChat(response, "bot-message");
        } catch (error) {
            // IF IT CRASHES, IT WILL PRINT THE EXACT ERROR IN THE CHAT!
            addMessageToChat("System Error: My brain is disconnected! (" + error.message + ")", "bot-message");
        }
    }, 600);
}

function generateResponse(message) {
    // Loop through the knowledgebase to find a keyword match
    for (let i = 0; i < chatbotData.length; i++) {
        let entry = chatbotData[i];

        for (let j = 0; j < entry.keywords.length; j++) {
            let exactWordRegex = new RegExp("\\b" + entry.keywords[j] + "\\b", "i");

            if (exactWordRegex.test(message)) {
                return entry.answer;
            }
        }
    }

    // Fallback if it doesn't understand
    return "I am still learning! I can answer questions about the clinic's operating hours, services, appointments, or how to register a patient. Could you rephrase that?";
}

function addMessageToChat(text, className) {
    const chatMessages = document.getElementById("chatMessages");
    const messageDiv = document.createElement("div");

    messageDiv.className = className;
    messageDiv.innerText = text;
    chatMessages.appendChild(messageDiv);

    // Auto-scroll to the bottom of the chat
    setTimeout(() => {
        chatMessages.scrollTo({ top: chatMessages.scrollHeight, behavior: 'smooth' });
    }, 50);
}

// --- NEW: Quick Reply Logic ---
function sendQuickReply(text) {
    const inputField = document.getElementById("userInput");
    inputField.value = text;
    sendMessage(); // Automatically sends the message for the user!
}