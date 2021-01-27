import React, { Component } from "react";
import { Route } from "react-router";
import { ThemeProvider } from "./styles/provider";
import { Layout } from "./components/Layout/Layout";
import { Home } from "./pages/home/home";
import { RegistrationMain } from "./pages/registration/registration-main";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <ThemeProvider>
        <Layout>
          <Route exact path="/" component={Home} />
          <Route exact path="/regisztracio" component={RegistrationMain} />
        </Layout>
      </ThemeProvider>
    );
  }
}
