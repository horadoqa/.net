# Executando teste Unitário

Ótima pergunta! Criar **testes unitários** é essencial para garantir que sua calculadora esteja funcionando corretamente — especialmente se você quiser adicionar mais funcionalidades no futuro.

Vamos fazer isso passo a passo:

---

## 🧪 Objetivo: Criar testes unitários com xUnit para a calculadora

---

## ✅ Passo 1: Refatorar o código

Antes de escrever testes, precisamos separar a **lógica de cálculo** do `Program.cs`. Isso significa mover a lógica para uma **classe separada** que possa ser testada.

### 🛠️ Crie a classe `Calculadora.cs`

No mesmo projeto, adicione este arquivo:

```csharp
public class Calculadora
{
    public double Somar(double a, double b) => a + b;

    public double Subtrair(double a, double b) => a - b;

    public double Multiplicar(double a, double b) => a * b;

    public double Dividir(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Não é possível dividir por zero.");
        return a / b;
    }
}
```

Agora temos uma classe que pode ser testada facilmente.

---

## ✅ Passo 2: Criar o projeto de teste

No terminal, volte para a raiz da solução e execute:

```bash
dotnet new xunit -n Calculadora.Tests
```

Depois, adicione uma **referência ao projeto principal**:

```bash
cd Calculadora.Tests
dotnet add reference ../Calculadora/Calculadora.csproj
```

---

## ✅ Passo 3: Criar os testes unitários

Abra o arquivo `UnitTest1.cs` e substitua pelo seguinte código:

### 📁 `CalculadoraTests.cs`

```csharp
using Xunit;
using System;

public class CalculadoraTests
{
    private readonly Calculadora _calc = new Calculadora();

    [Fact]
    public void Soma_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Somar(2, 3);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Subtracao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Subtrair(10, 4);
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Multiplicacao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Multiplicar(3, 4);
        Assert.Equal(12, resultado);
    }

    [Fact]
    public void Divisao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Dividir(10, 2);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Divisao_PorZero_DeveLancarExcecao()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
    }
}
```

---

## ✅ Passo 4: Rodar os testes

No terminal (dentro do projeto de testes), execute:

```bash
dotnet test
```

Se tudo estiver correto, você verá uma saída como:

```bash
➜  Calculadora.Tests git:(main) ✗ dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  Calculadora -> /home/rfahham/projetos/.net/Calculadora/bin/Debug/net8.0/Calculadora.dll
  Calculadora.Tests -> /home/rfahham/projetos/.net/Calculadora.Tests/bin/Debug/net8.0/Calculadora.Tests.dll
Test run for /home/rfahham/projetos/.net/Calculadora.Tests/bin/Debug/net8.0/Calculadora.Tests.dll (.NETCoreApp,Version=v8.0)
VSTest version 17.11.1 (x64)

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 3 ms - Calculadora.Tests.dll (net8.0)
```

---

## 📌 Estrutura final do projeto

```
/Calculadora
    - Program.cs
    - Calculadora.cs
/Calculadora.Tests
    - CalculadoraTests.cs
```

---

## Quer avançar?

Você pode adicionar:

* Cobertura de código com `coverlet`
* Testes parametrizados com `[Theory]`
* CI com GitHub Actions