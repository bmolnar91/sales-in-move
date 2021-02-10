import React from "react";
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
import SelectInput from "@material-ui/core/Select/SelectInput";
import { ControlledOpenSelect } from "../ControlledOpenSelect";

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(8),
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
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
    // alignItems: "center",
    // justifyContent: "center",
    height: "80vh",
  },
}));

export const SearchEmployees = () => {
  const classes = useStyles();
  return (
    <Grid container className={classes.mainContainer}>
      <Grid container item xs={3}>
        <Grid item xs={12}>
          <ControlledOpenSelect
            label={"Végzettség"}
            items={[
              "felnőttképzés",
              "érettségi",
              "főiskola",
              "egyetem",
              "mester",
            ]}
          />
        </Grid>
        <Grid item xs={12}></Grid>
        <Grid item xs={12}>
          <ControlledOpenSelect
            label={"Lokáció"}
            items={[
              "Budapest",
              "Székesfehérvár",
              "Siófok",
              "Debrecen",
              "Győr",
              "Veszprém",
              "Miskolc",
              "Budaörs",
              "Tatabánya",
              "Szeged",
              "Kecskemét",
              "Pécs",
              "Szombathely",
              "Szolnok",
              "Nyíregyháza",
              "Dunakeszi",
              "Zalaegerszeg",
              "Érd",
            ].sort()}
          />
        </Grid>
        <Grid item xs={12}>
          <Checkbox></Checkbox>
        </Grid>
        <Grid item xs={12}>
          <Checkbox></Checkbox>
        </Grid>
      </Grid>
      <Grid container item xs={9}>
        <Grid item xs={12}>
          <div>Hello</div>
        </Grid>
        <Grid item xs={12}>
          <div>Hello</div>
        </Grid>
        <Grid item xs={12}>
          <div>Hello</div>
        </Grid>
        <Grid item xs={12}>
          <div>Hello</div>
        </Grid>
        <Grid item xs={12}>
          <div>Hello</div>
        </Grid>
      </Grid>
    </Grid>
  );
};
