import { Component } from '@angular/core';
import { CurrencyConverterService } from './currency-converter.service';
@Component({
  selector: 'app-currency-converter',
  templateUrl: './currency-converter.component.html',
  styleUrls: ['./currency-converter.component.css']
})
export class CurrencyConverterComponent {

  amount!: number;
  result!: string;

  constructor(private converterService: CurrencyConverterService) {}

  convert() {
    this.converterService.convertToWords(this.amount).subscribe(
      (data) => {
        this.result = data;
      },
      (error) => {
        console.error(error);
      }
    );
  }
}
