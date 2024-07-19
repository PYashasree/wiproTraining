import { AbstractControl } from "@angular/forms";

function emailValidation(control:AbstractControl): {[key:string] :any} |null
{
    const email:string=control.value;
    const emailDomain=email.substring(email.lastIndexOf('@')+1)
    if(email==""|| email.toLocaleLowerCase()=="gmail.com")
        {
            return null;
        }
        else
    return{'emailDomain':true}
}