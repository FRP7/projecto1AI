# Relatório

**Francisco Pires a21804873**

**Nuno Figueiredo a21705451**


### **Quem fez o quê?**

**Github** : [https://github.com/FRP7/projecto1AI](https://github.com/FRP7/projecto1AI)

**Francisco Pires:**

- --Construção de cenário.
- --Implementação da Nav Mesh do Unity.
- --Criação de Spawn de agentes.
- --Criação da state machine principal.
- --Criação das states machines para fome e cansaço.
- --Criação do comportamento dos agentes no concerto.
- --Criação do comportamento dos agentes nos espaços verdes (sem sucesso).
- --Explosão básica (sem animação e spawn point).
- --Redação deste relatório

**Nuno Figueiredo:**

- --Acabou o comportamento dos agentes nos espaços verdes.
- --Criação do sistema timer de fome e cansaço.
- --Criação do comportamento dos agentes na zona da restauração.
- --Correcção no spawn de agentes.
- --Criação de UI para ver agente on click.
- --Finalização da explosão e UI para mostrar o número de mortos e dos que escaparam.



### **Introdução**

##

Na disciplina de Inteligência Artificial na licenciatura em Videojogos na Universidade Lusófona de Humanidades e Tecnologias foi nos desafiado um projecto em que teríamos que criar uma simulação de um festival de música (por exemplo, o Rock in Rio). Nesse mesmo projeto teríamos que ter um cenário em que nele estariam pelo menos dois palcos, duas zonas de restauração, dois espaços verdes e pelo menos cem agentes funcionais. Os agentes teriam que estar nos palcos o mais próximo possível deles e teriam um contador de fome e cansaço.

- -- **Fome** : Quando o contator da fome chegasse ao fim, o agente teria que ir para a zona da restauração comer e lá teria que encontrar uma mesa o mais vazia possível, sentar nela e ficar um bocado lá e depois voltar ao palco.

- -- **Cansaço** : Quando o contador do cansaço chegasse ao fim, o agente teria que ir para os espaços verdes descansar e lá iria procurar por um canto com menos gente e ficar lá quieto a descansar.



Depois na simulação teria explosões e elas matariam agentes e espalhariam fogo pelo cenário. Após a explosão os agentes teriam que fugir em pânico para a saída.

Este projecto teria que ser feito em Unity na linguagem C# e tanto o Francisco Pires e o Nuno Figueiredo não eram muito experientes em programação e muito menos virada para inteligência artificial. O resultado acabou por ser positivo porque conseguiram acabar o projecto com mínimo pesquisa possível.

Para pesquisa, o Francisco pesquisou informação básica na documentação de C# da Microsoft e Unity technologies e teve que ir a dois fóruns procurar por duas soluções para dois problemas que não conseguia resolver:

Aceder a todos os scripts em todos os objectos: [stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity](http://stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity)

Destruir os objectos com tag mais facilmente: [https://forum.unity.com/threads/destroy-gameobject-with-tag.64856/](https://forum.unity.com/threads/destroy-gameobject-with-tag.64856/)



### **Metodologia**

**Componentes:**

Este projecto foi feito em Unity, escrito em C# e em 3D.

Usámos o movimento cinemático mas todos os agentes têm um rigidbody.

Usámos como pathfinder o NavMesh do Unity.

Primeiro o Francisco criou 3 máquinas estados: um principal, um para a fome e outro para o cansaço. Essas máquinas de estado foram feitas através de Switch e controladas através de uma variável integer para cada máquina que nela poderíamos mudar de estado mudando o seu valor.

**Fome e cansaço:**

Cada agente possui um nível de fome e de cansaço. Quando o nível de fome chega a 0 o agente vai se dirigir para a zona de restauração. Após a sua chegada o agente vai calcular qual a mesa e cadeira ideal. A mesa ideal corresponde à mesa que tem menos agentes e a cadeira ideal corresponde à cadeira que se encontra mais longe dos restantes agentes na mesma mesa. Quando um agente se senta numa das cadeiras esta cadeira será marcada para os outros agentes como ocupada até este terminar a sua refeição. Quando o nível de cansaço chega a 0 o agente vai se dirigir para a zona do jardim. Após a sua chegada o agente vai calcular a zona mais isolada do jardim, sendo esta calculada usando o número atual de quantos agentes estão em cada zona.
 

Este flowchart explica bem como funciona o agente quando está na área da restauração: https://imgur.com/yNXmP7X


[![](https://i.imgur.com/yNXmP7X.png)](https://i.imgur.com/yNXmP7X.png)




Este flowchart explica bem como funciona o agente quando está nos espaços verdes: https://imgur.com/wXwY3TW

[![](https://i.imgur.com/wXwY3TW.png)](https://i.imgur.com/wXwY3TW.png)





**Máquinas de estado:**

Primeiro o Francisco criou 3 máquinas estados: um principal, um para a fome e outro para o cansaço. Essas máquinas de estado foram feitas através de Switch e controladas através de uma variável integer para cada máquina para assim podermos mudar de estado mudando o seu valor (no caso da principal, 1 seria a fome, 2 seria o cansaço, 3 a explosão e o 0 seria o concerto).

Temos aqui uns flowcharts para explicar com maior facilidade o funcionamento das máquinas de estado.

Este flowchart é a máquina de estado principal, ela trata da mudança para a máquina de estado da fome ou do cansaço.

https://imgur.com/uklHyYJ

[![](https://i.imgur.com/uklHyYJ.png)](https://i.imgur.com/uklHyYJ.png)
 
Quando o agente vai para a porta da restauração ou aos espaços verdes, o máquina liga a máquina de estado da fome ou de cansaço.

Este flowchart é a máquina de estado da fome: https://imgur.com/95KYh9e

[![](https://i.imgur.com/95KYh9e.png)](https://i.imgur.com/95KYh9e.png)

Quando inicia, o Agente primeiro procura por um lugar livre, após encontrar um, senta-se nele e come. Após comer, volta ao concerto, voltando assim à máquina de estado inicial.



Este flowchart é a máquina de estado do cansaço: https://imgur.com/d4AZ9nz

[![](https://i.imgur.com/d4AZ9nz.png)](https://i.imgur.com/d4AZ9nz.png)

Após o Agente chegar à zona dos espaços verdes, a máquina de estado do cansaço é iniciado. Primeiro o agente procura por um espaço livre e após encontrar um, vai para lá e depois fica lá um bocado para descansar. Após descansar. volta ao concerto e lá volta à máquina de estado inicial.





**Explosão:**

Após o utilizador carregar na tecla &quot;Space&quot; uma explosão vai ocorrer no centro do concerto e todos os agentes irão se tentar dirigir para a saída. Esta Explosão inicial mata qualquer agente que lhe toque. Após a explosão inicial haverá um outro elemento mortal, o fogo, este espalhar-se-há pelo cenário todo, resultando na morte de todos os agentes que não cheguem à saída.



### **Resultados e discussão**

1. 1)Às vezes no início da simulação, alguns agentes vinham primeiro para lugares onde não deviam estar por algum tempo e depois voltavam à zona inicial (os palcos). Não sabemos o que causa isso, mas é capaz de ser um bug na NavMesh do Unity e até agora não nos foi prejudicial.

1. 2)Por motivos que desconhecemos, os agentes andam meio enterrados no chão durante a simulação. Já experimentamos retirar o RigidBody deles ou mexer nos Colliders do chão mas infelizmente não tivemos sucesso. Especulamos que seja de novo um bug na NavMesh do Unity e verdade seja dita, nunca foi realmente prejudicial na simulação aliás, é difícil de se perceber isso quando vê a build.

1. 3)Na zona dos palcos, os agentes que estão a assistir aos espectáculos ficam a girar de volta do centro do objecto que têm de seguir. Achámos divertido porque apesar de não ser suposto à primeira isso acontecer parece bastante com a dança do &quot;Mosh Pit&quot; que é muito comum em concertos de Metal e Hardcore.

1. 4)Achamos o movimento dos agentes bastante semelhante ao das formigas mas também pode resultar da falta de modelos 3D realistas.

1. 5)Para melhor análise da simulação, achamos que 100 agentes é o número ideal. Em termos de realismo, 200 agentes é o número ideal, se forem mais, quantos mais forem mais estranho fica a simulação por exemplo, os agentes excessivos no palco posicionam-se de maneira estranha.



### **Conclusões**

Acabámos por conseguir cumprir praticamente todos os pontos propostos no projecto e ainda colocámos a possibilidade de o utilizador ver o nível de fome e cansaço caso clique num agente qualquer.

Apesar das nossas dificuldades em programação, conseguimos programar praticamente todas as funcionalidades necessárias sem recorrer a código do professor da disciplina ou de outras pessoas (excepto nos dois pontos assinalados na introdução e no uso da NavMesh do Unity) e conseguimos criar uma máquina de estados de raiz também sem recorrer a código externo ou tutoriais.

Aprendemos bastante também a trabalhar em equipa tanto a nível de comunicação e de gestão de projecto por Git como também aprendemos a programar o nosso código de forma a facilitar os merges e a compreensão por parte dos membros do grupo.

E por fim, aprendemos bastante a programar através de tentativa e erro e de pesquisa na documentação C# da Microsoft e do Unity.

### **Agradecimentos**

Agradecemos à documentação C# da Microsoft: [https://docs.microsoft.com/en-us/dotnet/csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/)

Agradecemos à documentação C# do Unity:

[https://docs.unity3d.com/ScriptReference/](https://docs.unity3d.com/ScriptReference/)

E por fim agradecemos ao professor Nuno Fachada por nos ter desafiado com este projecto e pela matéria e código exemplo que tem fornecido.



### **Referências**



Unknown. (2013). Accessing a script on all objects with tag in Unity, from [stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity](http://stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity)

moonjump. (2010). Destroy gameObject with tag, from: [https://forum.unity.com/threads/destroy-gameobject-with-tag.64856/](https://forum.unity.com/threads/destroy-gameobject-with-tag.64856/)

Microsoft. (2000). C# documentation, from:

[https://docs.microsoft.com/en-us/dotnet/csharp/](https://docs.microsoft.com/en-us/dotnet/csharp/)

Unity Technologies. (2005). Scripting API, from:

[https://docs.unity3d.com/ScriptReference/](https://docs.unity3d.com/ScriptReference/)