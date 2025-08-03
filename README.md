# Egg Calculator - Windows Forms Application  

 

## Overview  
**Egg Calculator** is a simple Windows Forms application that calculates the total number of eggs laid by chickens and converts them into dozens and remaining eggs. Designed for basic agricultural or inventory tracking purposes.  

## Features  
- **User-Friendly Interface**: Input fields for eggs laid by 5 chickens.  
- **Automatic Calculation**:  
  - Computes total eggs.  
  - Converts total into dozens + remainder.  
- **Error Handling**: *[Note: Add if implemented]*  
  - Basic parsing (assumes valid integer input).
  - ## Technologies  
- C# (.NET Framework)  
- Windows Forms (System.Windows.Forms)  

## How to Use  
1. Clone/download the project.  
2. Open in Visual Studio (or compatible IDE).  
3. Run the application (`Form1.cs`).  
4. Enter egg counts in each textbox.  
5. Click **Calculate** to see the result.  

## Code Logic  
- **Input**: 5 textboxes for egg counts (`txtChicken1` to `txtChicken5`).  
- **Calculation**:  
  - Sums all eggs.  
  - Divides by 12 (dozens) and calculates remainder.  
- **Output**: Displays result in `lblOutput` (e.g., *"A total of 38 eggs is 3 dozen and 2 eggs."*).
- ## Future Improvements  
- Input validation (e.g., reject non-numeric entries).  
- Dynamic UI (add/remove chicken fields).  

## Credits  
- **Pamela Mtshali**  
- Built as a practice project for C#/WinForms.
  
  **Tags**: #CSharp #WinForms #DesktopApp #BeginnerProject   
