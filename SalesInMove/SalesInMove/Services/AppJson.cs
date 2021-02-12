using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SalesInMove.Services
{
    public static class AppJson
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions 
            { Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.All) };

        public static string CreateJson(Object objectToSerialize)
        {
            return System.Text.Json.JsonSerializer.Serialize(objectToSerialize, _jsonOptions);
        }
    }
}