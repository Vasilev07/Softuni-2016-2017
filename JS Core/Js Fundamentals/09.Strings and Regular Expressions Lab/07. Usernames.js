function usernames(input) {
    let users = [];
    for (let name of input) {
        let firstname = name.split('@');
        let secondPart = firstname[1].split('.');
        let secondName = "";
        for (let i = 0; i < secondPart.length; i++) {
            secondName += secondPart[i][0];
        }
        let fullUsername = firstname[0] + "." + secondName;
        users.push(fullUsername);
    }
        console.log(users.join(", "))
}
usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com'])
