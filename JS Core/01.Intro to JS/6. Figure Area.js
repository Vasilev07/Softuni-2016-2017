function solve([w, h, W, H]) {
    [w, h, W, H] = [w, h, W, H].map(parseFloat);
    let first = W*H;
    let second = w*h;
    let common = Math.min(w,W)*Math.min(h,H);
    return first+second-common;
}
solve(['2', '4', '5', '3']);
solve(['13', '2', '5', '8']);
solve(['1', '1', '2', '2']);
solve(['1', '1.01','1','1']);
solve(['12.45', '23.266', '10.145', '28.561']);