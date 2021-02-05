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
import profilePage from './pages/profile/profilePage';

const App = () => {
  return (
    <>
      <AppBar />
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
      <Route exact path='/ProfilePage' component={profilePage} />
      <StickyFooter />
    </>
  );
};

export default App;
