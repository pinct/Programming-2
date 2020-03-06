using System;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Photo
    {
        private double width;
        private double height;
        protected double price;
        protected double extra = 0;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                if (Width == 8 && Height == 10)
                {
                    price = 3.99;
                }
                else if (Width == 10 && Height == 12)
                {
                    price = 5.99;
                }
                else
                {
                    price = 9.99;
                }
                price += extra;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                if (Width == 8 && Height == 10)
                {
                    price = 3.99;
                }
                else if (Width == 10 && Height == 12)
                {
                    price = 5.99;
                }
                else
                {
                    price = 9.99;
                }
                price += extra;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        public override string ToString()
        {
            return $"Type: {this.GetType()} Width: {Width} Height: {Height} Price: {Price}";
        }
    }
    class MattedPhoto : Photo
    {
        public string Color { get; set; }
        public MattedPhoto()
        {
            extra = 10;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType()} Width: {Width} Height: {Height} Color: {Color} Price: {Price}";
        }
    }
    class FramedPhoto : Photo
    {
        public string Material { get; set; }
        public string Style { get; set; }
        public FramedPhoto()
        {
            extra = 25;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType()} Width: {Width} Height: {Height} Material: {Material} Style: {Style} Price: {Price}";
        }
    }
}
