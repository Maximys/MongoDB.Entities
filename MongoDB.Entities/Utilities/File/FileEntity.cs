using System.Runtime.CompilerServices;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Entities.Core;

[assembly: InternalsVisibleTo("MongoDB.Entities.Tests")]
namespace MongoDB.Entities
{
    /// <summary>
    /// Inherit this base class in order to create your own File Entities
    /// </summary>
    public abstract class FileEntity : Entity
    {
        /// <summary>
        /// The total amount of data in bytes that has been uploaded so far
        /// </summary>
        [BsonElement]
        public double FileSize { get; internal set; }

        /// <summary>
        /// The number of chunks that have been created so far
        /// </summary>
        [BsonElement]
        public int ChunkCount { get; internal set; }

        /// <summary>
        /// Returns true only when all the chunks have been stored successfully in mongodb
        /// </summary>
        [BsonElement]
        public bool UploadSuccessful { get; internal set; }

        /// <summary>
        /// Access the DataStreamer class for uploading and downloading data
        /// </summary>
        public DataStreamer Data
        {
            get
            {
                if (streamer == null)
                {
                    streamer = new DataStreamer(this);
                }
                return streamer;
            }
        }
        /// <summary>
        /// Streamer.
        /// </summary>
        protected DataStreamer streamer { get; set; }
    }
}