import styled from "styled-components";

export const Container = styled.div`
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    width: 100%;
    height: 100vh;
    background-color: #f5f5f5;
`;
    
export const Content = styled.div`
    width: 360px;
    min-height: 360px;
    background-color: #e2e2e2;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.46);
    display: flex;
    flex-direction: column;
    margin-bottom: 20px;
    padding: 20px;
`;

export const Row = styled.div`
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    grid-template-rows: repeat(4, 1fr);
    gap: 4px;
`;

export const Column = styled.div`
    display: flex;
    flex-direction: column;    
    align-items: center;
    justify-content: space-between;
    margin: 4px 0;
`;
