import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CurrencyConverterService } from './currency-converter.service';

@Component({
  selector: 'app-currency-converter',
  templateUrl: './currency-converter.component.html',
  styleUrls: ['./currency-converter.component.css']
})
export class CurrencyConverterComponent {

  form: FormGroup;
  result!: string;

  constructor(
    private fb: FormBuilder,
    private converterService: CurrencyConverterService
  ) {
    this.form = this.fb.group({
      amount: ['', [
        Validators.required,
        Validators.max(999999999),
        this.arithmeticSymbolValidator,
        this.decimalValidator
      ]]
    });
  }

  convert() {
    const amount = this.form.get('amount')?.value;
    this.converterService.convertToWords(amount).subscribe(
      (data) => {
        this.result = data;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  // Custom validator for allowing only comma as the arithmetic symbol
  arithmeticSymbolValidator(control: FormControl): { [key: string]: boolean } | null {
    const value = control.value;
    if (!value) {
      return null; // No error if the value is empty
    }

    const forbiddenSymbols = /[+\-*^\/]/;
    if (forbiddenSymbols.test(value)) {
      return { 'forbiddenSymbols': true };
    }
    return null;
  }

  // Custom validator for allowing whole numbers or numbers with up to two decimal places
  decimalValidator(control: FormControl): { [key: string]: boolean } | null {
    const value = control.value;
    if (!value) {
      return null; // No error if the value is empty
    }

    const decimalPattern = /^-?\d+(\.\d{1,2})?$/;
    if (!decimalPattern.test(value.toString())) {
      return { 'decimalFormat': true };
    }
    return null;
  }
}
