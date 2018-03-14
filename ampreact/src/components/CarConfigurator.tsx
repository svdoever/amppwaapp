import * as React from "react";
import AmpPageAnalytics from "./AmpPageAnalytics";
import Header from "./Header";

const CarConfigurator = (productColorState?: any) => (
    <div>
        <h1>HELLO CARS!!!</h1>
        <AmpPageAnalytics/>
        <Header/>
        <h1>Car Configurator - do it!!</h1>
    </div>
);

export default CarConfigurator;
