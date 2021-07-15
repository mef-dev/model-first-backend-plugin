using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class ErrorDataJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        /*
        public override bool CanRead
        {
            get
            {
                return true;
            }
        }
        */

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JsonTextReader txtReader = reader as JsonTextReader;
            object obj = null;

            if (txtReader != null)
            {
                if (txtReader.TokenType == JsonToken.StartArray)
                {
                    obj = ReadArray(txtReader);
                }
                else
                if (txtReader.TokenType == JsonToken.StartObject)
                {
                    obj = ReadObject(txtReader);
                }
                else
                {
                    obj = txtReader.Value;
                    string data = (string)txtReader.Value;

                    try
                    {
                        BaseSqlExceptionModel[] ar = JsonConvert.DeserializeObject<BaseSqlExceptionModel[]>(data);
                        return ar;
                    }
                    catch (Exception e)
                    {

                    }

                }
            }


            return obj;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(JsonConvert.SerializeObject(value));
            //base.WriteJson(writer, value, serializer);
            /*
            if (value is string)
            {
                writer.WriteValue(value);
            }
            else
            {
                writer.WriteValue(JsonConvert.SerializeObject(value));
            }
            */
        }

        private BaseSqlExceptionModel[] ReadArray(JsonTextReader reader)
        {
            List<BaseSqlExceptionModel> resList = new List<BaseSqlExceptionModel>();
            do
            {
                reader.Read();
                if (reader.TokenType == JsonToken.StartArray)
                {
                    var arr = ReadArray(reader);
                }
                if (reader.TokenType == JsonToken.StartObject)
                {
                    var obj = ReadObject(reader);
                    if (obj != null)
                        resList.Add(obj);
                }
            }
            while (reader.TokenType != JsonToken.EndArray);

            return resList.ToArray();
        }

        private BaseSqlExceptionModel ReadObject(JsonTextReader reader)
        {
            BaseSqlExceptionModel res = new BaseSqlExceptionModel();
            do
            {
                reader.Read();

                if (reader.TokenType == JsonToken.PropertyName)
                {
                    string propertyName = (string)reader.Value;
                    reader.Read();

                    switch (propertyName.ToUpper())
                    {
                        case "DATA":
                            if (reader.TokenType == JsonToken.StartArray)
                                res.Data = null;//ReadArray(reader);
                            else
                            if (reader.TokenType == JsonToken.Null)
                                res.Data = null;
                            else
                            if (reader.TokenType != JsonToken.StartObject)
                                res.Data = null;// reader.Value;
                            break;
                        case "LEVELMESSAGE":
                            res.LevelMessage = Convert.ToInt32(reader.Value); break;
                        case "ERRNUMBER":
                            res.ErrNumber = Convert.ToInt32(reader.Value); break;
                        case "MESSAGE":
                            res.Message = (string)reader.Value; break;
                            /*
                        case "STATUS":
                            res.Status = Convert.ToInt32(reader.Value); break;
                            */
                        case "STATE":
                            res.State = Convert.ToInt64(reader.Value); break;
                        case "XML":
                            //res.Xml = (string)reader.Value; break;
                            res.ErrNumberReason = (int)reader.Value; break;
                        case "HELPLINK":
                            res.HelpLink = (string)reader.Value; break;
                    }

                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return res;
        }
    }
}