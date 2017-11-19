// tslint:disable:object-literal-key-quotes
// tslint:disable:trailing-comma
import * as React from "react";
import { Amp } from "react-amphtml";

const AmpPageAnalytics = () => {

    // Need to configure the configuration in a JavaScript object and convert to string and inject as
    // dangerouslySetInnerHTML to prevent issues
    const analyticsConfiguration = {
        "vars": {
            "account": "UA-35628378-1"
        },
        "triggers": {
            "trackPageview": {
            "on": "visible",
            "request": "pageview",
            }
        }
    };
    const analyticsConfigurationAsString: string = JSON.stringify(analyticsConfiguration);
    return (
    <Amp.Analytics type="googleanalytics" id="analytics-ga">
        <script type="application/json" dangerouslySetInnerHTML={{ __html: analyticsConfigurationAsString }}/ >
    </Amp.Analytics>
    );
}

export default AmpPageAnalytics;
