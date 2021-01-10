import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';


@inject(HttpClient)
export class Fetchdata {

    public applicants: Applicants[] = [];


    constructor(http: HttpClient) {
        this.getValues(http);
    }
    getValues(http: HttpClient) {
        http.fetch('http://localhost:5005/api/applicant')
            .then((applicants: { json: () => Promise<Applicants[]>; }) => applicants.json() as Promise<Applicants[]>)
            .then((data: Applicants[]) => {
                this.applicants = data;
                console.log(data);

            });
    }


}




interface Applicants {
    id: number,
    name: string,
    FamilyName: string
}

