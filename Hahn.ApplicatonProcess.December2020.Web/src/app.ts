import 'fetch';
import { HttpClient } from 'aurelia-fetch-client';

let httpClient = new HttpClient();

export class App {
  ApplicantsRecord: any;

  constructor() {
    this.ApplicantsRecord = null;
    this.fetchApplicants();
  }

  fetchApplicants() {
    httpClient.fetch('http://localhost:5005/api/applicant')
      .then(response => response.json())
      .then(data => {
        this.ApplicantsRecord = data;
      })
  }
}
