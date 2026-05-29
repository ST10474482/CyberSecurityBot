# CyberSecurity Awareness Bot

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
