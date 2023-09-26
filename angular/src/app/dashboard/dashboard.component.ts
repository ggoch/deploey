import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'ChengyiV2.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'ChengyiV2.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
