import { Component } from '@angular/core';
import { Form } from '@angular/forms';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})

export class SidebarComponent {
  isSidebarOpen = true;
  
  toggleSidebar() {
    this.isSidebarOpen = !this.isSidebarOpen;
  }
}
