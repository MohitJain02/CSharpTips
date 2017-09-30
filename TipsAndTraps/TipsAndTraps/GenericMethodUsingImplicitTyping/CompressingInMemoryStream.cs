using System.IO;
using System.Text;
using System.IO.Compression;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class CompressingInMemoryStream
    {
        [Fact]
        public void CompressDecompressData()
        {
            var originalString =
                @"Lorem ipsum dolor sit amet, no amet elitr appellantur vix, mea eu dicant dolorum. Dolor assentior cum ei. Tantas melius cetero ius eu. In eos torquatos repudiandae dissentiunt. Munere indoctum urbanitas vix ei, eum id error graeci.
                                        Mel ne posse nominati, ea ornatus feugait perfecto vix. Pro epicurei appetere suavitate ne. Tale sint adipisci per id. Pri et stet aliquam.
                                        Ad quo populo audiam persius, te usu novum solet quaeque. Brute mucius ex per, ex feugait verterem disputando qui, per cu etiam tempor invidunt. Simul expetendis vituperata ea cum. No eros graeci quo. Consequat eloquentiam mea an, vero";


            var originalBytes = Encoding.ASCII.GetBytes(originalString);

            //Compressed Data
            var compressedArray = Compress(originalBytes);

            var originalSize = originalBytes.Length;
            var compressedSize = compressedArray.Length;

            var sizeDifference = originalSize - compressedSize;

            //DecompressedData

            var decompressedArray = Decompress(compressedArray);
            var decompressedString = Encoding.ASCII.GetString(decompressedArray);
            
            bool isEqual = originalString == decompressedString;

        }

        private byte[] Compress(byte[] stringToCompress)
        {
            var memoryStream = new MemoryStream();

            using (var stream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                stream.Write(stringToCompress,0,stringToCompress.Length);
            }

            //End of the gzip stream and close of memory stream

            return memoryStream.ToArray();
        }

        private byte[] Decompress(byte[] compressedString)
        {
            var compressIntoMemory = new MemoryStream(compressedString);

            using (var decompressedStream = new MemoryStream())
            using (var stream = new GZipStream(compressIntoMemory, CompressionMode.Decompress))
            {
                stream.CopyTo(decompressedStream);

                return decompressedStream.ToArray();
            }
           
        }
    }
}
