"use strict";
// tslint:disable:max-line-length
Object.defineProperty(exports, "__esModule", { value: true });
const React = require("react");
const react_amphtml_1 = require("react-amphtml");
const ImageWithHeading_1 = require("./ImageWithHeading");
const Header = () => (React.createElement("header", null,
    React.createElement("section", { className: "container" },
        React.createElement("div", { id: "site-logo" },
            React.createElement("a", { href: "https://www.autoabonnement.nl/" },
                React.createElement(react_amphtml_1.Amp.Img, { src: "https://www.autoabonnement.nl/-/media/images/autoabonnement/logo/logo_autoabonnement.png", title: "header", alt: "header", layout: "responsive", height: "37", width: "234" })))),
    React.createElement(ImageWithHeading_1.default, { src: "/static/img/amp.jpg", width: 200, height: 100, alt: "Beautiful Image of a rectangle", heading: "Views from Space" })));
exports.default = Header;
//# sourceMappingURL=Header.js.map