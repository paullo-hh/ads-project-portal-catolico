# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

<img src="../docs/img/Persona1.jpg">

https://g1.globo.com/politica/noticia/2020/01/13/50percent-dos-brasileiros-sao-catolicos-31percent-evangelicos-e-10percent-nao-tem-religiao-diz-datafolha.ghtml acesso em 21/08/2024 às 08:03hs

https://gaudiumpress.org/content/pesquisa-traca-o-perfil-dos-catolicos-no-brasil/ acesso em 21/08/2024 às 08:14hs

https://ideascale.com/pt-br/blogue/definicao-de-mapa-de-persona/ acesso em 21/08/2024 às 13:06hs

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara  | Uma forma de identificar se uma agência é realmente confiável           | Me sentir mais segura ao contratar seus serviços               |
|Ana Clara       | Ter um mecanismo eficiente e rápido de comunicação                 | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas a seguir detalham os requisitos funcionais, não funcionais e restrições do projeto. Para determinar a prioridade de cada requisito, foi utilizado a técnica MoSCoW, que classifica os requisitos em quatro categorias:

<ul>
    <li>Must have (Essenciais): Requisitos indispensáveis para o sucesso do projeto.</li>
    <li>Should have (Importantes): Requisitos importantes, mas que não são críticos.</li>
    <li>Could have (Desejáveis): Requisitos que agregam valor, mas não são prioritários.</li>
    <li>Won’t have (Não necessários agora): Requisitos que podem ser adiados ou excluídos.</li>
</ul>

Cada requisito foi avaliado e categorizado de acordo com seu impacto no objetivo do projeto e nas necessidades dos usuários. A técnica MoSCoW nos permitiu focar nos requisitos mais críticos, garantindo que o projeto atenda suas metas principais dentro dos recursos e prazos disponíveis.

### Requisitos Funcionais

|ID| Descrição                | Prioridade e Justificativa |
|-------|---------------------------------|----|
| RF-01 |  <strong>Busca de igrejas e horários de missas por geolocalização</strong> <p> <li>Implementar uma funcionalidade de busca que permita aos usuários encontrar igrejas e horários de missas baseados na geolocalização.</li> <p> <li>Desenvolver um sistema de CRUD para gerenciamento das informações de igrejas e missas no banco de dados colaborativo.</li> | <strong>Essencial</strong> <p>Principal funcionalidade do portal  | 
| RF-02 |  <strong>Informações de Liturgia e homilia do dia</strong> <p> <li>Exibir diariamente as informações de liturgia e homilia do dia, obtidas por meio de uma API confiável.</li> | <strong>Essencial</strong> <p>Conteúdo diário importante para os usuários.  |
| RF-03 |  <strong>Agenda para eventos das igrejas</strong> <p> <li>Fornecer um formulário para as igrejas divulgarem seus eventos pastorais com um CRUD para gerenciamento dessas informações (gerenciado pelos administradores do site).</li>  | <strong>Importante</strong> <p>Funcionalidade útil, mas não crítica para o projeto | 
| RF-04 |  <strong>Espaço para publicidades pagas</strong> <p> <li>Desenvolver um módulo para exibição de publicidades pagas, com possibilidade de gerenciar anúncios e relatórios de desempenho.</li>  | <strong>Desejável</strong> <p>Pode gerar receita, mas não é prioritário para o lançamento inicial. |
| RF-05 |  <strong>Formulário para Cadastro de Paróquias e Missas</strong> <p> <li>Criar um formulário para que os usuários enviem dados de suas paróquias e horários de missas. As informações serão validadas antes de serem inseridas no banco de dados.</li>  | <strong>Importante</strong> <p>Facilita a expansão do banco de dados de forma colaborativa, com possível suporte da PUC para o fornecimento ou colaboração nas cargas de dados. |

**Prioridade: Essencial (Must have) / Importante (Should have) / Desejável (Could have). 
<br>

### Requisitos não Funcionais

|ID      | Descrição               | Prioridade e Justificativa |
|--------|-------------------------|----|
| RNF-01 |  <strong>Compatibilidade e responsividade</strong> <p> <li>A aplicação deve ser responsiva, adaptando-se a diferentes tamanhos de tela e dispositivos, como celulares, tablets e desktops.</li> | <strong>Essencial</strong> <p>Garantir que o portal funcione bem em todos os dispositivos é crucial para oferecer uma boa experiência de usuário e atender às expectativas modernas de acessibilidade e usabilidade. |
| RNF-02 |  <strong>Santo do dia</strong> <p> <li>Exibir o santo do dia com informações relevantes, sem necessidade de CRUD, utilizando uma fonte estática ou API externa.</li> | <strong>Importante</strong> <p>Relevante para a experiência do usuário, mas não essencial para o funcionamento. |
| RNF-03 |  <strong>Matérias relevantes</strong> <p> <li>Implementar uma área para matérias relevantes com foco em temas católicos, utilizando integração com fontes RSS ou APIs de notícias.</li> | <strong>Desejável</strong> <p>Aumenta o engajamento, mas pode ser adicionado em uma versão posterior. | 


**Prioridade: Essencial (Must have) / Importante (Should have) / Desejável (Could have).  
<br>

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir:

ID      | Restrição               |
|--------|-------------------------|
| 01 | Backend desenvolvido em C#.|
| 02 | Frontend desenvolvido com HTML, CSS e Bootstrap.|
| 03 | Necessidade do uso de pelo menos uma API.|
| 04 | Banco de dados MySQL, com implementação de 2 a 3 CRUD’s (por exemplo, para gestão de igrejas, missas e eventos).|
| 05 | Hospedagem na AWS ou Azure, com integração de SGBD (Sistema de Gerenciamento de Banco de Dados).|
| 06 | Conformidade com a LGPD para proteção de dados pessoais.|
| 07 | Autorização para uso de conteúdo externo, como liturgias e notícias.|

## Diagrama de Casos de Uso

<img src="../docs/img/Diagrama de casos de uso.jpg">
