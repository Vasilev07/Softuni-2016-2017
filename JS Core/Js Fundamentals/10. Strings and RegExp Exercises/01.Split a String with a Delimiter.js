function delimeter(text, delimeter) {
    text = text.split(delimeter);
    for (let obj of text) {
        console.log(obj)
    }
}
delimeter("One-Two-Three-Four-Five", "-")