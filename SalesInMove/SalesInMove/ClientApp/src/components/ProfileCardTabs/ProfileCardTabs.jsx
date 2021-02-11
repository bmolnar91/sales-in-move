import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import Typography from '@material-ui/core/Typography';
import Box from '@material-ui/core/Box';
import Grid from '@material-ui/core/Grid';
import AssignmentTurnedInIcon from '@material-ui/icons/AssignmentTurnedIn';
import AssignmentIcon from '@material-ui/icons/Assignment';
import SchoolIcon from '@material-ui/icons/School';
import LanguageIcon from '@material-ui/icons/Language';
import AttachMoneyIcon from '@material-ui/icons/AttachMoney';
import ArrowDropDownIcon from '@material-ui/icons/ArrowDropDown';
import DriveEtaIcon from '@material-ui/icons/DriveEta';
import Container from '@material-ui/core/Container';
import Divider from '@material-ui/core/Divider';
import EmojiPeopleIcon from '@material-ui/icons/EmojiPeople';
function TabPanel(props) {
  const { children, value, index, ...other } = props;

  return (
    <div
      role='tabpanel'
      hidden={value !== index}
      id={`scrollable-auto-tabpanel-${index}`}
      aria-labelledby={`scrollable-auto-tab-${index}`}
      {...other}
    >
      {value === index && (
        <Box p={3}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </div>
  );
}

TabPanel.propTypes = {
  children: PropTypes.node,
  index: PropTypes.any.isRequired,
  value: PropTypes.any.isRequired,
};

function a11yProps(index) {
  return {
    id: `scrollable-auto-tab-${index}`,
    'aria-controls': `scrollable-auto-tabpanel-${index}`,
  };
}

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
    width: '100%',
  },
  skillsGridItem: {
    marginTop: '40px',
    display: 'flex',
  },
  skillsIcon: {
    color: '#0044f4',
    marginRight: '20px',
  },
}));

export default function ProfileCardTabs() {
  const classes = useStyles();
  const [value, setValue] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValue(newValue);
  };

  return (
    <div className={classes.root}>
      <AppBar position='static' color='default'>
        <Tabs
          value={value}
          onChange={handleChange}
          indicatorColor='primary'
          textColor='primary'
          variant='scrollable'
          scrollButtons='auto'
          aria-label='scrollable auto tabs example'
        >
          <Tab label='Info' {...a11yProps(0)} />
          <Tab label='További információk' {...a11yProps(1)} />
          <Tab label='Rövid bemutatkozás' {...a11yProps(2)} />
        </Tabs>
      </AppBar>
      <TabPanel value={value} index={0}>
        <Grid className={classes.halfItem}>
          <Grid className={classes.skillsGridItem}>
            <EmojiPeopleIcon className={classes.skillsIcon}></EmojiPeopleIcon>
            Kor: 29
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <AssignmentTurnedInIcon
              className={classes.skillsIcon}
            ></AssignmentTurnedInIcon>
            Sales Specialist
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <SchoolIcon className={classes.skillsIcon} />
            Marketing BA, Metropolitan University
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <LanguageIcon className={classes.skillsIcon} />
            Angol, Kínai, Francia
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <AttachMoneyIcon className={classes.skillsIcon} />
            50 milliós forgalom az elmúlt 1 évben
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <DriveEtaIcon className={classes.skillsIcon} />
            Vezetői engedéllyel rendelkezem
          </Grid>
          <Grid className={classes.skillsGridItem}>
            <SchoolIcon className={classes.skillsIcon} />
            Egyéb oklevelek: Atom fizikus PhD, Scrum master
          </Grid>
        </Grid>
      </TabPanel>
      <TabPanel value={value} index={1}>
        <Grid container>
          <Grid item style={{ marginBottom: '30px' }}>
            <Typography variant='h6'>Előző munkahelyem:</Typography>
            <Divider style={{ marginBottom: '5px' }} />
            <Typography>Exxon Mobile Sales Senior</Typography>
          </Grid>
          <Grid item style={{ marginBottom: '30px' }}>
            <Typography variant='h6'>Amiben fejlődni szeretnék:</Typography>
            <Divider style={{ marginBottom: '5px' }} />
            <Typography>
              Contrary to popular belief, Lorem Ipsum is not simply random text.
              It has roots in a piece of classical Latin literature from 45 BC,
              making it over 2000 years old. Richard McClintock, a Latin
              professor at Hampden-Sydney College in Virginia, looked up one of
              the more obscure Latin words, consectetur, from a Lorem Ipsum
              passage, and going through the cites of the word in classical
              literature
            </Typography>
          </Grid>
          <Grid item>
            <Typography variant='h6'>Amiben jó vagyok:</Typography>
            <Divider style={{ marginBottom: '5px' }} />
            <Typography>
              This book is a treatise on the theory of ethics, very popular
              during the Renaissance. The first line of Lorem Ipsum, "Lorem
              ipsum dolor sit amet.Richard McClintock, a Latin professor at
              Hampden-Sydney College in Virginia.
            </Typography>
          </Grid>
        </Grid>
      </TabPanel>
      <TabPanel value={value} index={2}>
        <Typography variant='h6'>Rólam:</Typography>
        <Divider style={{ marginBottom: '5px' }} />
        <Typography>
          "Contrary to popular belief, Lorem Ipsum is not simply random text. It
          has roots in a piece of classical Latin literature from 45 BC, making
          it over 2000 years old. Richard McClintock, a Latin professor at
          Hampden-Sydney College in Virginia, looked up one of the more obscure
          Latin words, consectetur, from a Lorem Ipsum passage, and going
          through the cites of the word in classical literature, discovered the
          undoubtable source. Lorem Ipsum comes from sections 1.10.32 and
          1.10.33 of "de Finibus Bonorum et Malorum" The Extremes of Good and
          Evil by Cicero, written in 45 BC. This book is a treatise on the
          theory of ethics, very popular during the Renaissance. The first line
          of Lorem Ipsum, "Lorem ipsum dolor sit amet..", comes from a line in
          section 1.10.32. The standard chunk of Lorem Ipsum used since the
          1500s is reproduced below for those interested. Sections 1.10.32 and
          1.10.33 from "de Finibus Bonorum et Malorum" by Cicero are also
          reproduced in their exact original form, accompanied by English
          versions from the 1914 translation by H. Rackham.Cicero, written in 45
          BC. This book is a treatise on the theory of ethics, very popular
          during the Renaissance. The first line of Lorem Ipsum, "Lorem ipsum
          dolor sit amet.."
        </Typography>
      </TabPanel>
    </div>
  );
}
