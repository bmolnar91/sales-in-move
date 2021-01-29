import styled from "styled-components";

export const Container = styled.div`
  max-width: 1600px;
  margin: 10rem 0;

  & > * {
    margin-bottom: 2rem;
  }
`;

export const TopSectionContainer = styled.div`
  display: flex;
  justify-content: space-between;
`;

export const LogoImage = styled.img`
  width: 240px;
  height: 240px;
`;

export const MidSectionContainer = styled.div`
  display: flex;

  & > :first-child {
    padding-right: 3.125rem;
  }
`;

export const Image = styled.img`
  width: 538px;
  height: 450px;
`;

export const TextContainer = styled.div`
  width: 33.125rem;
  height: auto;

  align-self: center;
  white-space: pre-wrap;
`;
