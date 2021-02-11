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
import LocationOnIcon from '@material-ui/icons/LocationOn';
import CheckCircleIcon from '@material-ui/icons/CheckCircle';
import MessageIcon from '@material-ui/icons/Message';
import SaveIcon from '@material-ui/icons/Save';
import ProfileCardTabs from '../ProfileCardTabs/ProfileCardTabs';

const useStyles = makeStyles((theme) => ({
  root: {
    marginTop: '20px',
  },
  videoTitleText: {
    fontSize: '12px',
    color: '#a1a1a1',
    paddingTop: '12px',
  },
  videoTitleTextAndDividerContainer: {
    paddingRight: '24px',
    paddingLeft: '24px',
  },
  gridRightHalfTop: {
    height: '34%',
    padding: '0px 24px 0px 24px',
  },
  checkCircleIcon: {
    marginRight: '15px',
  },
}));
const ProfileCard = () => {
  const classes = useStyles();

  return (
    <Container className={classes.root}>
      <Grid container>
        <Grid item xs={4}>
          <Container component='div'>
            <img
              src='images/profile2.jpg'
              width='350x'
              className={classes.profileImage}
            />
          </Container>
          <Container className={classes.videoTitleTextAndDividerContainer}>
            <Typography className={classes.videoTitleText}>
              Bemutatkozó videó
            </Typography>
            <Divider style={{ marginBottom: '15px' }} />
          </Container>
          <Container component='div'>
            <iframe
              width='350'
              height='200'
              src='https://www.youtube.com/embed/icxJjlhYVMw'
              frameborder='0'
              allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
              allowfullscreen
            ></iframe>
          </Container>
          <Container className={classes.videoTitleTextAndDividerContainer}>
            <Typography className={classes.videoTitleText}>
              Rólam mondták
            </Typography>
            <Divider style={{ marginBottom: '15px' }} />
          </Container>
          <Container component='div'>
            <iframe
              width='350'
              height='200'
              src='https://www.youtube.com/embed/_Ha594R_zNw'
              frameborder='0'
              allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
              allowfullscreen
            ></iframe>
          </Container>
        </Grid>
        {/* Main container right half START*/}
        <Grid item container xs={8}>
          {/*  right half top  */}
          <Grid item container className={classes.gridRightHalfTop}>
            <Grid item item xs={4}>
              <Typography
                variant='h4'
                style={{
                  fontWeight: '500',
                }}
              >
                Erzsébet Chen
              </Typography>
            </Grid>
            <Grid
              item
              style={{
                color: 'grey',
              }}
              xs={8}
            >
              <LocationOnIcon style={{ color: 'grey' }} /> Budapest, HUN
            </Grid>
            <Grid
              item
              xs={12}
              style={{
                color: '#0044f4',
                fontSize: '18px',
                marginTop: '-15px',
                fontWeight: '500',
              }}
            >
              Sales Manager
            </Grid>
            <Grid item xs={4}>
              <Grid>
                <CheckCircleIcon
                  color='primary'
                  className={classes.checkCircleIcon}
                />
                Sales Kurzus előfizetés
              </Grid>
              <Button startIcon={<MessageIcon />} style={{ marginTop: '30px' }}>
                Üzenet küldés
              </Button>
            </Grid>
            <Grid item xs={4}>
              <CheckCircleIcon
                className={classes.checkCircleIcon}
                color='primary'
              />
              Profile személyiség teszt
              <Button
                startIcon={<SaveIcon />}
                variant='outlined'
                color='primary'
                style={{
                  marginTop: '30px',
                }}
              >
                Profil mentése
              </Button>
            </Grid>
          </Grid>
          {/*  right half bottom*/}
          <Grid
            item
            style={{
              display: 'flex',
              alignItems: 'flex-start',
              height: '100%',
            }}
          >
            <ProfileCardTabs />
          </Grid>
        </Grid>
        {/* Main container right half END*/}
      </Grid>
    </Container>
  );
};

export default ProfileCard;
