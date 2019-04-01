namespace RockPaperScissors.Helper
{
    public static class SqlQuery
    {
        public static string Add()
        {
            return "INSERT INTO dbo.Shapes (shapeID,shape) " +
                   "VALUES (1,'rock'),(2,'paper'),(3,'scissors')";
        }

        public static string Delete()
        {
            return "DELETE FROM dbo.Shapes";
        }

        public static string GetShape(string shape)
        {
            return "SELECT shape FROM dbo.Shapes WHERE shapeID =" + shape;
        }

        public static string GetRock()
        {
            return "SELECT shape FROM dbo.Shapes WHERE shapeID = 1";
        }

        public static string GetPaper()
        {
            return "SELECT shape FROM dbo.Shapes WHERE shapeID = 2";
        }

        public static string GetScissors()
        {
            return "SELECT shape FROM dbo.Shapes WHERE shapeID = 3";
        }
    }
}
