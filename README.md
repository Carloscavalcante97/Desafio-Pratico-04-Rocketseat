# ToDoList API

Este projeto é uma API desenvolvida em **.NET 8** como parte do **Desafio Prático 04 da Rocketseat**.  
A aplicação implementa uma lista de tarefas (**To-Do List**) seguindo os princípios do **Domain-Driven Design (DDD)** para uma estrutura de código organizada e escalável.  

![Example-Image]

## Funcionalidades

- **Criação de Tarefas**: Permite adicionar novas tarefas com título e descrição.  
- **Listagem de Tarefas**: Exibe todas as tarefas cadastradas.  
- **Atualização de Tarefas**: Possibilita a edição de informações das tarefas existentes.  
- **Exclusão de Tarefas**: Permite remover tarefas indesejadas.  

### Construído com

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-mysql]
![badge-swagger]

## Tecnologias Utilizadas

- **.NET 8**: Framework principal para o desenvolvimento da API.  
- **Entity Framework Core**: Utilizado para mapeamento objeto-relacional (**ORM**), facilitando a interação com o banco de dados.  
- **FluentValidation**: Implementado para validação das entradas de dados de forma fluente e desacoplada.  
- **Swagger**: Fornece uma interface interativa para documentação e testes dos endpoints da API.  

## Estrutura do Projeto

O repositório está organizado da seguinte forma:

- **ToDoList.API**: Contém os controladores e configurações da API.  
- **ToDoList.Application**: Inclui a lógica de aplicação, como serviços e casos de uso.  
- **ToDoList.Communication**: Abriga classes de comunicação, incluindo **Data Transfer Objects (DTOs)** e **ViewModels**.  

## Como Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/Carloscavalcante97/Desafio-Pratico-04-Rocketseat.git

2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)
<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Images -->
[Example-Image]: Images/Example.png

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
