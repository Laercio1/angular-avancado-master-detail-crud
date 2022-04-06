import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  @Input() animate = true;
  private timerID: any = null;
  @Input() speed = 50;
  @Input() acceleration = 2;

  public toggled: string = '';

  constructor(private router: Router) {}

  ngOnInit(): void {
  }

  showMenu(): boolean {
    return this.router.url != '/login' && this.router.url != '/registration';
  }

  toggleCollapsed() {
    if(this.toggled == "toggled"){
      this.toggled = '';
    } else {
    this.toggled = "toggled";
    }
  }

  abrir(event: any, nomeServico:any) {
    
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

