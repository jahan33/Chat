cd %~dp0
call npx tsc src/websocket-server/webSocketServer.ts
start node src/websocket-server/webSocketServer.js
call npm i
call ng serve -o

Pause
