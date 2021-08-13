namespace coding_test_api
{
    public interface ITriangleInfo
    {
        public RowColumns CalculateRowColumns(TriangleVertices triangleVertices);
        public TriangleVertices CalculateVertices(RowColumns rowColumns);
    }
}