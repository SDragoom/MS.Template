# MS.Template

Template para criação de microserviços em .NET 8.

## Visão Geral

Este template tem como objetivo padronizar o desenvolvimento de microserviços, fornecendo uma estrutura base reutilizável com:

- ASP.NET Core 8
- Swagger/OpenAPI
- Health Check
- Entity Framework Core
- Serilog
- Middleware Global de Exceções
- DTOs Padronizados
- Arquitetura em Camadas
- Injeção de Dependência
- Template .NET (`dotnet new`)

---

# Estrutura da Solução

```text
MS.Template

├── MS.Template.Api
├── MS.Template.Aplicacao
├── MS.Template.Dominio
├── MS.Template.Infraestrutura
└── MS.Template.Testes
```

---

# Arquitetura

## API

Responsável pela exposição dos endpoints REST.

```text
Controllers
Middlewares
Extensoes
Configuracoes
```

---

## Aplicação

Responsável pelos casos de uso.

```text
DTOs
Servicos
Comandos
Consultas
Interfaces
```

---

## Domínio

Responsável pelas regras de negócio.

```text
Entidades
Interfaces
Enumeradores
Excecoes
```

---

## Infraestrutura

Responsável pelo acesso a dados e integrações externas.

```text
Contexto
Repositorios
Configuracoes
Mapeamentos
```

---

## Testes

Projetos de testes unitários e integração.

```text
Unitarios
Integracao
```

---

# Pré-Requisitos

- .NET SDK 8.0
- Visual Studio 2022 ou superior
- Git

---

# Instalação do Template

Acesse a pasta raiz do template:

```powershell
cd C:\Git\MS.Template
```

Instale o template:

```powershell
dotnet new install .
```

Verifique se o template foi instalado:

```powershell
dotnet new list
```

Resultado esperado:

```text
Template de Microserviço
ms-template
```

---

# Utilização

Para criar um novo microserviço:

```powershell
dotnet new ms-template --name MS.Despesa
```

---

## Exemplo

Criando o microserviço de despesas:

```powershell
dotnet new ms-template --name MS.Despesa
```

Estrutura gerada:

```text
MS.Despesa.sln

MS.Despesa.Api

MS.Despesa.Aplicacao

MS.Despesa.Dominio

MS.Despesa.Infraestrutura

MS.Despesa.Testes
```

---

## Outro Exemplo

```powershell
dotnet new ms-template --name MS.Reembolso
```

Resultado:

```text
MS.Reembolso.sln

MS.Reembolso.Api
MS.Reembolso.Aplicacao
MS.Reembolso.Dominio
MS.Reembolso.Infraestrutura
MS.Reembolso.Testes
```

---

# Funcionalidades Incluídas

## Swagger

Disponível em:

```text
/swagger
```

---

## Health Check

Disponível em:

```text
/health
```

---

## Endpoint de Status

Disponível em:

```text
/api/status
```

Exemplo de resposta:

```json
{
  "sucesso": true,
  "mensagem": "Operação realizada com sucesso.",
  "dados": "Serviço ativo"
}
```

---

## Endpoint de Versão

Disponível em:

```text
/api/versao
```

Exemplo:

```json
{
  "sucesso": true,
  "mensagem": "Operação realizada com sucesso.",
  "dados": {
    "servico": "MS.Despesa",
    "versao": "1.0.0"
  }
}
```

---

# DTOs Padronizados

## RespostaDTO

```csharp
public class RespostaDTO<T>
{
    public bool Sucesso { get; set; }

    public string Mensagem { get; set; }

    public T? Dados { get; set; }
}
```

---

## RespostaErroDTO

```csharp
public class RespostaErroDTO
{
    public bool Sucesso { get; set; }

    public string Codigo { get; set; }

    public string Mensagem { get; set; }

    public string? CorrelationId { get; set; }
}
```

---

## RespostaPaginadaDTO

```csharp
public class RespostaPaginadaDTO<T>
{
    public IEnumerable<T> Dados { get; set; }

    public int Pagina { get; set; }

    public int TamanhoPagina { get; set; }

    public int TotalRegistros { get; set; }
}
```

---

# Middleware Global de Exceções

O template possui tratamento global de exceções.

Exemplo de retorno:

```json
{
  "sucesso": false,
  "codigo": "ERRO_INTERNO",
  "mensagem": "Ocorreu um erro interno na aplicação.",
  "correlationId": "0HNAB12345678:00000001"
}
```

---

# Atualizando o Template

Após realizar alterações na estrutura:

Remover o template instalado:

```powershell
dotnet new uninstall C:\Git\MS.Template
```

Instalar novamente:

```powershell
cd C:\Git\MS.Template

dotnet new install .
```

---

# Boas Práticas

- Não adicionar regras de negócio na API.
- Utilizar a camada Aplicação para orquestração.
- Centralizar entidades no Domínio.
- Concentrar acesso ao banco na Infraestrutura.
- Utilizar DTOs para comunicação entre camadas.
- Utilizar injeção de dependência para todos os serviços.

---

# Versionamento

Versão atual:

```text
1.0.0
```

---

# Autor

Marcelo de Lima Norvaes Peres
