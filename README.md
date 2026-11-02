# HANDS-ON #03 — Testes Unitários com xUnit

**Ponto de Conhecimento Tecnológico**

C# · .NET 10 · Visual Studio 2026 · xUnit

## Objetivo

Demonstrar a implementação e execução de testes unitários em C#, utilizando xUnit, através de um exemplo prático de cálculo de descontos.

O projeto permite validar regras de negócio, testar diferentes cenários de entrada, verificar exceções e analisar a cobertura de código.

## Estrutura da solução

```text
TestesUnitariosHandsOnDemo/
├── TestesUnitariosHandsOnDemo.Core/
│   └── CalculadoraDescontos.cs
├── TestesUnitariosHandsOnDemo/
│   └── UnitTest1.cs
├── .gitignore
└── README.md
```

**Core:** biblioteca de classes que contém a lógica de negócio.

**Projeto de testes:** contém os testes automatizados desenvolvidos com xUnit.

## Tecnologias utilizadas

- C# e .NET 10
- Visual Studio 2026
- xUnit 2.9.3
- Microsoft.NET.Test.Sdk 17.14.1
- xunit.runner.visualstudio 3.1.4
- coverlet.collector 6.0.4
- ReportGenerator 5.5.12

## Funcionalidades implementadas

A classe `CalculadoraDescontos` disponibiliza três métodos:

| Método | Descrição |
|---|---|
| `CalcularSubtotal()` | Calcula o subtotal com base no preço e quantidade. |
| `CalcularDesconto()` | Calcula o desconto percentual. |
| `CalcularTotal()` | Calcula o valor final após aplicação do desconto. |

Os métodos incluem validações para impedir valores inválidos.

## Testes unitários

Foram utilizados os seguintes recursos do xUnit:

- `[Fact]` — execução de um teste individual.
- `[Theory]` — execução de testes parametrizados.
- `[InlineData]` — definição de diferentes conjuntos de dados.
- `Assert.Equal()` — comparação entre resultados esperados e obtidos.
- `Assert.Throws<ArgumentException>()` — verificação de exceções.

Os testes seguem o padrão **AAA (Arrange, Act, Assert)**.

## Execução dos testes

Na pasta principal da solução, executar:

```powershell
dotnet test
```

## Cobertura de código

Para executar os testes e recolher métricas de cobertura:

```powershell
dotnet test --collect:"XPlat Code Coverage"
```

Para gerar um relatório HTML com o ReportGenerator:

```powershell
reportgenerator "-reports:TestesUnitariosHandsOnDemo\TestResults\**\coverage.cobertura.xml" "-targetdir:CoverageReport" "-reporttypes:Html"
```

O relatório pode ser consultado através do ficheiro `CoverageReport/index.html`.

## Resultados obtidos

| Indicador | Resultado |
|---|---|
| Testes executados | 26 |
| Testes aprovados | 26 |
| Testes falhados | 0 |
| Cobertura de linhas | 100% (19/19) |
| Cobertura de ramificações | 100% (16/16) |
| Métodos analisados | 3 |

Os resultados correspondem à classe `CalculadoraDescontos` na execução documentada.

**Nota:** 100% de cobertura não garante ausência de defeitos. A cobertura demonstra que as linhas e ramificações instrumentadas foram executadas, mas não substitui a qualidade dos cenários e das verificações implementadas.

## Conclusão

Este Hands-On demonstra como os testes unitários contribuem para a validação de regras de negócio e para a identificação de comportamentos inesperados.

A utilização conjunta de xUnit, Coverlet e ReportGenerator permite implementar testes automatizados, recolher métricas e analisar visualmente a cobertura do código.

---

**Ponto de Conhecimento Tecnológico**

*Hands-On | Aprender através da prática*