import React, { useEffect } from "react";
import { makeStyles } from "@material-ui/core/styles";
import FormLabel from "@material-ui/core/FormLabel";
import FormControl from "@material-ui/core/FormControl";
import FormGroup from "@material-ui/core/FormGroup";
import FormControlLabel from "@material-ui/core/FormControlLabel";
import FormHelperText from "@material-ui/core/FormHelperText";
import Checkbox from "@material-ui/core/Checkbox";

const useStyles = makeStyles((theme) => ({
  root: {
    display: "flex",
  },
  formControl: {
    margin: theme.spacing(3),
  },
}));

export const CheckboxesGroup = ({ checkboxLabel, checkboxItems }) => {
  const classes = useStyles();

  const obj = {};
  for (const key of checkboxItems) {
    obj[key] = false;
  }

  const [state, setState] = React.useState(obj);

  const handleChange = (event) => {
    setState({ ...state, [event.target.name]: event.target.checked });
  };

  return (
    <div className={classes.root}>
      <FormControl component="fieldset" className={classes.formControl}>
        <FormLabel component="legend">{checkboxLabel}</FormLabel>
        <FormGroup>
          {Object.keys(state).map((item) => {
            return (
              <FormControlLabel
                key={item}
                control={
                  <Checkbox
                    checked={state[item]}
                    onChange={handleChange}
                    name={item}
                  />
                }
                label={item}
              />
            );
          })}
        </FormGroup>
        <FormHelperText>Választhat többet</FormHelperText>
      </FormControl>
    </div>
  );
};
