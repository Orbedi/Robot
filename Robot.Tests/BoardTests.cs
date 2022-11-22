﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Tests
{
    public class BoardTests
    {
        private Board _board;

        [SetUp]
        public void SetUp()
        {
            _board = new Board(5, 5);
        }

        [Test]
        public void MaxX_Equals5_ReturnsTrue()
        {
            Assert.AreEqual(_board.MAX_X, 5);
        }

        [Test]
        public void MaxY_Equals5_ReturnsTrue()
        {
            Assert.AreEqual(_board.MAX_Y, 5);
        }

    }
}