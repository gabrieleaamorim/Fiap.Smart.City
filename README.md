# Fiap.Smart.City
API criada no treinamento "Desenvolvimento .NET" da Fiap, utilizando o framework Asp .NET Core e conectando a aplicação ao bando de dados MySQL.

##Para conectar ao banco de dados, seguir os seguintes comandos no PowerShell como administrador:

dotnet ef migrations add InitialCreate   //para criar a migrations.
dotnet ef database update     // para conectar de fato ao MySQL e criar o banco de dados.
