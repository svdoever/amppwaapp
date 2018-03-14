"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
// tslint:disable:object-literal-key-quotes
// tslint:disable:trailing-comma
const React = require("react");
const react_amphtml_1 = require("react-amphtml");
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
    const analyticsConfigurationAsString = JSON.stringify(analyticsConfiguration);
    return (React.createElement(react_amphtml_1.Amp.Analytics, { type: "googleanalytics", id: "analytics-ga" },
        React.createElement("script", { type: "application/json", dangerouslySetInnerHTML: { __html: analyticsConfigurationAsString } })));
};
exports.default = AmpPageAnalytics;
//# sourceMappingURL=AmpPageAnalytics.js.map