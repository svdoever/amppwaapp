/* tslint:disable no-var-requires */
const withReadme = (require("storybook-readme/with-readme") as any).default;
const CarConfiguratorReadme = require("./CarConfigurator.README.md");

import * as React from "react";
import { storiesOf } from "@storybook/react";
import { action } from "@storybook/addon-actions";
import AmpStorybookDecorator from "./AmpStorybookDecorator";
import CarConfigurator from "../src/components/CarConfigurator";

storiesOf('CarConfigurator', module)
.addDecorator(withReadme(CarConfigurator))
.addDecorator(AmpStorybookDecorator)
.add('default', () => (
  <CarConfigurator/>
));