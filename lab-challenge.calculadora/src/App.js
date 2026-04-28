import { useState } from "react";
import Input from "./components/Input";
import Button from "./components/Button";
import { Container, Content, Row } from "./styles";

function App() {
  const [currentValue, setCurrentValue] = useState("0"); 
  const [value1, setValue1] = useState("0");
  const [operation, setOperation] = useState(null);

  const handleAddValue = (value) => {
    if (currentValue.includes(".") && value === ".") return; // Prevent multiple decimals

    setCurrentValue((prevValue) => `${prevValue === "0" ? '' : prevValue}${value}`);
  };

  const handleClear = () => {
    setValue1("0");
    setCurrentValue("0");
    setOperation(null);
  };

  const handleOperation = (op) => {

    if (value1 === "0") {
      setValue1(currentValue);
      setCurrentValue("0");
      setOperation(op);
    }
    else
    {
      let sum = 0;
      switch (operation) {
        case "+":
          sum = Number(value1) + Number(currentValue);
          break;
        case "-":
          sum = Number(value1) - Number(currentValue);
          break;
        case "*":
          sum = Number(value1) * Number(currentValue);
          break;
        case "/":
          sum = Number(value1) / Number(currentValue);
          break;
        case "%":
          sum = Number(value1) % Number(currentValue);
          break;
        case "=":
          handleOperation(operation);
          break;
        default:
          break;
      }
      setCurrentValue(sum);
      setOperation(op);
    }
  };

  return (
    <div className="App">
      <Container>
        <Content>
          <Input value={currentValue} />
          <Row>
            
            <Button label="C" gridColumn="1 / 3" gridRow={1} onClick={() => handleClear()} />
            <Button label="7" gridColumn={1} gridRow={2} onClick={() => handleAddValue("7")} />
            <Button label="4" gridColumn={1} gridRow={3} onClick={() => handleAddValue("4")} />
            <Button label="1" gridColumn={1} gridRow={4} onClick={() => handleAddValue("1")} />
            <Button label="0" gridColumn={1} gridRow={5} onClick={() => handleAddValue("0")} />

            <Button label="8" gridColumn={2} gridRow={2} onClick={() => handleAddValue("8")} />
            <Button label="5" gridColumn={2} gridRow={3} onClick={() => handleAddValue("5")} />
            <Button label="2" gridColumn={2} gridRow={4} onClick={() => handleAddValue("2")} />
            <Button label="." gridColumn={2} gridRow={5} onClick={() => handleAddValue(".")} />
            
            <Button label="%" gridColumn={3} gridRow={1} onClick={() => handleOperation("%")}/>
            <Button label="9" gridColumn={3} gridRow={2} onClick={() => handleAddValue("9")} />
            <Button label="6" gridColumn={3} gridRow={3} onClick={() => handleAddValue("6")} />
            <Button label="3" gridColumn={3} gridRow={4} onClick={() => handleAddValue("3")} />
            <Button label="=" gridColumn={3} gridRow={5} onClick={() => handleOperation("=")}/>
            
            <Button label="/" gridColumn={4} gridRow={1} onClick={() => handleOperation("/")} />
            <Button label="*" gridColumn={4} gridRow={2} onClick={() => handleOperation("*")} />
            <Button label="-" gridColumn={4} gridRow={3} onClick={() => handleOperation("-")} />
            <Button label="+" gridColumn={4} gridRow="4 / 6" onClick={() => handleOperation("+")} />
          </Row>
        </Content>
      </Container>
    </div>  
  );
}

export default App;
