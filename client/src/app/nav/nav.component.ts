import { Component } from '@angular/core';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css',
})
export class NavComponent {
  isMenuOpen = false;
  toggleIcon = 'fa-solid fa-bars';

  toggleMenu(): void {
    this.isMenuOpen = !this.isMenuOpen;
    this.toggleIcon = this.isMenuOpen
      ? 'fa-solid fa-xmark'
      : 'fa-solid fa-bars';
  }
}
