import styled from "styled-components";
import { Link } from "react-router-dom";

export const NavContainer = styled.div`
  display: flex;
  justify-content: flex-end;
`;

export const NavList = styled.ul`
  border-bottom: 0.25rem solid ${({ theme }) => theme.colors.blue[100]};

  display: inline-flex;
  list-style-type: none;

  & > * {
    padding: 0 1.25rem;
  }
`;

export const StyledLink = styled(Link)`
  font-size: 1.25rem;
  color: black;

  && {
    text-decoration: none;
  }
`;
