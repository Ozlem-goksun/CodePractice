namespace ConsoleApp2
{
    public struct Point
    {
        public int XPoint { get; set; }
        public int YPoint { get; set; }

        public override string ToString()
        {
            return $"{XPoint},{YPoint}";
        }

        // Default ctor can't uses directly in structs
        public Point(int x, int y)
        {
            XPoint = x;
            YPoint = y;
        }

        public void SetOrigin()
        {
            this.XPoint = 0;
            this.YPoint = 0;
        }

        public void Change()
        {
            var temp = this.XPoint;
            XPoint = this.YPoint;
            YPoint = temp;
        }

    }
}
