import React, { useEffect, useState } from "react";
import Avatar from "@material-ui/core/Avatar";
import Button from "@material-ui/core/Button";
import Select from '@material-ui/core/Select';
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
import { CheckboxesGroup } from "../CheckboxesGroup";
import MenuItem from '@material-ui/core/MenuItem';
import Input from '@material-ui/core/Input';
import { FormControl } from "@material-ui/core";

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
  const [state, setState] = useState();

  useEffect(
    () => console.log(document.querySelector(".education"))
  ,[])
  
  const changedVal = (e) => {
    console.log("e.target");
  }

  const educations = [
    "felnőttképzés",
    "érettségi",
    "főiskola",
    "egyetem",
    "mester",
  ]

  return (
    <Grid container className={classes.mainContainer}>
      
      <form method="get" action="/api/account/search">
        <input name="Education"/>
        <input name="City"/>
        <input name="Languages"/>
        <label>
        DrivingLicence
        </label>
        <input name="DrivingLicence" type="checkbox"/>
        <button type="submit">Send</button>
      </form>
      <form method="get" action="/api/account/search">
        <Grid container item xs={3}>
          <Grid item xs={12}>
          <div className="container">
          <div class="dropdown">
            <a class="btn btn-secondary dropdown-toggle" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
              Dropdown link
            </a>
            <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
              {educations.map(education => <li class="dropdown-item">{education}</li>)}
              </ul>
           </div>
          </div>
          
          </Grid>
          <Grid item xs={12}></Grid>
          <Grid item xs={12}>
            <ControlledOpenSelect
              name="City"
              selectLabel={"Lokáció"}
              selectItems={[
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
            <CheckboxesGroup
              name="Languages"
              checkboxLabel={"Beszélt nyelvek"}
              checkboxItems={[
                "angol",
                "német",
                "spanyol",
                "francia",
                "kínai",
                "orosz",
                "lengyel",
                "szlovák",
                "cseh",
                "román",
                "szerb",
              ].sort()}
            ></CheckboxesGroup>
          </Grid>
          <Grid item xs={12}>
            <ControlledOpenSelect
              name="drivingLicense"
              selectLabel={"Jogosítvány"}
              selectItems={["van", "nincs"]}
            />
          <Grid item xs={12}>
            <Button type="submit">Hello</Button>
          </Grid>
          </Grid>
        </Grid>
      </form>
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
