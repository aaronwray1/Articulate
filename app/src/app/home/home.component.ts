import { Component, OnInit, Inject, Input, } from '@angular/core';
import { ApiService } from '../api.service';
import { Observable } from 'rxjs'


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent implements OnInit {
  public articulateWord: string | undefined;
  constructor(private service: ApiService) {
    console.log("Constructor");

  }

  ngOnInit(): void {
    this.refreshArticulate();
    console.log("ngOnINit");
  }

  refreshArticulate(): void {
    this.service.getArticulate()
      .subscribe(result => {
        this.articulateWord = result;
      }, error => console.error(error));
  }

}
