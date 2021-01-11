
import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';


@inject(HttpClient)
export class Fetchdata {

    public applicants: Applicant[];
    http_: any;

    constructor(http: HttpClient) {
        this.http_ = http;
        //  http.fetch('https://localhost:44304/applicant')
        http.fetch('http://localhost:5005/api/applicant')
            .then(result => result.json() as Promise<Applicant[]>)
            .then(data => {
                this.applicants = data;
            });
    }


    DeleteApplicant(id: number) {
        this.http_.fetch('http://localhost:5005/api/applicant/DeleteApplicant?id=' + id + '', {
            method: "Delete",
            headers: {
                "content-type": "application/json; charset=utf-8"
            }
        }).then((result: { json: () => Promise<Applicant[]>; }) => result.json() as Promise<Applicant[]>)
            .then((data: Applicant[]) => {
                this.applicants = data;
            });
    }


}

interface Applicant {
    id: number,
    Name: string
}


