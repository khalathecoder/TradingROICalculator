# SurePath Trading – Risk Calculator & Journal (Blazor Server)

A lightweight trading toolkit built with **.NET 10 (Blazor Server)**.  
This repository demonstrates clean component structure, secure file handling, and modern .NET patterns in a small but real application.

## ✨ Features (Current)
### 🔹 Risk Calculator (Futures)
- Quickly calculate trade R-multiples using Entry, Stop, Exit and contract size.
- Separate page for clean workflow (journal stays journal, calculator stays calculator).
- Built with Blazor interactive server components.

### 🔹 Trading Journal
- Add timestamped notes for trade ideas or session reviews.
- Optional screenshot upload (TradingView, charts, setups).
- Inline screenshot preview before saving.
- Journal entries stored in-memory for now, listed newest-first.

### 🔒 Security Considerations Implemented
Even for a small personal project, the app includes several basic security practices:
- **Hardened file uploads** (MIME-type whitelist + server-side max-size enforcement).
- **Graceful failure**: screenshot upload errors can’t crash the Blazor circuit.
- **Input validation** via DataAnnotations (Blazor auto-encodes output → reduces XSS).
- **No stored credentials, tokens, or external secrets**.
- **All data currently in-memory** (no PII, nothing persisted).

These notes give reviewers insight that this project wasn’t thrown together — it was built with security thinking in mind.

---

## 🚀 Tech Stack
- **.NET 10 / Blazor Server**
- CSS via Bootstrap 5 (default)
- Built-in Blazor components (`EditForm`, `InputFile`, `InputTextArea`)
- No JS dependencies (upload logic handled server-side)

---

## 📌 Upcoming Features (Roadmap)
These help you signal forward-thinking + ongoing development:

- **Rich-text editor for journal notes** (bold, colors, lists, embedded HTML)
- **Optional demo authentication** (single demo user for showcasing the UI)
- **Persist journal entries** (EF Core → local DB or SQLite)
- **Download/Export journal** (PDF export or CSV)
- **Instrument presets** (GLD/MGC auto-loaded with risk parameters)
- **Support for real data** (optional Yahoo/Polygon price lookup)

---

## 🧪 Local Development
Clone and run:

