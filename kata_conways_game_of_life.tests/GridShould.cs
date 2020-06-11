using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace kata_conways_game_of_life.tests
{
    public class GridShould
    {
        [Fact]
        public void ContainCorrectNumberOfSquares()
        {
            var sut = new Grid(3, 3);
            sut.AddCellsToLocations();
            
            var expectedDisplay = 
                "[ ][ ][ ]" + Environment.NewLine +
                "[ ][ ][ ]" + Environment.NewLine +
                "[ ][ ][ ]" + Environment.NewLine;
            
            Assert.Equal(expectedDisplay, sut.Display());
        }

        [Fact]
        public void Set8SurroundingNeighboursForNonBoundaryLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(3, 3);
            
            var expectedNeighbours = new List<Location>()
            {
                new Location(2, 2),
                new Location(2, 3),
                new Location(2, 4),
                new Location(3, 2),
                new Location(3, 4),
                new Location(4, 2),
                new Location(4, 3),
                new Location(4, 4),
            };

            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }
            
        }

        [Fact]
        public void Set8NeighboursToBoundaryLeftColumnLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(3, 1);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(2, 5),
                new Location(2, 1),
                new Location(2, 2),
                new Location(3, 5),
                new Location(3, 2),
                new Location(4, 5),
                new Location(4, 1),
                new Location(4, 2)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }

        }
        
        [Fact]
        public void Set8NeighboursToBoundaryRightColumnLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(3, 5);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(2, 4),
                new Location(2, 5),
                new Location(2, 1),
                new Location(3, 4),
                new Location(3, 1),
                new Location(4, 4),
                new Location(4, 5),
                new Location(4, 1)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }

        }
        
        [Fact]
        public void Set8NeighboursToBoundaryTopRowLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(1, 3);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(5, 2),
                new Location(5, 3),
                new Location(5, 4),
                new Location(1, 2),
                new Location(1, 4),
                new Location(2, 2),
                new Location(2, 3),
                new Location(2, 4)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }

        }
        
        [Fact]
        public void Set8NeighboursToBoundaryBottomRowLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(5, 2);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(4, 1),
                new Location(4, 2),
                new Location(4, 3),
                new Location(5, 1),
                new Location(5, 3),
                new Location(1, 1),
                new Location(1, 2),
                new Location(1, 3)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }

        }
        
        [Fact]
        public void Set8NeighboursToBoundaryTopLeftCornerLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(1, 1);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(5, 5),
                new Location(5, 1),
                new Location(5, 2),
                new Location(1, 5),
                new Location(1, 2),
                new Location(2, 5),
                new Location(2, 1),
                new Location(2, 2)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }

        }
        
        [Fact]
        public void Set8NeighboursToBoundaryTopRightCornerLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(1, 5);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(5, 4),
                new Location(5, 5),
                new Location(5, 1),
                new Location(1, 4),
                new Location(1, 1),
                new Location(2, 4),
                new Location(2, 5),
                new Location(2, 1)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }
        }
        [Fact]
        public void Set8NeighboursToBoundaryBottomLeftCornerLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(5, 1);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(4, 5),
                new Location(4, 1),
                new Location(4, 2),
                new Location(5, 5),
                new Location(5, 2),
                new Location(1, 5),
                new Location(1, 1),
                new Location(1, 2)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }
        }
        
        [Fact]
        public void Set8NeighboursToBoundaryBottomRightCornerLocation()
        {
            var sut = new Grid(5, 5);
            var actual = sut.GetNeighboursFor(5, 5);

            
            var expectedNeighbours = new List<Location>()
            {
                new Location(4, 4),
                new Location(4, 5),
                new Location(4, 1),
                new Location(5, 4),
                new Location(5, 1),
                new Location(1, 4),
                new Location(1, 5),
                new Location(1, 1)
            };
            
            for (var i = 0; i < 8; i++)
            {
                Assert.Equal( expectedNeighbours.ElementAt(i).RowNumber,actual.ElementAt(i).RowNumber);
                Assert.Equal( expectedNeighbours.ElementAt(i).ColumnNumber,actual.ElementAt(i).ColumnNumber);
            }
        }

        [Fact]
        public void UpdateTheNextCellStateForEachLocation()
        {
            var sut = new Grid(3, 3);
            sut.AddCellsToLocations();
            
            Assert.Equal(State.Alive, sut.ChangeLocationCellState(1, 1, State.Alive));
            
        }

        [Fact]
        public void UpdateLocationCellStatesWhenGivenStartingLiveCells()
        {
            var sut = new Grid(5, 5);
            sut.AddCellsToLocations();
        }
    }
}