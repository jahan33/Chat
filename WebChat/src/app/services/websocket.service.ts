import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root',
})
export class WebsocketService {
  private socket: WebSocket;
  receivedMessage: string = '';
  constructor(private toastrService: ToastrService) {
    this.socket = new WebSocket(environment.webSocketPath);
    this.socket.addEventListener('message', (event) => {
      event.data.text().then((x: any) => {
        this.toastrService.info('You received a new message!');
        this.receivedMessage = `${x}<br/>${this.receivedMessage}`;
      });
    });
  }

  sendMessage(message: string) {
    this.socket.send(message);
    this.toastrService.success('Message sent successfully!');
  }
}
