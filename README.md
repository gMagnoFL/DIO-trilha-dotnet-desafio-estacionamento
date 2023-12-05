# DIO - Trilha .NET - Fundamentos
## Desafio de projeto
Desafio proposto para exercitar os conhecimentos adquiridos no módulo de "fundamentos do C#" da trilha .NET da DIO.me. Foram usados conceitos como manipulação de listas, operações aritméticas, condicionais, estruturas de repetição, conversões de tipos, classes, instâncias e tratamento de exceções.

## Contexto
Construir um sistema para um estacionamento, para gerenciar os veículos estacionados e realizar operações básicas: adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos estacionados.

## Proposta
Construir uma classe chamada "Estacionamento":

![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

**Atributos:**

- ***precoInicial***: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

- ***precoPorHora***: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

- ***veiculos***: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.


**Métodos**

- ***AdicionarVeiculo***: recebe uma placa digitada pelo usuário.

- ***RemoverVeiculo***: verifica se um determinado veículo está estacionado, e caso positivo, calcula o valor a ser pago pelo cliente.

- ***ListarVeiculos***: Lista todos os veículos presentes atualmente no estacionamento.



**Por último, construir um menu interativo** com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar
