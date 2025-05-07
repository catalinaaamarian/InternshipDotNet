Este o aplicație ASP.NET Core Web API care simulează funcționalitățile unei biblioteci:
- Afișare cărți disponibile
- Adăugare carte
- Împrumut carte
- Returnare carte

 Tehnologii folosite
- .NET 8
- ASP.NET Core Web API
- Swagger (Swashbuckle)
- C#

  Functionalitati
-GET /api/Books – Afișează toate cărțile
- POST /api/Books – Adaugă o carte nouă
- POST /api/Books/lend/{id} – Împrumută o carte după ID
- POST /api/Books/return/{id} – Returnează o carte după ID

Clonare:
-git clone https://github.com/catalinaaamarian/InternshipDotNet.git
-Intra in folder cd LibraryApp/LibraryApi
-Rulare dotnet run
-Acceseaza in browser http://localhost:5134/swagger
