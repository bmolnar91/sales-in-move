import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import InputLabel from "@material-ui/core/InputLabel";
import MenuItem from "@material-ui/core/MenuItem";
import FormControl from "@material-ui/core/FormControl";
import Select from "@material-ui/core/Select";
import Button from "@material-ui/core/Button";

const useStyles = makeStyles((theme) => ({
  button: {
    display: "block",
    marginTop: theme.spacing(2),
  },
  formControl: {
    margin: theme.spacing(1),
    minWidth: 120,
  },
}));

export const ControlledOpenSelect = ({ selectLabel, selectItems }) => {
  const classes = useStyles();
  const [val, setVal] = React.useState("");
  const [open, setOpen] = React.useState(false);

  const handleChange = (event) => {
    setVal(event.target.value);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleOpen = () => {
    setOpen(true);
  };

  return (
    <div>
      <Button className={classes.button} onClick={handleOpen}>
        {/* Open the select */}
      </Button>
      <FormControl className={classes.formControl}>
        <InputLabel id="demo-controlled-open-select-label">
          {selectLabel}
        </InputLabel>
        <Select
          labelId="demo-controlled-open-select-label"
          id="demo-controlled-open-select"
          open={open}
          onClose={handleClose}
          onOpen={handleOpen}
          value={val}
          onChange={handleChange}
        >
          <MenuItem value="egyéb">
            <em>egyéb</em>
          </MenuItem>
          {selectItems.map((item) => {
            return (
              <MenuItem key={item} value={item}>
                {item}
              </MenuItem>
            );
          })}
        </Select>
      </FormControl>
    </div>
  );
};
