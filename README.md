Projeto Web API com Angular
Este projeto é uma aplicação Full Stack composta de uma API desenvolvida com .NET e um frontend desenvolvido em Angular. A API fornece os dados e serviços, enquanto o Angular consome e apresenta esses dados para os usuários.

📋 Sumário
Tecnologias
Pré-requisitos
Instalação
Configuração
Uso
Estrutura do Projeto
Contribuição
Licença
🛠 Tecnologias
Backend: .NET 6.0 Web API
Frontend: Angular 13+
Banco de Dados: SQL Server (ou outro banco de dados suportado)
🚀 Pré-requisitos
Backend:

.NET SDK (versão 6.0 ou superior)
SQL Server ou outro banco de dados configurado
Frontend:

Node.js (versão 14 ou superior)
Angular CLI (instalado globalmente)
🔧 Instalação
1. Clone o repositório
bash
Copiar código
git clone https://github.com/Washdevs/ASPNET_FULLSTACK.git
cd ASPNET_FULLSTACK
2. Configuração do Backend
Entre na pasta do projeto da API:

bash
Copiar código
cd API
Restaure as dependências:

bash
Copiar código
dotnet restore
Configure a string de conexão com o banco de dados no appsettings.json:

json
Copiar código
{
  "ConnectionStrings": {
    "DefaultConnection": "Your_Connection_String_Here"
  }
}
Rode as migrações para configurar o banco de dados:

bash
Copiar código
dotnet ef database update
Inicie a API:

bash
Copiar código
dotnet run
A API estará disponível em https://localhost:5001.

3. Configuração do Frontend
Entre na pasta do projeto Angular:

bash
Copiar código
cd ../frontend
Instale as dependências:

bash
Copiar código
npm install
Inicie o servidor de desenvolvimento:

bash
Copiar código
ng serve
A aplicação estará disponível em http://localhost:4200.

⚙️ Configuração
Variáveis de Ambiente
Backend: Verifique o arquivo appsettings.json para configurar os detalhes do banco de dados e outras variáveis.

Frontend: Configure a URL da API no environment.ts (para ambiente de desenvolvimento) e environment.prod.ts (para produção):

typescript
Copiar código
export const environment = {
  production: false,
  apiUrl: 'https://localhost:5001/api'
};
🚀 Uso
Inicie a API e o frontend usando os comandos descritos acima.
Abra http://localhost:4200 no navegador para acessar a aplicação Angular.
Use https://localhost:5001/swagger para explorar e testar a API com o Swagger UI.
📂 Estrutura do Projeto
Backend - .NET API
Controllers: Contêm os endpoints da API.
Models: Definem as classes e estruturas de dados.
Data: Configuração do contexto de dados (Entity Framework).
Frontend - Angular
app: Componentes e serviços.
assets: Arquivos estáticos.
environments: Configurações para diferentes ambientes.
🤝 Contribuição
Sinta-se à vontade para abrir Issues ou Pull Requests com sugestões ou correções.

📄 Licença
Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
