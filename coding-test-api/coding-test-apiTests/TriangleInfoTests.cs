using Microsoft.VisualStudio.TestTools.UnitTesting;
using coding_test_api;
using System;
using System.Collections.Generic;
using System.Text;

namespace coding_test_api.Tests
{
    [TestClass()]
    public class TriangleInfoTests
    {
        const string INVALID_TRIANGLE_VERTICES = "Invalid Triangle Vertices";
        const string INVALID_TRIANGLE_ROW_COLUMNS = "Invalid Triangle Row Columns";

        #region + Test rowColumn Data
        RowColumns rowColumns1 = new RowColumns() { Row = 'A', Column = 7 };
        RowColumns rowColumns2 = new RowColumns() { Row = 'A', Column = 8 };
        RowColumns rowColumns3 = new RowColumns() { Row = 'A', Column = 11 };
        RowColumns rowColumns4 = new RowColumns() { Row = 'A', Column = 12 };
        RowColumns rowColumns5 = new RowColumns() { Row = 'B', Column = 1 };
        RowColumns rowColumns6 = new RowColumns() { Row = 'B', Column = 2 };
        RowColumns rowColumns7 = new RowColumns() { Row = 'B', Column = 7 };
        RowColumns rowColumns8 = new RowColumns() { Row = 'B', Column = 8 };
        RowColumns rowColumns9 = new RowColumns() { Row = 'B', Column = 11 };
        RowColumns rowColumns10 = new RowColumns() { Row = 'B', Column = 12 };
        RowColumns rowColumns11 = new RowColumns() { Row = 'D', Column = 1 };
        RowColumns rowColumns12 = new RowColumns() { Row = 'D', Column = 2 };
        RowColumns rowColumns13 = new RowColumns() { Row = 'D', Column = 7 };
        RowColumns rowColumns14 = new RowColumns() { Row = 'D', Column = 8 };
        RowColumns rowColumns15 = new RowColumns() { Row = 'D', Column = 11 };
        RowColumns rowColumns16 = new RowColumns() { Row = 'D', Column = 12 };
        RowColumns rowColumns17 = new RowColumns() { Row = 'F', Column = 1 };
        RowColumns rowColumns18 = new RowColumns() { Row = 'F', Column = 2 };
        RowColumns rowColumns19 = new RowColumns() { Row = 'F', Column = 7 };
        RowColumns rowColumns20 = new RowColumns() { Row = 'F', Column = 8 };
        RowColumns rowColumns21 = new RowColumns() { Row = 'F', Column = 11 };
        RowColumns rowColumns22 = new RowColumns() { Row = 'F', Column = 12 };
        RowColumns rowColumns23 = new RowColumns() { Row = 'A', Column = 1 };
        RowColumns rowColumns24 = new RowColumns() { Row = 'A', Column = 2 };
        #endregion

        #region + Test vertices Data
        TriangleVertices triangleVertices1 = new TriangleVertices() { aX = 30, aY = 0, bX = 30, bY = 10, cX = 40, cY = 10 };
        TriangleVertices triangleVertices2 = new TriangleVertices() { aX = 30, aY = 0, bX = 40, bY = 0, cX = 40, cY = 10 };
        TriangleVertices triangleVertices3 = new TriangleVertices() { aX = 50, aY = 0, bX = 50, bY = 10, cX = 60, cY = 10 };
        TriangleVertices triangleVertices4 = new TriangleVertices() { aX = 50, aY = 0, bX = 60, bY = 0, cX = 60, cY = 10 };
        TriangleVertices triangleVertices5 = new TriangleVertices() { aX = 0, aY = 10, bX = 0, bY = 20, cX = 10, cY = 20 };
        TriangleVertices triangleVertices6 = new TriangleVertices() { aX = 0, aY = 10, bX = 10, bY = 10, cX = 10, cY = 20 };
        TriangleVertices triangleVertices7 = new TriangleVertices() { aX = 30, aY = 10, bX = 30, bY = 20, cX = 40, cY = 20 };
        TriangleVertices triangleVertices8 = new TriangleVertices() { aX = 30, aY = 10, bX = 40, bY = 10, cX = 40, cY = 20 };
        TriangleVertices triangleVertices9 = new TriangleVertices() { aX = 50, aY = 10, bX = 50, bY = 20, cX = 60, cY = 20 };
        TriangleVertices triangleVertices10 = new TriangleVertices() { aX = 50, aY = 10, bX = 60, bY = 10, cX = 60, cY = 20 };
        TriangleVertices triangleVertices11 = new TriangleVertices() { aX = 0, aY = 30, bX = 0, bY = 40, cX = 10, cY = 40 };
        TriangleVertices triangleVertices12 = new TriangleVertices() { aX = 0, aY = 30, bX = 10, bY = 30, cX = 10, cY = 40 };
        TriangleVertices triangleVertices13 = new TriangleVertices() { aX = 30, aY = 30, bX = 30, bY = 40, cX = 40, cY = 40 };
        TriangleVertices triangleVertices14 = new TriangleVertices() { aX = 30, aY = 30, bX = 40, bY = 30, cX = 40, cY = 40 };
        TriangleVertices triangleVertices15 = new TriangleVertices() { aX = 50, aY = 30, bX = 50, bY = 40, cX = 60, cY = 40 };
        TriangleVertices triangleVertices16 = new TriangleVertices() { aX = 50, aY = 30, bX = 60, bY = 30, cX = 60, cY = 40 };
        TriangleVertices triangleVertices17 = new TriangleVertices() { aX = 0, aY = 50, bX = 0, bY = 60, cX = 10, cY = 60 };
        TriangleVertices triangleVertices18 = new TriangleVertices() { aX = 0, aY = 50, bX = 10, bY = 50, cX = 10, cY = 60 };
        TriangleVertices triangleVertices19 = new TriangleVertices() { aX = 30, aY = 50, bX = 30, bY = 60, cX = 40, cY = 60 };
        TriangleVertices triangleVertices20 = new TriangleVertices() { aX = 30, aY = 50, bX = 40, bY = 50, cX = 40, cY = 60 };
        TriangleVertices triangleVertices21 = new TriangleVertices() { aX = 50, aY = 50, bX = 50, bY = 60, cX = 60, cY = 60 };
        TriangleVertices triangleVertices22 = new TriangleVertices() { aX = 50, aY = 50, bX = 60, bY = 50, cX = 60, cY = 60 };
        TriangleVertices triangleVertices23 = new TriangleVertices() { aX = 0, aY = 0, bX = 0, bY = 10, cX = 10, cY = 10 };
        TriangleVertices triangleVertices24 = new TriangleVertices() { aX = 0, aY = 0, bX = 10, bY = 0, cX = 10, cY = 10 };
        #endregion


        #region + Calculate Vertices Test
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_1_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns1);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices1.aX);
            Assert.AreEqual(result.aY, triangleVertices1.aY);
            Assert.AreEqual(result.bX, triangleVertices1.bX);
            Assert.AreEqual(result.bY, triangleVertices1.bY);
            Assert.AreEqual(result.cX, triangleVertices1.cX);
            Assert.AreEqual(result.cY, triangleVertices1.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_2_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns2);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices2.aX);
            Assert.AreEqual(result.aY, triangleVertices2.aY);
            Assert.AreEqual(result.bX, triangleVertices2.bX);
            Assert.AreEqual(result.bY, triangleVertices2.bY);
            Assert.AreEqual(result.cX, triangleVertices2.cX);
            Assert.AreEqual(result.cY, triangleVertices2.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_3_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns3);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices3.aX);
            Assert.AreEqual(result.aY, triangleVertices3.aY);
            Assert.AreEqual(result.bX, triangleVertices3.bX);
            Assert.AreEqual(result.bY, triangleVertices3.bY);
            Assert.AreEqual(result.cX, triangleVertices3.cX);
            Assert.AreEqual(result.cY, triangleVertices3.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_4_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns4);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices4.aX);
            Assert.AreEqual(result.aY, triangleVertices4.aY);
            Assert.AreEqual(result.bX, triangleVertices4.bX);
            Assert.AreEqual(result.bY, triangleVertices4.bY);
            Assert.AreEqual(result.cX, triangleVertices4.cX);
            Assert.AreEqual(result.cY, triangleVertices4.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_5_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns5);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices5.aX);
            Assert.AreEqual(result.aY, triangleVertices5.aY);
            Assert.AreEqual(result.bX, triangleVertices5.bX);
            Assert.AreEqual(result.bY, triangleVertices5.bY);
            Assert.AreEqual(result.cX, triangleVertices5.cX);
            Assert.AreEqual(result.cY, triangleVertices5.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_6_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns6);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices6.aX);
            Assert.AreEqual(result.aY, triangleVertices6.aY);
            Assert.AreEqual(result.bX, triangleVertices6.bX);
            Assert.AreEqual(result.bY, triangleVertices6.bY);
            Assert.AreEqual(result.cX, triangleVertices6.cX);
            Assert.AreEqual(result.cY, triangleVertices6.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_7_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns7);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices7.aX);
            Assert.AreEqual(result.aY, triangleVertices7.aY);
            Assert.AreEqual(result.bX, triangleVertices7.bX);
            Assert.AreEqual(result.bY, triangleVertices7.bY);
            Assert.AreEqual(result.cX, triangleVertices7.cX);
            Assert.AreEqual(result.cY, triangleVertices7.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_8_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns8);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices8.aX);
            Assert.AreEqual(result.aY, triangleVertices8.aY);
            Assert.AreEqual(result.bX, triangleVertices8.bX);
            Assert.AreEqual(result.bY, triangleVertices8.bY);
            Assert.AreEqual(result.cX, triangleVertices8.cX);
            Assert.AreEqual(result.cY, triangleVertices8.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_9_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns9);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices9.aX);
            Assert.AreEqual(result.aY, triangleVertices9.aY);
            Assert.AreEqual(result.bX, triangleVertices9.bX);
            Assert.AreEqual(result.bY, triangleVertices9.bY);
            Assert.AreEqual(result.cX, triangleVertices9.cX);
            Assert.AreEqual(result.cY, triangleVertices9.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_10_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns10);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices10.aX);
            Assert.AreEqual(result.aY, triangleVertices10.aY);
            Assert.AreEqual(result.bX, triangleVertices10.bX);
            Assert.AreEqual(result.bY, triangleVertices10.bY);
            Assert.AreEqual(result.cX, triangleVertices10.cX);
            Assert.AreEqual(result.cY, triangleVertices10.cY);
        }

        public void Calculate_Vertices_Input_Set_11_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns11);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices11.aX);
            Assert.AreEqual(result.aY, triangleVertices11.aY);
            Assert.AreEqual(result.bX, triangleVertices11.bX);
            Assert.AreEqual(result.bY, triangleVertices11.bY);
            Assert.AreEqual(result.cX, triangleVertices11.cX);
            Assert.AreEqual(result.cY, triangleVertices11.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_12_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns12);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices12.aX);
            Assert.AreEqual(result.aY, triangleVertices12.aY);
            Assert.AreEqual(result.bX, triangleVertices12.bX);
            Assert.AreEqual(result.bY, triangleVertices12.bY);
            Assert.AreEqual(result.cX, triangleVertices12.cX);
            Assert.AreEqual(result.cY, triangleVertices12.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_13_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns13);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices13.aX);
            Assert.AreEqual(result.aY, triangleVertices13.aY);
            Assert.AreEqual(result.bX, triangleVertices13.bX);
            Assert.AreEqual(result.bY, triangleVertices13.bY);
            Assert.AreEqual(result.cX, triangleVertices13.cX);
            Assert.AreEqual(result.cY, triangleVertices13.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_14_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns14);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices14.aX);
            Assert.AreEqual(result.aY, triangleVertices14.aY);
            Assert.AreEqual(result.bX, triangleVertices14.bX);
            Assert.AreEqual(result.bY, triangleVertices14.bY);
            Assert.AreEqual(result.cX, triangleVertices14.cX);
            Assert.AreEqual(result.cY, triangleVertices14.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_15_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns15);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices15.aX);
            Assert.AreEqual(result.aY, triangleVertices15.aY);
            Assert.AreEqual(result.bX, triangleVertices15.bX);
            Assert.AreEqual(result.bY, triangleVertices15.bY);
            Assert.AreEqual(result.cX, triangleVertices15.cX);
            Assert.AreEqual(result.cY, triangleVertices15.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_16_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns16);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices16.aX);
            Assert.AreEqual(result.aY, triangleVertices16.aY);
            Assert.AreEqual(result.bX, triangleVertices16.bX);
            Assert.AreEqual(result.bY, triangleVertices16.bY);
            Assert.AreEqual(result.cX, triangleVertices16.cX);
            Assert.AreEqual(result.cY, triangleVertices16.cY);
        }

        public void Calculate_Vertices_Input_Set_17_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns17);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices17.aX);
            Assert.AreEqual(result.aY, triangleVertices17.aY);
            Assert.AreEqual(result.bX, triangleVertices17.bX);
            Assert.AreEqual(result.bY, triangleVertices17.bY);
            Assert.AreEqual(result.cX, triangleVertices17.cX);
            Assert.AreEqual(result.cY, triangleVertices17.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_18_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns18);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices18.aX);
            Assert.AreEqual(result.aY, triangleVertices18.aY);
            Assert.AreEqual(result.bX, triangleVertices18.bX);
            Assert.AreEqual(result.bY, triangleVertices18.bY);
            Assert.AreEqual(result.cX, triangleVertices18.cX);
            Assert.AreEqual(result.cY, triangleVertices18.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_19_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns19);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices19.aX);
            Assert.AreEqual(result.aY, triangleVertices19.aY);
            Assert.AreEqual(result.bX, triangleVertices19.bX);
            Assert.AreEqual(result.bY, triangleVertices19.bY);
            Assert.AreEqual(result.cX, triangleVertices19.cX);
            Assert.AreEqual(result.cY, triangleVertices19.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_20_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns20);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices20.aX);
            Assert.AreEqual(result.aY, triangleVertices20.aY);
            Assert.AreEqual(result.bX, triangleVertices20.bX);
            Assert.AreEqual(result.bY, triangleVertices20.bY);
            Assert.AreEqual(result.cX, triangleVertices20.cX);
            Assert.AreEqual(result.cY, triangleVertices20.cY);
        }

        [TestMethod()]
        public void Calculate_Vertices_Input_Set_21_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns21);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices21.aX);
            Assert.AreEqual(result.aY, triangleVertices21.aY);
            Assert.AreEqual(result.bX, triangleVertices21.bX);
            Assert.AreEqual(result.bY, triangleVertices21.bY);
            Assert.AreEqual(result.cX, triangleVertices21.cX);
            Assert.AreEqual(result.cY, triangleVertices21.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_22_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns22);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices22.aX);
            Assert.AreEqual(result.aY, triangleVertices22.aY);
            Assert.AreEqual(result.bX, triangleVertices22.bX);
            Assert.AreEqual(result.bY, triangleVertices22.bY);
            Assert.AreEqual(result.cX, triangleVertices22.cX);
            Assert.AreEqual(result.cY, triangleVertices22.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_23_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns23);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices23.aX);
            Assert.AreEqual(result.aY, triangleVertices23.aY);
            Assert.AreEqual(result.bX, triangleVertices23.bX);
            Assert.AreEqual(result.bY, triangleVertices23.bY);
            Assert.AreEqual(result.cX, triangleVertices23.cX);
            Assert.AreEqual(result.cY, triangleVertices23.cY);
        }
        [TestMethod()]
        public void Calculate_Vertices_Input_Set_24_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            TriangleVertices result = triangleInfo.CalculateVertices(rowColumns24);

            // EXPECT
            Assert.AreEqual(result.aX, triangleVertices24.aX);
            Assert.AreEqual(result.aY, triangleVertices24.aY);
            Assert.AreEqual(result.bX, triangleVertices24.bX);
            Assert.AreEqual(result.bY, triangleVertices24.bY);
            Assert.AreEqual(result.cX, triangleVertices24.cX);
            Assert.AreEqual(result.cY, triangleVertices24.cY);
        }
        #endregion

        #region + Calculate RowColumns Test
        [TestMethod()]
        public void Calculate_RowColumns_Input1_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices1);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns1.Row);
            Assert.AreEqual(result.Column, rowColumns1.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input2_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices2);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns2.Row);
            Assert.AreEqual(result.Column, rowColumns2.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input3_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices3);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns3.Row);
            Assert.AreEqual(result.Column, rowColumns3.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input4_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices4);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns4.Row);
            Assert.AreEqual(result.Column, rowColumns4.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input5_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices5);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns5.Row);
            Assert.AreEqual(result.Column, rowColumns5.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input6_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices6);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns6.Row);
            Assert.AreEqual(result.Column, rowColumns6.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input7_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices7);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns7.Row);
            Assert.AreEqual(result.Column, rowColumns7.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input8_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices8);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns8.Row);
            Assert.AreEqual(result.Column, rowColumns8.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input9_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices9);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns9.Row);
            Assert.AreEqual(result.Column, rowColumns9.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input10_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices10);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns10.Row);
            Assert.AreEqual(result.Column, rowColumns10.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input11_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices11);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns11.Row);
            Assert.AreEqual(result.Column, rowColumns11.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input12_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices12);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns12.Row);
            Assert.AreEqual(result.Column, rowColumns12.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input13_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices13);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns13.Row);
            Assert.AreEqual(result.Column, rowColumns13.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input14_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices14);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns14.Row);
            Assert.AreEqual(result.Column, rowColumns14.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input15_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices15);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns15.Row);
            Assert.AreEqual(result.Column, rowColumns15.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input16_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices16);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns16.Row);
            Assert.AreEqual(result.Column, rowColumns16.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input17_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices17);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns17.Row);
            Assert.AreEqual(result.Column, rowColumns17.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input18_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices18);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns18.Row);
            Assert.AreEqual(result.Column, rowColumns18.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input19_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices19);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns19.Row);
            Assert.AreEqual(result.Column, rowColumns19.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input20_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices20);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns20.Row);
            Assert.AreEqual(result.Column, rowColumns20.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input21_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices21);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns21.Row);
            Assert.AreEqual(result.Column, rowColumns21.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input22_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices22);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns22.Row);
            Assert.AreEqual(result.Column, rowColumns22.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input23_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices23);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns23.Row);
            Assert.AreEqual(result.Column, rowColumns23.Column);
        }
        [TestMethod()]
        public void Calculate_RowColumns_Input24_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            RowColumns result = triangleInfo.CalculateRowColumns(triangleVertices24);

            // EXPECT
            Assert.AreEqual(result.Row, rowColumns24.Row);
            Assert.AreEqual(result.Column, rowColumns24.Column);
        }
        #endregion

        
        #region - Test rowColumn -ve Data
        RowColumns rowColumnsNegative1 = new RowColumns() { Row = 'X', Column = 2 };
        RowColumns rowColumnsNegative2 = new RowColumns() { Row = 'P', Column = 1 };
        RowColumns rowColumnsNegative3 = new RowColumns() { Row = 'A', Column = 88 };
        RowColumns rowColumnsNegative4 = new RowColumns() { Row = 'A', Column = 0 };
        RowColumns rowColumnsNegative5 = new RowColumns() { Row = 'X', Column = 14 };
        RowColumns rowColumnsNegative6 = new RowColumns() { Row = '@', Column = 14 };
        #endregion

        #region + Test vertices Data
        TriangleVertices negativeTriangleVertices1 = new TriangleVertices() { aX = -30, aY = 0, bX = 30, bY = 10, cX = 40, cY = 10 }; // incorrect aX
        TriangleVertices negativeTriangleVertices2 = new TriangleVertices() { aX = 30, aY = 157, bX = 40, bY = 0, cX = 40, cY = 10 }; // incorrect aY
        TriangleVertices negativeTriangleVertices3 = new TriangleVertices() { aX = 50, aY = 0, bX = 10, bY = 10, cX = 60, cY = 10 }; // incorrect bX
        TriangleVertices negativeTriangleVertices4 = new TriangleVertices() { aX = 50, aY = 0, bX = 60, bY = 1, cX = 60, cY = 10 }; // incorrect bY
        TriangleVertices negativeTriangleVertices5 = new TriangleVertices() { aX = 0, aY = 10, bX = 0, bY = 20, cX = -10, cY = 20 }; // incorrect cX
        TriangleVertices negativeTriangleVertices6 = new TriangleVertices() { aX = 0, aY = 10, bX = 10, bY = 10, cX = 10, cY = 70 }; // incorrect cY
        #endregion

        #region - Calculate Vertices Test
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_1_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative1));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_2_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative2));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_3_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative3));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_4_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative4));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_5_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative5));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        [TestMethod()]
        public void Negative_Calculate_Vertices_Input_Set_6_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateVertices(rowColumnsNegative6));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_ROW_COLUMNS);
        }
        #endregion

        #region - Calculate RowColumns Test
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input1_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices1));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input2_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices2));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input3_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices3));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input4_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices4));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input5_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices5));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        [TestMethod()]
        public void Negative_Calculate_RowColumns_Input6_Test()
        {
            // ACT
            ITriangleInfo triangleInfo = new TriangleInfo();
            Exception ex = Assert.ThrowsException<Exception>(() => triangleInfo.CalculateRowColumns(negativeTriangleVertices6));

            // EXPECT
            Assert.AreEqual(ex.Message, INVALID_TRIANGLE_VERTICES);
        }
        #endregion

    }
}