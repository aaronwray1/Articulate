import { Component, OnInit, Inject, Input, } from '@angular/core';
import { ApiService } from '../api.service';
import { Observable, timer } from 'rxjs'


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements OnInit {
  public articulateWord: string | undefined;
  public timeLeft: number = 30;
  public interval;
  public subscribeTimer: any;


  constructor(private service: ApiService) {
    console.log("Constructor");

  }

  ngOnInit(): void {
    this.refreshArticulate();
    console.log("ngOnINit");
    this.timeLeft = 30;
  }

  refreshArticulate(): void {
    this.service.getArticulate()
      .subscribe(result => {
        this.articulateWord = result;
      }, error => console.error(error));
  }

  observableTimer() {
    const source = timer(1000, 2000);
    const abc = source.subscribe(val => {
      console.log(val, '-');
      this.subscribeTimer = this.timeLeft - val;
    });
  }

  startTimer() {
    this.interval = setInterval(() => {
      if (this.timeLeft > 0) {
        this.timeLeft--;
      } else {
        this.refreshArticulate();
        this.timeLeft = 30;
      }
    }, 1000)
  }

  pauseTimer() {
    clearInterval(this.interval);
  }



}
