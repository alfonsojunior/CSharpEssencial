# Comandos úteis

### Verificar os SDKs disponíveis para instalar pelo Winget
```powershell
winget search Microsoft.DotNet.SDK
```

### Instalar o Net SDK 6 pelo Winget
```powershell
winget install Microsoft.DotNet.SDK.6
```

### Listar as SDKs disponíveis
```powershell
dotnet --list-sdks
```

### Listar os principais templates
```powershell
dotnet new
```

### Listar todos os templates possíveis
```powershell
dotnet new --list
```

### Executar o projeto
```powershell
dotnet run
```

### Forçar que um projeto seja criado usando um determinado SDK
```powershell
dotnet new globaljson --sdk-version <versão> --force
```

### Criar uma solução
```powershell
dotnet new sln -o <nome solução>
```

### Criar um projeto (entrar no diretório da solução)
```powershell
dotnet new <nome template> -o <nome projeto>
```

### Criar um projeto usando uma versão de SDK (entrar no diretório da solução)
```powershell
dotnet new <nome template> -o <nome projeto> -f <versão sdk>
Ex: dotnet new console -o AppConsole -f net5.0
```

### Criar um projeto com SDK novo, mas usando o método Main (entrar no diretório da solução)
```powershell
dotnet new <nome template> -o <nome projeto> --use-program-main
Ex: dotnet new console -o AppConsole -f net5.0 --use-program-main
```

### Adicionar o projet na solução
```powershell
dotnet sln <nome solução>.sln add <diretório projeto>/<nome projeto>.csproj
```

### Adicionar/remover referências de projetos para outros projetos
```powershell
dotnet add/remove reference <diretório projeto>/<nome projeto>.csproj
Ex: dotnet add AppConsole/AppConsole.csproj reference AppBiblioteca/AppBiblioteca.csproj
```

### Adicionar/remover referência de pacotes Nuget
```powershell
dotnet add/remove package <nome package> --version <VERSION>
Ex: dotnet add AppConsole/AppConsole.csproj package Newtonsoft.Json --version 13.0.1
```

### Pesquisa de pacotes Nuget pelo nome
```powershell
dotnet package search <nome pacote>
Ex: dotnet package search Newtonsoft.Json
```

### Para compilar uma solução em modo Debug (no diretório da solução)
```powershell
dotnet build
```

### Para compilar uma solução em modo Release
```powershell
dotnet build --configuration Release
 ou 
dotnet build -c Release
```

### Para Limpar e compilar uma solução
```powershell
dotnet build --force
```

### Para compilar somente um projeto da solução
```powershell
dotnet build <nome projeto>.csproj
Ex: dotnet build AppConsole/AppConsole.csproj
```