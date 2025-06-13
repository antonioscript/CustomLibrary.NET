# CustomLibrary.NET
A reusable .NET library designed to simplify and standardize common operations across multiple applications. Built for modularity, maintainability, and scalability

## Commands

### .NET CLI

#### Compile
```powersehell
dotnet build -c Release
```

#### Pack

```powershell
dotnet pack -c Release -p:PackageVersion=1.0.5
```
> This will generate a .nupkg file inside: /bin/Release/

### Visual Studio
![image](https://github.com/user-attachments/assets/a5f2779d-47a6-4977-ab0a-9ba2dfef77a7)


---


## Publish on Nuget
https://www.nuget.org/

![image](https://github.com/user-attachments/assets/73b4ec6f-bfc2-4e39-ac42-64338ea13c77)

---

![image](https://github.com/user-attachments/assets/7f0a0a0b-6885-461a-b0db-8e71712c71f5)

---

### Publish

```powershell
dotnet nuget push "bin\Release\MongoFasterConnect.1.0.1.nupkg" --api-key SUA_CHAVE_AQUI --source https://api.nuget.org/v3/index.json
```

![image](https://github.com/user-attachments/assets/d28fe011-d5a1-4c7b-b9fe-e07d1eb5929d)

---

![image](https://github.com/user-attachments/assets/dff54723-8404-419c-b35f-be47d377f110)


