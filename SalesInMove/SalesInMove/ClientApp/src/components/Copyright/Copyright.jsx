import React from "react";
import { Typography, Link } from "@material-ui/core";

export const Copyright = () => {
  return (
    <Typography variant="body2" color="textSecondary">
      {"Copyright © "}
      <Link color="inherit" href="https://material-ui.com/">
        Sales in Move
      </Link>{" "}
      {new Date().getFullYear()}
      {"."}
    </Typography>
  );
};
