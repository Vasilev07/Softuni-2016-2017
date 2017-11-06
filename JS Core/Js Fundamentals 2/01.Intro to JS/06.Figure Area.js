function figureArea([W, H, w, h]) {
    [W, H, w, h] = [W, H, w, h].map(Number);
    let result = (W*H) + (w*h) - (Math.min(W,w)*Math.min(H,h));
    console.log(result);
}
figureArea(['2', '4', '5', '3']);//17
figureArea(['13', '2', '5', '8']);//56