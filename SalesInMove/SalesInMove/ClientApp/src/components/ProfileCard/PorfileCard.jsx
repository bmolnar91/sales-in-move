import React from 'react';
import Grid from '@material-ui/core/Grid';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Typography from '@material-ui/core/Typography';
import AssignmentTurnedInIcon from '@material-ui/icons/AssignmentTurnedIn';
import AssignmentIcon from '@material-ui/icons/Assignment';
import Divider from '@material-ui/core/Divider';
import Button from '@material-ui/core/Button';
import SchoolIcon from '@material-ui/icons/School';
import LanguageIcon from '@material-ui/icons/Language';
import AttachMoneyIcon from '@material-ui/icons/AttachMoney';
import ArrowDropDownIcon from '@material-ui/icons/ArrowDropDown';
import DriveEtaIcon from '@material-ui/icons/DriveEta';

const useStyles = makeStyles((theme) => ({
  root: {
    height: '100vh',
    maxWidth: '80%',
    justifyContent: 'center',
    alignItems: 'center',
    marginTop: '100px',
  },
  mainGrid: {
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'center',
  },
  halfItem: {
    // display: 'flex',
    // justifyContent: 'center',
    // flexDirection: 'column',
    alignItems: 'center',
    margin: '50px',
  },
  profileHeadingContainer: {
    textAlign: 'center',
    fontWeight: '700',
    fontSize: '50px',
    letterSpacing: '5px',
  },
  profileImageContainer: {
    display: 'flex',
    justifyContent: 'center',
  },
  profileNameText: {
    marginTop: '20px',
    fontSize: '36px',
    textAlign: 'center',
    letterSpacing: '10px',
  },
  courseIfCourse: {
    display: 'flex',
    justifyContent: 'center',
    marginTop: '20px',
  },
  profileImage: {
    borderRadius: '10px',
  },
  salesCourseGridItem: {
    marginRight: '30px',
  },
  twitterText: {
    textAlign: 'center',
    color: 'grey',
  },
  skillsGridItem: {
    // textAlign: 'center',
    display: 'flex',
    alignItems: 'center',
    fontSize: '24px',
    marginTop: '40px',
  },
  skillsIcon: {
    fontSize: '40px',
  },
}));
const ProfileCard = () => {
  const classes = useStyles();
  return (
    <Container component='div' className={classes.root}>
      <Container component='div'>
        <Container component='div' className='startContainer'>
          <Container component='div' className={classes.profileImageContainer}>
            <img
              src='images/profile.jpg'
              width='150px'
              className={classes.profileImage}
            />
          </Container>
          <Typography className={classes.profileNameText} variant='h6'>
            Erzsébet Chan, 28, Budapest
          </Typography>
          <Typography className={classes.twitterText} variant='h6'>
            @chanzsi
          </Typography>
        </Container>

        <Grid container className={classes.courseIfCourse}>
          <Grid className={classes.salesCourseGridItem}>
            <AssignmentTurnedInIcon /> Sales kurzus előfizetés
          </Grid>
          <Grid>
            <AssignmentTurnedInIcon />
            Profiles Személyiség teszt
          </Grid>
        </Grid>
        <Divider style={{ marginTop: '30px' }} />
      </Container>
      <Grid container className={classes.mainGrid}>
        <Grid item xs={4} className={classes.halfItem}>
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
            Angol, Kínai
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <AttachMoneyIcon className={classes.skillsIcon} />
            50 milliós forgalom az elmúlt 1 évben
          </Grid>
          <Grid></Grid>
        </Grid>
        <Grid item xs={4} className={classes.halfItem}>
          <iframe
            width='400'
            height='315'
            src='https://www.youtube.com/embed/icxJjlhYVMw'
            frameborder='0'
            allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
            allowfullscreen
          ></iframe>
        </Grid>
      </Grid>
      <Container
        component='div'
        className='moreInfo'
        style={{
          display: 'flex',
          justifyContent: 'center',
        }}
      >
        <Button href='#text-buttons' color='primary'>
          További információk rólam <ArrowDropDownIcon />
        </Button>
      </Container>
      <Divider style={{ marginTop: '30px' }} />
      <Grid container className={classes.mainGrid}>
        <Grid item xs={4} className={classes.halfItem}>
          <Grid className={classes.skillsGridItem}>
            <DriveEtaIcon className={classes.skillsIcon}></DriveEtaIcon>
            Jogosítvánnyal rendelkezem
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <SchoolIcon className={classes.skillsIcon} />
            Egyéb oklevelek
          </Grid>
          <Typography style={{ marginTop: '25px' }} variant='h6'>
            Legutolsó munkahelyem:
          </Typography>
          <Typography>Google LLC </Typography>
          <Grid></Grid>
        </Grid>
        <Grid item xs={4} className={classes.halfItem}>
          <Typography variant='h6'>Referencia videó</Typography>
          <iframe
            width='400'
            height='315'
            src='https://www.youtube.com/embed/_Ha594R_zNw'
            frameborder='0'
            allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
            allowfullscreen
          ></iframe>
        </Grid>
        <Grid item xs={12} container>
          <Grid item xs={1} />
          <Grid item xs={9}>
            <Typography style={{ marginTop: '25px' }} variant='h6'>
              Amiben fejlődni szeretnék:
            </Typography>
            <Typography>
              It is a long established fact that a reader will be distracted by
              the readable content of a page when looking at its layout. The
              point of using Lorem Ipsum is that it has a more-or-less normal
              distribution of letters, as opposed to using 'Content here,
              content here', making it look like readable English. Many desktop
              publishing packages and web page editors now use Lorem Ipsum as
              their default model text, and a search for 'lorem ipsum' will
              uncover many web sites still in their infancy.
            </Typography>
            <Typography style={{ marginTop: '25px' }} variant='h6'>
              Amiben jó vagyok:
            </Typography>
            <Typography>
              It is a long established fact that a reader will be distracted by
              the readable content of a page when looking at its layout. The
              point of using Lorem Ipsum is that it has a more-or-less normal
              distribution of letters, as opposed to using 'Content here,
              content here', making it look like readable English. Many desktop
              publishing packages and web page editors now use Lorem Ipsum as
              their default model text, and a search for 'lorem ipsum' will
              uncover many web sites still in their infancy.
            </Typography>
          </Grid>
        </Grid>
        <Grid item xs={1} />
      </Grid>
    </Container>
  );
};

export default ProfileCard;
