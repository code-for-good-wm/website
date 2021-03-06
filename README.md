# Code for Good West Michigan

The code for http://codeforgoodwm.org/

## Coding the app

### Backend

#### Requirements

DotNet platform (OSX Unix and Windows):
https://www.microsoft.com/net/learn/get-started

The app is currently using .Net Core SDK 2.1

#### Recommended Editor

[Visual Studio Code](https://code.visualstudio.com)

### Frontend

#### Requirements

* Node 8.x
  * Build tool-chain
* [Prettier](https://prettier.io/) and [EditorConfig](http://editorconfig.org/) plugins for your editor
  * Code format consistency

Run `npm i` to install the dependencies

## Running the app

```
npm start
``` 

will begin a Webpack build of the frontend with file-watcher as well as starting the backend server.

## Deploy to AWS Instructions

`npm run build` will produce the frontend production artifacts.

In the root folder run

`> dotnet publish -o site`

Zip the contents of the /site folder into "site.zip", then zip **site.zip** into another zip file along with **aws-windows-deployment-manifest.json** and then upload that zip file to the AWS Elastic Beanstalk console.

The name "site.zip" is important because the manifest.json refers to that folder. Be sure to zip the contents of the /site folder and not the /site folder itself. The web.config needs to be in the root of the zip file.

You can name the containing zip file anything you want as long as it contains the deployment manifest and the site.zip files.
