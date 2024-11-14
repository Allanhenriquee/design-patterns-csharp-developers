# Documentação do Projeto Builder

## Visão Geral

Este projeto implementa o padrão de design Builder para a criação de objetos `OrderSimple`. O objetivo é facilitar a construção de instâncias de pedidos, permitindo que os usuários configurem produtos, métodos de pagamento, descontos, impostos e endereços de entrega de forma fluida e intuitiva.

## Estrutura do Projeto

O projeto é composto por duas classes principais:

1. **OrderSimple**: Representa um pedido simples com propriedades como produtos, método de pagamento, total, desconto, imposto e endereço de entrega.
2. **Program**: Contém a lógica principal para criar e exibir instâncias de `OrderSimple` usando o `OrderSimpleBuilder`.

## Classe `OrderSimple`

### Descrição

A classe `OrderSimple` encapsula as informações de um pedido. O construtor é privado, garantindo que as instâncias só possam ser criadas através do `OrderSimpleBuilder`.

### Propriedades

- `Products`: Lista de produtos incluídos no pedido.
- `PaymentMethod`: Método de pagamento utilizado para o pedido.
- `Total`: Valor total do pedido, incluindo produtos, descontos e impostos.
- `Discount`: Valor do desconto aplicado ao pedido.
- `Tax`: Valor do imposto calculado sobre o total do pedido.
- `ShippingAddress`: Endereço de entrega do pedido.

### Métodos

- `ToString()`: Retorna uma representação em string do pedido, incluindo todos os detalhes.

### Classe Aninhada `OrderSimpleBuilder`

#### Descrição

A classe `OrderSimpleBuilder` é responsável pela construção de instâncias de `OrderSimple`. Ela fornece métodos encadeáveis para adicionar produtos e definir propriedades do pedido.

#### Métodos

- `AddProduct(string product, decimal price)`: Adiciona um produto ao pedido e atualiza o total.
- `SetPaymentMethod(string paymentMethod)`: Define o método de pagamento do pedido.
- `ApplyDiscount(decimal discount)`: Aplica um desconto ao pedido e atualiza o total.
- `CalculateTax(decimal tax)`: Calcula e aplica o imposto ao total do pedido.
- `SetShippingAddress(string address)`: Define o endereço de entrega do pedido.
- `Build()`: Cria e retorna a instância de `OrderSimple` configurada.

## Classe `Program`

### Descrição

A classe `Program` contém a lógica principal para a execução do aplicativo. Ela demonstra como usar o `OrderSimpleBuilder` para criar instâncias de `OrderSimple` e exibir os detalhes do pedido no console.

### Exemplo de Uso

```cs
using BuilderSimple.Console.Models;

var completeOrder = new OrderSimple.OrderSimpleBuilder()
    .AddProduct("Notebook", 1500.00m)
    .AddProduct("Mouse", 50.00m)
    .AddProduct("Teclado", 1000.00m)
    .SetPaymentMethod("Cartão de Crédito")
    .ApplyDiscount(100.00m)
    .CalculateTax(0.08m)
    .SetShippingAddress("Rua, Bairro, Cidade, Estado, Brasil")
    .Build();

Console.WriteLine(completeOrder);
Console.WriteLine();

var simplifiedOrder = new OrderSimple.OrderSimpleBuilder()
    .AddProduct("Celular", 800.00m)
    .SetPaymentMethod("Pix")
    .CalculateTax(0.08m)
    .Build();

Console.WriteLine(simplifiedOrder);
```

