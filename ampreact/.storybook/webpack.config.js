// load the default config generator.
const genDefaultConfig = require('@storybook/react/dist/server/config/defaults/webpack.config.js');
var path = require('path');

module.exports = (baseConfig, env) => {
  const config = genDefaultConfig(baseConfig, env);

  // Extend it as you need.

  // For example, add typescript loader:
  config.module.rules.push({
    test: /\.(ts|tsx)$/,
    include: [
      path.resolve(__dirname, '.'),
      path.resolve(__dirname, '../src/components'),
      path.resolve(__dirname, '../src/pages'),
      path.resolve(__dirname, '../stories')
    ],
    loader: require.resolve('ts-loader')
  });
  config.resolve.extensions.push('.ts', '.tsx');

  // Add markdown loader
  config.module.rules.push({
    test: /\.md$/,
    include: path.resolve(__dirname, "../stories"),
    loader: require.resolve("raw-loader")
  });
  config.resolve.extensions.push(".md");

  config.module.rules.push({
    test: /\.(jpe?g|gif|png|svg)$/,
    loader: "file-loader"
  });

  config.resolve.alias['ampreact'] = path.resolve(__dirname, '../src/components')

  return config;
};