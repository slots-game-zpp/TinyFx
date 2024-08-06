﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TinyFx.Text;

namespace TinyFx.Serialization
{
    public class TinyJsonSerializer : ISerializer
    {
        public JsonSerializerOptions JsonOptions;
        public TinyJsonSerializer()
        {
            JsonOptions = SerializerUtil.GetJsonOptions();
        }

        public byte[] Serialize(object value)
        {
            var json = SerializerUtil.SerializeJson(value, JsonOptions);
            return Encoding.UTF8.GetBytes(json);
        }

        public object Deserialize(byte[] utf8Bytes, Type returnType)
        {
            var json = Encoding.UTF8.GetString(utf8Bytes);
            return SerializerUtil.DeserializeJson(json, returnType, JsonOptions);
        }

        public T Deserialize<T>(byte[] utf8Bytes)
        {
            return (T)Deserialize(utf8Bytes, typeof(T));
        }
    }
}
