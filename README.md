# CustomLibrary.NET

A reusable .NET library designed to simplify and standardize common operations across multiple applications.  
Built for **modularity**, **maintainability**, and **scalability**.

---

## Summary

- [Build and Pack](#build-and-pack)
  - [Using .NET CLI](#using-net-cli)
  - [Using Visual Studio](#using-visual-studio)
- [Publish to NuGet](#publish-to-nuget)
  - [Push to NuGet](#push-to-nuget)
  - [Success Output](#success-output)
  - [Final NuGet Package Page](#final-nuget-package-page)
- [Best Practices Tips](#tip)



## Build and Pack

### Using .NET CLI

#### Build (Release)

```bash
dotnet build -c Release
```

#### Pack (Create `.nupkg` file)

```bash
dotnet pack -c Release -p:PackageVersion=1.0.5
```

> This will generate a `.nupkg` file inside `/bin/Release/`.

---

### Using Visual Studio

Right-click the project and select `Pack`:

![Visual Studio Pack](https://github.com/user-attachments/assets/a5f2779d-47a6-4977-ab0a-9ba2dfef77a7)

---

## Publish to NuGet

1. Go to [https://www.nuget.org/](https://www.nuget.org/)
2. Create an API Key:

![Create API Key](https://github.com/user-attachments/assets/73b4ec6f-bfc2-4e39-ac42-64338ea13c77)

3. Configure the scopes and expiration:

![Configure Scopes](https://github.com/user-attachments/assets/7f0a0a0b-6885-461a-b0db-8e71712c71f5)

---

### Push to NuGet

```bash
dotnet nuget push "bin\Release\MongoFasterConnect.1.0.1.nupkg" --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json
```

> Replace `YOUR_API_KEY` with your actual key.

---

### Success Output

```bash
Your package was pushed.
Created https://www.nuget.org/api/v2/package/
```

![Push Success](https://github.com/user-attachments/assets/d28fe011-d5a1-4c7b-b9fe-e07d1eb5929d)

---

![image](https://github.com/user-attachments/assets/f74c73ea-02b3-46ce-85a4-ef0a84163098)

----

### Final NuGet Package Page

![NuGet Page](https://github.com/user-attachments/assets/bff7591e-d0db-42db-96b0-f33f62bc2cab)


