﻿/*
Author: Reid Reininger
Student ID: 11512839
*/
namespace Cpts321
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cpts321;
    using SpreadsheetEngine;

    /// <summary>
    /// Contains all cells.
    /// </summary>
    public class Spreadsheet
    {
        // Reference to cells
        private Cell[,] cells;

        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet"/> class.
        /// </summary>
        /// <param name="rows">Number of rows.</param>
        /// <param name="columns">Number of columns.</param>
        public Spreadsheet(int rows, int columns)
        {
            this.cells = new Cell[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.cells[i, j] = CreateCell(CellType.Text, i, j);
                    this.cells[i, j].PropertyChanged += this.Cell_PropertyChanged;
                }
            }
        }

        /// <summary>
        /// Event fires whenever a cell property in spreadsheet changes.
        /// </summary>
        public event PropertyChangedEventHandler CellPropertyChanged;

        /// <summary>
        /// Types of Cells.
        /// </summary>
        public enum CellType
        {
            /// <summary>
            /// Cell with text.
            /// </summary>
            Text,
        }

        /// <summary>
        /// Returns a cell of the given type.
        /// </summary>
        /// <param name="type">Type of cell to create.</param>
        /// <param name="row">Cell's row.</param>
        /// <param name="column">Cell's column.</param>
        /// <returns>New instance of cell type.</returns>
        public static Cell CreateCell(CellType type, int row, int column)
        {
            switch (type)
            {
                case CellType.Text:
                    return new TextCell(row, column);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Fires CellPropertyChanged when a cells property has changed.
        /// </summary>
        /// <param name="sender">Changed cell.</param>
        /// <param name="e">Event args from changed cell.</param>
        private void Cell_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.CellPropertyChanged?.Invoke(sender, e);
        }
    }
}
