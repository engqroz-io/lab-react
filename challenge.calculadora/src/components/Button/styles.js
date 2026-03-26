import styled from "styled-components";

export const ButtonContainer = styled.button`
  padding: 20px;
  background-color: #3498db;
  &:hover {
    opacity: 0.6;
  }
  color: white;
  font-weight: bold;
  font-size: 24px;
  font-weight: 24px;
  border-radius: 8px;
  border: 1px solid #106eb1e0;
  width: 100%;
  cursor: pointer;
  min-height: 50px;
  margin: 4px;
  flex: 1;
  ${props => props.gridColumn && `grid-column: ${props.gridColumn};`}
  ${props => props.gridRow && `grid-row: ${props.gridRow};`}
`;