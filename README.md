# MyFinance Web Application

## Descrição do Projeto
O **MyFinance Web Application** é uma aplicação web desenvolvida em ASP.NET Core para gerenciar transações, incluindo o cadastro de planos de contas. A aplicação permite a inserção, edição, exclusão e listagem de registros financeiros de forma eficiente. Esse projeto faz parte do curso de Pós-Graduação em Engenharia de Software da PUC-MG.

## 🛠️ Pré-requisitos

- [SDK do .NET Core 6.0](https://dotnet.microsoft.com/download/dotnet/6.0) ou posterior
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (A edição Express é suficiente)

## Arquitetura Utilizada
A aplicação segue a arquitetura **MVC (Model-View-Controller)**, que separa a aplicação em três componentes principais:


**Model (Modelo)**:
- Representa a camada de dados do aplicativo. É responsável por recuperar dados do banco de dados e armazenar a lógica de negócios associada.
   
**View (Visão)**:
- Representa a camada de apresentação. É responsável por exibir os dados ao usuário e enviar comandos de interface do usuário (como cliques de botões) de volta ao controlador.

**Controller (Controlador)**:
- Representa a camada de lógica de aplicação. É responsável por receber solicitações do usuário, processar os dados usando os modelos, e retornar a resposta apropriada.
   
## 📦 Dependências
- Microsoft.AspNetCore.Mvc
- Microsoft.EntityFrameworkCore
- AutoMapper
- Microsoft.Extensions.Logging

## Como Configurar para Startup do Projeto
Para configurar e iniciar o projeto localmente, siga os passos abaixo:

1. **Clonar o repositório**:
   git clone https://github.com/seu-usuario/myfinance_web_netcore.git
   cd myfinance_web_netcore

2. **Criar o banco de dados**:
   Dentro da pasta docs está disponível o arquivo **scriptBanco.txt** que deve ser utilizado para criar o banco de dados no SQL Server.

3. **Configurar a string de conexão**:
   Dentro da pasta Infrastructure, abra o arquivo MyFinanceDbContext.cs e edite de acordo com as configurações do seu ambiente.

4. **Restaurar as dependências do projeto**:
    Utilize o comando **dotnet restore** para restaurar as dependências do projeto
    
5. **Iniciar a aplicação**:
    Utilize o comando **dotnet run** para executar a aplicação. No console deve ser indicado o endereço local apontando para a porta 7144.

