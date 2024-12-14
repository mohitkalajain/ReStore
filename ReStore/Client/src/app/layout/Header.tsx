import { AppBar, Switch, Toolbar, Typography } from "@mui/material";
interface Props{
    darkMode:boolean;
    handleThemeChange:()=>void;
}
export default function Header({darkMode,handleThemeChange}:Props) {
  return (
    <AppBar sx={{height:60 ,mb:4}} position="static">
      <Toolbar >
        <Typography variant="h5">
          RE-STORE
        </Typography>
        <Switch checked={darkMode} onChange={handleThemeChange}/>
      </Toolbar>
    </AppBar>
  );
}
