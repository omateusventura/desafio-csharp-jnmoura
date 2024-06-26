# Desafio técnico JN Moura

Este projeto é um desafio técnico proposto pela empresa JN Moura. Para que este projeto funcione plenamente é necessário
a configuração do seu front-end que se encontra no link [Front-end desafio JN Moura](https://github.com/omateusventura/desafio-angularjs-jnmoura/)

## Clonando o projeto

```
Com o Visual Studio aberto encontre no menu superior a opção Git e selecione o item Clonar Repositório
```

```
Informe o repositório https://github.com/omateusventura/desafio-csharp-jnmoura.git e clique em clonar
```

```
Abra o arquivo appsettings.json, que se encontra na raiz, e na variável Connection String informe uma Connection String de uma conexão MySQL
```

```
Exemplo de Connection String utlizando MySQL: "Server=;Port=3306;Database=;User Id=;Password="
```

## Instalando as dependências

Abra o terminal NuGet acessando Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacote

```
dotnet add package Microsoft.EntityFrameworkCore
```

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

```
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

```
dotnet add package Pomelo.EntityFrameworkCore.MySql
```

```
dotnet add package Swashbuckle.AspNetCore
```

```
dotnet tool install --global dotnet-ef
```

```
dotnet restore
```

```
dotnet build --no-restore
```

## Rodando as migrations

```
dotnet ef database update
```


## Iniciando o projeto

```
dotnet run
```

```
O projeto irá abrir no endereço http://localhost:5252/swagger/index.html
```
