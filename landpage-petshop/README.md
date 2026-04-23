# 🐾 Exercício — Manutenção de Site: Pet Shop Patas Felizes

> **Nível:** Técnico em Desenvolvimento de Sistemas  
> **Unidade Curricular:** UC-09 — Atualização e Manutenção de Software

---

## 📋 Sobre o Exercício

Este exercício simula o **dia a dia de uma agência de desenvolvimento web**, onde um profissional júnior recebe a tarefa de dar manutenção em um site que foi entregue com problemas.

O site está propositalmente cheio de erros para que os alunos pratiquem a identificação e correção de problemas reais.

---

## 📁 Arquivos

| Arquivo | Descrição |
|---|---|
| `index.html` | Landing page do pet shop com bugs propositais |
| `style.css` | Estilos com alguns problemas de acessibilidade |
| `app.js` | JavaScript com erros de lógica e DOM |
| `imagens/` | Pasta de imagens **vazia** (causando imagens quebradas) |
| `situacao-de-aprendizagem.md` | **Ata de reunião + instruções para os alunos** |

---

## 🐛 Resumo dos Bugs Propositais

| ID | Localização | Tipo de Problema |
|---|---|---|
| BUG-01 | `<html lang="pt">` | `lang` incorreto, deveria ser `pt-BR` |
| BUG-02 | `<title>` | "PatasFelizes" sem espaço |
| BUG-03 | `<img src="imagens/logo-pet.png">` | Arquivo de imagem ausente |
| BUG-04 | `<h1>` | Texto apenas sobre cães, ignora outros pets |
| BUG-05 | Parágrafo hero | Erros de português: "proficionalismo", "cãe", "peludos" (plural errado) |
| BUG-06 | Botão CTA + submit | `bg-yellow-300 text-yellow-100` — baixo contraste (acessibilidade) |
| BUG-07 | `<img src="imagens/hero-pet.jpg">` | Arquivo de imagem ausente |
| BUG-08 | Imagem hero | `alt=""` vazio em imagem informativa (acessibilidade) |
| BUG-09 | Seção "Quem Somos" | `text-gray-300` sobre fundo branco — contraste insuficiente |
| BUG-10 | Texto "Quem Somos" | "adestradore" sem "s" |
| BUG-11 | Seção "Quem Somos" | Horário "8h às 18h" (diferente do contato: "9h às 19h") |
| BUG-12 | `<img src="imagens/cliente1.jpg">` | Arquivo de imagem ausente |
| BUG-13 | Depoimentos | `text-gray-300` em fundo amarelo claro — baixo contraste |
| BUG-14 | Seção Contato | Horário "9h às 19h" (inconsistente com "Quem Somos") |
| BUG-15 | `<label for="email">` | `for` não corresponde ao `id="e-mail"` do input |
| BUG-16 | Endereço | CEP fictício "88000-000" não removido |
| BUG-17 | Telefone | "(48) 0000-0000" placeholder não substituído |
| BUG-18 | E-mail | ".com.rb" ao invés de ".com.br" |
| BUG-19 | Footer | Ano "2021" hardcoded, desatualizado |
| BUG-20 | `app.js` | `getElementById('form-contato')` — ID errado (HTML usa `formContato`) |
| BUG-21 | `app.js` | Validação de e-mail incompleta |
| BUG-22 | `app.js` | Mensagem de sucesso mas e-mail destino está errado |
| BUG-23 | `app.js` | Lógica de menu ativo não desconta altura do header sticky |

## 🚀 Feature Ausente (proposital)

- **FEATURE:** Seção de Serviços — O `<section id="servicos">` existe mas está vazio. O CSS para os cards existe em `style.css` (`.service-card`) mas os cards não foram adicionados ao HTML.

---

## 📖 Como Usar em Aula

1. **Distribua o repositório** para os alunos (fork ou clone)
2. **Peça que leiam** o arquivo `situacao-de-aprendizagem.md`
3. **Classifiquem** cada item da ata como Bug ou Feature (etapa 1)
4. **Criem Issues** no GitHub para cada item (etapa 2)
5. **Corrijam os bugs** em branches separados com PRs (etapa 3)
6. **Opcionalmente**, implementem uma Feature (etapa 4)

---

*Exercício elaborado para UC-09 | SENAC Linhares*
