# myfinance-web-dotnet
Projeto da disciplina de Práticas de Implementação e Evolução de Software, do curso de Pós-Graduação em Engenharia de Software na PUC-MG.


## Descrição

O My Finance Web é uma ferramenta meticulosamente projetada para ser o braço direito das famílias na gestão de suas finanças. Este aplicativo, concebido para funcionar na web, é uma plataforma acessível e responsiva, adaptada para acompanhar o usuário em qualquer dispositivo, desde smartphones até tablets, proporcionando uma experiência consistente e prática.

Sua estrutura, a Arquitetura My Finance, foi cuidadosamente planejada para oferecer uma gama de funcionalidades que simplificam o registro e o acompanhamento dos ganhos e gastos familiares. O cerne dessa plataforma é permitir que cada usuário molde seu próprio Plano de Contas, possibilitando a categorização detalhada de todas as transações. Essa personalização é crucial, pois cada família tem suas particularidades financeiras e necessidades específicas.

## Como usar?

Seguindo as instruções descritas abaixo lhe permitirão obter uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.


### Pré-requisitos

Para operação do projeto em sua máquina é necessário ter instalado no computador o  Visual Studio Code ou alguma IDE análoga que lhe permita efetuar os comandos. Também é necessário ter em seu computador algum gerenciador de banco de dados SQL, como por exemplo, o SQL Management Studio (SSMS) ou dbeaver.

### Instalação

As etapas para operação do projeto são descritas abaixo:

```
1 - Abrir o projeto myfinance-web-dotnet em sua IDE
2 - Abrir o terminal da IDE
3 - Executar o comando dotnet build para compilação do projeto
4 - Executar o comando dotnet run ou dotnet watch run para execução do projeto
5 - Acessar a pasta Scripts para criação do banco de dados e executá-los em seu gerenciador de banco de dados. O primeiro script a ser executado é o myfinanceweb_DB.sql
```

## Diagrama arquitetural

![image](https://github.com/Narianapereira/myfinance-web-dotnet/architecture.jpeg)


## Tecnologias utilizadas

* [Visual Studio Code](https://code.visualstudio.com/download): Ambiente de desenvolvimento (IDE)
* [.NET Core SDK 7.0.402](https://dotnet.microsoft.com/en-us/download): Linguagem de implementação (Obs.: Foi utilizada a extensão do C#, instalada internamente no VS Code)
* [Microsoft ASPNetCore Identity Entity Framework Core 7.0.13](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity.EntityFrameworkCore): Framework
* [SQL Server 2019 Express Edition](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads): Banco de Dados


## Versão

Versão atual do projeto: 1.0 
