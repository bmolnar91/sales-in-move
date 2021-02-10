import React, { useState } from "react";
import axios from "axios";
import { useHistory } from "react-router-dom";
import FormData from "form-data";
import Avatar from "@material-ui/core/Avatar";
import Button from "@material-ui/core/Button";
import CssBaseline from "@material-ui/core/CssBaseline";
import TextField from "@material-ui/core/TextField";
import FormControlLabel from "@material-ui/core/FormControlLabel";
import Checkbox from "@material-ui/core/Checkbox";
import Link from "@material-ui/core/Link";
import Grid from "@material-ui/core/Grid";
import LockOutlinedIcon from "@material-ui/icons/LockOutlined";
import Typography from "@material-ui/core/Typography";
import { makeStyles } from "@material-ui/core/styles";
import Container from "@material-ui/core/Container";
import FacebookIcon from "@material-ui/icons/Facebook";
import Divider from "@material-ui/core/Divider";

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(8),
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
  },
  avatar: {
    margin: theme.spacing(1),
    backgroundColor: theme.palette.secondary.main,
  },
  form: {
    width: "100%", // Fix IE 11 issue.
  },
  submit: {
    margin: theme.spacing(3, 0, 2),
    // display: "flex",
    // justifyContent: "space-around",
  },
  mainContainer: {
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    height: "80vh",
  },
  google: {
    backgroundColor: "#d9534f",
    marginTop: "50px",
    color: "white",
  },
}));

export function LoginForm() {
  const classes = useStyles();
  let history = useHistory();

  const [formInputFields, setFormInputFields] = useState({
    email: "",
    password: "",
  });

  const [isValidLogin, setIsValidLogin] = useState(false);

  const passwordOnChange = (e) => {
    setFormInputFields({ ...formInputFields, password: e.target.value });
  };

  const emailOnChange = (e) => {
    setFormInputFields({ ...formInputFields, email: e.target.value });
  };

  const onSubmit = (e) => {
    e.preventDefault();

    let bodyFormData = new FormData();
    bodyFormData.append("email", formInputFields.email);
    bodyFormData.append("password", formInputFields.password);
    console.log(bodyFormData.get("email"));

    axios({
      method: "post",
      url: "/api/account/login",
      data: bodyFormData,
      headers: { "Content-type": "multipart/form-data" },
    })
      .then((res) => {
        console.log(res);
        const token = res.data.token;
        localStorage.setItem("jwt", token);

        setIsValidLogin(true);
      })
      .catch((err) => {
        console.log(err);
      });

    if (isValidLogin) {
      history.push("/");
    }
  };

  return (
    <Container component="main" maxWidth="xs" className={classes.mainContainer}>
      <CssBaseline />
      <div className={classes.paper}>
        <Avatar className={classes.avatar}>
          <LockOutlinedIcon />
        </Avatar>
        <Typography component="h1" variant="h5">
          Bejelentkezés
        </Typography>
        <form
          className={classes.form}
          noValidate
          // method="post"
          // action="/api/account/login"
          onSubmit={onSubmit}
        >
          <TextField
            variant="outlined"
            margin="normal"
            required
            fullWidth
            id="email"
            label="Email cím"
            // name="email"
            autoComplete="email"
            autoFocus
            onChange={emailOnChange}
          />
          <TextField
            variant="outlined"
            margin="normal"
            required
            fullWidth
            // name="password"
            label="Jelszó"
            type="password"
            id="password"
            autoComplete="current-password"
            onChange={passwordOnChange}
          />
          <FormControlLabel
            control={<Checkbox value="remember" color="primary" />}
            label="Emlékezz rám"
          />
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            className={classes.submit}
          >
            Bejelentkezés
          </Button>
          <Grid container>
            <Grid item xs>
              <Link href="#" variant="body2">
                Elfelejtett jelszó
              </Link>
            </Grid>
            <Grid item>
              <Link href="/regisztracio" variant="body2">
                {"Nincs fiókod? Regisztrálj"}
              </Link>
            </Grid>
          </Grid>
          <Divider />
          <Button
            type="submit"
            fullWidth
            variant="contained"
            className={(classes.submit, classes.google)}
          >
            <img height="20px" width="20px" src="images/google-icon.png"></img>
            Log in with Google
          </Button>
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            className={classes.submit}
          >
            <FacebookIcon />
            Log in with Facebook
          </Button>
        </form>
      </div>
    </Container>
  );
}
