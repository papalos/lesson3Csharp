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
            return Math.Sqrt(Math.Pow((pointEnd.x - pointStart.x), 2) + Math.Pow((pointEnd.y - pointStart.y), 2));
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
    }

    /// <summary>
    /// Квадрат задаваемый верхним левым углом и длиной сторон
    /// </summary>
    struct Square
    {
        Point startSquarePoint;
        Line lenghtSide;

        public Square(Point leftTopAngle, int side)
        {
            startSquarePoint = leftTopAngle;
            lenghtSide = new Line(leftTopAngle, new Point(leftTopAngle.x + side, leftTopAngle.y));
        }

        public double square()
        {
            return lenghtSide.lenght() * lenghtSide.lenght();
        }

        public double perimeter()
        {
            return 4 * lenghtSide.lenght();
        }
        
        /// <summary>
        /// Проверяет принадлежность точки к квадрату
        /// </summary>
        /// <param name="point">исследуемая точка</param>
        /// <returns>true-если принадлежит, false-если не принадлежит</returns>
        public bool isPointInSquare(Point point)
        {
            if ((point.x>=startSquarePoint.x & point.x <= (startSquarePoint.x + lenghtSide.lenght())) 
                & (point.y<=startSquarePoint.y&point.y>=(startSquarePoint.y-lenghtSide.lenght())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Круг задаваемый начальной точкой и длиной радиуса
    /// </summary>
    struct Circle
    {
        public Point center;
        public Line radius;

        public Circle(Point center, int lenghtRadius)
        {
            this.center = center;
            this.radius = new Line(center, new Point (center.x+lenghtRadius, center.y));
        }

        /// <summary>
        /// Проверяет вхождение точки в круг
        /// </summary>
        /// <param name="point">проверяемая точка</param>
        /// <returns>возвращает истину или ложь</returns>
        public bool isPointInCircle(Point point)
        {
            if (Math.Sqrt(Math.Pow(center.x-point.x,2)+Math.Pow(center.y-point.y,2))<=radius.lenght())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double circumference()
        {
            return 2 * Math.PI * radius.lenght();
        }

        public double square()
        {
            return (radius.lenght() * circumference()) / 2;
        }
    }

    /// <summary>
    /// Прямоугольник задаваемый верхним левым углом и длиной сторон
    /// </summary>
    struct Rectangle
    {
        Point leftTopAngle;
        Line width;
        Line lenght;

        public Rectangle(Point leftTopAngle, int width, int lenght)
        {
            this.leftTopAngle = leftTopAngle;
            this.width = new Line(leftTopAngle, new Point(leftTopAngle.x, leftTopAngle.y+ width));
            this.lenght = new Line(leftTopAngle, new Point(leftTopAngle.x+ width, leftTopAngle.y));
        }

        public double square()
        {
            return width.lenght() * lenght.lenght();
        }

        public double perimeter()
        {
            return 2 * width.lenght() + 2 * lenght.lenght();
        }

        /// <summary>
        /// Проверяет принадлежность точки к прямоугольнику
        /// </summary>
        /// <param name="point">исследуемая точка</param>
        /// <returns>true-если принадлежит, false-если не принадлежит</returns>
        public bool isPointInSquare(Point point)
        {
            if ((point.x >= leftTopAngle.x & point.x <= (leftTopAngle.x + lenght.lenght()))
                & (point.y <= leftTopAngle.y & point.y >= (leftTopAngle.y - lenght.lenght())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Ромб задаваемый центром и длинами вертикальной и горизонтальной диагоналями
    /// </summary>
    struct Rhomb
    {
        public Point centralPoint;
        public Line verticalHalfDiagonal;
        public Line horizontalHalfDiagonal;
        
        public Rhomb(Point centralPoint, int verticalDiagonal, int horizontalDiagonal)
        {
            this.centralPoint = centralPoint;
            this.verticalHalfDiagonal = new Line(centralPoint, new Point(centralPoint.x, centralPoint.y + (verticalDiagonal/2)));
            this.horizontalHalfDiagonal = new Line(centralPoint, new Point(centralPoint.x + (horizontalDiagonal/2), centralPoint.y));
        }

        public double square()
        {
            return 2 * verticalHalfDiagonal.lenght() * horizontalHalfDiagonal.lenght();
        }

        public double perimeter()
        {
            return 4*Math.Sqrt(Math.Pow(verticalHalfDiagonal.lenght(), 2) + Math.Pow(horizontalHalfDiagonal.lenght(), 2));
        }

        /// <summary>
        /// Принадлежит ли точка Ромбу
        /// </summary>
        /// <param name="point">Исследуемая точка</param>
        /// <returns>true-если принадлежит, false-если не принадлежит</returns>
        public bool isPointInRhomb(Point point)
        {
             if((Math.Abs(point.x - centralPoint.x)/horizontalHalfDiagonal.lenght())
                + (Math.Abs(point.y - centralPoint.y) / verticalHalfDiagonal.lenght()) <= 2)
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