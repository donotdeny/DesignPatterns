using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Shape
    {
        public string Name { get; set; } = string.Empty;
    }

    public class Triangle : Shape
    {
        protected IRenderer _iRenderer;
        public Triangle(IRenderer iRenderer)
        {
            Name = "Triangle";
            _iRenderer = iRenderer;
        }
        public override string ToString()
        {
            return _iRenderer.WhatToRenderAs(Name);
        }
    }

    public class Square : Shape
    {
        protected IRenderer _iRenderer;
        public Square(IRenderer iRenderer)
        {
            Name = "Square";
            _iRenderer = iRenderer;
        }
        public override string ToString()
        {
            return _iRenderer.WhatToRenderAs(Name);
        }
    }

    public class VectorSquare : Square
    {
        public VectorSquare(IRenderer iRenderer) : base(iRenderer)
        {
        }
    }

    public class RasterSquare : Square
    {
        public RasterSquare(IRenderer iRenderer) : base(iRenderer)
        {
        }
    }

    // imagine VectorTriangle and RasterTriangle are here too
    public interface IRenderer
    {
        string WhatToRenderAs(string name);
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs(string name)
        {
            return $"Drawing {name} as lines";
        }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs(string name)
        {
            return $"Drawing {name} as pixels";
        }
    }
}
