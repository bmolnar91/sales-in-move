import styled from "styled-components";

export const Container = styled.div`
  max-width: 1600px;
  margin: 2rem 0;

  & > * {
    margin-bottom: 5rem;
  }
`;

export const TopSectionContainer = styled.div`
  display: flex;
  justify-content: space-between;
`;

export const Image = styled.img`
  width: 280px;
  height: 280px;
`;

export const TextContainer = styled.div`
  width: 33.125rem;
  height: auto;

  white-space: pre-wrap;
`;
