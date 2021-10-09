namespace ConwaysGame.Components.Tests
{
    internal class World
    {
        private readonly int width;
        private readonly int height;

        public World(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width { get => width; }
        public int Height { get => height; }
    }
}