using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coding_test_api
{
    public class TriangleInfo : ITriangleInfo
    {
        const int MAX_ROW = 6;
        const int MAX_Column = 6;
        const int PIX_DIFFERENCE = 10;
        const string INVALID_TRIANGLE_VERTICES = "Invalid Triangle Vertices";
        const string INVALID_TRIANGLE_ROW_COLUMNS = "Invalid Triangle Row Columns";
        List<char> liRows;
        List<int> liColumns;
        public TriangleInfo()
        {
            liRows = new List<char>();
            liColumns = new List<int>();
            GenerateRowColumns();
        }
        
        public RowColumns CalculateRowColumns(TriangleVertices triangleVertices)
        {
            // to filter out each vertices is divisible by the pix difference, else it is an invalid vertice
            int aX = (triangleVertices.aX >= 0 && triangleVertices.aX % PIX_DIFFERENCE == 0) ? triangleVertices.aX / PIX_DIFFERENCE : -1;
            int bX = (triangleVertices.bX >= 0 && triangleVertices.bX % PIX_DIFFERENCE == 0) ? triangleVertices.bX / PIX_DIFFERENCE : -1;
            int cX = (triangleVertices.cX >= 0 && triangleVertices.cX % PIX_DIFFERENCE == 0) ? triangleVertices.cX / PIX_DIFFERENCE : -1;
            int aY = (triangleVertices.aY >= 0 && triangleVertices.aY % PIX_DIFFERENCE == 0) ? triangleVertices.aY / PIX_DIFFERENCE : -1;
            int bY = (triangleVertices.bY >= 0 && triangleVertices.bY % PIX_DIFFERENCE == 0) ? triangleVertices.bY / PIX_DIFFERENCE : -1;
            int cY = (triangleVertices.cY >= 0 && triangleVertices.cY % PIX_DIFFERENCE == 0) ? triangleVertices.cY / PIX_DIFFERENCE : -1;

            if (aX == -1 || aY == -1 || bX == -1 || bY == -1 || cX == -1 || cY == -1 ||
                aX > MAX_Column * 2 || bX > MAX_Column * 2 || cX > MAX_Column * 2 || aY > MAX_ROW || bY > MAX_ROW || cY > MAX_ROW)
                throw new Exception(INVALID_TRIANGLE_VERTICES);

            if (aX == bX && aY != bY)
            {
                return CalculateRowColumnsForOdd(aX, bX, cX, aY, bY, cY);
            }
            else if (bX == cX && bY != cY)
            {
                return CalculateRowColumnsForEven(aX, bX, cX, aY, bY, cY);
            }
            else
            {
                throw new Exception(INVALID_TRIANGLE_VERTICES);
            }
        }

        public TriangleVertices CalculateVertices(RowColumns rowColumns)
        {
            TriangleVertices triangleVertices = new TriangleVertices();
            int rowIndex = liRows.FindIndex(f => f == rowColumns.Row);
            int colIndex = liColumns.FindIndex(f => f == rowColumns.Column);
            if ((rowColumns.Column > 0 && rowColumns.Column <= MAX_ROW * 2) && (colIndex > -1 && rowIndex > -1))
            {
                if (rowColumns.Column > 1 && rowColumns.Column % 2 == 0)
                {
                    // isEven
                    triangleVertices.aX = (liColumns[colIndex - 1] / 2) * PIX_DIFFERENCE;
                    triangleVertices.bX = triangleVertices.cX = ((liColumns[colIndex]) / 2) * PIX_DIFFERENCE;

                    triangleVertices.aY = triangleVertices.bY = rowIndex * PIX_DIFFERENCE;
                    triangleVertices.cY = (rowIndex + 1) * PIX_DIFFERENCE;
                }
                else
                {
                    // isOdd
                    triangleVertices.aX = triangleVertices.bX = (liColumns[colIndex] / 2) * PIX_DIFFERENCE;
                    triangleVertices.cX = ((liColumns[colIndex + 1]) / 2) * PIX_DIFFERENCE;

                    triangleVertices.aY = rowIndex * PIX_DIFFERENCE;
                    triangleVertices.cY = triangleVertices.bY = (rowIndex + 1) * PIX_DIFFERENCE;
                }
                return triangleVertices;
            }
            else
            {
                throw new Exception(INVALID_TRIANGLE_ROW_COLUMNS);
            }

        }

        private void GenerateRowColumns()
        {
            for (int i = 1; i <= MAX_Column * 2; i++)
            {
                liColumns.Add(i);
            }
            int index = 1;
            for (char i = 'A'; index <= MAX_ROW; i++)
            {
                liRows.Add(i);
                index++;
            }
        }

        private RowColumns CalculateRowColumnsForEven(int aX, int bX, int cX, int aY, int bY, int cY)
        {
            if ((bX == cX && aX != bX && aX != cX) && (aY == bY && aY != cY && bY != cY))
            {
                char row = liRows[aY];
                int column = liColumns[(bX * 2) -1];
                RowColumns rowColumns = new RowColumns() { Row = row, Column = column };
                return rowColumns;
            }
            else
            {
                throw new Exception(INVALID_TRIANGLE_ROW_COLUMNS);
            }

        }

        private RowColumns CalculateRowColumnsForOdd(int aX, int bX, int cX, int aY, int bY, int cY)
        {
            if ((aX == bX && aX != cX && bX != cX) && (bY == cY && cY != aY && bY != aY))
            {
                char row = liRows[aY];
                int column = liColumns[bX * 2];
                RowColumns rowColumns = new RowColumns() { Row = row, Column = column };
                return rowColumns;
            }
            else
            {
                throw new Exception(INVALID_TRIANGLE_VERTICES);
            }
        }
    }
}
