# .net

O **.NET da Microsoft** é uma **plataforma de desenvolvimento** para criar e executar aplicações em diferentes ambientes, como **Windows, Linux, macOS, web, dispositivos móveis e nuvem**.

---

## 🧩 O que é exatamente o .NET?

**.NET** (ou “dot net”) é:

* Um **conjunto de ferramentas**, bibliotecas e linguagens de programação
* Uma **plataforma unificada**, criada pela Microsoft
* Usada para criar diversos tipos de aplicações

---

## ✅ O que dá pra fazer com o .NET?

Com .NET, você pode criar:

| Tipo de Aplicação | Exemplo                                       |
| ----------------- | --------------------------------------------- |
| 🌐 Web            | Sites, APIs REST com ASP.NET                  |
| 🖥️ Desktop       | Programas com interface (WinForms, WPF, MAUI) |
| 📱 Mobile         | Apps Android e iOS com .NET MAUI / Xamarin    |
| 📦 Bibliotecas    | Códigos reutilizáveis (.dll)                  |
| ⌨️ Console        | Scripts ou apps de terminal                   |
| ☁️ Nuvem          | Apps serverless e microservices em Azure, AWS |
| 🎮 Jogos          | Com Unity (usa C# e roda no .NET)             |

---

## 🛠️ Principais componentes do .NET

| Componente           | Descrição                                                                 |
| -------------------- | ------------------------------------------------------------------------- |
| **CLR**              | Common Language Runtime – o "motor" que executa os programas .NET         |
| **BCL**              | Base Class Library – bibliotecas padrão (ex: manipular arquivos, strings) |
| **C# / F# / VB.NET** | Linguagens de programação suportadas                                      |
| **ASP.NET**          | Framework para criar apps web e APIs                                      |
| **Entity Framework** | ORM para trabalhar com bancos de dados                                    |
| **.NET SDK**         | Ferramentas de linha de comando (como `dotnet run`, `dotnet build`)       |

---

## 🧠 Curiosidade: .NET Core vs .NET Framework

Antigamente, havia duas versões diferentes:

* **.NET Framework** – só funcionava no Windows (antigo)
* **.NET Core** – multiplataforma, mais moderno

Hoje, tudo foi unificado no **.NET 5+ (e agora .NET 8)**. A Microsoft chama isso de:

> ".NET moderno" — um único .NET para todas as plataformas.

---

## 🗣️ Linguagem usada

A principal linguagem para programar em .NET é o **C# (C-Sharp)**, mas ele também suporta:

* **F#**
* **Visual Basic .NET**

---

Aqui está um **exemplo básico de como criar um programa de console em .NET**, passo a passo.

---

### ✅ Pré-requisitos

Antes de começar, você precisa:

* Instalar o **.NET SDK** (versão mais recente):
  👉 [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

* Ter um editor de código (como o **Visual Studio Code**, **Visual Studio**, ou outro).

---

### 🔧 Passo a Passo: Criar um Projeto de Console com .NET

#### 1. **Abra o terminal (CMD, PowerShell, ou terminal do VS Code)**

#### 2. **Crie uma nova pasta (opcional):**

```bash
mkdir MeuProjetoConsole
cd MeuProjetoConsole
```

#### 3. **Crie um novo projeto .NET do tipo console:**

```bash
dotnet new console -n MeuApp
cd MeuApp
```

#### 4. **Abra o projeto no editor de sua escolha** (ex: VS Code):

```bash
code .
```

#### 5. **O arquivo `Program.cs` será gerado automaticamente**, com algo assim:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
    }
}
```

#### 6. **Execute o programa:**

```bash
dotnet run
```

📌 Saída esperada:

```
Olá, mundo!
```

---

### 👨‍💻 Quer fazer algo mais específico?

Você pode usar o .NET para:

* Criar **APIs REST** com ASP.NET
* Criar **aplicações web** (MVC, Razor Pages, Blazor)
* Criar **aplicações desktop** (WinForms, WPF, MAUI)
* Criar **bibliotecas** de código
* Trabalhar com **banco de dados** via Entity Framework




