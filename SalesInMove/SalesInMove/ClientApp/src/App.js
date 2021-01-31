import React, { Component } from 'react';
import { Route } from 'react-router';
import Container from '@material-ui/core/Container';
import Box from '@material-ui/core/Box';
import { HomePage } from './pages/home/home';
import { RegistrationMain } from './pages/registration/registration-main';
import { RegistrationEmployer } from './pages/registration/registration-employer';
import { RegistrationEmployee } from './pages/registration/registration-employee';
import { LoginPage } from './pages/login/login';
import { StickyFooter } from './components/StickyFooter';
import { AppBar } from './components/AppBar';
import Grid from '@material-ui/core/Grid';
import { makeStyles } from '@material-ui/core/styles';
import Image from './images/homepageBg.jpg';

const useStyles = makeStyles((theme) => ({
  mainGridItem: {
    backgroundImage: `url(${Image})`,
    backgroundSize: 'cover',
  },
  fullWidthContainerMain: {
    marginLeft: '100px',
    marginTop: '150px',
  },
}));

const App = () => {
  const classes = useStyles();
  return (
    <Grid
      container
      direction='row'
      spacing={1}
      className={classes.mainGridItem}
    >
      <Grid xs={12}>
        <AppBar />
      </Grid>
      <Grid xs={12}>
        <Container maxWidth='xl' className={classes.fullWidthContainerMain}>
          <Box my={4}>
            <Route exact path='/' component={HomePage} />
            <Route exact path='/regisztracio' component={RegistrationMain} />
            <Route
              exact
              path='/regisztracio/munkaltato'
              component={RegistrationEmployer}
            />
            <Route
              exact
              path='/regisztracio/munkavallalo'
              component={RegistrationEmployee}
            />
            <Route exact path='/bejelentkezes' component={LoginPage} />
          </Box>
        </Container>
      </Grid>
      <Grid xs={12}>
        <StickyFooter />
      </Grid>
    </Grid>
  );
};

export default App;
