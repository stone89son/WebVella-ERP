﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using WebVella.ERP.Storage;

namespace WebVella.ERP.Storage.Mongo
{
    public class MongoDateField : MongoBaseField, IStorageDateField
    {
		[BsonElement("defaultValue")]
		public DateTime? DefaultValue { get; set; }

		[BsonElement("format")]
		public string Format { get; set; }

		[BsonElement("useCurrentTimeAsDefaultValue")]
		public bool UseCurrentTimeAsDefaultValue { get; set; }
    }
}