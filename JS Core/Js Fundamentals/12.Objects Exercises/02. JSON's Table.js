function JSONTable(input) {
    let html = `<table>\n`;

    for (let obj of input) {
        html += `    <tr>\n`;
        let fullObj = JSON.parse(obj);
        let keys = Object.keys(fullObj);

        let name = fullObj[`${keys[0]}`];
        let position = fullObj[`${keys[1]}`];
        let salary = fullObj[`${keys[2]}`];

        html += `        <td>${name}</td>\n`;
        html += `        <td>${position}</td>\n`;
        html += `        <td>${Number(salary)}</td>\n`;

        html += `    <tr>\n`;
    }
    return html += `</table>`;

    function escapeName(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}
JSONTable([
    '{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'
])