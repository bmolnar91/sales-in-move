import React from "react";
import { NavContainer, NavList, StyledLink } from "./NavBar.style";

export const NavBar = () => {
  return (
    <>
      <NavContainer>
        <NavList>
          <li>
            <StyledLink to="#">Missziónk</StyledLink>
          </li>
          <li>
            <StyledLink to="#">Munkát keresel?</StyledLink>
          </li>
          <li>
            <StyledLink to="#">Munkát kínálsz?</StyledLink>
          </li>
          <li>
            <StyledLink to="#">Partnereink</StyledLink>
          </li>
          <li>
            <StyledLink to="#">Kapcsolat</StyledLink>
          </li>
        </NavList>
      </NavContainer>
    </>
  );
};
