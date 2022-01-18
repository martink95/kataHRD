using System;
using Xunit;
using KataHRD;

namespace KataHRDTests
{
    public class TestGetReadableTime
    {
        TimeFormat tf = new TimeFormat();

        [Fact]
        public void TestGetReadableTime0()
        {       
            Assert.Equal("00:00:00", tf.GetReadableTime(0));     
        }

        [Fact]
        public void TestGetReadableTime5()
        {
            Assert.Equal("00:00:05", tf.GetReadableTime(5));
        }

        [Fact]
        public void TestGetReadableTime60()
        {
            Assert.Equal("00:01:00", tf.GetReadableTime(60));
        }

        [Fact]
        public void TestGetReadableTime86399()
        {
            Assert.Equal("23:59:59", tf.GetReadableTime(86399));
        }

        [Fact]
        public void TestGetReadableTime359999()
        {
            Assert.Equal("99:59:59", tf.GetReadableTime(359999));
        }
    }
}
