# DESIGNPATTERNCOMMAND
DESIGN PATTERN COMMAND: O padrão Command é um padrão comportamental do GoF que encapsula uma solicitação como um objeto, permitindo parametrizar clientes com diferentes requisições, enfileirar operações e suportar operações de desfazer (undo).

## 2. Problema que o padrão resolve

###  Sem o uso do Command
- Código fortemente acoplado à interface (`Button.Click`)
- Difícil manutenção
- Baixa reutilização de código

###  Com o uso do Command
- Separação entre interface (UI) e lógica
- Reutilização de ações
- Melhor organização do código

---

## 3. Estrutura do padrão

O padrão Command é composto pelos seguintes participantes:

- **Command (ICommand)** → Interface que define a execução
- **ConcreteCommand (RelayCommand)** → Implementação do comando
- **Receiver (ViewModel)** → Onde a lógica é executada
- **Invoker (Button)** → Elemento que dispara o comando

---

## 4. Justificativa da escolha

O padrão Command foi escolhido pelos seguintes motivos:

- O WPF já possui suporte nativo ao `ICommand`
- Integra-se perfeitamente com o padrão arquitetural MVVM
- Elimina o uso de eventos no *code-behind*
- Promove desacoplamento e organização do sistema

---

## 5. Aplicação no projeto

### Comandos implementados
- `AdicionarCommand`
- `RemoverCommand`

### Execução na View (XAML)
```xml
<Button Command="{Binding AdicionarCommand}" />
<Button Command="{Binding RemoverCommand}" />

---

## 7. Vantagens
- Baixo acoplamento
- Reutilização de código
- Facilidade de manutenção
- Separação de responsabilidades
- Melhor testabilidade

---

## 8. Desvantagens
- Aumento no número de classes
- Maior complexidade inicial
- Pode ser excessivo para projetos pequenos

---

## 9. Exemplos reais de uso
Botões de sistemas (Salvar, Excluir, Atualizar)
Sistemas bancários
Sistemas ERP
Aplicações WPF, Xamarin e MAUI

---

## 10. Análise crítica
O padrão Command é extremamente útil em aplicações com interface gráfica, pois promove organização, desacoplamento e reutilização de código.
No entanto, seu uso em aplicações muito simples pode introduzir uma complexidade desnecessária, sendo importante avaliar o contexto antes de sua aplicação.
