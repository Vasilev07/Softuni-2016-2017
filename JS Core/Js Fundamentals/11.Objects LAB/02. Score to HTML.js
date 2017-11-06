function scoreToHTML(input) {
    let html = '<table>\n';
    html += '   <tr><th>name</th><th>score</th></tr>\n';
    let scores = JSON.parse(input);
    let currentScore;

    for (let score of scores) {
        currentScore = score.score;
        html += `   <tr><td>${escapeName(score.name)}` +
            `</td><td>${currentScore}</td></tr>\n`;

    }
    html += '</table>';
    function escapeName(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
    console.log(html)
}
scoreToHTML('[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]')
scoreToHTML('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]')
