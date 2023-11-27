import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CurrencyConverterService {
    private apiUrl = 'https://localhost:5108';


  constructor(private http: HttpClient) {}

  convertToWords(amount: number): Observable<string> {
    return this.http.get<string>(`${this.apiUrl}/currencyconverter?amount=${amount}`);
  }
}
