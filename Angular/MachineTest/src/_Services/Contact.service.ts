import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
    private apiBaseUrl = environment.ApiUrl + 'contact/';
    
constructor(private http: HttpClient) {}


GetAllContacts() {
    return this.http.get<any>(this.apiBaseUrl );
  }

  AddContact (model: any) {
    return this.http.post<any>(this.apiBaseUrl + '/Add', model).pipe(map((response: any) => (response.AddedContact)));
  }

  EditContact(model: any) {
    return this.http.post(this.apiBaseUrl + '/Edit', model);
  }

  DeleteContact(model: any) {
    return this.http.delete(this.apiBaseUrl , model);
  }

}
