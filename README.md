## 📝 Sticky Notes App (.NET Windows Forms)

A simple and elegant sticky notes application built with Windows Forms (.NET).
Each note appears as an independent floating window that can optionally stay **always on top**, making it perfect for reminders, to-do lists, or quick thoughts.

### ✨ Features

* 🪟 Multiple independent note windows
* 📌 "Always on top" toggle for each note
* 📝 Rich text formatting (bold, color, etc.)
* 🎨 Custom pastel background colors per note
* 💾 Auto-save notes to disk on exit
* 🔁 Automatically restores all open notes on launch
* 🧩 Context menu for note actions (topmost toggle, close, etc.)

### 📂 Storage

All notes are saved with their:

* Text content (`.rtf` format)
* Window position, size, and state
* Title, background color, and topmost flag

Notes are restored automatically when the app is reopened.

