/* tslint:disable no-var-requires */
const withReadme = (require("storybook-readme/with-readme") as any).default;
const ContainerReadme = require("./Container.README.md");

import * as React from "react";
import { storiesOf } from "@storybook/react";
import { action } from "@storybook/addon-actions";
import AmpStorybookDecorator from "./AmpStorybookDecorator";
import Container from "../src/components/Container";

storiesOf('Container', module)
  .addDecorator(withReadme(Container))
  .addDecorator(AmpStorybookDecorator)
  .add('default', () => (
      <Container>Hello world!</Container>
  ));