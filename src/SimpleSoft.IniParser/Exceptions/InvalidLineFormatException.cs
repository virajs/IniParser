﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2017 João Simões
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace SimpleSoft.IniParser.Exceptions
{
    /// <summary>
    /// Exception thrown when a line can not be parsed into a comment, section or property.
    /// </summary>
    public class InvalidLineFormatException : IniParserException
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="line">The line position were parse failed</param>
        /// <param name="value">The line value</param>
        public InvalidLineFormatException(int line, string value) 
            : base($"The line at position '{line}' could not be parsed into a comment, section or property")
        {
            Line = line;
            Value = value;
        }

        /// <summary>
        /// The line position were parse failed.
        /// </summary>
        public int Line { get; }

        /// <summary>
        /// The line value.
        /// </summary>
        public string Value { get; }
    }
}
