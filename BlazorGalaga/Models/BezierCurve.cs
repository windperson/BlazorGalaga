﻿using System;
using System.Drawing;

namespace BlazorGalaga.Models
{
    public class BezierCurve
    {
        public PointF StartPoint { get; set; }
        public PointF ControlPoint1 { get; set; }
        public PointF ControlPoint2 { get; set; }
        public PointF EndPoint { get; set; }
        public bool StartPointDragged { get; set; }
        public bool ControlPoint1Dragged { get; set; }
        public bool ControlPoint2Dragged { get; set; }
        public bool EndPointDragged { get; set; }
        public bool DrawPath { get; set; }
        public string Name { get; set; }
        public bool OutPutDebug { get; set; }
        public bool BreakPath { get; set; }
        public bool IsIntroPath { get; set; }
    }

}
