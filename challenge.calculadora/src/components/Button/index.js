import { ButtonContainer } from "./styles";

const Button = ({label, onClick, ...props}) => {
  return (
    <ButtonContainer {...props} onClick={onClick}>
      {label}
    </ButtonContainer>
  );
};

export default Button;

