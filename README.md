### Requisitos

 Arquitetura em camadas



Como visto em aula, é uma boa prática dividirmos a nossa aplicação em camadas. 
Por isso, o seu projeto deve conter: 

             **Camada de comunicação**

          **Camada de regras de negócios**

---

<aside> Dados e campos sugeridos



Uma tarefa deverá ter os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
- Uma data limite para tarefa ser realizada;
- Um status.
*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*

---

 Endpoints necessários


- Deve ser possível criar uma tarefa;
- Deve ser possível visualizar todas as tarefas criadas;
- Deve ser possível visualizar uma tarefa buscando pelo seu id;
- Deve ser possível editar informações de uma tarefa;
- Deve ser possível excluir uma tarefa.
