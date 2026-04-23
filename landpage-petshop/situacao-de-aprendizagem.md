# Situação de Aprendizagem — Manutenção de Software Web

**Unidade Curricular:** UC-09 — Atualização e Manutenção de Software  
**Nível:** Técnico em Desenvolvimento de Sistemas  
**Duração estimada:** 4 horas/aula  
**Pré-requisitos:** HTML, CSS (Tailwind), JavaScript básico  

---

## 🎯 Objetivo da Atividade

Colocar o aluno no papel de um **profissional web júnior** em uma agência de desenvolvimento, que recebe a demanda de manutenção de um site já produzido por outro desenvolvedor (mais inexperiente).

O aluno deverá:
1. Ler a ata de reunião entre o cliente e o gerente da agência
2. Identificar quais relatos correspondem a **Bugs** (defeitos a corrigir)
3. Identificar quais relatos correspondem a **Features** (funcionalidades novas a implementar)
4. Abrir **Issues** no repositório para cada item identificado
5. Corrigir o código e registrar as alterações

---

## 📁 Estrutura do Projeto

```
manutencao-petshop/
├── index.html       ← Landing page do pet shop (com problemas)
├── style.css        ← Estilos da página
├── app.js           ← Scripts JavaScript
└── imagens/         ← Pasta de imagens (incompleta!)
```

---

## 📖 Contexto

A agência **WebCraft Soluções Digitais** desenvolveu uma landing page para o **Pet Shop Patas Felizes**, localizado em Florianópolis/SC. O projeto foi entregue por João, um estagiário, que foi responsável por todo o desenvolvimento.

Após a entrega, o dono do pet shop, **Sr. Roberto Abreu**, marcou uma reunião com **Marina Costa**, gerente de projetos da agência, para passar um retorno sobre o site. A seguir está a ata desta reunião.

---

## 🗒️ ATA DE REUNIÃO

---

**ATA DE REUNIÃO — REVISÃO DO SITE PATAS FELIZES**

**Data:** 22 de março de 2024  
**Local:** Escritório da WebCraft Soluções Digitais — Sala de Reuniões 2  
**Horário de Início:** 14h00  
**Horário de Encerramento:** 15h20  

**Participantes:**
- **Roberto Abreu** — Cliente / Proprietário do Pet Shop Patas Felizes
- **Marina Costa** — Gerente de Projetos / WebCraft Soluções Digitais
- **Ana Ferreira** — Assistente de Projetos / WebCraft Soluções Digitais (registrou a ata)

---

### 1. Abertura

Marina Costa iniciou a reunião agradecendo a presença do Sr. Roberto e reforçando o compromisso da WebCraft com a satisfação do cliente. Em seguida, cedeu a palavra ao cliente para que expressasse seu retorno sobre o site entregue.

---

### 2. Retorno do Cliente

O Sr. Roberto Abreu relatou os seguintes pontos:

---

**2.1 — Nome errado no título da aba do navegador**

> *"Olha, a primeira coisa que eu notei foi que quando eu abro o site num computador, lá em cima, na abinha do navegador, aparece escrito 'PatasFelizes' tudo junto, sem espaço. Fica feio e parece erro de digitação. O nome correto é 'Patas Felizes', com espaço."*

Marina anotou o ponto.

---

**2.2 — Texto com erros de português**

> *"Quando eu fui ler o textinho de apresentação ali na parte de cima da página, tava cheio de erro de português. Eu trouxe até um papel aqui anotado. Olha: tá escrito 'proficionalismo' em vez de 'profissionalismo'. Depois mais embaixo tem 'adestradore' sem o 's' no final. E tem um trecho que fala 'atendemos cãe' sem o 's'. São erros básicos mesmo, de digitação."*

---

**2.3 — Imagens quebradas em todo o site**

> *"Isso foi o que mais me chateou, sinceramente. Quando eu abri o site pra mostrar pra minha esposa, não aparecia nenhuma foto. A logo, a foto grande do início, as fotinhas dos clientes nos depoimentos... tudo com aquele ícone de imagem quebrada. Fica muito feio, parece que o site não foi terminado."*

Marina pediu desculpas e explicou que provavelmente os arquivos de imagem não foram enviados junto com os arquivos do site, e que investigaria o ocorrido com o desenvolvedor.

---

**2.4 — Botão de agendamento quase invisível**

> *"Tem um botão ali na parte de cima, pra agendar uma visita. Mas o botão é amarelo claro com uma letra que também é amarelinha... eu mal consigo ler o que tá escrito. Minha mãe que tem 67 anos tentou usar o site e disse que não enxergava nada no botão. Precisa melhorar isso pra ficar mais fácil de ler."*

---

**2.5 — O texto da seção 'Quem Somos' está sumindo no fundo**

> *"Na parte do 'Quem Somos', o texto explica tudo sobre a empresa, mas a cor tá tão clarinha que eu mal consigo ler. É cinza clarinho no fundo branco. Parece que não tem nada escrito ali. Até achei que tivesse em branco quando vi pela primeira vez."*

---

**2.6 — Horário de funcionamento inconsistente**

> *"Outro ponto: tem dois lugares no site onde aparece o horário que a gente funciona, e eles estão diferentes. Num lugar tá escrito 'das 8h às 18h' e em outro tá 'das 9h às 19h'. Qual dos dois tá certo? O certo é das 9h às 19h. Se o cliente ligar tentando falar com a gente às 8h da manhã, não vai ter ninguém pra atender."*

---

**2.7 — E-mail de contato com domínio errado**

> *"O email que tá no site, 'contato@patasfelizes.com.rb', não existe. O certo é '.com.br'. Alguém que tentar nos mandar um email por ali vai receber erro. Isso é grave, porque a gente pode estar perdendo clientes sem saber."*

---

**2.8 — Telefone de contato está incorreto**

> *"O telefone que aparece no site é '(48) 0000-0000'. Isso não é número real, parece que o dev esqueceu de colocar o número verdadeiro. O número correto é (48) 3232-4545."*

---

**2.9 — Ano de copyright desatualizado no rodapé**

> *"Lá embaixo no rodapé tá escrito '© 2021'. Já faz três anos! Isso passa uma impressão que o site tá abandonado e desatualizado."*

---

**2.10 — Formulário de contato não está funcionando**

> *"Eu mesmo testei a parte de 'Entre em Contato'. Preenchi tudo e cliquei no botão de enviar, e nada aconteceu. Nem mensagem de erro, nem de sucesso. O formulário simplesmente não faz nada. Isso é sério, porque a gente depende muito do formulário para conseguir novos clientes."*

---

**2.11 — Seção de serviços está vazia**

> *"Essa daqui foi a que mais me pegou de surpresa. A gente conversou desde o começo que ia ter uma seção com os nossos serviços — banho e tosa, consulta veterinária, hotel para pets, adestramento, loja de produtos, vacinação. Eu até mandei a lista por e-mail. Mas quando eu acessei o site, a seção de serviços tá escrito só 'Serviços em breve...' Parece loja que nunca abre. Os clientes precisam saber o que a gente oferece."*

Marina registrou o ponto e confirmou que a seção foi planejada desde o início do projeto.

---

**2.12 — Falta de menu mobile (hamburger)**

> *"Outro ponto que a minha sobrinha comentou: ela acessou o site pelo celular e o menu ficou todo espremido, com as palavras saindo da tela. Não tem aquele botão de menu hambúrguer que abre e fecha no celular. Hoje em dia a maioria das pessoas acessa pelo celular, né? Precisa funcionar bem no celular."*

Marina agradeceu o feedback e prometeu que o próximo acesso ao site, após as correções, seria feito em múltiplos dispositivos para validação.

---

**2.13 — Solicitação de nova funcionalidade: Seção de Galeria de Fotos**

> *"Uma coisa que eu queria muito adicionar no site, e que a gente não tinha conversado ainda, é uma galeria de fotos dos nossos pets que foram atendidos aqui. Os donos adoram ver as fotinhas depois do banho e da tosa. Ia ser um diferencial e daria mais vida ao site. Dá pra adicionar isso?"*

Marina informou que seria avaliada a viabilidade e custo da inclusão.

---

**2.14 — Solicitação de nova funcionalidade: Sistema de Agendamento Online**

> *"Outra coisa: hoje os clientes me ligam ou mandam WhatsApp pra agendar. Seria incrível ter um sistema direto no site onde o cliente escolhe o serviço, o dia e o horário. Tipo um calendário online. Isso ia facilitar muito a vida de todo mundo e eu conseguiria gerenciar melhor os atendimentos."*

Marina informou que essa funcionalidade demandaria um estudo técnico mais aprofundado e poderia ser discutida em uma segunda reunião.

---

**2.15 — Solicitação de nova funcionalidade: Integração com WhatsApp**

> *"Também queria um botão flutuante de WhatsApp no site. Sabe aquele botãozinho verde que fica no canto da tela? Muita gente prefere falar pelo WhatsApp do que preencher formulário. Colocar isso seria bem simples, não é?"*

Marina confirmou que seria uma adição simples e anotou como demanda para o desenvolvedor.

---

### 3. Encaminhamentos

Ao final da reunião, ficou acordado que:

- A equipe técnica da WebCraft irá analisar todos os itens levantados pelo cliente
- Os itens serão organizados em um sistema de controle de versão (Issues no GitHub)
- Cada item receberá uma prioridade: **Alta**, **Média** ou **Baixa**
- O prazo de entrega das correções e melhorias urgentes será de **5 dias úteis**

---

### 4. Próxima Reunião

Ficou agendada uma nova reunião para **29 de março de 2024**, às 14h00, para apresentação das correções e discussão das novas funcionalidades solicitadas.

---

**Assinaturas:**

Marina Costa — Gerente de Projetos / WebCraft  
Roberto Abreu — Proprietário / Pet Shop Patas Felizes  

*Ata registrada por: Ana Ferreira — Assistente de Projetos / WebCraft*

---

---

## ✅ Parte Prática — O Que o Aluno Deve Fazer

### 🔍 Etapa 1 — Leitura e Análise da Ata (Individual)

Leia atentamente a ata acima e, para cada item relatado pelo Sr. Roberto, classifique:

| # | Descrição Resumida | Tipo (Bug ou Feature) | Prioridade Sugerida |
|---|---|---|---|
| 2.1 | | | |
| 2.2 | | | |
| 2.3 | | | |
| 2.4 | | | |
| 2.5 | | | |
| 2.6 | | | |
| 2.7 | | | |
| 2.8 | | | |
| 2.9 | | | |
| 2.10 | | | |
| 2.11 | | | |
| 2.12 | | | |
| 2.13 | | | |
| 2.14 | | | |
| 2.15 | | | |

> **Dica:** Um **Bug** é algo que deveria funcionar mas está quebrado ou errado. Uma **Feature** é uma funcionalidade nova que o cliente está solicitando adicionar.

---

### 🐛 Etapa 2 — Criação de Issues (Em Dupla)

Utilizando o repositório disponibilizado pelo professor no GitHub:

1. Acesse a aba **Issues** do repositório
2. Para cada item identificado como **Bug**, crie uma Issue com:
   - **Título:** claro e objetivo (ex: `[BUG] Imagens quebradas no site`)
   - **Label:** `bug`
   - **Descrição:** onde está o problema, qual o comportamento esperado
3. Para cada item identificado como **Feature**, crie uma Issue com:
   - **Título:** (ex: `[FEATURE] Adicionar seção de galeria de fotos`)
   - **Label:** `enhancement`
   - **Descrição:** o que o cliente solicitou e como poderia ser implementado

---

### 🛠️ Etapa 3 — Correção dos Bugs (Em Dupla)

Após criar todas as Issues, corrija os bugs no código:

1. Clone o repositório localmente
2. Para cada bug a ser corrigido:
   - Crie um **branch** com o nome do bug (ex: `fix/imagens-quebradas`)
   - Faça a correção no código
   - Faça o commit referenciando a Issue (ex: `git commit -m "fix: corrige caminho das imagens - closes #3"`)
   - Abra um **Pull Request** para a branch principal

> **⚠️ Atenção:** Não corrija todos os bugs em um único commit. Cada bug deve ser corrigido em seu próprio branch e Pull Request.

---

### 🚀 Etapa 4 — Implementação de Feature (Opcional / Avançado)

Escolha **UMA** das features solicitadas e implemente-a no código:

- **Opção A:** Grade de Serviços (cards com ícones e descrição)
- **Opção B:** Botão flutuante de WhatsApp
- **Opção C:** Menu hambúrguer para mobile

---

## 📊 Gabarito — Classificação dos Itens

> *(Para uso exclusivo do professor — não revelar antes da etapa 1)*

<details>
<summary>Clique para revelar o gabarito</summary>

| # | Descrição | Tipo | Justificativa |
|---|---|---|---|
| 2.1 | Nome errado na aba do navegador | **Bug** | O `<title>` no HTML está incorreto — problema de conteúdo |
| 2.2 | Erros de português no texto | **Bug** | Texto incorreto no HTML — deve ser corrigido |
| 2.3 | Imagens quebradas | **Bug** | Arquivos de imagem ausentes — problema de entrega |
| 2.4 | Botão com baixo contraste | **Bug** | Problema de acessibilidade — viola WCAG 2.1 |
| 2.5 | Texto cinza claro sobre branco | **Bug** | Problema de acessibilidade — cor `gray-300` ilegível |
| 2.6 | Horário inconsistente | **Bug** | Dois valores diferentes no mesmo site — inconsistência |
| 2.7 | Domínio de e-mail errado | **Bug** | `.com.rb` ao invés de `.com.br` — dado errado |
| 2.8 | Telefone placeholder | **Bug** | Número fictício não substituído — dado inválido |
| 2.9 | Ano desatualizado no footer | **Bug** | Copyright hardcoded com ano errado |
| 2.10 | Formulário não funciona | **Bug** | Erro de JS — ID do formulário incorreto no `getElementById` |
| 2.11 | Seção de serviços vazia | **Bug** | Foi combinada com o cliente e não foi entregue — entrega incompleta |
| 2.12 | Menu sem responsividade | **Bug** | Falta o comportamento mobile que deveria ter sido incluído |
| 2.13 | Galeria de fotos | **Feature** | Funcionalidade nova, não discutida no escopo original |
| 2.14 | Agendamento online | **Feature** | Novo sistema, fora do escopo original |
| 2.15 | Botão de WhatsApp | **Feature** | Funcionalidade nova solicitada pelo cliente |

</details>

---

## 📚 Conceitos Revisados

| Conceito | Definição |
|---|---|
| **Bug** | Comportamento incorreto em uma funcionalidade que deveria estar funcionando |
| **Feature** | Nova funcionalidade que o sistema ainda não possui |
| **Issue** | Registro de um problema ou melhoria em um sistema de controle (ex: GitHub Issues) |
| **Label** | Etiqueta usada para categorizar Issues (ex: `bug`, `enhancement`, `documentation`) |
| **Branch** | Ramificação do código para desenvolver algo isoladamente |
| **Pull Request** | Solicitação para mesclar um branch com a branch principal após revisão |
| **Acessibilidade (A11y)** | Capacidade do site ser usado por pessoas com diferentes necessidades (visuais, motoras etc.) |
| **Contraste WCAG** | Padrão internacional que define a relação mínima de contraste entre texto e fundo |

---

*Situação de Aprendizagem elaborada para a UC-09 — Atualização e Manutenção de Software | SENAC*
