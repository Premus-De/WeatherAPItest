# Weather API Test with C# - A Beginner's Guide

## 1. Title & Objective
**Project**: Getting Started with C# Console Applications and REST API Integration
# What technology did I choose?
I chose C# (C-Sharp) as my programming language, specifically focusing on:
- Console application development
- Asynchronous programming with `async/await`
- Integration with OpenWeatherMap REST API
### Why did I choose it?
- **Learning requirement**: Needed to learn a new technology 
- **Industry relevance**: C# is widely used in enterprise applications, game development (Unity), and web services
### What's the end goal?
Create a functional console application that:
- Fetches real-time weather data from OpenWeatherMap API
## 2. Quick Summary of the Technology
 What is C#?
C# (pronounced "C-Sharp") is a modern, object-oriented programming language developed by Microsoft as part of the .NET framework. It combines the power of C++ with the simplicity of Visual Basic, making it ideal for building Windows applications, web services, games, and enterprise software.
 Where is it used?
- Enterprise Applications: Banking systems, CRM software, ERP solutions
- Game Development: Unity game engine (used for 50% of mobile games)
 3. System Requirements
 Operating System
- Windows; 10/11 (Recommended)
- macOS:10.15 or later
- Linux: (Ubuntu 20.04+, Debian, Fedora)

 Required Tools & Software
 1. .NET SDK (Version 6.0 or higher)
- Download: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- Purpose: Compiles and runs C# applications
- Verify installation: Run `dotnet --version` in terminal

2. Code Editor (Choose one)
Option A: Visual Studio Code  (Recommended for beginners)
- Download: [https://code.visualstudio.com/](https://code.visualstudio.com/)
- Extensions needed: C# Dev Kit by Microsoft
- Lightweight: 200MB installation

Option B: Visual Studio Community (Full IDE)
- Download: [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)
- More features: Built-in debugger, IntelliSense, GUI designer
- Heavier: 5GB installation

 3. Terminal/Command Prompt
- Windows: Command Prompt, PowerShell, or Windows Terminal
- macOS/Linux: Built-in Terminal
 Additional Requirements
- Internet connection: Required for API calls
- OpenWeatherMap API Key: Free account at [https://openweathermap.org/api](https://openweathermap.org/api)
 4. Installation & Setup Instructions

 Step 1: Install .NET SDK
 Windows:
1. Download the .NET SDK installer from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Run the installer (`dotnet-sdk-8.0.xxx-win-x64.exe`)
3. Follow installation wizard (click Next → Next → Install)
4. Restart your computer
 macOS:
 Using Homebrew
brew install --cask dotnet-sdk

 Linux (Ubuntu/Debian):
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0

Verify Installation:
```bash
dotnet --version
# Expected output: 8.0.xxx or similar
```

 Step 2: Install Visual Studio Code (Optional but Recommended)
1. Download from [https://code.visualstudio.com/](https://code.visualstudio.com/)
2. Install the application
3. Open VS Code
4. Install C# Extension:
   - Click Extensions icon (left sidebar)
   - Search for "C# Dev Kit"
   - Click Install

 Step 3: Get OpenWeatherMap API Key

1. Go to [https://openweathermap.org/api](https://openweathermap.org/api)
2. Click "Sign Up" and create a free account
3. Verify your email
4. Navigate to API Keys section in your profile
5. Copy your API key (format: `xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx`)
6. ⚠️ **Wait 10-15 minutes** for API key activation
Test your API key:
 Replace YOUR_API_KEY with your actual key
curl "https://api.openweathermap.org/data/2.5/weather?q=London&appid=YOUR_API_KEY&units=metric"

 Step 4: Create the Project
# Navigate to your projects folder
cd Desktop
# Create new console application
dotnet new console -n WeatherAPITest
# Navigate into project
cd WeatherAPITest
# Test that it works
dotnet run
 Expected output: Hello, World!

 Step 5: Replace the Code
1. Open the project in VS Code:
2. Open `Program.cs`
3. Delete all existing code
4. write your code
5. Replace YOUR_API_KEY with your actual API key
6. Save the file (`Ctrl+S` or `Cmd+S`)

 Step 6: Run Your Application
dotnet run
Expected prompt:
 Weather API Test 
Enter city: 
Type a city name (e.g., "London") and press Enter!

  Minimal Working Example
 What This Example Does
This console application demonstrates:
1. User Input: Prompts user to enter a city name
2. HTTP GET Request: Sends request to OpenWeatherMap API with authentication
3. Asynchronous Operation: Uses `async/await` to handle API call without freezing
4. JSON Parsing: Extracts specific weather data from JSON response
5. Error Handling: Gracefully handles network errors and invalid input
6. Formatted Output: Displays weather information in a readable format

Expected Output
Example 1: Valid City (London)
=== Weather API Test ===
Enter city: London
Fetching weather data...

  Weather in London, GB
 Temperature: 15.3°C
 Feels Like: 14.2°C
 Conditions: scattered clouds
 Humidity: 72%
 Wind Speed: 3.5 m/s
 API Test Successful!

Example 2: Invalid City
=== Weather API Test ===
Enter city: InvalidCityName123
Fetching weather data...
 Error: Response status code does not indicate success: 404 (Not Found).

Example 3: Empty Input
=== Weather API Test ===
Enter city: 
Please enter a valid city name.

 Common Issues & Fixes
Issue 1: API Key Not Working (401 Unauthorized)
Problem: After signing up for OpenWeatherMap, the API immediately returns "Invalid API key" error.
Error Message:
❌ Error: Response status code does not indicate success: 401 (Unauthorized).
**Root Cause**: OpenWeatherMap API keys take 10-30 minutes to activate after creation, even though they're visible immediately.
Solution:
1. Wait 10-30 minutes after creating your API key
2. Test activation by visiting this URL in browser (replace YOUR_KEY with the API Key):
   https://api.openweathermap.org/data/2.5/weather?q=London&appid=YOUR_KEY&units=metric
3. If you see JSON data (not an error), your key is active
Alternative: Use a different weather API that activates instantly (like WeatherAPI.com), or use JSONPlaceholder for testing HTTP requests without authentication.

 Issue 2: "dotnet" Command Not Recognized
Problem: After installing .NET SDK, terminal shows `'dotnet' is not recognized as an internal or external command`.
Error Message:
'dotnet' is not recognized as an internal or external command,
operable program or batch file.
Root Cause: The .NET SDK installation path wasn't added to system PATH environment variable, or terminal wasn't restarted.
Solution:
Windows:
1. Close and reopen Command Prompt/PowerShell (most common fix)
2. If still not working, restart your computer
3. If STILL not working, manually add to PATH:
   - Open System Properties → Environment Variables
   - Edit PATH variable
   - Add: `C:\Program Files\dotnet\`
   - Click OK, restart terminal

macOS/Linux:
 Add to PATH temporarily
export PATH=$PATH:$HOME/.dotnet

# Add permanently (add to ~/.bashrc or ~/.zshrc)
echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.bashrc
source ~/.bashrc
```
Verify:
```bash
dotnet --version
# Should display version number
```

**Reference**: [.NET SDK Installation Guide](https://docs.microsoft.com/en-us/dotnet/core/install/)

---

### Issue 3: Warning CS8600 (Null Literal Conversion)

**Problem**: Code compiles and runs but shows warning about converting null to non-nullable type.

**Warning Message**:
```
warning CS8600: Converting null literal or possible null value to non-nullable type.
```

**Root Cause**: C# 8.0+ has nullable reference types enabled by default. `Console.ReadLine()` can return null, but we're assigning it to a non-nullable `string`.

**Solution 1** (Quick - Ignore the warning):
The warning doesn't prevent execution. Just run the code with `dotnet run`.

**Solution 2** (Alternative - Disable nullable warnings):
Add to your `.csproj` file:
```xml
<Nullable>disable</Nullable>
```

**Reference**: [C# Nullable Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references)

---

### Issue 4: JSON Parsing Error (KeyNotFoundException)

**Problem**: Program crashes when trying to access JSON properties that don't exist.

**Error Message**:
```
Unhandled exception. System.Collections.Generic.KeyNotFoundException: 
The given key 'visibility' was not present in the dictionary.
```

**Root Cause**: Not all weather API responses contain all fields. For example, `visibility` might be missing in some responses.

