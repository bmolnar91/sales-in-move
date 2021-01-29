import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import { Container, Box, Button } from "@material-ui/core";

const useStyles = makeStyles((theme) => ({
  button: {
    margin: theme.spacing(3),
  },
  box: {
    marginTop: "15rem",
    display: "flex",
    justifyContent: "space-around",
  },
}));

export function Registration() {
  const classes = useStyles();
  return (
    <Container>
      <h1>Regisztráció</h1>
      <Box className={classes.box}>
        <Button
          variant="contained"
          color="primary"
          href="/regisztracio/munkavallalo"
          className={classes.margin}
        >
          Munkavállalóként
        </Button>
        <Button
          variant="contained"
          color="primary"
          href="/regisztracio/munkaltato"
        >
          Munkáltatóként
        </Button>
      </Box>
    </Container>
  );
}
