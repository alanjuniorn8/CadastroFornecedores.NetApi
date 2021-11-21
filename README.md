# Cadastro de Fornecedores Api

## Uma api para realizar cadastro de fornecedores e produtos

### ✨ Features
- [x] Cadastro de fornecedores
- [x] Cadastro de produtos

### 🚧 Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina o framework [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
Além disto é necessário ter configurado um database MySql[MySql](https://www.mysql.com/)

### 🎲 Rodando a aplicação

```bash
# Clone este repositório
$ git clone <https://github.com/alanjuniorn8/CadastroFornecedores.NetApi>

#  No arquivo appsettings.json configure a string de conexão com banco de dados MySql

# Instale o dotnet ef tool para executar as migrations
$ dotnet tool install --global dotnet-ef

# Na pasta do projeto no terminal/cmd execute as migrations para atualizar o banco
$ dotnet ef database update

# Execute a aplicação em modo de desenvolvimento
$ dotnet run

# O servidor inciará na porta:5001 - acesse <https://localhost:5001>
```

### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET 5.0](https://dotnet.microsoft.com/)
- [Entity Framework](https://docs.microsoft.com/pt-br/ef/)
- [MySql](https://www.mysql.com/)
