using System;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class WorkingWithUri
    {
        [Fact]
        public void CreateUri()
        {
            var uri = new Uri("http://www.google.com");
            var filePath = new Uri(@"c:\temp\Sample.txt");


            // Use the urlBuilder class to build the uri

            var builder = new UriBuilder();
            builder.Host = "google.com";
            builder.Path = "gmail.com";
            builder.Scheme = "http:";

             var finalUri = builder.Uri;
        }

        [Fact]
        public void AbsoluteOrRealtiveUri()
        {
            var defaultAsAbsoluteUri = new Uri("http://www.gmail.com");
            var absoluteUri = new Uri("http://bloggsport.com", UriKind.Absolute);

            //relative 
           // var realtiveUri = new Uri("/index.html"); //throws exception as it assumes to be absolute
            var successRelativeUri = new Uri("/index.html", UriKind.Relative);


            //absoluteorrelative

            var absoluteorRelativeUri = new Uri("/employee.html",UriKind.RelativeOrAbsolute);


            var absoluteOrRelativeCombination = new Uri(absoluteUri,successRelativeUri);


        }

        [Fact]
        public void UriParts()
        {
            var completeUri = new Uri("http://gmail.com:9090/blog/?tag=/desing#foo");

            var path = completeUri.AbsolutePath;
            var schema = completeUri.Scheme;
            var portno = completeUri.Port;
            var hostname = completeUri.Host;

            var query = completeUri.Query;

            var fragment = completeUri.Fragment;

            var pathAndQuery = completeUri.PathAndQuery;

            var authority = completeUri.Authority;

        }

        [Fact]
        public void ModifyUri()
        {
            var uri = new Uri("http://gmail.com:9090/blog/?tag=/desing#foo");

            var builder = new UriBuilder {Port = 8081};
            var newUri = builder.Uri;
        }

        [Fact]

        public void SomeOtherUsefulThings()
        {
            var uri = new Uri("http://gmail.com:9090/blog/?tag=/desing#foo");

            var isdefaultPort = uri.IsDefaultPort;
            var isFile = uri.IsFile;
            var isunc = uri.IsUnc;

            var localfile = new Uri("file:///c:/temp/Sample.txt");
            var fullPath = localfile.LocalPath;
        }
    }
}
