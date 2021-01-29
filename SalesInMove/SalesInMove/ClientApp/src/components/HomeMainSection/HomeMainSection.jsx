import React from "react";
import {
  Container,
  MidSectionContainer,
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
