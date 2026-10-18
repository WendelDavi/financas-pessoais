# Finanças Pessoais

Sistema web de gerenciamento financeiro pessoal, desenvolvido em C# e .NET.

## Objetivo

Desenvolver uma aplicação para gerenciamento de finanças pessoais, permitindo registrar, organizar e acompanhar receitas, despesas e movimentações financeiras.

O sistema busca oferecer maior controle sobre o orçamento pessoal, possibilitando personalizações conforme as necessidades do usuário.

Além da utilidade prática, o projeto tem como objetivo o aprimoramento de conhecimentos em desenvolvimento de software, arquitetura de sistemas, persistência de dados e boas práticas de programação.

## Tecnologias

- **Linguagem:** C#
- **Framework:** .NET 10 / ASP.NET Core
- **Frontend:** Blazor
- **ORM:** Entity Framework Core
- **Banco de dados:** SQLite
- **Testes automatizados:** xUnit
- **Versionamento:** Git e GitHub
- **Containerização:** Docker
- **Ambiente de desenvolvimento:** Arch Linux (WSL2)
- **Editor:** LunarVim

## Arquitetura

A aplicação será organizada em camadas, seguindo os princípios de separação de responsabilidades.

| Projeto | Responsabilidade |
|---|---|
| Financas.Domain | Entidades e regras de negócio |
| Financas.Application | Serviços e casos de uso |
| Financas.Infrastructure | Persistência e acesso aos dados |
| Financas.Web | Interface web e endpoints HTTP |
| Financas.Tests | Testes automatizados |

## Funcionalidades planejadas

### Gerenciamento financeiro
- Cadastro de contas financeiras
- Registro de receitas e despesas
- Transferências entre contas
- Categorização de movimentações
- Consulta de saldos e extratos

### Planejamento
- Controle de despesas recorrentes
- Gerenciamento de pagamentos futuros
- Projeção de saldo
- Acompanhamento de orçamento mensal

### Cartões de crédito
- Cadastro de cartões
- Controle de faturas
- Registro de compras parceladas
- Acompanhamento de vencimentos

### Relatórios
- Resumo financeiro mensal
- Análise de receitas e despesas
- Relatórios por categoria
- Evolução do saldo

### Recursos adicionais
- Autenticação de usuários
- Importação e exportação de dados
- Backup das informações financeiras
- Interface responsiva para computadores e dispositivos móveis

## Estrutura do projeto

```text
financas-pessoais/
├── src/
│   ├── Financas.Domain/
│   ├── Financas.Application/
│   ├── Financas.Infrastructure/
│   └── Financas.Web/
├── tests/
│   └── Financas.Tests/
├── docs/
├── .github/
├── Financas.slnx
├── .editorconfig
├── .gitattributes
├── .gitignore
└── README.md
```

## Status do desenvolvimento

**Em desenvolvimento — configuração inicial concluída.**

A estrutura da solução .NET foi criada e o ambiente está preparado para o início da implementação das regras de negócio.

### Próximas etapas

1. Modelagem das entidades financeiras.
2. Implementação das regras de negócio.
3. Criação dos testes unitários.
4. Configuração do Entity Framework Core e SQLite.
5. Desenvolvimento da interface web.
6. Implementação das funcionalidades de planejamento financeiro.

## Finalidade

Projeto de desenvolvimento pessoal, destinado ao uso cotidiano e à construção de um portfólio profissional.

O desenvolvimento será realizado de maneira incremental, priorizando funcionalidades utilizáveis, organização do código, testes e evolução progressiva da arquitetura.
