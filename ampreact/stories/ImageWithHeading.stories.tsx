/* tslint:disable no-var-requires */
const withReadme = (require("storybook-readme/with-readme") as any).default;
const ImageWithHeadingReadme = require("./ImageWithHeading.README.md");

import * as React from "react";
import { storiesOf } from "@storybook/react";
import { action } from "@storybook/addon-actions";
import AmpStorybookDecorator from "./AmpStorybookDecorator";
import ImageWithHeading from "../src/components/ImageWithHeading";

storiesOf("ImageWithHeading", module)
  .addDecorator(withReadme(ImageWithHeadingReadme))
  .addDecorator(AmpStorybookDecorator)
  .add("with text", () => (
    <ImageWithHeading
      src="/img/amp.jpg"
      width={1280}
      height={853}
      alt="Beautiful Image of a rectangle"
      heading="Views from OuterSpace and back!" />
  ));
