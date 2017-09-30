using System.IO.Compression;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
   public  class WorkingWithZipFiles
    {
        [Fact]
        public void CreateZipDirectoryFromGivenDirectory()
        {
            ZipFile.CreateFromDirectory(@"C:\TipsandTraps\OriginalSource", @"C:\TipsandTraps\ZipFolder");
        }

        /// <summary>
        /// Create the Directory inside the zip directory with the same name as that of the original folder
        /// </summary>
        [Fact]
        public void CreateASubDirectoryFromGivenDirectory()
        {
            ZipFile.CreateFromDirectory(@"C:\TipsandTraps\OriginalSource", @"C:\TipsandTraps\SubDirectory",
                CompressionLevel.Fastest, true);

        }

        /// <summary>
        /// Extract the files/folder from the zip folder to the normal folder
        /// </summary>
        [Fact]
        public void ExtractFilesFromZipFolder()
        {
            ZipFile.ExtractToDirectory(@"C:\TipsandTraps\tipsZipFolder.zip", @"C:\TipsandTraps\ExtractedFromZip");
        }

        /// <summary>
        /// Add the file inside the zip folder
        /// </summary>
        [Fact]
        public void AddFilesToZipFolder()
        {
            using (var archive = ZipFile.Open(@"C:\TipsandTraps\tipsZipFolder.zip", ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(@"C:\TipsandTraps\OriginalSource\File.txt", "Sample.txt");
            }
        }

        /// <summary>
        /// Remove the file from the zip folder
        /// </summary>
        [Fact]
        public void RemoveFilesFromZipFolder()
        {
            using (var archive = ZipFile.Open(@"C:\TipsandTraps\tipsZipFolder.zip", ZipArchiveMode.Update))
            {
                archive.GetEntry(@"Sample.txt").Delete();

            }
        }
    }
}
