// DataElement.cs
// 
using System;
namespace DCSharp.Core
{
    /// <summary>
    /// Data element.
    /// </summary>
    public struct DataElement
    {
        decimal Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DCSharp.Core.DataElement"/> struct.
        /// </summary>
        /// <param name="value">Value.</param>
        public DataElement (decimal value)
        {
            Value = value;
        }
        
        #region Operators

        /// <param name="d">D.</param>
        public static DataElement operator + (DataElement d)
        {
            return new DataElement (+d.Value);
        }

        /// <param name="d">D.</param>
        public static DataElement operator - (DataElement d)
        {
            return new DataElement (-d.Value);
        }

        /// <param name="d">D.</param>
        public static DataElement operator ++ (DataElement d)
        {
            return new DataElement (d.Value + 1);
        }

        /// <param name="d">D.</param>
        public static DataElement operator -- (DataElement d)
        {
            return new DataElement (d.Value - 1);
        }

        /// <summary>
        /// Adds a <see cref="DCSharp.Core.DataElement"/> to a <see cref="DCSharp.Core.DataElement"/>, yielding a new <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to add.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to add.</param>
        /// <returns>The <see cref="T:DCSharp.Core.DataElement"/> that is the sum of the values of <c>d1</c> and <c>d2</c>.</returns>
        public static DataElement operator + (DataElement d1, DataElement d2)
        {
            return new DataElement (d1.Value + d2.Value);
        }

        /// <summary>
        /// Subtracts a <see cref="DCSharp.Core.DataElement"/> from a <see cref="DCSharp.Core.DataElement"/>, yielding a
        /// new <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The <see cref="DCSharp.Core.DataElement"/> to subtract from (the minuend).</param>
        /// <param name="d2">The <see cref="DCSharp.Core.DataElement"/> to subtract (the subtrahend).</param>
        /// <returns>The <see cref="T:DCSharp.Core.DataElement"/> that is the <c>d1</c> minus <c>d2</c>.</returns>
        public static DataElement operator - (DataElement d1, DataElement d2)
        {
            return d1 + (-d2);
        }

        /// <summary>
        /// Computes the product of <c>d1</c> and <c>d2</c>, yielding a new <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The <see cref="DCSharp.Core.DataElement"/> to multiply.</param>
        /// <param name="d2">The <see cref="DCSharp.Core.DataElement"/> to multiply.</param>
        /// <returns>The <see cref="T:DCSharp.Core.DataElement"/> that is the <c>d1</c> * <c>d2</c>.</returns>
        public static DataElement operator * (DataElement d1, DataElement d2)
        {
            return new DataElement (d1.Value * d2.Value);
        }

        /// <summary>
        /// Computes the division of <c>d1</c> and <c>d2</c>, yielding a new <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The <see cref="DCSharp.Core.DataElement"/> to divide (the divident).</param>
        /// <param name="d2">The <see cref="DCSharp.Core.DataElement"/> to divide (the divisor).</param>
        /// <returns>The <see cref="T:DCSharp.Core.DataElement"/> that is the <c>d1</c> / <c>d2</c>.</returns>
        public static DataElement operator / (DataElement d1, DataElement d2)
        {
            return new DataElement (d1.Value / d2.Value);
        }

        /// <param name="d1">D1.</param>
        /// <param name="d2">D2.</param>
        public static DataElement operator % (DataElement d1, DataElement d2)
        {
            return new DataElement (d1.Value % d2.Value);
        }

        /// <summary>
        /// Determines whether a specified instance of <see cref="DCSharp.Core.DataElement"/> is equal to another
        /// specified <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> and <c>d2</c> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator == (DataElement d1, DataElement d2)
        {
            return d1.Value == d2.Value;
        }

        /// <summary>
        /// Determines whether a specified instance of <see cref="DCSharp.Core.DataElement"/> is not equal to another
        /// specified <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> and <c>d2</c> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator != (DataElement d1, DataElement d2)
        {
            return !(d1 == d2);
        }

        /// <summary>
        /// Determines whether one specified <see cref="DCSharp.Core.DataElement"/> is lower than another specfied <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> is lower than <c>d2</c>; otherwise, <c>false</c>.</returns>
        public static bool operator < (DataElement d1, DataElement d2)
        {
            return d1.Value < d2.Value;
        }

        /// <summary>
        /// Determines whether one specified <see cref="DCSharp.Core.DataElement"/> is greater than another specfied <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> is greater than <c>d2</c>; otherwise, <c>false</c>.</returns>
        public static bool operator > (DataElement d1, DataElement d2)
        {
            return d1.Value > d2.Value;
        }

        /// <summary>
        /// Determines whether one specified <see cref="DCSharp.Core.DataElement"/> is lower than or equal to another
        /// specfied <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> is lower than or equal to <c>d2</c>; otherwise, <c>false</c>.</returns>
        public static bool operator <= (DataElement d1, DataElement d2)
        {
            return d1.Value <= d2.Value;
        }

        /// <summary>
        /// Determines whether one specified <see cref="DCSharp.Core.DataElement"/> is greater than or equal to another
        /// specfied <see cref="DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d1">The first <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <param name="d2">The second <see cref="DCSharp.Core.DataElement"/> to compare.</param>
        /// <returns><c>true</c> if <c>d1</c> is greater than or equal to <c>d2</c>; otherwise, <c>false</c>.</returns>
        public static bool operator >= (DataElement d1, DataElement d2)
        {
            return d1.Value >= d2.Value;
        }

        /// <summary>
        /// Implicit conversion to decimal.
        /// </summary>
        /// <returns>The decimal.</returns>
        /// <param name="d">D.</param>
        public static implicit operator decimal (DataElement d)
        {
            return d.Value;
        }

        /// <summary>
        /// Explicit conversion to <see cref="DCSharp.Core.DataElement"/> from decimal.
        /// </summary>
        /// <returns>The <see cref="DCSharp.Core.DataElement"/>.</returns>
        /// <param name="d">D.</param>
        public static explicit operator DataElement (decimal d)
        {
            return new DataElement (d);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:DCSharp.Core.DataElement"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current
        /// <see cref="T:DCSharp.Core.DataElement"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals (object obj)
        {
            switch (obj)
            {
                case DataElement d:
                    return Equals (d);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="DCSharp.Core.DataElement"/> is equal to the current <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <param name="d">The <see cref="DCSharp.Core.DataElement"/> to compare with the current <see cref="T:DCSharp.Core.DataElement"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="DCSharp.Core.DataElement"/> is equal to the current
        /// <see cref="T:DCSharp.Core.DataElement"/>; otherwise, <c>false</c>.</returns>
        public bool Equals (DataElement d)
        {
            return this == d;
        }

        /// <summary>
        /// Serves as a hash function for a <see cref="T:DCSharp.Core.DataElement"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode ()
        {
            return Value.GetHashCode ();
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:DCSharp.Core.DataElement"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:DCSharp.Core.DataElement"/>.</returns>
        public override string ToString ()
        {
            return string.Format ($"[DataElement: {Value}]");
        }

        #endregion
    }
}
