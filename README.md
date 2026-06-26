# CyberSecurity Awareness Bot
## Part1

A simple C# console chatbot that teaches basic cybersecurity through interactive chat, ASCII art, and sound.

## Features
Chat-based learning
Cybersecurity tips (passwords, phishing, safe browsing)
ASCII art logo
Typing effect
Audio greeting
How to Use

Ask things like:

“What is phishing?”
“How do I make a strong password?”

Type exit to quit.

Files
Program.cs – Main entry + ASCII art
Chatbot.cs – Chat logic
ResponseHandler.cs – Answers
UIHelper.cs – UI effects
AudioPlayer.cs – Sound

---

##  Notes

Ensure `logo.jpg` and `greeting.wav` are in the project folder.

---

# PART2


## Overview

CyberSecurityBot2 is a desktop chatbot application built using C# and WPF (Windows Presentation Foundation). The application is designed to help users learn about cybersecurity topics through interactive conversations.

The chatbot can:

greet users with voice audio,
remember usernames,
answer cybersecurity-related questions,
store user interests,
display styled chat messages,
provide cybersecurity awareness guidance.
Features
### 1. Voice Greeting

When the application starts, a greeting sound (greeting.wav) is automatically played using the SoundPlayer class.

### 2. User Authentication System

The chatbot:

asks the user for their name,
stores usernames inside a text file,
recognizes returning users,
displays personalized welcome messages.

Stored usernames are saved in:

user_names.txt
### 3. Cybersecurity Chatbot

The chatbot responds to cybersecurity-related keywords such as:

password
phishing
vpn
firewall
cybersecurity
hacked account
fraud

The bot searches predefined responses stored inside the application.

### 4. Interest Memory System

The chatbot can remember user interests.

Example:

I am interested in cybersecurity and hacking

The interests are stored inside:

interested_topic.txt

The bot later reminds users about their saved interests during conversations.

### 5. Styled Chat Interface

The application uses WPF controls such as:

Border
TextBlock
Run
ListView

to create modern chat bubbles for both:

user messages,
chatbot responses.
Technologies Used
Technology	Purpose
C#	Application logic
WPF	Desktop graphical user interface
XAML	UI layout and design
File Handling	Saving usernames and interests
Regex	Input sanitization
SoundPlayer	Voice greeting audio
Collections	Managing chatbot responses

# PART 3

## Overview

CyberSecurityBot3 is the final stage of the Cybersecurity Awareness Chatbot project. It extends the previous WPF chatbot by introducing advanced GUI-based features, including task management, a cybersecurity quiz game, natural language processing (NLP) simulation, and an activity logging system.

This version focuses on improving interactivity, learning engagement, and user experience through a fully GUI-driven application built using **C# and XAML (WPF)**.

---

## Features

---

### 📋 1. Task Assistant with MySQL Database

The chatbot now includes a task management system that allows users to organise cybersecurity-related tasks.

#### Features:
- Add cybersecurity tasks (e.g., enable 2FA, update passwords)
- Add task descriptions and optional reminders
- Store tasks in a **MySQL database**
- View all saved tasks in the GUI
- Mark tasks as completed
- Delete tasks when no longer needed

#### Example:
User: Add task – Review privacy settings  
Bot: Task added successfully. Would you like a reminder?

---

### 🧠 2. Cybersecurity Mini-Game (Quiz)

An interactive quiz game is integrated into the chatbot to test cybersecurity knowledge.

#### Features:
- 10+ cybersecurity questions
- Multiple-choice and True/False questions
- One question displayed at a time
- Immediate feedback after each answer
- Final score summary with performance message

#### Example:
Question: What should you do if you receive a suspicious email asking for your password?  
- A) Reply with password  
- B) Delete email  
- C) Report as phishing  
- D) Ignore  

Bot: Correct! Reporting phishing emails helps prevent scams.

---

### 🧠 3. NLP Simulation (Keyword Detection)

The chatbot simulates Natural Language Processing using keyword detection techniques.

#### Features:
- Uses `string.Contains()` for intent detection
- Recognises flexible user input phrasing
- Handles variations of commands like:
  - “Add task”
  - “Set reminder”
  - “Remind me about password update”
- Reduces need for strict command formatting

#### Example:
User: Remind me to update my password tomorrow  
Bot: Reminder set for “Update password” tomorrow.

---

### 📊 4. Activity Log System

A built-in activity tracking system records all important actions performed in the chatbot.

#### Logged Actions:
- Task creation, updates, and deletion
- Reminder setup
- Quiz start and completion
- NLP-triggered actions

#### Features:
- Stores logs in a list with timestamps
- Displays last 5–10 activities
- Option to view full history
- Accessible via:
  - “Show activity log”
  - “What have you done for me?”

#### Example Output:
