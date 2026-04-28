# First-Proj - Aplicação React / *`React Application`*

Uma aplicação simples construída com **React 19**, demonstrando conceitos fundamentais de gerenciamento de estado e efeitos colaterais, com um setup completo de tooling moderno para desenvolvimento web.

> *A simple application built with **React 19**, demonstrating fundamental concepts of state management and side effects, with a complete setup of modern tooling for web development.*

## 📋 Descrição / *`Description`*

Esta é uma aplicação de lista de usuários que permite:

> *This is a user list application that allows you to:*

- **Adicionar usuários** a uma lista através de um campo de input
- **Contabilizar automaticamente** o número de usuários na lista
- **Renderizar dinamicamente** a lista de usuários na interface

> *- **Add users** to a list through an input field*
>
> *- **Automatically count** the number of users in the list*
>
> *- **Dynamically render** the user list on the interface*

A aplicação serve como ponto de partida para projetos React, demonstrando boas práticas de configuração e desenvolvimento.

> *The application serves as a starting point for React projects, demonstrating best practices in configuration and development.*

---

## 🛠️ Tech Stack & Ferramentas / *`Tech Stack & Tools`*

### Babel

O **Babel** é um *transpiler* JavaScript que converte código moderno (ES6+) em versões compatíveis com navegadores mais antigos.

> *`Babel is a JavaScript transpiler that converts modern code (ES6+) into versions compatible with older browsers.`*

**Configuração do projeto (`.babelrc`) / *`Project configuration`* (`.babelrc`):**
```json
{
  "presets": [
    "@babel/preset-env",
    ["@babel/preset-react", {"runtime": "automatic"}]
  ]
}
```

**Presets utilizados:** / **`Presets used:`**
| Preset | Função / *`Function`* |
|--------|--------|
| `@babel/preset-env` | Transpila JavaScript moderno para versões compatíveis |
| `@babel/preset-react` | Transforma JSX em JavaScript válido |

> *`@babel/preset-env` - Transpiles modern JavaScript to compatible versions*
>
> *`@babel/preset-react` - Transforms JSX into valid JavaScript*

A opção `"runtime": "automatic"` permite o uso de JSX sem necessidade de importar `React` explicitamente em cada componente.

> *The `"runtime": "automatic"` option allows the use of JSX without needing to explicitly import `React` in each component.*

---

### EditorConfig

O **EditorConfig** mantém consistência de estilo entre diferentes editores e IDEs.

> *`EditorConfig maintains style consistency across different editors and IDEs.`*

**Configuração (`.editorconfig`) / *`Configuration`* (`.editorconfig`):**
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

> *`root=true` — Sets this as the root configuration file*
>
> *`end_of_line=lf` — Uses Unix line feeds (\n) as line endings*
>
> *`insert_final_line=true` — Ensures a blank line at the end of the file*
>
> *`indent_size=4` — Sets indentation with 4 spaces*

---

### Prettier

O **Prettier** é um formatador de código opinativo que garante estilo consistente automaticamente.

> *`Prettier is an opinionated code formatter that ensures consistent style automatically.`*

**Configuração (`.prettierrc`) / *`Configuration`* (`.prettierrc`):**
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

> *`semi` - Adds semicolons at the end of statements*
>
> *`tabWidth` - Tab width in spaces*
>
> *`printWidth` - Maximum number of characters per line*
>
> *`singleQuote` - Uses single quotes in strings*
>
> *`trailingComma` - Removes trailing commas in objects/arrays*
>
> *`jsxbracketSameLine` - Closes JSX tags on the same line*

---

### ESLint

O **ESLint** é um linter estático que identifica e reporta problemas no código, garantindo qualidade e evitando bugs.

> *`ESLint is a static linter that identifies and reports problems in code, ensuring quality and preventing bugs.`*

**Configuração (`eslint.config.mjs`) / *`Configuration`* (`eslint.config.mjs`):**

O projeto utiliza o formato **flat config** (configuração plana), introduzido no ESLint v9+.

> *`The project uses the flat config format, introduced in ESLint v9+.`*

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

> *`@eslint/js` - Recommended rules for JavaScript*
>
> *`eslint-plugin-react` - Specific rules for React*
>
> *`eslint-plugin-prettier` - Integrates Prettier with ESLint*
>
> *`eslint-config-prettier` - Disables conflicting rules between ESLint and Prettier*
>
> *`@eslint/json` - Linting for JSON files*
>
> *`@eslint/css` - Linting for CSS files*
>
> *`typescript-eslint` - Recommended rules for TypeScript*

**Regra personalizada:** / **`Custom rule:`**
```js
"react/react-in-jsx-scope": "off"
```
Desabilita a necessidade de importar `React` em arquivos JSX (compatível com React 17+).

> *Disables the need to import `React` in JSX files (compatible with React 17+).*

---

### Webpack

O **Webpack** é um empacotador de módulos que bundla todos os assets da aplicação em um ou mais arquivos otimizados.

> *`Webpack is a module bundler that bundles all application assets into one or more optimized files.`*

**Configuração (`webpack.config.js`) / *`Configuration`* (`webpack.config.js`):**

**Entry point:** `./src/index.js`

**Loaders configurados:** / **Configured loaders:**
| Loader | Extensão / Extension | Função / Function |
|--------|----------|--------|
| `babel-loader` | `.js` | Transpila JavaScript/Babel |
| `html-loader` | `.html` | Processa arquivos HTML |
| `style-loader` + `css-loader` | `.css` | Importa e injeta CSS no DOM |
| `file-loader` | `.png, .jpg, .jpeg, .gif` | Gerencia assets de imagem |

> *`babel-loader` - Transpiles JavaScript/Babel*
>
> *`html-loader` - Processes HTML files*
>
> *`style-loader` + `css-loader` - Imports and injects CSS into the DOM*
>
> *`file-loader` - Manages image assets*

**Plugin:** / **`Plugin:`**
- **HtmlWebpackPlugin** — Gera automaticamente o `index.html` no bundle, injetando os scripts necessários

> *`HtmlWebpackPlugin` — Automatically generates `index.html` in the bundle, injecting the necessary scripts*

**Scripts disponíveis:** / **`Available scripts:`**
```bash
# Inicia o servidor de desenvolvimento com hot reload
yarn start

# Gera build otimizado para produção
yarn build
```

> *`# Starts the development server with hot reload`*
>
> *`yarn start`*
>
> *`# Generates optimized build for production`*
>
> *`yarn build`*

**Features do dev server:** / **`Dev server features:`**
- `--open` — Abre o navegador automaticamente
- `--hot` — Habilita Hot Module Replacement (HMR)
- `--mode development` — Ativa source maps e mensagens de erro detalhadas

> *`--open` — Opens the browser automatically*
>
> *`--hot` — Enables Hot Module Replacement (HMR)*
>
> *`--mode development` — Activates source maps and detailed error messages*

---

### Yarn Lock

O arquivo **`yarn.lock`** é gerado automaticamente pelo Yarn e garante instalações determinísticas. Ele:

> *`The yarn.lock file is automatically generated by Yarn and ensures deterministic installations. It:`*

- Registra as **versões exatas** de cada dependência instalada
- Garante que **todos os desenvolvedores** usem as mesmas versões
- Previne bugs causados por atualizações inesperadas de pacotes
- Deve ser **commitado** no versionamento

> *`Records the exact versions of each installed dependency`*
>
> *`Ensures all developers use the same versions`*
>
> *`Prevents bugs caused by unexpected package updates`*
>
> *`Should be committed to version control`*

---

## ⚛️ Funcionalidades do React / *`React Features`*

### Componentes Funcionais / *`Functional Components`*

A aplicação utiliza **functional components**, o padrão moderno para criação de componentes React:

> *`The application uses functional components, the modern standard for creating React components:`*

```jsx
const App = () => {
  // ... lógica e JSX
}
export default App;
```

### Hooks

#### `useState`
Gerencia o estado local do componente:

> *`Manages the component's local state:`*

| Estado / State | Tipo / Type | Descrição / Description |
|--------|------|-----------|
| `usuario` | `string` | Armazena o valor do input |
| `count` | `number` | Contabiliza o número de usuários |
| `usuarios` | `array` | Lista de objetos de usuário |

> *`usuario` - Stores the input value*
>
> *`count` - Counts the number of users*
>
> *`usuarios` - List of user objects*

#### `useEffect`
Executa efeitos colaterais em resposta a mudanças no estado:

> *`Executes side effects in response to state changes:`*

```jsx
useEffect(() => {
  setCount(usuarios.length);
}, [usuarios]);
```
O array de dependências `[usuarios]` garante que o efeito execute apenas quando a lista de usuários mudar.

> *The dependency array `[usuarios]` ensures that the effect only runs when the user list changes.*

### Renderização Condicional e Listas / *`Conditional Rendering and Lists`*

A aplicação demonstra: / *The application demonstrates:*
- **Renderização de listas** com `Array.map()`
- Uso de **`key`** prop para otimização de reconciliação
- **Two-way data binding** com `value` e `onChange` no input
- **Event handling** com `onClick` no botão

> *`List rendering with Array.map()`*
>
> *`Use of key prop for reconciliation optimization`*
>
> *`Two-way data binding with value and onChange on input`*
>
> *`Event handling with onClick on button`*

### React 19 - createRoot

O ponto de entrada utiliza a API moderna `createRoot` do `react-dom/client`:

> *`The entry point uses the modern createRoot API from react-dom/client:`*

```jsx
import { createRoot } from "react-dom/client";
const container = document.getElementById("root");
const root = createRoot(container);
root.render(<App />);
```

---

## 📦 Dependências / *`Dependencies`*

### Production Dependencies
| Pacote / Package | Versão / Version | Descrição / Description |
|--------|--------|-----------|
| `react` | ^19.2.4 | Biblioteca core do React |
| `react-dom` | ^19.2.4 | Renderização do React no DOM |

> *`react` - Core React library*
>
> *`react-dom` - React rendering in the DOM*

### Development Dependencies
| Pacote / Package | Versão / Version | Descrição / Description |
|--------|--------|-----------|
| `@babel/core` | ^7.29.0 | Core do Babel |
| `@babel/preset-env` | ^7.29.2 | Preset para JavaScript moderno |
| `@babel/preset-react` | ^7.28.5 | Preset para JSX |
| `babel-loader` | ^10.1.1 | Integração Babel + Webpack |
| `webpack` | ^5.105.4 | Module bundler |
| `webpack-cli` | ^7.0.2 | CLI do Webpack |
| `webpack-dev-server` | ^5.2.3 | Servidor de desenvolvimento |
| `html-webpack-plugin` | ^5.6.6 | Gera HTML automaticamente |
| `eslint` | ^10.1.0 | Linter JavaScript |
| `eslint-plugin-react` | ^7.37.5 | Regras ESLint para React |
| `eslint-plugin-prettier` | ^5.5.5 | Integração Prettier |
| `eslint-config-prettier` | ^10.1.8 | Desabilita conflitos Prettier |
| `prettier` | ^3.8.1 | Formatador de código |
| `css-loader` | ^7.1.4 | Importa CSS em módulos JS |
| `style-loader` | ^4.0.0 | Injeta CSS no DOM |
| `html-loader` | ^5.1.0 | Processa HTML |
| `file-loader` | ^6.2.0 | Gerencia assets de arquivo |

> *`@babel/core` - Babel core*
>
> *`@babel/preset-env` - Preset for modern JavaScript*
>
> *`@babel/preset-react` - Preset for JSX*
>
> *`babel-loader` - Babel + Webpack integration*
>
> *`webpack` - Module bundler*
>
> *`webpack-cli` - Webpack CLI*
>
> *`webpack-dev-server` - Development server*
>
> *`html-webpack-plugin` - Automatically generates HTML*
>
> *`eslint` - JavaScript linter*
>
> *`eslint-plugin-react` - ESLint rules for React*
>
> *`eslint-plugin-prettier` - Prettier integration*
>
> *`eslint-config-prettier` - Disables Prettier conflicts*
>
> *`prettier` - Code formatter*
>
> *`css-loader` - Imports CSS into JS modules*
>
> *`style-loader` - Injects CSS into the DOM*
>
> *`html-loader` - Processes HTML*
>
> *`file-loader` - Manages file assets*

---

## 🚀 Começando / *`Getting Started`*

### Pré-requisitos / *`Prerequisites`*

- [Node.js](https://nodejs.org/) (v18 ou superior)
- [Yarn](https://yarnpkg.com/)

> *`Node.js (v18 or higher)`*
>
> *`Yarn`*

### Instalação / *`Installation`*

```bash
# Instalar dependências
yarn install
```

> *`# Install dependencies`*
>
> *`yarn install`*

### Desenvolvimento / *`Development`*

```bash
# Iniciar servidor de desenvolvimento
yarn start
```

> *`# Start development server`*
>
> *`yarn start`*

### Build de Produção / *`Production Build`*

```bash
# Gerar bundle otimizado
yarn build
```

> *`# Generate optimized bundle`*
>
> *`yarn build`*

O output será gerado na pasta `dist/`.

> *The output will be generated in the `dist/` folder.*

---

## 📁 Estrutura do Projeto / *`Project Structure`*

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

> *`public/index.html` - HTML template*
>
> *`src/App.js` - Main component*
>
> *`src/index.js` - Entry point*
>
> *`.babelrc` - Babel configuration*
>
> *`.editorconfig` - EditorConfig configuration*
>
> *`.prettierrc` - Prettier configuration*
>
> *`eslint.config.mjs` - ESLint configuration*
>
> *`webpack.config.js` - Webpack configuration*
>
> *`package.json` - Dependencies and scripts*
>
> *`yarn.lock` - Yarn lockfile*
>
> *`README.md` - Documentation*

