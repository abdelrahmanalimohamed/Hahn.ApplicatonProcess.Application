import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

@inject(HttpClient)
export class insert {
    http: any;

    country: country[];
    constructor(http: HttpClient) {
        this.http = http;
        http.fetch('https://restcountries.eu/rest/v2')
            .then(result => result.json() as Promise<country[]>)
            .then(data => {
                this.country = data;

            });

    }

    id = '';

    name = '';
    address = '';
    countryofOrigin = '';
    eMailAddress = '';
    familyName = '';
    hired = false;

    public async postdata(): Promise<boolean> {
        // if (!this.name || !this.id || !this.eMailAddress || !this.familyName || !this.countryofOrigin) {
        //   return false;
        // }

        let applicantdata = new Applicant(parseInt(this.id), this.name, this.eMailAddress, this.address, this.countryofOrigin, this.familyName, this.hired);
        try {
            await this.http.fetch('http://localhost:5005/api/applicant/CreateApplicant', {
                method: "post",
                body: JSON.stringify(applicantdata),
                headers: {
                    "content-type": "application/json; charset=utf-8"
                }
            }).then((response: { json: () => any; }) => response.json());

            return true;
        } catch (Ex) {
            console.log("Error: " + Ex.Message);
            return false;
        }
    }
}

class Applicant {
    id = 0;
    name = '';
    eMailAddress = '';
    address = '';
    countryofOrigin = '';
    familyName = '';
    hired = false;
    constructor(id: number, name: string, eMailAddress: string, address: string, countryofOrigin: string, familyName: string, hired: boolean) {
        this.id = id;
        this.name = name;
        this.eMailAddress = eMailAddress;
        this.address = address;
        this.countryofOrigin = countryofOrigin;
        this.hired = hired;
        this.familyName = familyName;

    }
}

interface country {
    name: string
}



