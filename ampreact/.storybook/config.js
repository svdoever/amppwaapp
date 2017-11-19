import { configure } from '@storybook/react';
import { setOptions } from "@storybook/addon-options";

setOptions({
  name: '⚡AMP ⚛React',
  downPanelInRight: false
});

console.log("STORYBOOK INITIALIZATION...");
// Stories loader
function loadStories() {
  const req = require.context("../stories", true, /stories.tsx$/);
  console.log(req.keys());
  req.keys().forEach(req);
}

// Initialize react-storybook
configure(loadStories, module);