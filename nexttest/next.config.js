var path = require('path');
var merge = require('webpack-merge');

module.exports = {
  webpack: (config) => {
    // Fixes npm packages that depend on `fs` module
    config.node = {
      fs: 'empty'
    };
    var newConfig = merge(config, {
      resolve: {
        extensions: ['.ts', '.tsx', '.js', '.jsx']
      }
    });

    const configString = JSON.stringify(newConfig, null, 2);
    console.log(configString);

    return newConfig;    
  }
}
