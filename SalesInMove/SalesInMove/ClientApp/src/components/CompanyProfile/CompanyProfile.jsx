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
const CompanyProfile = () => {
  const classes = useStyles();

  return (
    <Container className={classes.root} style={{ marginTop: '50px' }}>
      <Grid container>
        <Grid item xs={4}>
          <Container component='div'>
            <img
              src='images/Procter.jpg'
              width='350x'
              className={classes.profileImage}
            />
          </Container>
          <Container className={classes.videoTitleTextAndDividerContainer}>
            <Typography className={classes.videoTitleText}>
              Cég Információk
            </Typography>
            <Divider style={{ marginBottom: '20px' }} />
            <Typography style={{ marginBottom: '20px' }}>
              Név : Procter & Gamble Co. (rövidítve: P&G)
            </Typography>
            <Typography style={{ marginBottom: '20px' }}>
              Székhely : Budapest
            </Typography>
            <Typography style={{ marginBottom: '20px' }}>
              Alapítás éve: : 1837
            </Typography>
            <Typography style={{ marginBottom: '20px' }}>
              Szektor : Marketing
            </Typography>
            <Typography style={{ marginBottom: '20px' }}>
              Értékesítők létszáma : 100 fő
            </Typography>
            <Typography style={{ marginBottom: '20px' }}>
              Éves Nettó árbevétel : 100.000.000.000$
            </Typography>
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
            <Button
              startIcon={<MessageIcon />}
              style={{ marginTop: '30px', marginLeft: '10px' }}
            >
              Üzenet küldés
            </Button>
          </Container>
        </Grid>
        {/* Main container right half START*/}
        <Grid xs={8}>
          <Container component='div'>
            <iframe
              width='800'
              height='570'
              src='https://www.youtube.com/embed/W_EeQnObhjQ'
              frameborder='0'
              allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
              allowfullscreen
            ></iframe>
          </Container>
        </Grid>
        {/* Main container right half END*/}
      </Grid>
    </Container>
  );
};

export default CompanyProfile;
