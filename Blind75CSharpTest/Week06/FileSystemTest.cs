using System.Collections.Generic;
using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class FileSystemTest
{
   [Fact]
   public void FileSystem_WalkThroughLc()
   {
      var testObj = new FileSystem();
      testObj.Ls("/").Should().BeEquivalentTo(new List<string>());

      testObj.Mkdir("/a/b/c");

      testObj.AddContentToFile("/a/b/c/d", "hello");

      testObj.Ls("/").Should().BeEquivalentTo(new List<string> {"a"});

      testObj.ReadContentFromFile("/a/b/c/d").Should().Be("hello");
   }

   [Fact]
   public void FileSystem_AppendingDataToFile()
   {
      var testObj = new FileSystem();
      testObj.Ls("/").Should().BeEquivalentTo(new List<string>());
      testObj.Mkdir("/a/b/c");
      testObj.AddContentToFile("/a/b/c/d", "hello world");
      testObj.Ls("/").Should().BeEquivalentTo(new List<string> {"a"});
      testObj.ReadContentFromFile("/a/b/c/d").Should().Be("hello world");
      testObj.AddContentToFile("/a/b/c/d", " hello hello world");
      testObj.ReadContentFromFile("/a/b/c/d").Should().Be("hello world hello hello world");
   }

   [Fact]
   public void FileSystem_Ls()
   {
      var testObj = new FileSystem();
      testObj.Ls("/").Should().BeEquivalentTo(new List<string>());
      testObj.Mkdir("/a/b/c");
      testObj.Ls("/a/b").Should().BeEquivalentTo(new List<string> {"c"});
   }

   [Fact]
   public void FileSystem_OrderOfFiles()
   {
      var testObj = new FileSystem();
      testObj.Mkdir("/a/b/c");
      testObj.Mkdir("/a/b/z");
      var actual = testObj.Ls("/a/b");
      var expected = new List<string>
      {
         "c", "z"
      };

      actual.Should().BeEquivalentTo(expected, cfg => cfg.WithStrictOrdering());
   }
}