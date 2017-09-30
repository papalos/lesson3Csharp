using System;


namespace Geometric
{
    /// <summary>
    /// Описание точки ее координатами
    /// </summary>
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Расстояние от начала координат до точки
        /// </summary>
        /// <returns>длина вектора</returns>
        public double distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

    }

    /// <summary>
    /// Линия задаваемая двумя точками
    /// </summary>
    struct Line
    {
        private Point pointStart;
        private Point pointEnd;

        public Line(Point st, Point end)
        {
            pointStart = st;
            pointEnd = end;
        }

        /// <summary>
        /// Длина линии
        /// </summary>
        public double lenght()
        {
            return Math.Sqrt(Math.Pow((pointEnd.x - pointStart.x),2) + Math.Pow((pointEnd.y - pointStart.y),2));
        }

        /// <summary>
        /// проверяет лежит ли заданная точка на данном отрезке
        /// </summary>
        /// <param name="exam">проверяемая точка</param>
        /// <returns>true-если принадлежит, false-если не принадлежит</returns>
        public bool isPointOnLine(Point exam)
        {
            if (((exam.x - pointStart.x) / (pointEnd.x - pointStart.x)) == ((exam.y - pointStart.y) / (pointEnd.y - pointStart.y)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Квадрат задаваемый верхним левым углом и длиной сторон
        /// </summary>
        struct Square
        {
            Point startSquarePoint;
            int lenghtSide;

            public Square(Point leftTopAngle, int side)
            {
                startSquarePoint = leftTopAngle;
                lenghtSide = side;
            }

            public double square()
            {
                return lenghtSide * lenghtSide;
            }

            public double perimeter()
            {
                return 4 * lenghtSide;
            }

            /// <summary>
            /// Проверяет принадлежность точки к квадрату
            /// </summary>
            /// <param name="point">исследуемая точка</param>
            /// <returns>true-если принадлежит, false-если не принадлежит</returns>
            public bool isPointInSquare(Point point)
            {
                if ((point.x>=startSquarePoint.x & point.x <= (startSquarePoint.x + lenghtSide)) & (point.y<=startSquarePoint.y&point.y>=(startSquarePoint.y-lenghtSide)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}