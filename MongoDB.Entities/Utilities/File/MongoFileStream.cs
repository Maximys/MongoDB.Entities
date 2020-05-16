using System;
using System.IO;

namespace MongoDB.Entities
{
    /// <summary>
    /// Provides a <see cref="Stream"/> for a file inside MongoDb.
    /// </summary>
    public class MongoFileStream : Stream
    {
        /// <inheritdoc/>
        public override bool CanRead => throw new NotImplementedException();
        /// <inheritdoc/>
        public override bool CanSeek => throw new NotImplementedException();
        /// <inheritdoc/>
        public override bool CanWrite => throw new NotImplementedException();
        /// <inheritdoc/>
        public override long Length => throw new NotImplementedException();
        /// <inheritdoc/>
        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoFileStream"/> class.
        /// </summary>
        public MongoFileStream()
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override void Flush()
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc/>
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }
    }
}