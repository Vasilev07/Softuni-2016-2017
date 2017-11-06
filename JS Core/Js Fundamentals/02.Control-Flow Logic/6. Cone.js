function solve([radius, height]) {
    [radius, height] = [radius, height].map(Number);
    let slantHeight = Math.sqrt(radius * radius + height*height);
    let volume = (Math.PI * (radius*radius) * height) / 3;
    let baseSurfaceArea = Math.PI*(radius*radius);
    let lateralSurfaceArea = Math.PI*radius*slantHeight;
    let totalSurfaceArea = baseSurfaceArea + lateralSurfaceArea;
    console.log("volume = " + volume);
    console.log("area = " + totalSurfaceArea);
}
solve(['3', '5']);
solve(['3.3', '7.8']);