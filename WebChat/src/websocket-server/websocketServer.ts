import * as express from 'express';
import * as http from 'http';
import * as WebSocket from 'ws';
import { environment } from '../environments/environment.development';

const app = express();
const server = http.createServer(app);
const wss = new WebSocket.Server({ server });

wss.on('connection', (socket) => {
  console.log('WebSocket connected');

  socket.on('message', (message) => {
    console.log('Received:', message);

    // Send the message back to all clients
    wss.clients.forEach((client) => {
      if (client !== socket && client.readyState === WebSocket.OPEN) {
        client.send(message);
      }
    });
  });

  socket.on('close', () => {
    console.log('WebSocket disconnected');
  });
});

server.listen(5080, () => {
  console.log(
    'WebSocket server is listening on port: ' + environment.webSocketPort
  );
});
