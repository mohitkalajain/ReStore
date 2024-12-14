import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Header() {
  return (
    <AppBar sx={{height:60 ,mb:4}} position="static">
      <Toolbar >
        <Typography variant="h5">
          <h6>RE-STORE</h6>
        </Typography>
      </Toolbar>
    </AppBar>
  );
}
