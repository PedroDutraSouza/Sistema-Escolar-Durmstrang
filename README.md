# 📜 Projeto Durmstrang - Sistema Acadêmico

> Um sistema de gerenciamento acadêmico em C\# WinForms para o Instituto Durmstrang, com geração de boletins em PDF (via QuestPDF) e um dashboard de desempenho (via Power BI).

**Status do Projeto:** 🚧 Em Desenvolvimento 🚧

-----

## 📖 Sobre o Projeto

Este é um sistema desktop (Windows Forms) para o gerenciamento acadêmico do Instituto Durmstrang. O objetivo é fornecer uma solução robusta e temática para administrar as operações diárias da escola, desde o registro de novos alunos bruxos até a emissão de seus boletins de desempenho em Artes das Trevas e outras disciplinas.

-----

## 🚀 Funcionalidades Principais

O sistema é dividido em quatro módulos centrais:

### 1\. 🎓 Cadastro de Alunos e Professores

  * Registro completo de informações dos alunos (Nome, Casa, Status de Sangue, Varinha, etc.).
  * Cadastro de corpo docente (Professores e suas disciplinas).
  * Busca rápida, edição e exclusão de perfis.
  * Histórico acadêmico do aluno.

### 2\. 🪄 Gestão de Disciplinas e Notas

  * Criação de disciplinas (Ex: Defesa Contra Artes das Trevas, Transfiguração, Duelos).
  * Lançamento de notas por período letivo.
  * Controle de frequência e faltas nas aulas.

### 3\. 📄 Emissão de Boletins (com QuestPDF)

  * **Geração de boletins em formato PDF** utilizando a biblioteca **QuestPDF**.
  * O layout do PDF é estilizado com o brasão e a identidade visual de Durmstrang.
  * Consolidação automática das notas e frequências do aluno no documento.

### 4\. 📊 Dashboard de Desempenho (com Power BI)

  * Um painel visual (dashboard) apresentando o status da escola.
  * **Integração com dashboard do Power BI** (embutido ou via link) para análise de dados.
  * Visualização de indicadores:
      * Média de notas por Casa.
      * Taxa de aprovação por disciplina.
      * Desempenho geral do Instituto.

-----

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído utilizando as seguintes tecnologias:

  * **Linguagem:** C\#
  * **Plataforma:** .NET Framework (ou .NET 6+)
  * **Interface:** Windows Forms (WinForms)
  * **Banco de Dados:** [*SQL Server ou MySQL*]
  * **Geração de PDF:** **QuestPDF**
  * **Visualização de Dados:** **Power BI**
  * **IDE:** Visual Studio 2022

-----

## 🏁 Como Rodar o Projeto

Siga os passos abaixo para executar o projeto em sua máquina local.

**Pré-requisitos:**

  * Visual Studio 2022 ou mais recente
  * SDK do .NET [*Sua Versão, ex: 6.0*]
  * Um SGBD (Ex: SQL Server Management Studio ou MySQL Workbench/XAMPP)

**Instalação:**

1.  Inicie seu serviço de banco de dados (Ex: MySQL pelo XAMPP ou o serviço do SQL Server).
2.  Acesse seu gerenciador de banco de dados (Ex: `phpMyAdmin` ou `SSMS`).
3.  Crie um novo banco de dados (ex: `db_durmstrang`).
4.  Execute o script de criação do banco (ex: `database.sql`) para gerar as tabelas.
5.  Clone o repositório:
    ```bash
    git clone [https://github.com/seu-usuario/Projeto-Durmstrang.git](https://github.com/seu-usuario/Projeto-Durmstrang.git)
    ```
6.  Abra o arquivo de solução (`.sln`) no Visual Studio.
7.  Configure a *connection string* (string de conexão) com o seu banco de dados no arquivo `App.config`.
      * *Exemplo de connection string para MySQL:*
        ```xml
        <add name="SuaConnectionString" connectionString="Server=localhost;Database=db_durmstrang;Uid=root;Pwd=;" />
        ```
      * *Exemplo de connection string para SQL Server:*
        ```xml
        <add name="SuaConnectionString" connectionString="Server=localhost\\SQLEXPRESS;Database=db_durmstrang;Integrated Security=True;" />
        ```
8.  Pressione `F5` ou clique no botão "Start" para compilar e executar o projeto.

-----

## 📸 Screenshots

*(Adicione aqui screenshots do seu sistema com a temática de Durmstrang\!)*

**Exemplo:**

| Tela de Login (Temática) | Dashboard (Power BI) |
| :---: | :---: |
| [Imagem da Tela de Login] | [Imagem do Dashboard] |

| Cadastro de Alunos | Boletim Gerado (PDF) |
| :---: | :---: |
| [Imagem do Cadastro] | [Imagem do PDF com QuestPDF] |

-----

## 👨‍💻 Autores

**[Pedro Dutra Paes Penteado Dâmaso de Souza]**

  * [[https://www.linkedin.com/in/pedro-dutra-a43170341/](https://www.linkedin.com/in/pedro-dutra-a43170341/)]
  * [[https://github.com/PedroDutraSouza?tab=repositories](https://github.com/PedroDutraSouza?tab=repositories)]

**[João Pedro Malta Caldeira]**

  * [[https://www.linkedin.com/in/joao-pedro-malta-caldeira-19a032329/](https://www.linkedin.com/in/joao-pedro-malta-caldeira-19a032329/)]
  * [Link do seu GitHub]

**[Thiago Henrique Salustiano Couto]**

  * [[https://www.linkedin.com/in/thiago-couto-8804b92a3/](https://www.linkedin.com/in/thiago-couto-8804b92a3/)]
  * [Link do seu GitHub]

**[Tarciene dos Santos Ferreira Borges]**

  * [[https://www.linkedin.com/in/tarciene-borges-santos/](https://www.linkedin.com/in/tarciene-borges-santos/)]
  * [Link do seu GitHub]
