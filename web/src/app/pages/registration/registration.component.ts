import { Component, OnInit } from '@angular/core';
import { UntypedFormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'app/services/auth.service';

@Component({
    selector: 'app-registration',
    templateUrl: './registration.component.html',
    styleUrls: ['./registration.component.scss'],
    standalone: false
})
export class RegistrationComponent implements OnInit {
  isFetching = false;
  error = '';
  success = '';
  inputUsername = new UntypedFormControl('');
  inputEmail = new UntypedFormControl('');
  inputPassword = new UntypedFormControl('');
  inputPasswordAgain = new UntypedFormControl('');

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {
    if (this.authService.getBearerToken() !== undefined) {
      this.router.navigate(['']);
    }
  }

  onRegistration() {
    this.isFetching = true

    this.authService.registration({
      'username': this.inputUsername.value,
      'email': this.inputEmail.value,
      'password': this.inputPassword.value,
      'passwordAgain': this.inputPasswordAgain.value,
    }).subscribe({
      next: () => {
        this.isFetching = false;
        this.success = 'Success! You created an account. Log in!';
      },
      error: err => {
        this.error = err
        this.inputPassword.setValue('');
        this.inputPasswordAgain.setValue('');
        this.isFetching = false;
      }
    })

    this.isFetching = false;
  }

  usernamePattern() {
    return this.authService.usernamePattern();
  }

  emailPattern() {
    return this.authService.emailPattern();
  }

  passwordPattern() {
    return this.authService.passwordPattern();
  }

  passwordErrorMsg() {
    return this.authService.passwordErrorMsg();
  }

  login() {
    this.success = '';
    this.router.navigate(['login'])
  }

  removeError() {
    this.error = '';
  }
}
