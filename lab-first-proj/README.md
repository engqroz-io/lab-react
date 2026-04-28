# First-Proj - Aplicação React / _`React Application`_

Uma aplicação simples construída com **React 19**, demonstrando conceitos fundamentais de gerenciamento de estado e efeitos colaterais, com um setup completo de tooling moderno para desenvolvimento web.

> _A simple application built with **React 19**, demonstrating fundamental concepts of state management and side effects, with a complete setup of modern tooling for web development._

## 🛠️ Stacks Utilizadas / Used Stacks

Aqui vai o que usei para montar este primeiro projeto:

> Here is what I used to build this first project:

- **React**: Para criar a interface e gerenciar o estado. `To create the interface and manage the state.`
- **Webpack**: Para empacotar tudo bem. `To bundle everything well.`
- **Babel**: Para transformar o código moderno em algo que os navegadores entendem. `To transform modern code into something browsers understand.`
- **ESLint e Prettier**: Para manter o código limpo e bem formatado. `To keep the code clean and well formatted.`
- **CSS Loaders**: Para carregar estilos. `To load styles.`
- **HTML Webpack Plugin**: Para gerar o HTML automaticamente. `To generate HTML automatically.`

Foi meu primeiro passo no mundo do React, e adorei configurar tudo manualmente! 😊

> It was my first step in the React world, and I loved configuring everything manually! 😊

## 📊 Status do Projeto / Project Status

**Concluído!** ✅ / `**Completed!** ✅`

---

## 🧾 Descrição / _`Description`_

Esta é uma aplicação de lista de usuários que permite:

> _This is a user list application that allows you to:_

- **Adicionar usuários** a uma lista através de um campo de input
- **Contabilizar automaticamente** o número de usuários na lista
- **Renderizar dinamicamente** a lista de usuários na interface

> _- **Add users** to a list through an input field_
>
> _- **Automatically count** the number of users in the list_
>
> _- **Dynamically render** the user list on the interface_

A aplicação serve como ponto de partida para projetos React, demonstrando boas práticas de configuração e desenvolvimento.

> _The application serves as a starting point for React projects, demonstrating best practices in configuration and development._

---

## 🛠️ Tech Stack & Ferramentas / _`Tech Stack & Tools`_

### Babel

O **Babel** é um _transpiler_ JavaScript que converte código moderno (ES6+) em versões compatíveis com navegadores mais antigos.

> _`Babel is a JavaScript transpiler that converts modern code (ES6+) into versions compatible with older browsers.`_

**Configuração do projeto (`.babelrc`) / _`Project configuration`_ (`.babelrc`):**

```json
{
    "presets": ["@babel/preset-env", ["@babel/preset-react", { "runtime": "automatic" }]]
}
```

**Presets utilizados:** / **`Presets used:`**
| Preset | Função / _`Function`_ |
|--------|--------|
| `@babel/preset-env` | Transpila JavaScript moderno para versões compatíveis |
| `@babel/preset-react` | Transforma JSX em JavaScript válido |

> _`@babel/preset-env` - Transpiles modern JavaScript to compatible versions_
>
> _`@babel/preset-react` - Transforms JSX into valid JavaScript_

A opção `"runtime": "automatic"` permite o uso de JSX sem necessidade de importar `React` explicitamente em cada componente.

> _The `"runtime": "automatic"` option allows the use of JSX without needing to explicitly import `React` in each component._

---

### EditorConfig

O **EditorConfig** mantém consistência de estilo entre diferentes editores e IDEs.

> _`EditorConfig maintains style consistency across different editors and IDEs.`_

**Configuração (`.editorconfig`) / _`Configuration`_ (`.editorconfig`):**

```ini
root=true
end_of_line=lf
insert_final_line=true
indent_size=4
```

**Regras aplicadas:** / **`Applied rules:`**

- `root=true` — Define este como o arquivo raiz de configuração
- `end_of_line=lf` — Usa line feeds Unix (`\n`) como final de linha
- `insert_final_line=true` — Garante uma linha vazia ao final do arquivo
- `indent_size=4` — Define indentação com 4 espaços

> _`root=true` — Sets this as the root configuration file_
>
> _`end_of_line=lf` — Uses Unix line feeds (\n) as line endings_
>
> _`insert_final_line=true` — Ensures a blank line at the end of the file_
>
> _`indent_size=4` — Sets indentation with 4 spaces_

---

### Prettier

O **Prettier** é um formatador de código opinativo que garante estilo consistente automaticamente.

> _`Prettier is an opinionated code formatter that ensures consistent style automatically.`_

**Configuração (`.prettierrc`) / _`Configuration`_ (`.prettierrc`):**

```json
{
    "semi": true,
    "tabWidth": 4,
    "printWidth": 100,
    "singleQuote": true,
    "trailingComma": "none",
    "jsxbracketSameLine": true
}
```

**Regras aplicadas:** / **`Applied rules:`**
| Regra / Rule | Valor / Value | Descrição / Description |
|-------|-------|-----------|
| `semi` | `true` | Adiciona ponto e vírgula ao final das instruções |
| `tabWidth` | `4` | Largura da tabulação em espaços |
| `printWidth` | `100` | Número máximo de caracteres por linha |
| `singleQuote` | `true` | Usa aspas simples em strings |
| `trailingComma` | `none` | Remove vírgulas finais em objetos/arrays |
| `jsxbracketSameLine` | `true` | Fecha tags JSX na mesma linha |

> _`semi` - Adds semicolons at the end of statements_
>
> _`tabWidth` - Tab width in spaces_
>
> _`printWidth` - Maximum number of characters per line_
>
> _`singleQuote` - Uses single quotes in strings_
>
> _`trailingComma` - Removes trailing commas in objects/arrays_
>
> _`jsxbracketSameLine` - Closes JSX tags on the same line_

---

### ESLint

O **ESLint** é um linter estático que identifica e reporta problemas no código, garantindo qualidade e evitando bugs.

> _`ESLint is a static linter that identifies and reports problems in code, ensuring quality and preventing bugs.`_

**Configuração (`eslint.config.mjs`) / _`Configuration`_ (`eslint.config.mjs`):**

O projeto utiliza o formato **flat config** (configuração plana), introduzido no ESLint v9+.

> _`The project uses the flat config format, introduced in ESLint v9+.`_

**Plugins e extensões ativas:** / **`Active plugins and extensions:`**
| Plugin/Extensão / Plugin/Extension | Função / Function |
|-----------------|--------|
| `@eslint/js` | Regras recomendadas para JavaScript |
| `eslint-plugin-react` | Regras específicas para React |
| `eslint-plugin-prettier` | Integra Prettier com ESLint |
| `eslint-config-prettier` | Desabilita regras conflitantes entre ESLint e Prettier |
| `@eslint/json` | Linting para arquivos JSON |
| `@eslint/css` | Linting para arquivos CSS |
| `typescript-eslint` | Regras recomendadas para TypeScript |

> _`@eslint/js` - Recommended rules for JavaScript_
>
> _`eslint-plugin-react` - Specific rules for React_
>
> _`eslint-plugin-prettier` - Integrates Prettier with ESLint_
>
> _`eslint-config-prettier` - Disables conflicting rules between ESLint and Prettier_
>
> _`@eslint/json` - Linting for JSON files_
>
> _`@eslint/css` - Linting for CSS files_
>
> _`typescript-eslint` - Recommended rules for TypeScript_

**Regra personalizada:** / **`Custom rule:`**

```js
"react/react-in-jsx-scope": "off"
```

Desabilita a necessidade de importar `React` em arquivos JSX (compatível com React 17+).

> _Disables the need to import `React` in JSX files (compatible with React 17+)._

---

### Webpack

O **Webpack** é um empacotador de módulos que bundla todos os assets da aplicação em um ou mais arquivos otimizados.

> _`Webpack is a module bundler that bundles all application assets into one or more optimized files.`_

**Configuração (`webpack.config.js`) / _`Configuration`_ (`webpack.config.js`):**

**Entry point:** `./src/index.js`

**Loaders configurados:** / **Configured loaders:**
| Loader | Extensão / Extension | Função / Function |
|--------|----------|--------|
| `babel-loader` | `.js` | Transpila JavaScript/Babel |
| `html-loader` | `.html` | Processa arquivos HTML |
| `style-loader` + `css-loader` | `.css` | Importa e injeta CSS no DOM |
| `file-loader` | `.png, .jpg, .jpeg, .gif` | Gerencia assets de imagem |

> _`babel-loader` - Transpiles JavaScript/Babel_
>
> _`html-loader` - Processes HTML files_
>
> _`style-loader` + `css-loader` - Imports and injects CSS into the DOM_
>
> _`file-loader` - Manages image assets_

**Plugin:** / **`Plugin:`**

- **HtmlWebpackPlugin** — Gera automaticamente o `index.html` no bundle, injetando os scripts necessários

> _`HtmlWebpackPlugin` — Automatically generates `index.html` in the bundle, injecting the necessary scripts_

**Scripts disponíveis:** / **`Available scripts:`**

```bash
# Inicia o servidor de desenvolvimento com hot reload
yarn start

# Gera build otimizado para produção
yarn build
```

> _`# Starts the development server with hot reload`_
>
> _`yarn start`_
>
> _`# Generates optimized build for production`_
>
> _`yarn build`_

**Features do dev server:** / **`Dev server features:`**

- `--open` — Abre o navegador automaticamente
- `--hot` — Habilita Hot Module Replacement (HMR)
- `--mode development` — Ativa source maps e mensagens de erro detalhadas

> _`--open` — Opens the browser automatically_
>
> _`--hot` — Enables Hot Module Replacement (HMR)_
>
> _`--mode development` — Activates source maps and detailed error messages_

---

### Yarn Lock

O arquivo **`yarn.lock`** é gerado automaticamente pelo Yarn e garante instalações determinísticas. Ele:

> _`The yarn.lock file is automatically generated by Yarn and ensures deterministic installations. It:`_

- Registra as **versões exatas** de cada dependência instalada
- Garante que **todos os desenvolvedores** usem as mesmas versões
- Previne bugs causados por atualizações inesperadas de pacotes
- Deve ser **commitado** no versionamento

> _`Records the exact versions of each installed dependency`_
>
> _`Ensures all developers use the same versions`_
>
> _`Prevents bugs caused by unexpected package updates`_
>
> _`Should be committed to version control`_

---

## ⚛️ Funcionalidades do React / _`React Features`_

### Componentes Funcionais / _`Functional Components`_

A aplicação utiliza **functional components**, o padrão moderno para criação de componentes React:

> _`The application uses functional components, the modern standard for creating React components:`_

```jsx
const App = () => {
    // ... lógica e JSX
};
export default App;
```

### Hooks

#### `useState`

Gerencia o estado local do componente:

> _`Manages the component's local state:`_

| Estado / State | Tipo / Type | Descrição / Description          |
| -------------- | ----------- | -------------------------------- |
| `usuario`      | `string`    | Armazena o valor do input        |
| `count`        | `number`    | Contabiliza o número de usuários |
| `usuarios`     | `array`     | Lista de objetos de usuário      |

> _`usuario` - Stores the input value_
>
> _`count` - Counts the number of users_
>
> _`usuarios` - List of user objects_

#### `useEffect`

Executa efeitos colaterais em resposta a mudanças no estado:

> _`Executes side effects in response to state changes:`_

```jsx
useEffect(() => {
    setCount(usuarios.length);
}, [usuarios]);
```

O array de dependências `[usuarios]` garante que o efeito execute apenas quando a lista de usuários mudar.

> _The dependency array `[usuarios]` ensures that the effect only runs when the user list changes._

### Renderização Condicional e Listas / _`Conditional Rendering and Lists`_

A aplicação demonstra: / _The application demonstrates:_

- **Renderização de listas** com `Array.map()`
- Uso de **`key`** prop para otimização de reconciliação
- **Two-way data binding** com `value` e `onChange` no input
- **Event handling** com `onClick` no botão

> _`List rendering with Array.map()`_
>
> _`Use of key prop for reconciliation optimization`_
>
> _`Two-way data binding with value and onChange on input`_
>
> _`Event handling with onClick on button`_

### React 19 - createRoot

O ponto de entrada utiliza a API moderna `createRoot` do `react-dom/client`:

> _`The entry point uses the modern createRoot API from react-dom/client:`_

```jsx
import { createRoot } from 'react-dom/client';
const container = document.getElementById('root');
const root = createRoot(container);
root.render(<App />);
```

---

## 📦 Dependências / _`Dependencies`_

### Production Dependencies

| Pacote / Package | Versão / Version | Descrição / Description      |
| ---------------- | ---------------- | ---------------------------- |
| `react`          | ^19.2.4          | Biblioteca core do React     |
| `react-dom`      | ^19.2.4          | Renderização do React no DOM |

> _`react` - Core React library_
>
> _`react-dom` - React rendering in the DOM_

### Development Dependencies

| Pacote / Package         | Versão / Version | Descrição / Description        |
| ------------------------ | ---------------- | ------------------------------ |
| `@babel/core`            | ^7.29.0          | Core do Babel                  |
| `@babel/preset-env`      | ^7.29.2          | Preset para JavaScript moderno |
| `@babel/preset-react`    | ^7.28.5          | Preset para JSX                |
| `babel-loader`           | ^10.1.1          | Integração Babel + Webpack     |
| `webpack`                | ^5.105.4         | Module bundler                 |
| `webpack-cli`            | ^7.0.2           | CLI do Webpack                 |
| `webpack-dev-server`     | ^5.2.3           | Servidor de desenvolvimento    |
| `html-webpack-plugin`    | ^5.6.6           | Gera HTML automaticamente      |
| `eslint`                 | ^10.1.0          | Linter JavaScript              |
| `eslint-plugin-react`    | ^7.37.5          | Regras ESLint para React       |
| `eslint-plugin-prettier` | ^5.5.5           | Integração Prettier            |
| `eslint-config-prettier` | ^10.1.8          | Desabilita conflitos Prettier  |
| `prettier`               | ^3.8.1           | Formatador de código           |
| `css-loader`             | ^7.1.4           | Importa CSS em módulos JS      |
| `style-loader`           | ^4.0.0           | Injeta CSS no DOM              |
| `html-loader`            | ^5.1.0           | Processa HTML                  |
| `file-loader`            | ^6.2.0           | Gerencia assets de arquivo     |

> _`@babel/core` - Babel core_
>
> _`@babel/preset-env` - Preset for modern JavaScript_
>
> _`@babel/preset-react` - Preset for JSX_
>
> _`babel-loader` - Babel + Webpack integration_
>
> _`webpack` - Module bundler_
>
> _`webpack-cli` - Webpack CLI_
>
> _`webpack-dev-server` - Development server_
>
> _`html-webpack-plugin` - Automatically generates HTML_
>
> _`eslint` - JavaScript linter_
>
> _`eslint-plugin-react` - ESLint rules for React_
>
> _`eslint-plugin-prettier` - Prettier integration_
>
> _`eslint-config-prettier` - Disables Prettier conflicts_
>
> _`prettier` - Code formatter_
>
> _`css-loader` - Imports CSS into JS modules_
>
> _`style-loader` - Injects CSS into the DOM_
>
> _`html-loader` - Processes HTML_
>
> _`file-loader` - Manages file assets_

---

## 🚀 Começando / _`Getting Started`_

### Pré-requisitos / _`Prerequisites`_

- [Node.js](https://nodejs.org/) (v18 ou superior)
- [Yarn](https://yarnpkg.com/)

> _`Node.js (v18 or higher)`_
>
> _`Yarn`_

### Instalação / _`Installation`_

```bash
# Instalar dependências
yarn install
```

> _`# Install dependencies`_
>
> _`yarn install`_

### Desenvolvimento / _`Development`_

```bash
# Iniciar servidor de desenvolvimento
yarn start
```

> _`# Start development server`_
>
> _`yarn start`_

### Build de Produção / _`Production Build`_

```bash
# Gerar bundle otimizado
yarn build
```

> _`# Generate optimized bundle`_
>
> _`yarn build`_

O output será gerado na pasta `dist/`.

> _The output will be generated in the `dist/` folder._

---

## 📁 Estrutura do Projeto / _`Project Structure`_

```
first-proj/
├── public/
│   └── index.html          # Template HTML
├── src/
│   ├── App.js              # Componente principal
│   └── index.js            # Ponto de entrada
├── .babelrc                # Configuração do Babel
├── .editorconfig           # Configuração do EditorConfig
├── .prettierrc             # Configuração do Prettier
├── eslint.config.mjs       # Configuração do ESLint
├── webpack.config.js       # Configuração do Webpack
├── package.json            # Dependências e scripts
├── yarn.lock               # Lockfile do Yarn
└── README.md               # Documentação
```

> _`public/index.html` - HTML template_
>
> _`src/App.js` - Main component_
>
> _`src/index.js` - Entry point_
>
> _`.babelrc` - Babel configuration_
>
> _`.editorconfig` - EditorConfig configuration_
>
> _`.prettierrc` - Prettier configuration_
>
> _`eslint.config.mjs` - ESLint configuration_
>
> _`webpack.config.js` - Webpack configuration_
>
> _`package.json` - Dependencies and scripts_
>
> _`yarn.lock` - Yarn lockfile_
>
> _`README.md` - Documentation_
