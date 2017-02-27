namespace _06.RectanglePosition
{
    public class RectanglePosition
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcArea => Height * Width;

        public int Bottom => Top - Height;

        public int Right => Left + Width;
       
    }
}
