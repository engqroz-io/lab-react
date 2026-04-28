import React, { useEffect, useState } from "react";

const App = () => {

  const [ usuario, setUsuario ] = useState("");
  const [ count, setCount ] = useState(0);
  const [ usuarios, setUsuarios ] = useState([
    { id: 1, nome: "Alice" },
    { id: 2, nome: "Bob" },
    { id: 3, nome: "Charlie" }
  ]);

  useEffect(() => {
    setCount(usuarios.length);
  }, [usuarios]);

  const handlerAddUsuario = () => {
    setUsuarios([...usuarios, { id: Date.now(), nome: usuario }]);
    setUsuario("");
  };

  return (
    <div className="App">
      <h1>Hello, React!</h1>
      <h3>Usuários: {count}</h3>
      <div>
        <input value={usuario}
          onChange={(event) => setUsuario(event.target.value)} />
        <button onClick={handlerAddUsuario}>Add Usuario</button>
      </div>
      <ul>
        {usuarios.map(usuario => (
          <li key={usuario.id}>{usuario.nome}</li>
        ))}
      </ul>
    </div>
  )
}

export default App;