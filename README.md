# FutureSkillHub.Api – API RESTful em .NET 8

API simples desenvolvida em **.NET 8** com **Entity Framework Core** e **SQLite**, permitindo operações CRUD de cursos e versionamento de rotas (v1 e v2).  
Projeto criado para a disciplina de Web Services & APIs (FIAP – 3ESPR).

---

## Tecnologias Utilizadas
- .NET 8  
- ASP.NET Core Web API  
- Entity Framework Core 8  
- SQLite  
- Swagger / OpenAPI

---

## Estrutura do Projeto
- **Controllers**: CursoV1Controller, CursoV2Controller  
- **Models**: Curso  
- **Data**: AppDbContext  
- **Migrations**: InitialCreate  
- **Banco**: futureskillhub.db (SQLite)

---

## Endpoints Disponíveis

### **Versão 1 (v1)**  
Base URL: `/api/v1/cursos`

| Método | Rota                | Descrição                    |
|--------|----------------------|------------------------------|
| GET    | /api/v1/cursos       | Retorna todos os cursos      |
| GET    | /api/v1/cursos/{id}  | Retorna um curso específico  |
| POST   | /api/v1/cursos       | Cria um novo curso           |
| PUT    | /api/v1/cursos/{id}  | Atualiza um curso existente  |
| DELETE | /api/v1/cursos/{id}  | Remove um curso              |

---

### **Versão 2 (v2)**  
Base URL: `/api/v2/cursos`

| Método | Rota                | Descrição                                   |
|--------|----------------------|---------------------------------------------|
| GET    | /api/v2/cursos       | Retorna apenas nome e nível dos cursos     |


---

## Execução
1. `dotnet ef database update`  
2. `dotnet run`  
3. Acessar Swagger:  
   http://localhost:5131/swagger

---

## Diagrama
O diagrama da arquitetura está disponível no arquivo:
[futureskill.pdf](https://github.com/user-attachments/files/23518033/futureskill.pdf)

---

## Vídeo
[Link para o vídeo de apresentação]([URL_AQUI](https://youtu.be/WaYZ3WClgG0))

---

## Autora
Maria Julia Araujo Rodrigues – RM 553384  
FIAP – Engenharia de Software (3ESPR)

