# Leitura acompanhada 

Leitura Acompanhada é um sistema em C# que simula o comportamento de uma biblioteca digital, utilizando persistência em JSON para armazenar dados de livros e leituras.

O sistema permite cadastrar livros e registrar leituras associadas a cada livro, garantindo que um livro só possa ter uma leitura ativa por vez. Cada livro e cada leitura possuem IDs únicos, garantindo separação e controle individual de cada registro.

Além disso, o usuário pode filtrar livros por título, autor ou gênero, acompanhar o histórico de leituras e atualizar o status de um livro para concluído assim que a leitura for finalizada, simulando a “devolução” do livro.

O projeto combina conceitos de Programação Orientada a Objetos e persistência em JSON para representar de forma simples e organizada a gestão de uma biblioteca.

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"/>
  <img src="https://img.shields.io/badge/.NET-8%2B-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
  <img src="https://img.shields.io/badge/Versão-1.0-blueviolet?style=for-the-badge"/>
  <img src="https://img.shields.io/badge/Contribuições-Bem%20vindas-brightgreen?style=for-the-badge"/>
  <img src="https://img.shields.io/badge/Status-%20concluído-yellow?style=for-the-badge"/>
</p>

## 🚀 Funcionalidades

**Inserir livros**
- Permite cadastrar novos livros informando título, autor e gênero.
<div align="center">
  <img src="Assets/InserirLivro.gif" alt="Inserir Livro" width="550"/>
</div>

**Inserir leitura**
- Adiciona uma leitura a um livro específico (via ID do livro).
- Cada leitura recebe um ID único.
- Registra a data de início da leitura.
<div align="center">
  <img src="Assets/InserirLeitura.gif" alt="Inserir Leitura" width="550"/>
</div>

**Lista de livros**
- Exibe todos os livros cadastrados com seus identificadores (IDs).
<div align="center">
  <img src="Assets/ListaLivros.gif" alt="Lista de Livros" width="550"/>
</div>

**Histórico de leitura**
- Mostra todas as leituras registradas de um determinado livro, com status e datas.
<div align="center">
  <img src="Assets/HistoricoDeLeituras.gif" alt="Histórico de Leituras" width="550"/>
</div>

**Atualizar status da leitura**
- Permite atualizar o status de uma leitura para concluído.
- Define a data de término automaticamente quando a leitura é concluída.
<div align="center">
  <img src="Assets/AtualizarStatus.gif" alt="Atualizar Status" width="550"/>
</div>

**Filtro de busca**
- Permite buscar livros por título, autor ou gênero, retornando todos os livros que correspondem ao critério.
<div align="center">
  <img src="Assets/FiltroDeBusca.gif" alt="Filtro de Busca" width="550"/>
</div>


### ⚙️ **Como Executar o Projeto**

- .NET SDK (versão 8.0 ou superior).
- Um editor de código como Visual Studio Code ou Visual Studio.

#### 💻 Clonando o repositório
```bash
git clone https://github.com/MaaLuu21/LeituraAcompanhada.git
```

#### 📂 Acesse o diretório do projeto
```bash
cd LeituraAcompanhada/LeituraAcompanhada
```

#### 🧰 Restaure as dependências e compile
```bash
dotnet restore
dotnet build
```
#### ▶️ Executando
```bash
dotnet run
```

## 🔒 Validação
- O sistema realiza verificações para garantir a integridade dos dados inseridos, impedindo campos vazios, datas inválidas, status incorretos e salvamento de informações inconsistentes no JSON.
