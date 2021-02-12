import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import InputLabel from '@material-ui/core/InputLabel';
import MenuItem from '@material-ui/core/MenuItem';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import Button from '@material-ui/core/Button';
import { v4 as uuidv4 } from 'uuid';
import { ControlledOpenSelect } from '../ControlledOpenSelect';
import { CheckboxesGroup } from '../CheckboxesGroup';
import Grid from '@material-ui/core/Grid';
import FormGroup from '@material-ui/core/FormGroup';
import Checkbox from '@material-ui/core/Checkbox';
import axios from 'axios';

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  paper: {
    height: 140,
    width: 100,
  },
  control: {
    padding: theme.spacing(2),
  },
}));

const educations = [
  'felnőttképzés',
  'érettségi',
  'főiskola',
  'egyetem',
  'mester',
];
const locations = [
  'Budapest',
  'Székesfehérvár',
  'Siófok',
  'Debrecen',
  'Győr',
  'Veszprém',
  'Miskolc',
  'Budaörs',
  'Tatabánya',
  'Szeged',
  'Kecskemét',
  'Pécs',
  'Szombathely',
  'Szolnok',
  'Nyíregyháza',
  'Dunakeszi',
  'Zalaegerszeg',
  'Érd',
];
const languagesArr = [
  'angol',
  'német',
  'spanyol',
  'francia',
  'kínai',
  'orosz',
  'lengyel',
  'szlovák',
  'cseh',
  'román',
  'szerb',
];

export const SearchEmployees = () => {
  const classes = useStyles();
  const [age, setAge] = React.useState('');
  const [open, setOpen] = React.useState(false);
  const [ager, setAger] = React.useState('');
  const [openr, setOpenr] = React.useState(false);

  const [ageLic, setAgeLic] = React.useState('');
  const [openLic, setOpenLic] = React.useState(false);
  const [languages, setLanguages] = React.useState([]);
  const [searchResults, setSearchReults] = React.useState();

  //select education
  const handleChange = (event) => {
    setAge(event.target.value);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleOpen = () => {
    setOpen(true);
  };
  //select city
  const handleChange2 = (event) => {
    setAger(event.target.value);
  };

  const handleClose2 = () => {
    setOpenr(false);
  };

  const handleOpen2 = () => {
    setOpenr(true);
  };
  //license
  const handleChangeLic = (event) => {
    setAgeLic(event.target.value);
  };

  const handleCloseLic = () => {
    setOpenLic(false);
  };

  const handleOpenLic = () => {
    setOpenLic(true);
  };

  const axios = require('axios').default;

  const sendRequest = () => {
    const resp = axios.get(`/api/account/search?Education=${age}&City=${ager}&DrivingLicence=${ageLic}`, {
      headers: {
        'Education': age,
        'City': ager,
        'DrivingLicence': ageLic 
      }
    }).then(resp => console.log(resp));
    console.log(resp);
  }

  //chekcbox language
  const changeLang = (e) => {
    console.log(e.target.value);
    if (languages.includes(e.target.value)) {
      setLanguages(languages.filter((item) => item !== e.target.value));
    }
    setLanguages([...languages, e.target.value]);
  };
  console.log(languages);

  return (
    <Grid container className={classes.mainContainer}>
      <Grid container item xs={3}>
        <form
          className={classes.formControl}
          method='get'
          action='/api/account/search'
        >
          <Grid item xs={12}>
            <InputLabel id='demo-controlled-open-select-label'>
              Végzettség
            </InputLabel>
            <Select
              labelId='demo-controlled-open-select-label'
              id='demo-controlled-open-select'
              open={open}
              onClose={handleClose}
              onOpen={handleOpen}
              value={age}
              onChange={handleChange}
              name='Education'
            >
              <MenuItem value=''>
                <em>None</em>
              </MenuItem>
              {educations.map((education) => (
                <MenuItem key={uuidv4()} value={education}>
                  {education}
                </MenuItem>
              ))}
            </Select>
          </Grid>
          <Grid item xs={12} style={{ marginTop: '130px' }}>
            <InputLabel id='demo-controlled-open-select-label'>
              Lokáció
            </InputLabel>
            <Select
              labelId='demo-controlled-open-select-label'
              id='demo-controlled-open-select'
              open={openr}
              onClose={handleClose2}
              onOpen={handleOpen2}
              value={ager}
              onChange={handleChange2}
              name='City'
            >
              <MenuItem value=''>
                <em>None</em>
              </MenuItem>
              {locations.map((education) => (
                <MenuItem key={uuidv4()} value={education}>
                  {education}
                </MenuItem>
              ))}
            </Select>
          </Grid>
          <Grid item xs={12}></Grid>
          <Grid item xs={12} style={{ marginTop: '130px' }}>
            <InputLabel id='demo-controlled-open-select-label'>
              Jogosítvány
            </InputLabel>
            <Select
              labelId='demo-controlled-open-select-label'
              id='demo-controlled-open-select'
              open={openLic}
              onClose={handleCloseLic}
              onOpen={handleOpenLic}
              value={ageLic}
              onChange={handleChangeLic}
              name='DrivingLicence'
            >
              <MenuItem value=''>
                <em>None</em>
              </MenuItem>
              <MenuItem value='van'>
                <em>Van</em>
              </MenuItem>
              <MenuItem value='nincs'>
                <em>Nincs</em>
              </MenuItem>
            </Select>
          </Grid>
          <Button
            onClick={sendRequest}
          >
            lol
          </Button>
          <Button
            style={{ marginTop: '30px' }}
            variant='contained'
            color='primary'
            type='submit'
          >
            Keresés
          </Button>
        </form>
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

// import React, { useEffect, useState } from "react";
// import Avatar from "@material-ui/core/Avatar";
// import Button from "@material-ui/core/Button";
// import Select from '@material-ui/core/Select';
// import CssBaseline from "@material-ui/core/CssBaseline";
// import TextField from "@material-ui/core/TextField";
// import FormControlLabel from "@material-ui/core/FormControlLabel";
// import Checkbox from "@material-ui/core/Checkbox";
// import Link from "@material-ui/core/Link";
// import Grid from "@material-ui/core/Grid";
// import LockOutlinedIcon from "@material-ui/icons/LockOutlined";
// import Typography from "@material-ui/core/Typography";
// import { makeStyles } from "@material-ui/core/styles";
// import Container from "@material-ui/core/Container";
// import FacebookIcon from "@material-ui/icons/Facebook";
// import Divider from "@material-ui/core/Divider";
// import SelectInput from "@material-ui/core/Select/SelectInput";
// import { ControlledOpenSelect } from "../ControlledOpenSelect";
// import { CheckboxesGroup } from "../CheckboxesGroup";
// import MenuItem from '@material-ui/core/MenuItem';
// import Input from '@material-ui/core/Input';
// import { FormControl } from "@material-ui/core";

// const useStyles = makeStyles((theme) => ({
//   paper: {
//     marginTop: theme.spacing(8),
//     display: "flex",
//     flexDirection: "column",
//     alignItems: "center",
//   },
//   form: {
//     width: "100%", // Fix IE 11 issue.
//   },
//   submit: {
//     margin: theme.spacing(3, 0, 2),
//     // display: "flex",
//     // justifyContent: "space-around",
//   },
//   mainContainer: {
//     display: "flex",
//     // alignItems: "center",
//     // justifyContent: "center",
//     height: "80vh",
//   },
// }));

// export const SearchEmployees = () => {
//   const classes = useStyles();
//   const [state, setState] = useState();

//   useEffect(
//     () => console.log(document.querySelector(".education"))
//   ,[])
  
//   const changedVal = (e) => {
//     console.log("e.target");
//   }

//   const educations = [
//     "felnőttképzés",
//     "érettségi",
//     "főiskola",
//     "egyetem",
//     "mester",
//   ]

//   return (
//     <Grid container className={classes.mainContainer}>
      
//       <form method="get" action="/api/account/search">
//         <input name="Education"/>
//         <input name="City"/>
//         <input name="Languages"/>
//         <label>
//         DrivingLicence
//         </label>
//         <input name="DrivingLicence" type="checkbox"/>
//         <button type="submit">Send</button>
//       </form>
//       <form method="get" action="/api/account/search">
//         <Grid container item xs={3}>
//           <Grid item xs={12}>
//           <div className="container">
//           <div class="dropdown">
//             <a class="btn btn-secondary dropdown-toggle" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
//               Dropdown link
//             </a>
//             <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
//               {educations.map(education => <li class="dropdown-item">{education}</li>)}
//               </ul>
//            </div>
//           </div>
          
//           </Grid>
//           <Grid item xs={12}></Grid>
//           <Grid item xs={12}>
//             <ControlledOpenSelect
//               name="City"
//               selectLabel={"Lokáció"}
//               selectItems={[
//                 "Budapest",
//                 "Székesfehérvár",
//                 "Siófok",
//                 "Debrecen",
//                 "Győr",
//                 "Veszprém",
//                 "Miskolc",
//                 "Budaörs",
//                 "Tatabánya",
//                 "Szeged",
//                 "Kecskemét",
//                 "Pécs",
//                 "Szombathely",
//                 "Szolnok",
//                 "Nyíregyháza",
//                 "Dunakeszi",
//                 "Zalaegerszeg",
//                 "Érd",
//               ].sort()}
//             />
//           </Grid>
//           <Grid item xs={12}>
//             <CheckboxesGroup
//               name="Languages"
//               checkboxLabel={"Beszélt nyelvek"}
//               checkboxItems={[
//                 "angol",
//                 "német",
//                 "spanyol",
//                 "francia",
//                 "kínai",
//                 "orosz",
//                 "lengyel",
//                 "szlovák",
//                 "cseh",
//                 "román",
//                 "szerb",
//               ].sort()}
//             ></CheckboxesGroup>
//           </Grid>
//           <Grid item xs={12}>
//             <ControlledOpenSelect
//               name="drivingLicense"
//               selectLabel={"Jogosítvány"}
//               selectItems={["van", "nincs"]}
//             />
//           <Grid item xs={12}>
//             <Button type="submit">Hello</Button>
//           </Grid>
//           </Grid>
//         </Grid>
//       </form>
//       <Grid container item xs={9}>
//         <Grid item xs={12}>
//           <div>Hello</div>
//         </Grid>
//         <Grid item xs={12}>
//           <div>Hello</div>
//         </Grid>
//         <Grid item xs={12}>
//           <div>Hello</div>
//         </Grid>
//         <Grid item xs={12}>
//           <div>Hello</div>
//         </Grid>
//         <Grid item xs={12}>
//           <div>Hello</div>
//         </Grid>
//       </Grid>
//     </Grid>
//   );
// };
