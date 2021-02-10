import React, { useEffect } from "react";
import { Route, Switch } from "react-router";
import { HomePage } from "./pages/home/home";
import { RegistrationMain } from "./pages/registration/registration-main";
import { RegistrationEmployer } from "./pages/registration/registration-employer";
import { RegistrationEmployee } from "./pages/registration/registration-employee";
import { LoginPage } from "./pages/login/login";
import { StickyFooter } from "./components/StickyFooter";
import { AppBar } from "./components/AppBar";
import profilePage from "./pages/profile/profilePage";

const App = () => {
  useEffect(() => {}, []);

  return (
    <>
      <AppBar />
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/regisztracio" component={RegistrationMain} />
        <Route
          exact
          path="/regisztracio/munkaltato"
          component={RegistrationEmployer}
        />
        <Route
          exact
          path="/regisztracio/munkavallalo"
          component={RegistrationEmployee}
        />
        <Route exact path="/bejelentkezes" component={LoginPage} />
        <Route exact path="/ProfilePage" component={profilePage} />
      </Switch>
      {/* <StickyFooter /> */}
    </>
  );
};

export default App;
