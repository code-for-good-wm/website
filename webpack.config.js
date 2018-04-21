const webpack = require("webpack");
const path = require("path");
const ExtractCssPlugin = require("mini-css-extract-plugin");

const outputPath = path.resolve(__dirname, "wwwroot");

const baseConfig = {
  entry: "./frontend/index.js",
  module: {
    rules: [
      {
        test: /\.js$/,
        enforce: "pre",
        loader: "eslint-loader"
      },
      {
        test: /\.scss$/,
        use: [
          ExtractCssPlugin.loader, // Extract CSS text
          {
            loader: "css-loader", // translates CSS into CommonJS
            options: {
              minimize: true,
            },
          },
          {
            loader: "sass-loader" // compiles Sass to CSS
          }
        ]
      },
      {
        test: /\.(png|svg|jpg|gif)$/,
        use: ["file-loader?name=img/[name].[ext]"]
      },
      {
        test: /\.(woff|woff2|eot|ttf|otf)$/,
        use: ["file-loader?name=fonts/[name].[ext]"]
      }
    ]
  },
  resolve: {
    extensions: [".js"]
  },
  output: {
    filename: "js/app.min.js",
    path: outputPath,
    publicPath: "/"
  },
  plugins: [new ExtractCssPlugin({ filename: "css/site.min.css" })]
};

const buildConfig = {
  mode: "production",
  entry: baseConfig.entry,
  devtool: "source-map",
  module: baseConfig.module,
  resolve: baseConfig.resolve,
  output: baseConfig.output,
  plugins: baseConfig.plugins
};

const devConfig = {
  mode: "development",
  entry: baseConfig.entry,
  devtool: "inline-source-map",
  module: baseConfig.module,
  resolve: baseConfig.resolve,
  output: baseConfig.output,
  performance: { hints: false },
  plugins: baseConfig.plugins
};

switch (process.env.npm_lifecycle_event) {
  case "build":
    module.exports = buildConfig;
    break;
  default:
    module.exports = devConfig;
    break;
}
