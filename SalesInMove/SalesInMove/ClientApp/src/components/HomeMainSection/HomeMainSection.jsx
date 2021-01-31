import React from 'react';
import {
  Container,
  MidSectionContainer,
  Image,
  TextContainer,
} from './HomeMainSection.style';
import Button from '@material-ui/core/Button';
import Grid from '@material-ui/core/Grid';
import Typography from '@material-ui/core/Typography';
import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles((theme) => ({
  mainh1Text: {
    fontWeight: '600',
    fontSize: '4rem',
  },
  mainSecondaryText: {
    fontSize: '32px',
  },
  moveText: {
    fontSize: '42px',
  },
  jobSearchBtn: {
    marginRight: '30px',
  },
}));

export const HomeMainSection = () => {
  const classes = useStyles();
  return (
    <Grid container direction='column' spacing={1}>
      <Grid container item xs={12}>
        <Grid item item xs={5}>
          <Container component='div'>
            <TextContainer>
              <Typography
                className={classes.mainh1Text}
                variant='h2'
                component='h2'
                gutterBottom
              >
                Mutasd meg szeméyiségedet azonnal, merj önmagad lenni!
              </Typography>
              <Typography className={classes.mainSecondaryText} gutterBottom>
                Mi megkönnyítjük a munka keresést és a pozícióra legmegfelelőbb
                ember megtalálását!
              </Typography>
              <Typography
                className={classes.moveText}
                variant='h4'
                component='h4'
                gutterBottom
              >
                Felkészültél ? Move !
              </Typography>
            </TextContainer>
          </Container>
        </Grid>
        <Grid xs={7}></Grid>
      </Grid>
      <Grid container xs={5}>
        <Grid item className={classes.buttonContainer}>
          <Button
            variant='contained'
            color='primary'
            className={classes.jobSearchBtn}
          >
            Munkát keresek !
          </Button>
          <Button variant='contained' color='secondary'>
            Munkát kínálok !
          </Button>
        </Grid>
        <Grid xs={7}></Grid>
      </Grid>
    </Grid>

    // <Container>
    //   <MidSectionContainer>
    //     <Container component='div'>
    //       <TextContainer>
    //         <p>{paragraph}</p>
    //       </TextContainer>
    //     </Container>
    //     <Container component='div'>
    //       <Button variant='contained' color='primary'>
    //         Primary
    //       </Button>
    //       <Button variant='contained' color='primary'>
    //         Primary
    //       </Button>
    //     </Container>
    //   </MidSectionContainer>
    //   <br />
    // </Container>
  );
};
