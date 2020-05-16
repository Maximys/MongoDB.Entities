using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Entities.Core;

namespace MongoDB.Entities
{
    /// <summary>
    /// Chunk of binary file.
    /// </summary>
    [Name("[BINARY_CHUNKS]")]
    internal class FileChunk : IEntity
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        /// <summary>
        /// Modification date.
        /// </summary>
        [Ignore]
        public DateTime ModifiedOn { get; set; }
        /// <summary>
        /// Identifier of file.
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string FileID { get; set; }
        /// <summary>
        /// Binary data.
        /// </summary>
        public byte[] Data { get; set; }
    }
}
