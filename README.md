# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto 
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.


## Resolução do projeto
No método "AdicionarVeiculo()" foi feita a implementação da lógica de receber uma placa e ver se está enquadrada no padrão de placas do Mercosul. Ex: AAA-1111 ou AAA1A11. Caso não esteja em conformidade com o padrão, um erro é retornado.

No método "RemoverVeiculo()" foi implementada a verificação da placa de carros, na lista veiculos; além da verificação do cálculo de horas e do preço final, sendo definido por "valorTotal = precoInicial + precoPorHora * horas;" e com as horas assumindo o valor passado em totalHoras.

Por fim, em "ListarVeiculos()", foi aplicado um laço foreach iterando em cima de cada item na lista de veículos, imprimindo uma saída separada por placas.

TODO List:

- [x] implementar o cadastro dos veículos por placa
- [x] pedir para o usuário incluir a placa e o total de horas que o veículo ficou estacionado.
- [x] remover a placa e analisar qual o total pago pelo tempo de uso do estacionamento.
- [x] listar os veículos disponíveis utilizando um laço de repetição.

