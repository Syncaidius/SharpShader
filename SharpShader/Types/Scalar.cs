using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    public class Scalar<T> where T : struct
    {
        /// <summary>
        /// The X componenet. This is the same as <see cref="R"/>.
        /// </summary>
        public T X;

        /// <summary>
        /// The red channel. This is the same value as <see cref="X"/>.
        /// </summary>
        public T R => X;

        public Vector2<T> XX => new Vector2<T>(X, X);

        public static Scalar<T> operator *(Scalar<T> a, Scalar<T> b)
        {
            return new Scalar<T>();

            // TODO do we actually implement this? Is there any point?
            // Do we ever want to run what is essentially dummy code for translation to a shader language?
            //dynamic ax = a.X;
            //return new Scalar<T>() { X = ax * b.X };
        }

        public static Scalar<T> operator /(Scalar<T> a, Scalar<T> b)
        {
            return new Scalar<T>();
        }

        public static Scalar<T> operator +(Scalar<T> a, Scalar<T> b)
        {
            return new Scalar<T>();
        }

        public static Scalar<T> operator -(Scalar<T> a, Scalar<T> b)
        {
            return new Scalar<T>();
        }
    }
}
