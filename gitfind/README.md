# GitFind

---

## Descrição da Aplicação / *`Application Description`*

O **GitFind** é uma aplicação web desenvolvida, com React que consome a API pública do GitHub para buscar perfis de usuários e listar seus repositórios. O usuário informa um nome de usuário GitHub (`@username`) e, ao clicar em **Pesquisar**, a aplicação realiza uma requisição HTTP para obter os dados do perfil e dos repositórios.

> ***GitFind** is a web application built with React that consumes the public GitHub API to search for user profiles and list their repositories. The user enters a GitHub username (`@username`) and clicks **Search** — the application then makes an HTTP request to fetch profile data and repository information.* 

## Funcionalidades Principais / *`Key Features`*

### `async / await`

A função `handleGetData` utiliza o padrão `async / await`, pois não sabe o tempo de resposta da API. Isso permite que o código aguarde a resposta da API do GitHub antes de continuar a execução, sem bloquear a interface do usuário:

> *The `handleGetData` function uses the `async / await` pattern to handle asynchronous operations in a clean and readable way. This allows the code to wait for the GitHub API response before continuing execution, without blocking the user interface:*

```js
const handleGetData = async () => {
  const userData = await fetch(`https://api.github.com/users/${user}`);
  const newUser = await userData.json();
  // ...
  const reposData = await fetch(`https://api.github.com/users/${user}/repos`);
  const newRepos = await reposData.json();
  // ...
};
```

### `fetch`

A função nativa `fetch` é utilizada para fazer requisições HTTP do tipo **GET** aos endpoints da API do GitHub:

> *The native `fetch` function is used to make **GET** HTTP requests to the GitHub API endpoints:*

- **`https://api.github.com/users/{user}`** — obtém os dados do perfil (avatar, nome, bio, login)
> *retrieves profile data (avatar, name, bio, login).*

- **`https://api.github.com/users/{user}/repos`** — obtém a lista de repositórios públicos do usuário.
> *retrieves the list of public repositories.*

Os dados retornados são convertidos para JSON com o método `.json()` e armazenados no estado da aplicação via `useState`.

> *The returned data is parsed to JSON using the `.json()` method and stored in the application state via `useState`.*


Por padrão, a função `fetch` faz requisição **GET**, mas pode ser alterada, por exemplo:
> *By default, the `fetch` function makes **GET** requests,  but it can be changed. For example:*

```jsx
const response = await fetch("http://exemplo.api/post", { method: "POST"});
```

### `.map`

O método `.map` do JavaScript é utilizado para percorrer o array de repositórios retornados pela API e renderizar um componente `<ItemList />` para cada item:

> *The JavaScript `.map` method is used to iterate over the array of repositories returned by the API and render an `<ItemList />` component for each item:*

```jsx
{repos.map(repo => (
  <ItemList title={repo.name} description={repo.description} />
))}
```

Dessa forma, cada repositório é exibido na tela com seu nome e descrição de maneira dinâmica e declarativa, aproveitando o componente criado, sem replicações.

> *This way, each repository is displayed on the screen with its name and description in a dynamic and declarative manner, leveraging the created component — without duplication.*

### Estrutura do Projeto / *`Project Structure`*

```
src/
├── index.js              ← Ponto de entrada da aplicação
├── styles.css            ← Estilos globais
├── pages/
│   └── Home/             ← Página principal (componente App)
├── components/
│   ├── Header/           ← Cabeçalho da aplicação
│   ├── Input/            ← Campo de entrada
│   ├── Button/           ← Botão de pesquisa
│   └── ItemList/         ← Exibição de cada repositório
└── assets/
    └── background.png    ← Imagem de fundo
```

### Como Executar / *`How to Run`*

1. Instale as dependências / *`Install dependencies`*:
   ```bash
   npm install
   ```

2. Inicie o servidor de desenvolvimento / *`Start the development server`*:
   ```bash
   npm start
   ```

---