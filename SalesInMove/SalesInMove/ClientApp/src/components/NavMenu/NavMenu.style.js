import styled from "styled-components";

export const Header = styled.header`
  a.navbar-brand {
    white-space: normal;
    text-align: center;
    word-break: break-all;
  }

  html {
    font-size: 14px;
  }
  @media (min-width: 768px) {
    html {
      font-size: 16px;
    }
  }

  .box-shadow {
    box-shadow: 0 0.25rem 0.75rem rgba(0, 0, 0, 0.05);
  }
`;
