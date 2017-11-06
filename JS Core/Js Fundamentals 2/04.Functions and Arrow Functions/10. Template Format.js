
function solve(input) {

    let html = '<?xml version="1.0" encoding="UTF-8"?>\n';
    html += '<quiz>\n';

    function questions(question) {
        return `    <question>\n      ${question}\n   </question>\n`;
    }
    function answers(answer) {
        return  `    <answer>\n      ${answer}\n   </answer>\n`;
    }

    for(let i = 0; i < input.length; i += 2) {
        let quiz = input[i];
        let ans = input[i+1];
        html += questions(quiz);
        html += answers(ans);
        break;
    }

    html += '</quiz>';

    console.log(html);
}
