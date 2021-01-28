import React from "react";
import { NavBar } from "../NavBar";
import {
  Container,
  TopSectionContainer,
  MidSectionContainer,
  LogoImage,
  Image,
  TextContainer,
} from "./HomeMainSection.style";

export const HomeMainSection = () => {
  const paragraph = `Mi jut eszedbe a következő szavakról? Munkakeresés és a pozícióra a lefmegfelelőbb embert megtalálása? Hosszú, unalmas, stresszes, fárasztó, irritáló. Nagyon kevés választ kaptam mely szerint érdekes, szórakoztató vagy akár kihívásokkal teli.

Mi úgy gondoltuk, hogy legyen ez a stresszes feladat egy jó kikapcsolódás. Mutasd meg szeméyiségedet azonnal .... önéletrajzod csak később lesz fontos. 
  
Merj önmagad lenni. Felkészültél??
  
MOVE`;

  return (
    <Container>
      <TopSectionContainer>
        <LogoImage src="/images/logo-02.png" />
        <NavBar />
      </TopSectionContainer>
      <MidSectionContainer>
        <TextContainer>
          <p>{paragraph}</p>
        </TextContainer>
        <Image src="/images/landing-01.png" />
      </MidSectionContainer>
      <br />
    </Container>
  );
};
