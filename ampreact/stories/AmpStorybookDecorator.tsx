import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { RenderFunction, StoryDecorator } from '@storybook/react';
import {Helmet} from 'react-helmet';
import {
  AmpScripts,
  AmpScriptsManager,
  headerBoilerplate
} from 'react-amphtml';

interface ScriptAttributes {
  src: string;
  async: "";
  "custom-element"?: string
}

const AmpStorybookDecorator: StoryDecorator = (storyFn: RenderFunction) => {
  const ampScripts = new AmpScripts();
  var dummyDiv = document.createElement('div');
  ReactDOM.render(
    <div>
        <AmpScriptsManager ampScripts={ampScripts}>
          { storyFn() }
        </AmpScriptsManager>
    </div>,
    dummyDiv
  );

  let styles = require("!raw-loader!../src/styles/global-styles.css");

  let scripts: ScriptAttributes[] = [];

  [...ampScripts.scripts].map(
    ([component, script]) => {
      let attrs: ScriptAttributes = { "src": script, "async": "" };
      if (!!component) { attrs["custom-element"] = component };
      scripts.push(attrs);
    }
  );

  return (
    <div>
      <Helmet script={scripts}>
        <style amp-custom="">{styles}</style>
      </Helmet>
      { storyFn() }
    </div>
  );
};

export default AmpStorybookDecorator;