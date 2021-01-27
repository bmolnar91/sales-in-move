import React from "react";
import { NavBar } from "../NavBar";
import {
  Container,
  TopSectionContainer,
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
        <Image src="/images/logo.png" />
        <NavBar />
      </TopSectionContainer>
      <TextContainer>
        <p>{paragraph}</p>
      </TextContainer>
    </Container>
  );
};
