function JSONtoHTML(input) {
    let html = '<table>\n';
    let arr = JSON.parse(input);
    html += "  <tr>"
    let keyWord = Object.keys(arr[0]);

    for (let key of keyWord) {
        html += `<th>${key}</th>`;
    }
    html += "</tr>\n";

    for (let obj of arr) {
        html += `   <tr><td>${escapeName(obj[`${keyWord[0]}`])}</td>`;
        for (let i = 0; i < html.length; i++) {
            html += `<td>${obj[`${keyWord[i]}`]}</td>`;
        }
        html += '</tr>\n';
    }
    html += '</table>';
    function escapeName(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}
JSONtoHTML('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]');