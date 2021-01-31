import { createGlobalStyle } from 'styled-components';

export const GlobalStyle = createGlobalStyle`
  * {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
    font-weight: 400;
  }

  html, body {
    height: 100%;
    margin: 0 auto;
  }

  b {
    font-weight: 600;
  }
`;
