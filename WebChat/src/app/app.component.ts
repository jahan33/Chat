import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { WebsocketService } from './services/websocket.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  message: string = '';
  chatForm!: FormGroup;
  constructor(
    public websocketService: WebsocketService,
    private fb: FormBuilder,
    private toastrService: ToastrService
  ) {}
  ngOnInit(): void {
    this.chatForm = this.fb.group({
      message: [this.message, [Validators.required]],
    });
  }

  sendMessage() {
    if (!this.chatForm.invalid) {
      debugger;
      this.message = this.chatForm.value.message;
      let message = `Web User: ${this.message}`;
      this.websocketService.sendMessage(message);
      this.message = '';
      this.chatForm.controls['message'].setValue(null);
    } else {
      this.toastrService.error('Please enter the message!');
    }
  }
}
