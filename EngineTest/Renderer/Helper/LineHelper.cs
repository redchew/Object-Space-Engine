﻿using EngineTest.Recources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EngineTest.Renderer.Helper
{
    public class LineHelper
    {
        public readonly VertexPositionColor[] Verts;
        public readonly short[] Indices = {0, 1};

        private Vector3 _start;
        private Vector3 _end;

        public short Timer;

        public LineHelper(Vector3 start, Vector3 end, short time, Color starColor, Color endColor)
        {
            if (!GameSettings.h_DrawLines) return;

            _start = start;
            _end = end;

            Verts = new VertexPositionColor[2];
            //Verts[0].Position = _start;
            //Verts[1].Position = _end;

            //Verts[0].Color = starColor;
            //Verts[1].Color = endColor;
            Verts[0] = LineHelperManager.GetVertexPositionColor(_start, starColor);
            Verts[1] = LineHelperManager.GetVertexPositionColor(_end, endColor);

            Timer = time;
        }

        public LineHelper(Vector3 start, Vector3 end, short time)
        {
            if (!GameSettings.h_DrawLines) return;

            _start = start;
            _end = end;

            Verts = new VertexPositionColor[2];
            //Verts[0].Position = _start;
            //Verts[1].Position = _end;

            //Verts[0].Color = new Color(Color.Red, 0.5f);
            //Verts[1].Color = new Color(Color.Green, 0.5f);
            Verts[0] = LineHelperManager.GetVertexPositionColor(_start, new Color(Color.Red, 0.5f));
            Verts[1] = LineHelperManager.GetVertexPositionColor(_end, new Color(Color.Green, 0.5f));
            Timer = time;
        }

        public void Translate(Vector3 start, Vector3 end, short time)
        {
            _start = start;
            _end = end;

            Verts[0].Position = _start;
            Verts[1].Position = _end;
            Timer = time;
        }

        public void SetDir(Vector3 direction)
        {
            _end = _start + direction;

            Verts[0].Position = _start;
            Verts[1].Position = _end;
        }
        
    }
}
