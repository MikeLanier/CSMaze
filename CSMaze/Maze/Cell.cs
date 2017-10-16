using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMaze.Maze
{
	public class Cell
	{
		private int xOrigin = 0;
		private int yOrigin = 0;

		int X() { return xOrigin; }
		int Y() { return yOrigin; }

		private Maze.Wall[] cellWalls = new Maze.Wall[4];
		private bool visited = false;

		bool Visited() { return visited; }
		void setVisited() { visited = true; }

		static int west = 0;
		static int north = 1;
		static int east = 2;
		static int south = 3;

		Maze.Wall W(int which)
		{
			return cellWalls[which];
		}

		public enum CellType
		{
			eCellTypeNormal,
			eCellTypeStart,
			eCellTypeEntrance,
			eCellTypeExit,
			eCellTypeRoom,
			eCellTypeStairsDown,
			eCellTypeStairsUp
		}

		public enum CellFacing
		{
			eCellFacingNone,
			eCellFacingEast,
			eCellFacingWest,
			eCellFacingNorth,
			eCellFacingSouth
		}

		private CellType type = CellType.eCellTypeNormal;
		private CellFacing facing = CellFacing.eCellFacingNone;

		bool facingNorth() { return facing == CellFacing.eCellFacingNorth; }// ? true : false; }
		bool facingSouth() { return facing == CellFacing.eCellFacingSouth; }// ? true : false; }
		bool facingEast() { return facing == CellFacing.eCellFacingEast; }// ? true : false; }
		bool facingWest() { return facing == CellFacing.eCellFacingWest; }// ? true : false; }
		bool facingNone() { return facing == CellFacing.eCellFacingNone; }// ? true : false; }
		bool stairsUp() { return type == CellType.eCellTypeStairsUp; }
		bool stairsDown() { return type == CellType.eCellTypeStairsDown; }

		CellFacing direction() { return facing; }

		public void setType(CellType _type) { type = _type; }
		public void setFacing(CellFacing _facing) { facing = _facing; }

		public Cell(int _xOrigin, int _yOrigin, Maze.Wall west, Maze.Wall north, Maze.Wall east, Maze.Wall south)
		{
			xOrigin = _xOrigin;
			yOrigin = _yOrigin;
			cellWalls[0] = west;
			cellWalls[1] = north;
			cellWalls[2] = east;
			cellWalls[3] = south;
		}

		public int ID()
		{
			return GlobalData.ID(xOrigin, yOrigin, false);
		}

		public void draw(Graphics gc, int xOffset, int yOffset, int cellSize)
		{
			float x = (float)(xOffset + xOrigin * cellSize);
			float y = (float)(yOffset + yOrigin * cellSize);

			float scale = ((float)cellSize) / 6.0f;

			PointF[] pointsEast = new PointF[] {
				new PointF(x + 1 * scale,	y + 2 * scale),
				new PointF(x + 3 * scale,	y + 2 * scale),
				new PointF(x + 3 * scale,	y + 1 * scale),
				new PointF(x + 5 * scale,	y + 3 * scale),
				new PointF(x + 3 * scale,	y + 5 * scale),
				new PointF(x + 3 * scale,	y + 4 * scale),
				new PointF(x + 1 * scale,	y + 4 * scale),
				new PointF(x + 1 * scale,	y + 2 * scale)
			};

			PointF[] pointsSouth = new PointF[] {
				new PointF(x + 2 * scale,	y + 1 * scale),
				new PointF(x + 2 * scale,	y + 3 * scale),
				new PointF(x + 1 * scale,	y + 3 * scale),
				new PointF(x + 3 * scale,	y + 5 * scale),
				new PointF(x + 5 * scale,	y + 3 * scale),
				new PointF(x + 4 * scale,	y + 3 * scale),
				new PointF(x + 4 * scale,	y + 1 * scale),
				new PointF(x + 2 * scale,	y + 1 * scale)
			};

			PointF[] pointsWest = new PointF[] {
				new PointF(x + 5 * scale,	y + 2 * scale),
				new PointF(x + 3 * scale,	y + 2 * scale),
				new PointF(x + 3 * scale,	y + 1 * scale),
				new PointF(x + 1 * scale,	y + 3 * scale),
				new PointF(x + 3 * scale,	y + 5 * scale),
				new PointF(x + 3 * scale,	y + 4 * scale),
				new PointF(x + 5 * scale,	y + 4 * scale),
				new PointF(x + 5 * scale,	y + 2 * scale)
			};

			PointF[] pointsNorth = new PointF[] {
				new PointF(x + 2 * scale,	y + 5 * scale),
				new PointF(x + 2 * scale,	y + 3 * scale),
				new PointF(x + 1 * scale,	y + 3 * scale),
				new PointF(x + 3 * scale,	y + 1 * scale),
				new PointF(x + 5 * scale,	y + 3 * scale),
				new PointF(x + 4 * scale,	y + 3 * scale),
				new PointF(x + 4 * scale,	y + 5 * scale),
				new PointF(x + 2 * scale,	y + 5 * scale)
			};

			Brush brush = new SolidBrush(Color.White);
			gc.FillRectangle(brush, x + 1, y + 1, cellSize - 2, cellSize - 2);

			if (type == CellType.eCellTypeStart)
			{
				brush = new SolidBrush(Color.Yellow);
			}
			else if (type == CellType.eCellTypeRoom)
			{
				brush = new SolidBrush(Color.White);
			}
			else if (type == CellType.eCellTypeEntrance)
			{
				brush = new SolidBrush(Color.LightGreen);
			}
			else if (type == CellType.eCellTypeExit)
			{
				brush = new SolidBrush(Color.LightPink);
			}
			else
			{
				brush = new SolidBrush(Color.White);
			}
			gc.FillRectangle(brush, x, y, cellSize, cellSize);

			if (!facingNone())
			{
				if (type == CellType.eCellTypeEntrance)
				{
					brush = new SolidBrush(Color.Red);
				}
				else if (type == CellType.eCellTypeExit)
				{
					brush = new SolidBrush(Color.Red);
				}
				else
				{
					brush = new SolidBrush(Color.Green);
				}

				if (facingEast())
				{
					gc.FillPolygon(brush, pointsEast);
				}
				else if (facingNorth())
				{
					gc.FillPolygon(brush, pointsNorth);
				}
				else if (facingSouth())
				{
					gc.FillPolygon(brush, pointsSouth);
				}
				else if (facingWest())
				{
					gc.FillPolygon(brush, pointsWest);
				}
			}
			else
			{
				if (type == CellType.eCellTypeStairsDown ||
					type == CellType.eCellTypeStairsUp)
				{
					//				gc.fillRect(x, y, cellSize, cellSize);

					Pen pen = new Pen(Brushes.Black);
					int s = cellSize / 4;
					for (int i = 0; i < cellSize; i += s)
					{
						gc.DrawLine(pen, x + i, y, x + i, y + cellSize);
					}
				}
			}
		}

		private void drawDoors3D(Graphics gc, int x, float z, Maze.Cell.CellFacing facing)
		{
			float x1 = -1 + (x * 2);
			float x2 = 1 + (x * 2);
			float y1 = -1;
			float y2 = 1;
			float z1 = z;
			float z2 = z + 1;

			Maze.Math.point p000 = new Maze.Math.point(x1, y1, z1);
			Maze.Math.point p100 = new Maze.Math.point(x2, y1, z1);
			Maze.Math.point p010 = new Maze.Math.point(x1, y2, z1);
			Maze.Math.point p110 = new Maze.Math.point(x2, y2, z1);
			Maze.Math.point p001 = new Maze.Math.point(x1, y1, z2);
			Maze.Math.point p101 = new Maze.Math.point(x2, y1, z2);
			Maze.Math.point p011 = new Maze.Math.point(x1, y2, z2);
			Maze.Math.point p111 = new Maze.Math.point(x2, y2, z2);

			Maze.Math.rectangle left = new Maze.Math.rectangle(p000, p001, p011, p010);
			Maze.Math.rectangle back = new Maze.Math.rectangle(p001, p101, p111, p011);
			Maze.Math.rectangle right = new Maze.Math.rectangle(p100, p101, p111, p110);

			Maze.Math.matrix m = new Maze.Math.matrix();
			m.scale(100);

			left = m.dot(left);
			back = m.dot(back);
			right = m.dot(right);

			float doorFrameSize = 15;
			left.p[0].y += doorFrameSize;
			left.p[1].y += doorFrameSize;
			left.p[0].z += doorFrameSize;
			left.p[1].z -= doorFrameSize;
			left.p[2].z -= doorFrameSize;
			left.p[3].z += doorFrameSize;

			right.p[0].y += doorFrameSize;
			right.p[1].y += doorFrameSize;
			right.p[0].z += doorFrameSize;
			right.p[1].z -= doorFrameSize;
			right.p[2].z -= doorFrameSize;
			right.p[3].z += doorFrameSize;

			back.p[0].y += doorFrameSize;
			back.p[1].y += doorFrameSize;
			back.p[0].x += doorFrameSize;
			back.p[1].x -= doorFrameSize;
			back.p[2].x -= doorFrameSize;
			back.p[3].x += doorFrameSize;

			left.perspective(500.0f);
			back.perspective(500.0f);
			right.perspective(500.0f);

			float xOffset = 500;
			float yOffset = 250;

			left.move(xOffset, yOffset);
			back.move(xOffset, yOffset);
			right.move(xOffset, yOffset);

			//gc.setStroke(Color.BLACK);
			//gc.setFill(Color.LIGHTGRAY);

			if (facing == Maze.Cell.CellFacing.eCellFacingEast)
			{
				if (W(Maze.Cell.east).Door()) back.draw(gc);
				if (W(Maze.Cell.north).Door()) left.draw(gc);
				if (W(Maze.Cell.south).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingWest)
			{
				if (W(Maze.Cell.west).Door()) back.draw(gc);
				if (W(Maze.Cell.south).Door()) left.draw(gc);
				if (W(Maze.Cell.north).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingNorth)
			{
				if (W(Maze.Cell.north).Door()) back.draw(gc);
				if (W(Maze.Cell.west).Door()) left.draw(gc);
				if (W(Maze.Cell.east).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingSouth)
			{
				if (W(Maze.Cell.south).Door()) back.draw(gc);
				if (W(Maze.Cell.east).Door()) left.draw(gc);
				if (W(Maze.Cell.west).Door()) right.draw(gc);
			}
		}

		private void drawStairsDown3D(Graphics gc, int x, float z, Maze.Cell.CellFacing facing)
		{
			float x1 = -1 + (x * 2);
			float x2 = 1 + (x * 2);
			float y1 = -1;
			float y2 = 1;
			float z1 = z;
			float z2 = z + 1;

			Maze.Math.point p000 = new Maze.Math.point(x1, y1, z1);
			Maze.Math.point p100 = new Maze.Math.point(x2, y1, z1);
			Maze.Math.point p010 = new Maze.Math.point(x1, y2, z1);
			Maze.Math.point p110 = new Maze.Math.point(x2, y2, z1);
			Maze.Math.point p001 = new Maze.Math.point(x1, y1, z2);
			Maze.Math.point p101 = new Maze.Math.point(x2, y1, z2);
			Maze.Math.point p011 = new Maze.Math.point(x1, y2 + 1, z2);
			Maze.Math.point p111 = new Maze.Math.point(x2, y2 + 1, z2);

			Maze.Math.rectangle bottom = new Maze.Math.rectangle(p010, p011, p111, p110);

			Maze.Math.matrix m = new Maze.Math.matrix();
			m.scale(100);

			bottom = m.dot(bottom);
			bottom.perspective(500.0f);

			float xOffset = 500;
			float yOffset = 250;

			bottom.move(xOffset, yOffset);

			//gc.setStroke(Color.BLACK);
			//gc.setFill(Color.BLACK);

			bottom.draw(gc);
		}

		private void drawStairsUp3D(Graphics gc, int x, float z, Maze.Cell.CellFacing facing)
		{
			float x1 = -1 + (x * 2);
			float x2 = 1 + (x * 2);
			float y1 = -1;
			float y2 = 1;
			float z1 = z;
			float z2 = z + 1;

			Maze.Math.point p000 = new Maze.Math.point(x1, y1, z1);
			Maze.Math.point p100 = new Maze.Math.point(x2, y1, z1);
			Maze.Math.point p010 = new Maze.Math.point(x1, y2, z1);
			Maze.Math.point p110 = new Maze.Math.point(x2, y2, z1);
			Maze.Math.point p001 = new Maze.Math.point(x1, y1, z2);
			Maze.Math.point p101 = new Maze.Math.point(x2, y1, z2);
			Maze.Math.point p011 = new Maze.Math.point(x1, y2, z2);
			Maze.Math.point p111 = new Maze.Math.point(x2, y2, z2);

			Maze.Math.rectangle left = new Maze.Math.rectangle(p000, p001, p011, p010);
			Maze.Math.rectangle back = new Maze.Math.rectangle(p001, p101, p111, p011);
			Maze.Math.rectangle right = new Maze.Math.rectangle(p100, p101, p111, p110);
			Maze.Math.rectangle front = new Maze.Math.rectangle(p000, p100, p110, p010);

			Maze.Math.matrix m = new Maze.Math.matrix();
			m.scale(100);

			Maze.Math.rectangle stairs = new Maze.Math.rectangle(p000, p000, p000, p000);

			for (int i = 0; i < 11; i++)
			{
				if (facing == Maze.Cell.CellFacing.eCellFacingEast)
				{
					stairs = back;
				}
				else if (facing == Maze.Cell.CellFacing.eCellFacingWest)
				{
					//				System.out.println("stairs: before");
					//				System.out.println("  p[0]: " + front.p[0].x + ", " + front.p[0].y + ", " + front.p[0].z);
					//				System.out.println("  p[1]: " + front.p[1].x + ", " + front.p[1].y + ", " + front.p[1].z);
					//				System.out.println("  p[2]: " + front.p[2].x + ", " + front.p[2].y + ", " + front.p[2].z);
					//				System.out.println("  p[3]: " + front.p[3].x + ", " + front.p[3].y + ", " + front.p[3].z);

					if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8 || i == 10)
					{
						front.p[2].z = front.p[0].z;
						front.p[3].z = front.p[1].z;
						front.p[0].y = front.p[2].y - .2f;
						front.p[1].y = front.p[3].y - .2f;
					}
					else
					{
						front.p[2].y = front.p[0].y;
						front.p[3].y = front.p[1].y;
						front.p[0].z = front.p[2].z + .2f;
						front.p[1].z = front.p[3].z + .2f;
					}
					//				System.out.println("stairs: after");
					//				System.out.println("  p[0]: " + front.p[0].x + ", " + front.p[0].y + ", " + front.p[0].z);
					//				System.out.println("  p[1]: " + front.p[1].x + ", " + front.p[1].y + ", " + front.p[1].z);
					//				System.out.println("  p[2]: " + front.p[2].x + ", " + front.p[2].y + ", " + front.p[2].z);
					//				System.out.println("  p[3]: " + front.p[3].x + ", " + front.p[3].y + ", " + front.p[3].z);

					stairs.copy(front);
				}
				else if (facing == Maze.Cell.CellFacing.eCellFacingNorth)
				{
					stairs = right;
				}
				else if (facing == Maze.Cell.CellFacing.eCellFacingSouth)
				{
					stairs = left;
				}

				stairs = m.dot(stairs);
				stairs.perspective(500.0f);

				float xOffset = 500;
				float yOffset = 250;

				stairs.move(xOffset, yOffset);

				//gc.setStroke(Color.BLACK);
				//gc.setFill(Color.LIGHTGRAY);

				stairs.draw(gc);
			}
		}

		public void draw3D(Graphics gc, int x, float z, Maze.Cell.CellFacing facing)
		{
			float x1 = -1 + (x * 2);
			float x2 = 1 + (x * 2);
			float y1 = -1;
			float y2 = 1;
			float z1 = z;
			float z2 = z + 1;

			Maze.Math.point p000 = new Maze.Math.point(x1, y1, z1);
			Maze.Math.point p100 = new Maze.Math.point(x2, y1, z1);
			Maze.Math.point p010 = new Maze.Math.point(x1, y2, z1);
			Maze.Math.point p110 = new Maze.Math.point(x2, y2, z1);
			Maze.Math.point p001 = new Maze.Math.point(x1, y1, z2);
			Maze.Math.point p101 = new Maze.Math.point(x2, y1, z2);
			Maze.Math.point p011 = new Maze.Math.point(x1, y2, z2);
			Maze.Math.point p111 = new Maze.Math.point(x2, y2, z2);

			Maze.Math.rectangle left = new Maze.Math.rectangle(p000, p001, p011, p010);
			Maze.Math.rectangle back = new Maze.Math.rectangle(p001, p101, p111, p011);
			Maze.Math.rectangle right = new Maze.Math.rectangle(p100, p101, p111, p110);

			Maze.Math.matrix m = new Maze.Math.matrix();
			m.scale(100);

			left = m.dot(left);
			back = m.dot(back);
			right = m.dot(right);

			left.perspective(500.0f);
			back.perspective(500.0f);
			right.perspective(500.0f);

			float xOffset = 500;
			float yOffset = 250;

			left.move(xOffset, yOffset);
			back.move(xOffset, yOffset);
			right.move(xOffset, yOffset);

			//gc.setStroke(Color.BLACK);
			//gc.setFill(Color.WHITE);

			if (facing == Maze.Cell.CellFacing.eCellFacingEast)
			{
				if (!W(Maze.Cell.east).Open() || W(Maze.Cell.east).Door()) back.draw(gc);
				if (!W(Maze.Cell.north).Open() || W(Maze.Cell.north).Door()) left.draw(gc);
				if (!W(Maze.Cell.south).Open() || W(Maze.Cell.south).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingWest)
			{
				if (!W(Maze.Cell.west).Open() || W(Maze.Cell.west).Door()) back.draw(gc);
				if (!W(Maze.Cell.south).Open() || W(Maze.Cell.south).Door()) left.draw(gc);
				if (!W(Maze.Cell.north).Open() || W(Maze.Cell.north).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingNorth)
			{
				if (!W(Maze.Cell.north).Open() || W(Maze.Cell.north).Door()) back.draw(gc);
				if (!W(Maze.Cell.west).Open() || W(Maze.Cell.west).Door()) left.draw(gc);
				if (!W(Maze.Cell.east).Open() || W(Maze.Cell.east).Door()) right.draw(gc);
			}
			else if (facing == Maze.Cell.CellFacing.eCellFacingSouth)
			{
				if (!W(Maze.Cell.south).Open() || W(Maze.Cell.south).Door()) back.draw(gc);
				if (!W(Maze.Cell.east).Open() || W(Maze.Cell.east).Door()) left.draw(gc);
				if (!W(Maze.Cell.west).Open() || W(Maze.Cell.west).Door()) right.draw(gc);
			}

			drawDoors3D(gc, x, z, facing);

			if (stairsUp()) drawStairsUp3D(gc, x, z, facing);
			if (stairsDown()) drawStairsDown3D(gc, x, z, facing);
		}
	}
}
