# HANDS-ON #03 — Testes Unitários com xUnit

**Ponto de Conhecimento Tecnológico**

C# · .NET 10 · Visual Studio 2026 · xUnit

## Sobre o projeto

Este Hands-On demonstra a implementação de testes unitários em C#, utilizando o framework xUnit, através de um exemplo prático de cálculo de descontos.

O objetivo é explorar a validação de regras de negócio, a utilização de testes parametrizados, a verificação de exceções e a análise da cobertura de código.

O projeto inclui o código-fonte, testes automatizados, um guia técnico de configuração e um relatório HTML de cobertura.

## Tecnologias utilizadas

| Tecnologia | Finalidade |
|---|---|
| C# / .NET 10 | Desenvolvimento da lógica de negócio |
| Visual Studio 2026 | Ambiente de desenvolvimento |
| xUnit 2.9.3 | Framework de testes unitários |
| Microsoft.NET.Test.Sdk 17.14.1 | Infraestrutura de execução de testes |
| xunit.runner.visualstudio 3.1.4 | Integração dos testes com o Visual Studio |
| coverlet.collector 6.0.4 | Recolha de métricas de cobertura |
| ReportGenerator 5.5.12 | Geração de relatórios HTML |

## Estrutura da solução

```text
HandsOn-03-Testes-Unitarios-xUnit/
├── TestesUnitariosHandsOnDemo.Core/
│   └── CalculadoraDescontos.cs
├── TestesUnitariosHandsOnDemo/
│   └── UnitTest1.cs
├── CoverageReport/
│   └── index.html
├── docs/
│   └── HandsOn-03-Guia-Tecnico.pdf
├── README.md
├── .gitignore
└── TestesUnitariosHandsOnDemo.slnx
```

A pasta `docs` deverá ser criada e o guia técnico colocado na localização indicada.

## Funcionalidades implementadas

A classe `CalculadoraDescontos` contém três métodos:

| Método | Responsabilidade |
|---|---|
| `CalcularSubtotal()` | Calcula o subtotal a partir do preço unitário e da quantidade |
| `CalcularDesconto()` | Calcula o desconto percentual |
| `CalcularTotal()` | Determina o valor final após o desconto |

Os métodos incluem validações para impedir valores inválidos.

## Testes unitários

Foram explorados os seguintes recursos do xUnit:

- `[Fact]` — testes individuais.
- `[Theory]` e `[InlineData]` — testes parametrizados.
- `Assert.Equal()` — validação de resultados.
- `Assert.Throws<ArgumentException>()` — verificação de exceções.
- Padrão AAA — Arrange, Act, Assert.

## Executar o projeto

**Pré-requisitos:** .NET 10 SDK e Visual Studio 2026 ou outro ambiente compatível.

Clonar o repositório:

```bash
git clone https://github.com/FgAraujo-web/HandsOn-03-Testes-Unitarios-xUnit.git
```

Na pasta principal da solução, executar:

```powershell
dotnet restore
dotnet test
```

## Cobertura de código

Executar os testes com recolha de cobertura:

```powershell
dotnet test --collect:"XPlat Code Coverage"
```

Instalar o ReportGenerator, caso ainda não esteja disponível:

```powershell
dotnet tool install --global dotnet-reportgenerator-globaltool
```

Gerar o relatório HTML:

```powershell
reportgenerator "-reports:TestesUnitariosHandsOnDemo\TestResults\**\coverage.cobertura.xml" "-targetdir:CoverageReport" "-reporttypes:Html"
```

O relatório pode ser consultado no ficheiro `CoverageReport/index.html`.

## Resultados obtidos

| Indicador | Resultado |
|---|---|
| Testes executados | 26 |
| Testes aprovados | 26 |
| Testes falhados | 0 |
| Cobertura de linhas | 100% (19/19) |
| Cobertura de ramificações | 100% (16/16) |
| Métodos analisados | 3 |

Os resultados correspondem à execução documentada e à classe `CalculadoraDescontos`.

**Nota:** uma cobertura de 100% não garante ausência de defeitos. É igualmente importante avaliar a qualidade dos cenários e das verificações implementadas.

## Documentação técnica

O guia técnico apresenta o desenvolvimento do exercício passo a passo, incluindo:

1. Introdução aos testes unitários e às tecnologias utilizadas.
2. Criação da solução e dos projetos no Visual Studio 2026.
3. Configuração das referências e dos pacotes NuGet.
4. Implementação de testes com xUnit.
5. Execução e diagnóstico de problemas.
6. Recolha e interpretação da cobertura de código.

**[Consultar o Guia Técnico — HANDS-ON #03](docs/HandsOn-03-Guia-Tecnico.pdf)**

## Relatório de cobertura

O projeto disponibiliza um relatório HTML gerado com Coverlet e ReportGenerator.

**[Consultar os ficheiros do relatório de cobertura](CoverageReport/)**

Para visualizar o relatório completo, abrir localmente o ficheiro `CoverageReport/index.html` num navegador.

## Conclusão

Os testes unitários constituem uma prática importante para validar comportamentos e apoiar a evolução segura das aplicações.

Este Hands-On demonstra como combinar xUnit, Coverlet e ReportGenerator para implementar testes automatizados, analisar resultados e identificar o código exercitado pelos testes.

---

**Ponto de Conhecimento Tecnológico**

*Explorar · Experimentar · Aprender · Partilhar*

**HANDS-ON | Tutoriais, guias e boas práticas**