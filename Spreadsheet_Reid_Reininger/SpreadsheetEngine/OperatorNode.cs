﻿// Reid Reininger
// 11512839
namespace Cpts321
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cpts321;

    /// <summary>
    /// Abstract class for operator nodes.
    /// </summary>
    internal abstract class OperatorNode : Node
    {
        private string op;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorNode"/> class.
        /// </summary>
        /// <param name="op">String to represent operator in expressions.</param>
        protected OperatorNode(string op)
        {
            this.op = op;
        }

        /// <summary>
        /// Gets string representing operator in expression.
        /// </summary>
        internal string Op
        {
            get => this.op;
        }

        /// <summary>
        /// Evaluates value of node.
        /// </summary>
        /// <returns>Value of node as double.</returns>
        internal override abstract double Evaluate();
    }
}
