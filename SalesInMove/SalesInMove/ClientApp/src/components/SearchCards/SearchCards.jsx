import React from 'react';
import Avatar from '@material-ui/core/Avatar';
import Button from '@material-ui/core/Button';
import CssBaseline from '@material-ui/core/CssBaseline';
import TextField from '@material-ui/core/TextField';
import FormControlLabel from '@material-ui/core/FormControlLabel';
import Checkbox from '@material-ui/core/Checkbox';
import Link from '@material-ui/core/Link';
import Grid from '@material-ui/core/Grid';
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import Typography from '@material-ui/core/Typography';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import FacebookIcon from '@material-ui/icons/Facebook';
import Divider from '@material-ui/core/Divider';
import SelectInput from '@material-ui/core/Select/SelectInput';
import AssignmentTurnedInIcon from '@material-ui/icons/AssignmentTurnedIn';
import AssignmentIcon from '@material-ui/icons/Assignment';
import SchoolIcon from '@material-ui/icons/School';
import LanguageIcon from '@material-ui/icons/Language';
import AttachMoneyIcon from '@material-ui/icons/AttachMoney';
import ArrowDropDownIcon from '@material-ui/icons/ArrowDropDown';
import DriveEtaIcon from '@material-ui/icons/DriveEta';
import EmojiPeopleIcon from '@material-ui/icons/EmojiPeople';

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
    minHeight: '80vh',
  },
  skillsIcon: {
    color: '#0044f4',
    marginRight: '5px',
  },
  skillsGridItem: {
    display: 'flex',
    alignItems: 'center',
  },
}));

const SearchCards = (props) => {
  const classes = useStyles();
  return (
    <Grid
      container
      item
      xs={5}
      style={{
        height: '200px',
        margin: '20px',
        boxShadow: '0px 0px 5px 0px rgba(0,0,0,0.15)',
      }}
    >
      <Grid
        item
        xs={6}
        style={{
          display: 'flex',
          justifyContent: 'center',
          flexDirection: 'column',
        }}
      >
        <img
          src='images/profile2.jpg'
          width='170x'
          className={classes.profileImage}
        />
        <div>{props.userInfo.FirstName} 28 Budapest</div>
        <Button style={{ width: '30px' }}> Tovább </Button>
      </Grid>
      <Grid
        item
        xs={6}
        style={{
          display: 'flex',
          justifyContent: 'center',
          flexDirection: 'column',
        }}
      >
        <Grid className={classes.skillsGridItem}>
          <AssignmentTurnedInIcon
            className={classes.skillsIcon}
          ></AssignmentTurnedInIcon>
          Sales Specialist
        </Grid>
        <Grid className={classes.skillsGridItem}>
          <SchoolIcon className={classes.skillsIcon} />
          Marketing BA
        </Grid>
        <Grid className={classes.skillsGridItem}>
          <LanguageIcon className={classes.skillsIcon} />
          Angol, Kínai, Francia
        </Grid>
        <Grid className={classes.skillsGridItem}>
          <AttachMoneyIcon className={classes.skillsIcon} />
          50 milliós forgalom
        </Grid>
      </Grid>
    </Grid>
  );
};

export default SearchCards;
