# 🗳️ Simulador de Urna Eletrônica

Este projeto é um simulador de urna eletrônica desenvolvido com **C# (.NET Windows Forms)** e **PostgreSQL**, com o objetivo de simular uma votação real, incluindo candidatos, categorias e votos computados via hash.

## 📂 Estrutura do Projeto

- `UrnaEletronica/` - Código-fonte da aplicação
- `VotosRegistrados/` - Pasta onde os votos são salvos com hash
- `Sound/` - Sons da urna (ex: clique, confirmação)
- `Banco/` - Dump do banco de dados (`Urna_Eletronica.sql`)

## ⚙️ Tecnologias Utilizadas

- C# (.NET Framework / Windows Forms)
- PostgreSQL
- Npgsql (Driver para PostgreSQL em C#)

## 📦 Banco de Dados

O banco de dados contém as seguintes tabelas principais:

- `categoria` - Tipos de cargos (Presidente, Governador, etc)
- `partido` - Partidos políticos com sigla
- `candidato` - Dados dos candidatos, incluindo imagem
- (opcional) `estado` - Para controle regional, se necessário

### 🎯 Importando o Banco

1. Instale o PostgreSQL.
2. Crie o banco `Urna_Eletronica`.
3. Execute o dump
