import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrls: ['./registration-form.component.css']
})
export class RegistrationFormComponent implements OnInit {
  registrationForm!: FormGroup;

  constructor(private fb: FormBuilder, private http: HttpClient) { }

  ngOnInit(): void {
    this.registrationForm = this.fb.group({
      firstName: ['', Validators.required],
      middleName: [''],
      lastName: ['', Validators.required],
      age: ['', [Validators.required, Validators.min(0), Validators.max(100)]],
      dob: ['', Validators.required],
      emailId: ['', [Validators.required, Validators.email, this.customEmailValidator]],
      country: ['', Validators.required],
      gender: ['', Validators.required]
    });
  }

  customEmailValidator(control: FormControl): { [key: string]: boolean } | null {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    if (control.value && !emailRegex.test(control.value)) {
      return { 'invalidEmail': true };
    }
    return null;
  }

  onSubmit(): void {
    if (this.registrationForm.valid) {
      this.http.post('http://localhost:3000/employees', this.registrationForm.value)
        .subscribe(response => {
          console.log('Form Submitted', response);
        });
    }
  }
}
