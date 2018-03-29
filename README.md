# Code for Good West Michigan

The code for http://codeforgoodwm.org/

## Coding the app

Use [Visual Studio Code](https://code.visualstudio.com)

Run Yarn Install to install client dependencies from the /ClientApp folder  
```> yarn install```

This project uses the React-Scripts setup:  
https://github.com/facebook/create-react-app/blob/master/packages/react-scripts/template/README.md

## Runing the app

You can run the app by running this command from the /ClientApp folder  
```> yarn run start```

## Deploy to AWS Instructions

In the root folder run

```> dotnet publish -o site```

Zip the contents of the /site folder into "site.zip", then zip **site.zip** into another zip file along with **aws-windows-deployment-manifest.json** and then upload that zip file to the AWS Elastic Beanstalk console.

The name "site.zip" is important because the manifest.json refers to that folder.  Be sure to zip the contents of the /site folder and not the /site folder itself.  The web.config needs to be in the root of the zip file.

You can name the containing zip file anything you want as long as it contains the deployment manifest and the site.zip files.