import React, { useEffect, useState } from 'react';
import Avatar from '@material-ui/core/Avatar';
import Button from '@material-ui/core/Button';
import Select from '@material-ui/core/Select';
import CssBaseline from '@material-ui/core/CssBaseline';
import TextField from '@material-ui/core/TextField';
import FormControlLabel from '@material-ui/core/FormControlLabel';
import Checkbox from '@material-ui/core/Checkbox';
import Link from '@material-ui/core/Link';
import Grid from '@material-ui/core/Grid';
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import Typography from '@material-ui/core/Typography';
import { makeStyles, useTheme } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import FacebookIcon from '@material-ui/icons/Facebook';
import Divider from '@material-ui/core/Divider';
import SelectInput from '@material-ui/core/Select/SelectInput';
import { ControlledOpenSelect } from '../ControlledOpenSelect';
import { CheckboxesGroup } from '../CheckboxesGroup';
import MenuItem from '@material-ui/core/MenuItem';
import Input from '@material-ui/core/Input';
import FormControl from '@material-ui/core/FormControl';
import ListItemText from '@material-ui/core/ListItemText';
import Chip from '@material-ui/core/Chip';
import InputLabel from '@material-ui/core/InputLabel';

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(8),
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
  },
  form: {
    width: '100%', // Fix IE 11 issue.
  },
  submit: {
    margin: theme.spacing(3, 0, 2),
    // display: "flex",
    // justifyContent: "space-around",
  },
  mainContainer: {
    display: 'flex',
    // alignItems: "center",
    // justifyContent: "center",
    height: '80vh',
  },
  formControl: {
    margin: theme.spacing(1),
    minWidth: 120,
    maxWidth: 300,
  },
  chips: {
    display: 'flex',
    flexWrap: 'wrap',
  },
  chip: {
    margin: 2,
  },
  noLabel: {
    marginTop: theme.spacing(3),
  },
}));
const ITEM_HEIGHT = 48;
const ITEM_PADDING_TOP = 8;
const MenuProps = {
  PaperProps: {
    style: {
      maxHeight: ITEM_HEIGHT * 4.5 + ITEM_PADDING_TOP,
      width: 250,
    },
  },
};

export const SearchEmployees = () => {
  const classes = useStyles();
  const [state, setState] = useState();

  const names = ['felnőttképzés', 'érettségi', 'főiskola', 'egyetem', 'mester'];

  const [personName, setPersonName] = React.useState([]);

  const handleChange = (event) => {
    setPersonName(event.target.value);
    console.log(event.target.value);
  };
  //TEST
  // const handleChangeMultiple = (event) => {
  //   const { options } = event.target;
  //   const value = [];
  //   for (let i = 0, l = options.length; i < l; i += 1) {
  //     if (options[i].selected) {
  //       value.push(options[i].value);
  //     }
  //   }
  //   setPersonName(value);
  // };

  return (
    <Grid container className={classes.mainContainer}>
      <Grid container item xs={3}>
        <Grid item xs={12}>
          <FormControl className={classes.formControl}>
            <InputLabel id='demo-mutiple-name-label'>Name</InputLabel>
            <Select
              labelId='demo-mutiple-name-label'
              id='demo-mutiple-name'
              multiple
              value={personName}
              onChange={handleChange}
              input={<Input />}
              MenuProps={MenuProps}
            >
              {names.map((name) => (
                <MenuItem key={name} value={name}>
                  {name}
                </MenuItem>
              ))}
            </Select>
          </FormControl>
        </Grid>
        <Grid item xs={12}>
          <div className='container'>
            <div class='dropdown'>
              <a
                class='btn btn-secondary dropdown-toggle'
                role='button'
                id='dropdownMenuLink'
                data-bs-toggle='dropdown'
                aria-expanded='false'
              >
                Dropdown link
              </a>
              <ul class='dropdown-menu' aria-labelledby='dropdownMenuLink'>
                {educations.map((education) => (
                  <li class='dropdown-item'>{education}</li>
                ))}
              </ul>
            </div>
          </div>
        </Grid>
        <Grid item xs={12}></Grid>
        <Grid item xs={12}>
          <ControlledOpenSelect
            name='City'
            selectLabel={'Lokáció'}
            selectItems={[
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
            ].sort()}
          />
        </Grid>
        <Grid item xs={12}>
          <CheckboxesGroup
            name='Languages'
            checkboxLabel={'Beszélt nyelvek'}
            checkboxItems={[
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
            ].sort()}
          ></CheckboxesGroup>
        </Grid>
        <Grid item xs={12}>
          <ControlledOpenSelect
            name='drivingLicense'
            selectLabel={'Jogosítvány'}
            selectItems={['van', 'nincs']}
          />
          <Grid item xs={12}>
            <Button type='submit'>Hello</Button>
          </Grid>
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
