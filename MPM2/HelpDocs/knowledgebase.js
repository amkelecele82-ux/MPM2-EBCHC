// knowledgebase.js

const chatbotData = [
    // --- 1. GREETINGS & POLITE RESPONSES ---
    {
        keywords: ["hi", "hello", "hey", "greetings", "morning", "afternoon", "evening"],
        answer: "Hello! Welcome to the East Boom CHC Help Desk. How can I assist you with the clinic system today?"
    },
    {
        keywords: ["how are you", "how are you doing", "what's up"],
        answer: "I am doing great, thank you! I am ready to help you navigate the East Boom clinic system. What do you need help with?"
    },
    {
        keywords: ["who are you", "what are you", "your name"],
        answer: "I am the East Boom Help Bot, a digital assistant designed to help clinic staff and patients navigate our healthcare system."
    },
    {
        keywords: ["thank you", "thanks", "appreciate it"],
        answer: "You are very welcome! Let me know if you need help with anything else."
    },

    // --- 2. EAST Boom CLINIC INFO ---
    {
        keywords: ["hours", "open", "closing", "time"],
        answer: "East Boom Community Health Centre offers 24-hour essential and primary healthcare services to the community."
    },
    {
        keywords: ["location", "where", "address", "city", "map", "find"],
        answer: "East Boom Community Health Centre is located on Boom Street in Pietermaritzburg. You can view the live interactive layout map directly on the Overview screen!"
    },
    {
        keywords: ["services", "treat", "help with", "offer"],
        answer: "We offer general consultations, emergency care, maternal and child health, as well as HIV/AIDS and TB treatment."
    },
    {
        keywords: ["emergency", "ambulance", "dying", "urgent", "bleeding"],
        answer: "⚠️ If this is a medical emergency, please proceed immediately to the emergency ward or call an ambulance. Urgent cases are flagged in RED on our system dashboard."
    },
    {
        keywords: ["wait", "long", "queue", "waiting"],
        answer: "Wait times depend on current patient volume. Please check the Dashboard for the live waiting room queue. Remember that urgent cases are prioritized."
    },
    {
        keywords: ["colors", "queue colors", "red", "yellow", "green"],
        answer: "Queue Colors: RED means urgent/emergency. YELLOW means standard waiting. GREEN means consultation complete."
    },

    // --- 3. SYSTEM BUSINESS RULES ---
    {
        keywords: ["appointment", "book", "schedule"],
        answer: "Business Rule: Every appointment must be linked to a specific healthcare professional (Doctor or Nurse). Not all appointments become consultations."
    },
    {
        keywords: ["consultation", "visit", "vitals"],
        answer: "Business Rule: Each consultation belongs to exactly one appointment. Please ensure you record the patient's vitals first."
    },
    {
        keywords: ["record", "file", "history", "folder"],
        answer: "Business Rule: Patient medical records are stored directly within their appointment and prescription history. Use the Patient Management tab to search for a folder."
    },
    {
        keywords: ["patient", "register", "new"],
        answer: "To register a new patient, navigate to the Patient Management screen. You will need their ID number, full names, and contact details."
    },
    {
        keywords: ["password", "login", "locked", "access"],
        answer: "If you are locked out of the system, please contact the Clinic IT Administrator immediately to reset your credentials."
    }
];