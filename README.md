# Preconditions

Install Angular>= 16, Node>= 20,.Net 7

## Development server
To run this application, open the webchat folder and  proceed with the these steps:

First run the websocket server 
To start the websocket run the  the following commands
npx tsc src/websocket-server/webSocketServer.ts
node src/websocket-server/webSocketServer.js
then run the web application(WebChat) by using these commands 
npm i
ng server

Or run `RunApp.bat` file

Once the web application is running, open the winform application(WinChat) and execute it.

# Description
To establish communication between the web application and the Windows application, I've implemented a Node.js WebSocket for the backend. 
I develop the web application using Angular, TypeScript, SCSS, and HTML5. For an enhanced user interface, I incorporated Angular Material Design, for notifications are I have use the ng-x Toastr Service.

the WinForms application was developed utilizing .NET 7 and a WebSocket client.


