import React, { useState } from "react";
import { Container } from "reactstrap";
import { NavMenu } from "./NavMenu";
import { Grid, Button, TextField } from "@material-ui/core";

const Layout = () => {
  const [baseCurrency, setBaseCurrency] = useState("EUR");
  const [conversionCurrency, setConversionCurrency] = useState("");
  const [amount, setAmount] = useState(0);

  const [convertedAmount, setConvertedAmount] = useState("")
  const [errorMessage, setErrorMessage] = useState("")


  const SendData = () => {
    setErrorMessage("")
    
    var baseString = "https://localhost:5001/CurrencyConversion";
    var queryString =
      "?base=" +
      baseCurrency +
      "&Symbols=" +
      conversionCurrency +
      "&amount=" +
      amount;

    fetch(baseString + queryString)
    .then((response) => response.json())
    .then((data) => setConvertedAmount(data))
    .catch((error) => setErrorMessage(error));;  
  
  };

  return (
    <div>
      <NavMenu />
      <Container>
        <h1>Currency converter</h1>
        <Grid container>
          <Grid item xs={12}>
            <TextField
              defaultValue="EUR"
              variant="outlined"
              helperText="Enter currency you want to convert"
              label="Base currency"
              onChange={(e) => setBaseCurrency(e.target.value)}
            ></TextField>
          </Grid>
          <Grid item xs={12}>
            <TextField
              variant="outlined"
              helperText="Enter currency you want to convert to"
              label="Conversion currency"
              onChange={(e) => setConversionCurrency(e.target.value)}
            ></TextField>
          </Grid>

          <Grid item xs={12}>
            <TextField
              variant="outlined"
              helperText="Enter the amount you want to convert"
              label="Amount"
              onChange={(e) => setAmount(e.target.value)}
            ></TextField>
          </Grid>
          <br></br>
          <Grid item xs={12}>
            <Button 
            variant="outlined"
            onClick={() => SendData()}
            >Send request</Button>
          </Grid>
        </Grid>

        
        {convertedAmount ? amount + baseCurrency + " is " + convertedAmount + conversionCurrency : ""}
        {errorMessage ? "Error while trying to convert currency" : ""}
        <h3></h3>
      </Container>
    </div>
  );
};

export default Layout;
