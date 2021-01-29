import React from "react";
import { Container, Button } from "@material-ui/core";
import { Registration } from "../../components/Registration";

export const RegistrationMain = () => {
  return (
    // <Container>
    //   <h1>Regisztráció</h1>
    //   <Button variant="contained" href="/regisztracio/munkavallalo">
    //     Munkavállalóként
    //   </Button>
    //   <Button variant="contained" href="/regisztracio/munkaltato">
    //     Munkáltatóként
    //   </Button>
    // </Container>
    <Registration />
  );
};
