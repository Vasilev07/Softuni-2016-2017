function xmlMessenger(input) {
    let recepient = /(to="[A-Za-z ]+")/g;
    let sender = /(from="[A-Za-z ]+")/g;
      let haveSender = sender.test(input) && recepient.test(input);

    if(!haveSender){
        console.log("Missing attributes");
    }else {
        console.log("Invalid message format");
    }
}
//xmlMessenger('<message from="Alice" timestamp="1497254112">Same old, same old</message>')
//xmlMessenger('<message to="Alice" from="Charlie"><img src="fox.jpg"/></message><meta version="2"/>')
xmlMessenger('<message from="Hillary" to="Edward" secret:true>VGhpcyBpcyBhIHRlc3Q</message>');