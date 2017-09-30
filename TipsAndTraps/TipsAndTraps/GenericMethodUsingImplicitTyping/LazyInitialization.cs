using System;
using System.Diagnostics;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class LazyInitialization
    {
        [Fact]
        public void IniitializeReport()
        {
            var normalReportObj = new Report();

            //Lazy Call

            var lazyReport = new Lazy<Report>();
            lazyReport.Value.DoSomething();
        }

        [Fact]
        public void Init()
        {
            var defaultLazy = new Lazy<Report>();
            defaultLazy.Value.DoSomething();

            //Paramterized Lazy

            var parametrizedLazy = new Lazy<Report>(() => new Report("Parameterized Lazy"));
            parametrizedLazy.Value.DoSomething();
        }

        [Fact]
        public void ReadOnlyValue()
        {
            var readOnlyLazy = new Lazy<Report>();
           // readOnlyLazy.Value = new Report(); // can not set the value and give compile time error
            readOnlyLazy.Value.ReportName = "Set the reportname prop";

        }

        [Fact]
        public void PerformanceLazyVsNonLazy()
        {
            var reportArray = new Report[10];
            var watch = Stopwatch.StartNew();

            for (var i = 0; i < 10; i++)
            {
                reportArray[i] = new Report();
                if (i % 2 == 0)
                {
                    reportArray[i].DoSomething();
                }
            }

            watch.Stop();

            Debug.WriteLine($"Normal Object Creation time {watch.ElapsedMilliseconds}");

            //Lazy Performace

            var reportArrayWithLazy = new Lazy<Report>[10];
            watch =  Stopwatch.StartNew();

            for (var i = 0; i < 10; i++)
            {
                reportArrayWithLazy[i] = new Lazy<Report>();
                if (i % 2 == 0)
                {
                    reportArrayWithLazy[i].Value.DoSomething();
                }
            }

            watch.Stop();

            Debug.WriteLine($"Time elapsed with the Lazy spec is {watch.ElapsedMilliseconds}");
        }

        /// <summary>
        /// Exception caching is a technique which will not call the constrcutor
        /// again and again if the exception occurs one time .
        /// Then if there is exception at the second time then it will pick the exception from the cache
        /// </summary>
        [Fact]
        public void EnableExceptionCaching()
        {
            //Enable exception caching

            var exceptionCaching = new Lazy<ExceptionReport>(() => new ExceptionReport());

            try
            {
                exceptionCaching.Value.DoSomething();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            //again throw the exception
            try
            {
                exceptionCaching.Value.DoSomething();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

        }

        /// <summary>
        ///  Exception caching is not enabled and the constrcutor is initialized n time 
        /// if the method is called n times
        /// </summary>
        [Fact]
        public void NoExceptionCaching()
        {
            //Enable exception caching

            var exceptionCaching = new Lazy<ExceptionReport>();

            try
            {
                exceptionCaching.Value.DoSomething();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            //again throw the exception
            try
            {
                exceptionCaching.Value.DoSomething();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

        }
    }
}
