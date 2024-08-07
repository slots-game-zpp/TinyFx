﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TinyFx.Core;

public class JsonDateTimeConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var fromString = reader.GetString();
        if (string.IsNullOrWhiteSpace(fromString))
            return DateTime.MinValue;
        return DateTime.Parse(fromString);
    }
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
}
