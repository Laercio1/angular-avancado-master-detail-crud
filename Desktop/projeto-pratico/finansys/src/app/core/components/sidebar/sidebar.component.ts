import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  @Input() animate = true;
  private timerID: any = null;
  @Input() speed = 50;
  @Input() acceleration = 2;

  public toggled: string = '';

  constructor(private router: Router) {}

  ngOnInit(): void {

  }

  toggleCollapsed() {
    if(this.toggled == "toggled"){
      this.toggled = '';
    } else {
    this.toggled = "toggled";
    }
  }

  abrir(event: any, nomeServico:any) {
    // console.log("event: ", event);
    // console.log("nomeServico: ", nomeServico);

    this.router.navigate([nomeServico]);
    if (!this.isBrowser()) {
      return;
    }

    this.rolarPaginaParaTopo(event);
  }

  rolarPaginaParaTopo(event: any){
    event.preventDefault();
    if (this.animate) {
      this.animateScrollTop();
    } else {
      window.scrollTo(0, 0);
    }
  }


  isBrowser(): boolean {
    return typeof (window) !== 'undefined';
  }

  animateScrollTop() {
    if (this.timerID !== null) {
      return;
    }

    let initialSpeed = this.speed;
    const that = this;
    this.timerID = setInterval(function () {
      window.scrollBy(0, -initialSpeed);
      initialSpeed = initialSpeed + that.acceleration;
      if (that.getCurrentScrollTop() === 0) {
        clearInterval(that.timerID);
        that.timerID = null;
      }
    }, 15);
  }

  getCurrentScrollTop() {
    if (typeof window.scrollY !== 'undefined' && window.scrollY >= 0) {
      return window.scrollY;
    }
    if (typeof window.pageYOffset !== 'undefined' && window.pageYOffset >= 0) {
      return window.pageYOffset;
    }
    if (typeof document.body.scrollTop !== 'undefined' && document.body.scrollTop >= 0) {
      return document.body.scrollTop;
    }
    if (typeof document.documentElement.scrollTop !== 'undefined' && document.documentElement.scrollTop >= 0) {
      return document.documentElement.scrollTop;
    }
    return 0;
  }
}

