﻿// Reid Reininger
// ID: 11512839

namespace CellTests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>
    /// Tests for cell class.
    /// </summary>
    [TestFixture]
    public class TestCell
    {
        /// <summary>
        /// Test valid input for Cell constructor.
        /// </summary>
        /// <param name="rowIndex">Cells' row index.</param>
        /// <param name="columnIndex">Cell's column index.</param>
        [TestCase(0, 0)] // Edge case, least possible indices
        [TestCase(0, 1)] // Edge case
        [TestCase(1, 0)] // Edge case
        [TestCase(1, 1)] // Edge case
        [TestCase(2, 3)] // Normal case
        public void TestCellConstructorValidInput(int rowIndex, int columnIndex)
        {
        }
    }
}
