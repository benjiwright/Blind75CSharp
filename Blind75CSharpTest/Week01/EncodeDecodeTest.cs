using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class EncodeDecodeTest
{
   [Fact]
   public void Codec_Encode_When_BaseCase()
   {
      var io = new[] {"Hello", "World"};

      var testObject = new Codec();

      var encoded = testObject.encode(io);

      var decoded = testObject.decode(encoded);

      decoded.Should().BeEquivalentTo(io, cfg => cfg.WithStrictOrdering());
   }
}