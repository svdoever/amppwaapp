var path = require('path');
var merge = require('webpack-merge');

module.exports = {
    distDir: '../next_build',
    webpack: function(config, {dev}) {
      var newConfig = merge(config, {
        // module: {
        //   rules: [
        //     {
        //       test: /\.(ts|tsx)$/,
        //       include: [
        //           path.resolve(__dirname, './src/components'),
        //           path.resolve(__dirname, './src/pages'),
        //       ],
        //       use: { 
        //         loader: 'ts-loader'
        //       }
        //     }, {
        //       test: /\.(jpe?g|gif|png|svg)$/, 
        //       use: {
        //         loader: "file-loader"
        //       }
        //     }
        //   ]
        // },
        resolve: {
          extensions: ['.ts', '.tsx', '.js', '.jsx']
        }
      });
  
      const configString = JSON.stringify(newConfig, null, 2);
      console.log(configString);
  
      return newConfig
    }
  }