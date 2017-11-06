function emalValidation(input) {
    let regex = /^[A-za-z0-9]+@[a-z]+(\.[a-z])+$/;
    let result = regex.test(input);
    result ? console.log("Valid") : console.log("Invalid");

}
emalValidation('valid@email.bg');
emalValidation('invalid@emai1.bg');