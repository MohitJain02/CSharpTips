using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
   public  class WorkingWithHiddenFiles
    {
        [Fact]
        public void OverWriteHiddenFiles()
        {
            try
            {
                var hiddenFilePath = @"C:\HIddenFiles.txt";


                File.Delete(hiddenFilePath); // by deleting this file we will overwrite the hidden file prop of the file
                File.Create(hiddenFilePath);

                //var fileStream = new FileStream(hiddenFilePath, FileMode.Create);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("HIdden File Can not be overwriiten with the File.Create and FileStream Method with the " +
                                "FileMode.Create" + ex.Message);
                throw;
            }

        }
    }
}
