function formFiller(name, email, number, text) {
    let namePattern = /<![A-Za-z ]+!>/;
    let mailPatern = /<@[A-Za-z ]+@!>/;
    let numberPattern = /<+[A-Za-z ]+\+>/;
    for (let obj of text) {
       let nameMatch = namePattern.exec(obj);
       let mailMatch = mailPatern.exec(obj);
       let numberMatch = numberPattern.exec(obj);
       if(nameMatch){
           obj = obj.replace(nameMatch, name);
       }
       if(mailMatch){
           obj = obj.replace(mailMatch, email);
       }
       if(numberMatch){
           obj = obj.replace(numberMatch, number);
       }
       console.log(obj)
    }
}
formFiller('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']);
