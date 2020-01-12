import { Component, OnInit } from '@angular/core';
import { ContactService } from 'src/_Services/Contact.service';

@Component({
  selector: 'app-contact-form',
  templateUrl: './Contact-form.component.html',
  styleUrls: ['./Contact-form.component.css']
})
export class ContactFormComponent implements OnInit {
  contactData: any;

  constructor(private contactService: ContactService) {}

  ngOnInit() {
this.contactService.GetAllContacts().subscribe(
  result => {this.contactData = result;
             console.log(result);
  });
  }

}
