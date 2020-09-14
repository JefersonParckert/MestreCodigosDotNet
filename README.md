# Mestre dos Codigos .Net

Projeto Mestre dos códigos em DotNet

### Perguntas teóricas de introdução
- Em quais linguagens o C# foi inspirado?
>  O C# possui sua inspiração nas linguagens Java, C, C++, Smalltalk, Delphi e VB.

- Inicialmente o C# foi criado para qual finalidade?
> O C# teve como finalidade flexibilizar o desenvolvimento de aplicativos, desta forma o programador não cria aplicativos especificos para cada dispositivo e sim para uma plataforma.

- Quais os principais motivos para a Microsoft ter migrado para o Core?
> Proporcionar uma técnologia multi-plataforma compativel com aplicações em nuvem e containers.

- Cite as principais diferenças entre .Net Full Framework e .Net Core.
> Acredito que a principal diferença entre eles é a portabilidade, ou seja a possibilidade de executar a mesma solução em diferentes sistemas operacionais, alem disto o .Net Core é open source e possui maior performance

### Trabalhando no Console

1) Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.
* Some esses 2 valores;
* Faça uma subtração do valor A - B;
* Divida o valor B por A;
* Multiplique o valor A por B;
* Imprima os valores de entrada, informado se o número é par ou impar;
* Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_1" disponível na solução

2) Crie uma aplicação que receba nome e salario de N funcionários. Utilize a repetição for e while.
* Imprima o maior salario
* Imprima o menor salario.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_2" disponível na solução

3) Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_3" disponível na solução

4) Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para estrutura de repetição.
* Crie um objeto alunos
* Armazene os alunos em uma lista.
* Imprima todos os alunos com medias superiores a 7.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_4" disponível na solução
 
5) Crie uma aplicação que calcule a fórmula de Bhaskara.
* Receba os valores a,b,c.
* Imprima os resultados R1 e R2.
* Use a biblioteca MATH.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_5" disponível na solução

6) Crie uma aplicação, que demonstre a diferença entre REF e OUT.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_6" disponível na solução

7) Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_7" disponível na solução

8) Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_8" disponível na solução

9) Utilizando a biblioteca LINQ crie no console e execute:
* Crie uma lista que receba inteiros.
* Imprimir todos os números da lista.
* Imprimir todos os números da lista na ordem crescente.
* Imprimir todos os números da lista na ordem decrescente.
* Imprima apenas o primeiro número da lista
* Imprima apenas o ultimo número da lista
* Insira um numero no inicio da lista.
* Insira um numero no final da lista.
* Remova o primeiro número .
* Remova o ultimo número .
* Retorne apenas os número pares.
* Retorne apenas o número informado.
* Transforme todos os numero da lista em um array.
> Resposta:  Exercício resolvido na projeto "ConsoleExercicio_9" disponível na solução

### Utilizando POO

1) Responda e demonstre no código os itens abaixo:
* O que é POO?
* O que é polimorfismo?
* O que é abstração?
* O que é encapsulamento?
* Quando usar uma classe abstrata e quando devo usar uma interface?
* O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
* Existe herança múltipla (de classes) em C#?
> Resposta:  Exercício resolvido na projeto "ExercicioPOO_1" disponível na solução

2) Crie uma classe para representar uma pessoa
* Crie os atributos privados de nome, data de nascimento e altura.
* Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa.
* Crie um método para calcular a idade da pessoa.
* Imprima os dados via console.
> Resposta:  Exercício resolvido na projeto "ExercicioPOO_2" disponível na solução

3) Faça uma aplicação bancaria.
* Crie uma classe abstrata Conta Bancaria que contém como atributos, numero da conta e o saldo, e como métodos abstratos sacar e depositar que recebem um parâmetro do tipo double.
* Crie as classes Conta Corrente e Conta Especial que herdam da Conta Bancaria.
* A Conta Corrente possui um atributo taxaDeOperação que é descontado sempre que um saque e um depósito são feitos.
* A Conta Especial possui um atributo limite que dá credito a mais para o correntista caso ele precise sacar mais que o saldo. Neste caso, o saldo pode ficar negativo desde que não ultrapasse o limite. Contudo isso não pode acontecer na classe Conta Corrente.
* Crie uma interface Imprimível que declara um método MostrarDados, implemente em ambas contas e imprima os dados em cada uma.
* Via console, abra 2 contas de cada tipo execute todas as operações.
> Resposta:  Exercício resolvido na projeto "ExercicioPOO_3" disponível na solução

4) Crie uma classe Televisão e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle de volume permite:
* Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez.
* Aumentar e diminuir o número do canal em uma unidade.
* Trocar para um canal indicado.
*Consultar o valor do volume de som e o canal selecionado.
* Imprima os dados via console.
> Resposta:  Exercício resolvido na projeto "ExercicioPOO_4" disponível na solução

### Trabalhando com testes
1) Quais os principais frameworks que podemos usar no desenvolvimento de testes?
> Resposta: Os principais frameworks de teste de unidade que temos disponível no .NET Core são os frameworks xUnit, NUnit e MSTest

2) Escolha dois frameworks e faça testes unitários para pelo menos dois exercícios em cada framework.
> Resposta:  Para este exercício foram escolhidos os frameworks xUnit e nUnit conforme tabela abaixo

| Framework | Nome do Projeto |
| --------- | --------------- |
| nUnit     | ExercicioPOO_2_NUnitTests |
| nUnit     | ExercicioPOO_3_NUnitTests |
| xUnit     | ExercicioPOO_2_XUnitTests |
| xUnit     | ExercicioPOO_3_XUnitTests |