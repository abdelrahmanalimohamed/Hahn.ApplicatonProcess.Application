import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

@inject(HttpClient)
export class applicantdetails {
    httpclient: any
    public applicants: ApplicantInterface[];
    constructor(http: HttpClient) {
        this.httpclient = http;
    }

    activate(parms: { id: number; }) {
        return this.httpclient.fetch('http://localhost:5005/api/applicant/GetApplicant?id=' + parms.id + '')
            .then((result: { json: () => Promise<ApplicantInterface[]>; }) => result.json() as Promise<ApplicantInterface[]>)
            .then((data: ApplicantInterface[]) => {
                this.applicants = data;
            });
    }
}

interface ApplicantInterface {
    id: number,
    name: string,
    familyName: string
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
