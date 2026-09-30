
# GamerProfile - Cadastro de Jogadores

## Sobre o Projeto

O GamerProfile é um sistema desenvolvido em C# com .NET 10, com o objetivo de gerenciar funcionalidades básicas relacionadas ao cadastro de jogadores.

O projeto foi desenvolvido como atividade da disciplina de Gestão e Qualidade de Software, do curso de Análise e Desenvolvimento de Sistemas, sob orientação do professor Daniel Henrique Matos de Paiva.

A aplicação utiliza testes unitários com xUnit para verificar o funcionamento dos métodos implementados, garantindo que os resultados estejam de acordo com os requisitos propostos.

## Funcionalidades

O projeto possui a classe `PerfilJogadorService`, responsável por implementar três funcionalidades:

* **GerarTagUsuario:** recebe o nickname e o código do jogador e retorna a tag no formato `Nickname#Codigo`.
* **CalcularXPTotal:** soma a experiência (XP) de duas fases e adiciona um bônus fixo de 100 pontos.
* **EEligivelParaRanked:** verifica se o jogador possui nível maior ou igual a 15 para participar de partidas ranqueadas.

## Testes Unitários

Os testes foram desenvolvidos utilizando o framework xUnit, com o atributo `[Fact]`, para validar individualmente os métodos da aplicação.

### 1. Teste de geração da tag

Verifica se o método `GerarTagUsuario` concatena corretamente o nickname e o código do jogador, utilizando o caractere `#`.

* Método de validação: `Assert.Equal`
* Resultado esperado: `Nickname#0000`

### 2. Teste de cálculo do XP

Verifica se o método `CalcularXPTotal` soma corretamente os pontos de experiência das duas fases e aplica o bônus fixo de 100 pontos.

* Método de validação: `Assert.Equal`
* Exemplo: 200 + 300 + 100 = 600.

### 3. Teste de elegibilidade para Ranked

Verifica se o método `EEligivelParaRanked` retorna o valor booleano correto de acordo com o nível do jogador.

* `Assert.True`: utilizado para validar jogadores com nível maior ou igual a 15.
* `Assert.False`: utilizado para validar jogadores com nível abaixo de 15.

## Como Executar os Testes

É necessário ter o SDK do .NET 10 ou superior instalado.

1. Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/gamer-profile-xunit.git
```

2. Entre na pasta do projeto:

```bash
cd gamer-profile-xunit
```

3. Execute os testes unitários:

```bash
dotnet test
```

O comando executa os testes do projeto `GamerProfile.Tests` e apresenta no terminal o resultado da execução, indicando os testes aprovados ou reprovados.

---

## Autores
**Kaio Moreira - 32510906**

**Erick Mello - 326211590**

**Icaro Ferreira - 325111358**

Projeto acadêmico desenvolvido para a disciplina de **Garantia e Qualidade de Software**.
