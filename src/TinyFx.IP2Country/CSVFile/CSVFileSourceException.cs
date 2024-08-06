﻿using System;

namespace TinyFx.IP2Country.DataSources.CSVFile
{
    internal abstract class CSVFileSourceException : Exception
    {
        public CSVFileSourceException()
            : base() { }

        public CSVFileSourceException(string message)
            : base(message) { }

        public CSVFileSourceException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    internal class UnexpectedNumberOfFieldsException : CSVFileSourceException
    {
        public UnexpectedNumberOfFieldsException()
            : base() { }

        public UnexpectedNumberOfFieldsException(int actualFieldCount, int expectedFieldCount)
            : this($"Unexpected number of fields: {actualFieldCount}, expected: {expectedFieldCount}") { }

        public UnexpectedNumberOfFieldsException(int actualFieldCount, int[] expectedFieldCounts)
            : this($"Unexpected number of fields: {actualFieldCount}, expected on of: {string.Join(",", expectedFieldCounts)}") { }

        public UnexpectedNumberOfFieldsException(string message)
            : this(message, null) { }

        public UnexpectedNumberOfFieldsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}