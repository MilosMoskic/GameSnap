import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css',
})
export class NavComponent {
  private accountService = inject(AccountService);
  loggedIn = false;
  model: any = {}

  isMenuOpen = false;
  toggleIcon = 'fa-solid fa-bars';

  login() {
    this.accountService.login(this.model).subscribe({
      next: response => {
        console.log(response)
        this.loggedIn = true;
      },
      error: error => console.log(error)
    })
  }

  logout() {
    this.loggedIn = false;
  }

  toggleMenu(): void {
    this.isMenuOpen = !this.isMenuOpen;
    this.toggleIcon = this.isMenuOpen
      ? 'fa-solid fa-xmark'
      : 'fa-solid fa-bars';
  }
}
