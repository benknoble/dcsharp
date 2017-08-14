// Engine.cs
// 
using System.Collections.Generic;
namespace DCSharp.Core
{
    /// <summary>
    /// The DC Engine.
    /// </summary>
    public class Engine
    {
        Stack<DataElement> main;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DCSharp.Core.Engine"/> class.
        /// </summary>
        public Engine ()
        {
            main = new Stack<DataElement> ();
        }

        /// <summary>
        /// Push the specified data.
        /// </summary>
        /// <param name="d">D.</param>
        public void Push (DataElement d) => main.Push (d);
    }
}
