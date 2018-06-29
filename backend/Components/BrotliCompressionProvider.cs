using System.IO;
using System.IO.Compression;
using Microsoft.AspNetCore.ResponseCompression;

namespace CodeForGood.Components
{
	public class BrotliCompressionProvider : ICompressionProvider
	{
		public string EncodingName => "br";

		public bool SupportsFlush => true;

		public Stream CreateStream(Stream outputStream) => new BrotliStream(outputStream, CompressionMode.Compress);

	}
}