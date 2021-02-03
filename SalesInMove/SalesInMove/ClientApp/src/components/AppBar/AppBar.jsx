import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';
import IconButton from '@material-ui/core/IconButton';

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  menuButton: {
    marginRight: theme.spacing(2),
  },
  title: {
    flexGrow: 1,
  },
  image: {
    width: '160px',
    height: '80px',
  },
  button: {
    marginLeft: theme.spacing(4),
    fontWeight: '500',
    padding: '6px',
  },
}));

export function ButtonAppBar() {
  const classes = useStyles();

  return (
    <div className={classes.root}>
      <AppBar position='static' color='transparent' elevation={0}>
        <Toolbar>
          <IconButton
            edge='start'
            className={classes.menuButton}
            color='inherit'
            aria-label='menu'
          >
            <img
              src='/images/logo-01.png'
              alt='logo'
              className={classes.image}
            />
          </IconButton>
          <Typography variant='h6' className={classes.title}></Typography>
          <Button color='inherit'>Missziónk</Button>
          <Button color='inherit'>Munkát keresel?</Button>
          <Button color='inherit'>Munkát kínálsz?</Button>
          <Button color='inherit'>Partnereink</Button>
          <Button color='inherit'>Kapcsolat</Button>
          <Button
            color='primary'
            size='small'
            href='/bejelentkezes'
            className={classes.button}
            variant='outlined'
          >
            Bejelentkezés
          </Button>
          <Button
            variant='outlined'
            color='primary'
            size='small'
            className={classes.button}
            href='/regisztracio'
          >
            Regisztráció
          </Button>
        </Toolbar>
      </AppBar>
    </div>
  );
}
