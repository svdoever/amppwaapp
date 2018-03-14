"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
// tslint:disable:max-line-length
const React = require("react");
const react_amphtml_1 = require("react-amphtml");
const styled_components_1 = require("styled-components");
const Button = styled_components_1.default.button `
border-radius: 3px;
padding: 0.25em 1em;
margin: 0 1em;
background: transparent;
color: palevioletred;
border: 2px solid palevioletred;
`;
const StyledAmpImg = styled_components_1.default(react_amphtml_1.Amp.Img) `
filter: ${(props) => {
    switch (props["data-filter"]) {
        case 1:
            return "blur(10px)";
        case 2:
            return "hue-rotate(180deg)";
        case 3:
            return "invert(100%)";
        case 4:
            return "grayscale(100%)";
        case 5:
            return "sepia(100%)";
        case 6:
            return "saturate(100%)";
        default:
            return "none";
    }
}};
`;
// tslint:disable-next-line:max-line-length
const ImageWithHeading = ({ src, width, height, alt = "", heading = "" }) => (React.createElement("div", null,
    React.createElement("figure", { className: "ampstart-image-with-heading m0 relative mb4" },
        React.createElement(StyledAmpImg, { "data-filter": 5, src: src, width: width, height: height, layout: "responsive", alt: alt }),
        React.createElement("figcaption", { className: "absolute right-0 bottom-0 left-0" },
            React.createElement("header", { className: "ampstart-image-heading px2 py2 line-height-4" },
                React.createElement("h1", null, heading)))),
    React.createElement(react_amphtml_1.Amp.Accordion, null,
        React.createElement("section", { expanded: true },
            React.createElement("h4", null, "Section 1"),
            React.createElement(Button, null, "I'm a magic button!")),
        React.createElement("section", null,
            React.createElement("h4", null, "Section 2"),
            React.createElement("div", null,
                "Bunch of even more awesome content. This time in a",
                React.createElement("code", null, "<div>"),
                ".")),
        React.createElement("section", null,
            React.createElement("h4", null, "Section 3"),
            React.createElement("p", null, "More awesome content!!!!!")))));
exports.default = ImageWithHeading;
//# sourceMappingURL=ImageWithHeading.js.map