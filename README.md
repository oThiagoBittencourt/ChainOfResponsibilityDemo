# Chain of Responsibility em C#

Este projeto demonstra o uso do padrão de projeto **Chain of Responsibility (Cadeia de Responsabilidade)** em um cenário fictício de suporte técnico.

---

## Sobre o projeto

O sistema simula uma cadeia de atendimento com três níveis:
- **Atendente**: resolve problemas simples.  
- **Supervisor**: resolve problemas moderados.  
- **Gerente**: resolve problemas críticos.  

Se um nível não conseguir resolver o problema, ele o encaminha para o próximo na cadeia.  
Toda a construção da sequência é feita pela classe `SuporteHandlerFactory`, de forma encapsulada — o programador usa apenas o ponto de entrada retornado por ela.

---

## O que é Chain of Responsibility

O **Chain of Responsibility** é um padrão de projeto comportamental que permite passar uma requisição por uma cadeia de manipuladores (handlers).  
Cada manipulador decide se trata o pedido ou o encaminha para o próximo da cadeia, promovendo **desacoplamento** entre o emissor e o receptor da requisição.
