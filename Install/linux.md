# LINUX

Perfeito, você está usando **Linux** — então aqui vai um guia rápido e direto para instalar o **.NET SDK** corretamente no seu sistema.

---

## ✅ Como instalar o .NET SDK no Linux

O processo exato varia conforme a **distribuição** Linux que você usa. Vamos cobrir os mais comuns:

---

### 📦 Para Ubuntu / Debian

1. **Abra o terminal**

2. **Instale as dependências:**

```bash
sudo apt update
sudo apt install -y wget apt-transport-https
```

3. **Baixe a chave oficial da Microsoft:**

```bash
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
```

4. **Adicione o repositório:**

```bash
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
```

5. **Instale o SDK do .NET 8 (exemplo):**

```bash
sudo apt install -y dotnet-sdk-8.0
```

6. **Verifique a instalação:**

```bash
dotnet --version
```

> Se aparecer algo como `8.0.301`, está tudo certo ✅

---

### 🐧 Para outras distros (ex: Fedora, Arch, etc.)

* Use as instruções específicas da sua distro aqui:
  👉 [https://learn.microsoft.com/dotnet/core/install/linux](https://learn.microsoft.com/dotnet/core/install/linux)

---

### 🛠️ Dica: Corrigir PATH manualmente (caso necessário)

Se depois de instalar o `dotnet` o terminal ainda disser "command not found", adicione isto no seu `~/.zshrc`:

```bash
export DOTNET_ROOT=/usr/share/dotnet
export PATH=$PATH:$DOTNET_ROOT
```

Depois rode:

```bash
source ~/.zshrc
```

---

Se você quiser me dizer qual é a sua distribuição (ex: Ubuntu 22.04, Debian 12, etc.), posso mandar comandos exatos só pra ela. Quer isso?
