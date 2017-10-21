import { Component, ViewChild } from '@angular/core';
import { Tabs, IonicPage } from 'ionic-angular';
import { HomePage } from './home/home';
import { AboutPage } from './about/about';
import { ContactPage } from './contact/contact';

@IonicPage({
  name: 'maintabs'
})
@Component({
  templateUrl: 'tabs.html'
})
export class TabsPage {
  tab1Root = HomePage;
  tab2Root = AboutPage;
  tab3Root = ContactPage;
  //tab1Root = 'home';
  //tab2Root = 'about';
  //tab3Root = 'contact';

  @ViewChild('mainTabs') tabs: Tabs;
  constructor() {

  }
}
